#!/usr/bin/python

# -*- coding: utf-8 -*-
"""
Created on Thu Jun 23 18:14:02 2011

@author: -
"""

import os
import wx
import sys
from argparse import ArgumentParser
from PyDragonfly import CMessage, copy_to_msg, MT_EXIT
import Dragonfly_config as rc
from dragonfly_utils import respond_to_ping
import numpy as np
from DragonflyThread import DragonflyThread, Subscription

# from enthought.traits.api import HasTraits, Float, Instance, List, Range, Button
# from enthought.traits.ui.api import Handler, View, Item, UItem, StatusItem, \
#      HGroup, VGroup, RangeEditor
from traits.api import HasTraits, Float, Instance, List, Range, Button
from traitsui.api import Handler, View, Item, UItem, StatusItem, \
     HGroup, VGroup, RangeEditor


class DriftCorrector(HasTraits):
    parent = Instance(wx.Frame)

    subs = List

    x = Float(0.0)
    y = Float(0.0)
    z = Float(0.0)

    i = Float(0.0)
    j = Float(0.0)
    k = Float(0.0)

    a = Float(0.0)
    b = Float(0.0)
    c = Float(0.0)
    d = Float(0.0)

    set_all_to_zero = Button()

    view = View(VGroup(
                   VGroup(
                        Item(name='x', width=360, editor=RangeEditor(low=-1.0, high=1.0, mode='slider', format="%2.2f")),
                        Item(name='y', editor=RangeEditor(low=-1.0, high=1.0, mode='slider', format="%2.2f")),
                        Item(name='z', editor=RangeEditor(low=-1.0, high=1.0, mode='slider', format="%2.2f")),
                        label = 'Translation (dims 1,2,3)', show_border = True),
                   VGroup(
                        Item(name='i', editor=RangeEditor(low=-1.0, high=1.0, mode='slider', format="%2.2f")),
                        Item(name='j', editor=RangeEditor(low=-1.0, high=1.0, mode='slider', format="%2.2f")),
                        Item(name='k', editor=RangeEditor(low=-1.0, high=1.0, mode='slider', format="%2.2f")),
                        label = 'Orientation (dims 5,6,7)', show_border = True),
                   VGroup(
                        Item(name='a', label='1', editor=RangeEditor(low=-1.0, high=1.0, mode='slider', format="%2.2f")),
                        Item(name='b', label='2', editor=RangeEditor(low=-1.0, high=1.0, mode='slider', format="%2.2f")),
                        Item(name='c', label='3', editor=RangeEditor(low=-1.0, high=1.0, mode='slider', format="%2.2f")),
                        Item(name='d', label='4', editor=RangeEditor(low=-1.0, high=1.0, mode='slider', format="%2.2f")),
                        label = 'Hand (dims 9,10,11,12)', show_border = True),
                   VGroup(
                        Item(name='set_all_to_zero', show_label=False))
                ))

    def _set_all_to_zero_fired(self):
        self.x = 0.0
        self.y = 0.0
        self.z = 0.0
        self.i = 0.0
        self.j = 0.0
        self.k = 0.0
        self.a = 0.0
        self.b = 0.0
        self.c = 0.0
        self.d = 0.0

    def _subs_default(self):
        ret = [MT_EXIT, rc.MT_PING]
        return ret

    def _x_changed(self):
        self.update_drift_correction()

    def _y_changed(self):
        self.update_drift_correction()

    def _z_changed(self):
        self.update_drift_correction()

    def _i_changed(self):
        self.update_drift_correction()

    def _j_changed(self):
        self.update_drift_correction()

    def _k_changed(self):
        self.update_drift_correction()

    def _a_changed(self):
        self.update_drift_correction()

    def _b_changed(self):
        self.update_drift_correction()

    def _c_changed(self):
        self.update_drift_correction()

    def _d_changed(self):
        self.update_drift_correction()

    def process_message(self, dragonfly, msg):
        msg_type = msg.GetHeader().msg_type
        if msg_type == rc.MT_PING:
            respond_to_ping(dragonfly, msg, 'DriftCorrector')

    def update_drift_correction(self):
        mdf = rc.MDF_EM_UPDATE_DRIFT_CORRECTION()
        mdf.drift_correction[0:3] = np.array([self.x, self.y, self.z])
        mdf.drift_correction[4:7] = np.array([self.i, self.j, self.k])
        mdf.drift_correction[8:12] = np.array([self.a, self.b, self.c, self.d])

        msg = CMessage(rc.MT_EM_UPDATE_DRIFT_CORRECTION)
        copy_to_msg(mdf, msg)
        self.dragonfly_thread.add_to_send_queue(msg)

    def connect(self, server):
        self.dragonfly_thread = DragonflyThread()
        self.dragonfly_thread.server = server
        self.dragonfly_thread.mid = 0
        self.dragonfly_thread.subs = self.subs
        self.dragonfly_thread.recv_msg = self.process_message
        self.dragonfly_thread.exit_callback = self.exit_app
        self.dragonfly_thread.start()

    def exit_app(self):
        self.parent.exit_app()

    def disconnect(self):
        self.dragonfly_thread.stop()



class MainWindow(wx.Frame):
    def __init__(self, mm_ip):
        wx.Frame.__init__(self, None, -1, 'DriftCorrector', wx.DefaultPosition, \
                          wx.DefaultSize, wx.CAPTION|wx.CLOSE_BOX|wx.SYSTEM_MENU|wx.MINIMIZE_BOX)
                          #wx.DefaultSize, wx.CAPTION|wx.CLOSE_BOX|wx.SYSTEM_MENU|wx.RESIZE_BORDER|wx.MINIMIZE_BOX)
        self.sm = DriftCorrector()
        self.sm.connect(mm_ip)
        self.sm.parent = self
        self.sm.edit_traits(parent=self, kind='subpanel')
        self.Fit()
        self.Show(True)
        self.Bind(wx.EVT_CLOSE, self.OnClose)

    def OnClose(self, event):
        self.sm.disconnect()
        self.Destroy()
        self.Refresh()

    def exit_app(self):
        self.Close()


if __name__ == "__main__":
    parser = ArgumentParser(description = "Adjusts drift correction")
    parser.add_argument(type=str, dest='config')
    parser.add_argument(type=str, dest='mm_ip', nargs='?', default='')
    args = parser.parse_args()

    if args.mm_ip == '':
        args.mm_ip = '127.0.0.1:7111'

    print("Using MM IP=%s" % (args.mm_ip))

    app = wx.App(False)
    frame = MainWindow(args.mm_ip)
    app.MainLoop()
