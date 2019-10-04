from PyDragonfly import Dragonfly_Module, CMessage, MT_EXIT
import Dragonfly_config as rc
from time import sleep
from threading import Thread, Event

class Subscription(object):
    def __init__(self, name, num=None, has_data=True):
        self.name = name
        if num == None:
            self.num = eval('rc.MT_%s' % name)
        else:
            if not type(num) == int:
                raise ValueError("Subscription number must be of type `int`")
            self.num = num
        if has_data:
            mdf_name = 'MDF_%s' % (name)
            self.mdf = eval('rc.' + mdf_name)
        else:
            self.mdf = None

class DragonflyThread(Thread):
    '''
    Run RTMA message collection in a separate thread. Especially useful
    for co-existing with GUI threads.

    Notes
    -----
    In container object, create an instance of RTMAThread, declare
    'server', 'subs', 'recv_msg', 'status', and then call start()
    '''
    # override these attributes
    mid = 0 # default to dynamic allocation
    subs = []
    server = ''
    recv_msg = lambda msg: None
    status = Event() #lambda: True
    exit_callback = None
    out_msg_queue = []

    def add_to_send_queue(self, msg):
        self.out_msg_queue.append(msg)

    def run(self):
        self.mod = Dragonfly_Module(self.mid, 0)
        self.mod.ConnectToMMM(self.server)
        for sub in self.subs:
            print "subscribing to %s" % (sub)
            self.mod.Subscribe(sub)
        self.mod.SendModuleReady()
        
        while not self.status.isSet():
            while self.out_msg_queue:
                self.mod.SendMessage(self.out_msg_queue.pop())
        
            msg = CMessage()
            rcv = self.mod.ReadMessage(msg, 0)
            if rcv == 1:
                msg_type = msg.GetHeader().msg_type
                if msg_type in self.subs:
                    if msg_type == MT_EXIT:
                        dest_mod_id = msg.GetHeader().dest_mod_id
                        if (dest_mod_id == 0) or (dest_mod_id == self.mod.GetModuleID()):
                            if self.exit_callback is not None:
                                self.exit_callback()
                            else:
                                self.stop()
                    else:
                        self.recv_msg(self.mod, msg)
            sleep(.001)


    def stop(self):
        #print 'stop called'
        self.status.set()
        self.mod.SendSignal(rc.MT_EXIT_ACK)
        self.mod.DisconnectFromMMM()
