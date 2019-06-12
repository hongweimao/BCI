using System.Runtime.InteropServices;

namespace Dragonfly
{
    [StructLayout(LayoutKind.Sequential)]
    public class MT
    {
        public const int EXIT = 0;
        public const int KILL = 1;
        public const int ACKNOWLEDGE = 2;
        public const int FAIL_SUBSCRIBE = 6;
        public const int FAILED_MESSAGE = 7;
        public const int MM_ERROR = 83;
        public const int MM_INFO = 84;
        public const int CONNECT = 13;
        public const int DISCONNECT = 14;
        public const int SUBSCRIBE = 15;
        public const int UNSUBSCRIBE = 16;
        public const int PAUSE_SUBSCRIPTION = 85;
        public const int RESUME_SUBSCRIPTION = 86;
        public const int SHUTDOWN_DRAGONFLY = 17;
        public const int SHUTDOWN_APP = 18;
        public const int FORCE_DISCONNECT = 82;
        public const int CORE_MODULE_REINIT_ACK = 25;
        public const int MODULE_READY = 26;
        public const int DYNAMIC_DD_READ_ERR = 90;
        public const int DEBUG_TEXT = 91;
        public const int AM_EXIT = 30;
        public const int START_APP = 31;
        public const int STOP_APP = 32;
        public const int RESTART_APP = 33;
        public const int KILL_APP = 34;
        public const int AM_RE_READ_CONFIG_FILE = 89;
        public const int AM_GET_APP_NAME = 92;
        public const int SLAVE_START_APP = 64;
        public const int SLAVE_START_APP_ACK = 65;
        public const int SLAVE_STOP_APP = 66;
        public const int SLAVE_KILL_APP = 67;
        public const int SLAVE_RESTART_APP = 68;
        public const int AM_ERROR = 35;
        public const int AM_ACKNOWLEDGE = 36;
        public const int FAIL_START_APP = 37;
        public const int FAIL_STOP_APP = 38;
        public const int FAIL_KILL_APP = 39;
        public const int APP_START_COMPLETE = 2121;
        public const int APP_SHUTODWN_COMPLETE = 41;
        public const int APP_RESTART_COMPLETE = 42;
        public const int APP_KILL_COMPLETE = 43;
        public const int ALL_MODULES_READY = 44;
        public const int CORE_MODULE_REINIT = 45;
        public const int AM_CONFIG_FILE_DATA = 46;
        public const int AM_APP_NAME = 93;
        public const int SLAVE_ALL_MODULES_READY = 69;
        public const int SLAVE_FAIL_START_APP = 70;
        public const int SLAVE_FAIL_STOP_APP = 71;
        public const int SLAVE_FAIL_KILL_APP = 72;
        public const int SLAVE_APP_SHUTODWN_COMPLETE = 74;
        public const int SLAVE_APP_RESTART_COMPLETE = 75;
        public const int SLAVE_APP_KILL_COMPLETE = 76;
        public const int SLAVE_AM_ERROR = 77;
        public const int APP_ERROR = 47;
        public const int SM_EXIT = 48;
        public const int CLOCK_SYNC = 49;
        public const int TIMER_EXPIRED = 50;
        public const int TIMED_OUT = 73;
        public const int SET_TIMER_FAILED = 51;
        public const int TM_EXIT = 52;
        public const int SET_TIMER = 53;
        public const int CANCEL_TIMER = 54;
        public const int LM_EXIT = 55;
        public const int MM_READY = 94;
        public const int LM_READY = 96;
        public const int SAVE_MESSAGE_LOG = 56;
        public const int MESSAGE_LOG_SAVED = 57;
        public const int PAUSE_MESSAGE_LOGGING = 58;
        public const int RESUME_MESSAGE_LOGGING = 59;
        public const int RESET_MESSAGE_LOG = 60;
        public const int DUMP_MESSAGE_LOG = 61;
        public const int TIMING_TEST = 62;
        public const int PS3_BUTTON_PRESS = 2135;
        public const int PS3_BUTTON_RELEASE = 2136;
        public const int PS3_STICK_READING = 2137;
        public const int PS3_RAW_CONFIG = 6543;
        public const int PS3_SIMPLE_BUTTON_PRESS = 6544;
        public const int PS3_SIMPLE_BUTTON_RELEASE = 6545;
        public const int PS3_GENERIC_DATA = 6546;
        public const int EM_START_SESSION = 1600;
        public const int EM_END_SESSION = 1601;
        public const int EM_FREEZE = 1602;
        public const int EM_RESET_STATE = 1603;
        public const int EM_UNFREEZE = 1604;
        public const int EM_START_TRIAL = 1605;
        public const int EM_END_TRIAL = 1606;
        public const int EM_DISCARD_TRIAL = 1607;
        public const int EM_ADAPT_NOW = 1608;
        public const int EM_FEEDBACK = 1609;
        public const int EM_MOD_DEPTH_CUTOFF = 1610;
        public const int EM_PAUSE_COLLECTION = 1611;
        public const int EM_RESUME_COLLECTION = 1612;
        public const int EM_GET_PDS = 1613;
        public const int EM_SET_PDS = 1614;
        public const int EM_AGGREGATE_DATA_NOW = 1615;
        public const int EM_RESET_AGGREGATION = 1616;
        public const int EM_CORRECT_DRIFT_NOW = 1617;
        public const int EM_UPDATE_DRIFT_CORRECTION = 1618;
        public const int RELOAD_PVA_CONFIG = 1619;
        public const int EM_READY = 1650;
        public const int EM_FROZEN = 1651;
        public const int EM_ADAPT_DONE = 1652;
        public const int EM_ADAPT_FAILED = 1653;
        public const int EM_MOD_DEPTH_FAILED = 1654;
        public const int EM_MOD_DEPTH_SUCCEEDED = 1655;
        public const int EM_PDS = 1656;
        public const int EM_ALREADY_FROZEN = 1657;
        public const int EM_DRIFT_CORRECTED = 1658;
        public const int RELOAD_CONFIGURATION = 1004;
        public const int PVA_CONFIG = 382;
        public const int PVA_STATE = 383;
        public const int DECISION = 384;
        public const int TRAINING_BEGIN = 385;
        public const int DO_IT_DECIDER = 386;
        public const int PVA_ATTENUATE_COMMAND = 387;
        public const int GROBOT_SEGMENT_PERCEPTS = 1888;
        public const int CERESTIM_CONFIG_MODULE = 1889;
        public const int CERESTIM_CONFIG_CHAN = 1890;
        public const int GROBOT_COMMAND = 1700;
        public const int GROBOT_RAW_FEEDBACK = 1701;
        public const int GROBOT_FEEDBACK = 1702;
        public const int COMMANDSPACE_FEEDBACK = 1703;
        public const int GROBOT_BYPASS = 1704;
        public const int GROBOT_END_BYPASS = 1707;
        public const int MICROSTRAIN_DATA = 1705;
        public const int GLOVE_DATA = 1706;
        public const int EM_OVERRIDE_CONFIG = 1708;
        public const int OPTO_CNTRL_CMD = 1709;
        public const int OPTO_POS_CMD = 1712;
        public const int KIN_POS_CMD = 1713;
        public const int KINECT_SKELETON = 1711;
        public const int SESSION_CONFIG = 1710;
        public const int RAW_SPIKECOUNT = 1750;
        public const int SPM_SPIKECOUNT = 1751;
        public const int SAMPLE_GENERATED = 1752;
        public const int SAMPLE_RESPONSE = 1753;
        public const int RESET_SAMPLE_ALIGNMENT = 1754;
        public const int SYNCH_NOW = 1800;
        public const int SYNCH_START = 1801;
        public const int SYNCH_DONE = 1802;
        public const int INPUT_DOF_DATA = 1850;
        public const int OPERATOR_MOVEMENT_COMMAND = 1900;
        public const int FIXTURED_MOVEMENT_COMMAND = 1910;
        public const int SHADOW_COMPOSITE_MOVEMENT_COMMAND = 1919;
        public const int FIXTURED_COMPOSITE_MOVEMENT_COMMAND = 1920;
        public const int PROBOT_FEEDBACK = 1930;
        public const int CHANGE_TOOL = 1940;
        public const int CHANGE_TOOL_INVALID = 1941;
        public const int CHANGE_TOOL_COMPLETE = 1942;
        public const int CHANGE_TOOL_FAILED = 1943;
        public const int TASK_STATE_CONFIG = 1950;
        public const int JUDGE_VERDICT = 1960;
        public const int END_TASK_STATE = 1970;
        public const int RAW_SAMPLE_RESPONSE = 1980;
        public const int CODE_VERSION = 1990;
        public const int TRIAL_DATA_SAVED = 2080;
        public const int EM_DECODER_CONFIGURATION = 2090;
        public const int SPM_FIRINGRATE = 2100;
        public const int LOAD_DECODER_CONFIG = 2110;
        public const int APP_START = 2120;
        public const int MODULE_START = 2125;
        public const int MODULE_START_COMPLETE = 2126;
        public const int EXIT_ACK = 2130;
        public const int PING = 2140;
        public const int PING_ACK = 2141;
        public const int XM_START_SESSION = 2150;
        public const int DEBUG_VECTOR = 2160;
        public const int SPM_SPIKE_SNIPPET = 2170;
        public const int REJECTED_SNIPPET = 2171;
        public const int RAW_CTSDATA = 2172;
        public const int SPIKE_SNIPPET = 2174;
        public const int DIGITAL_EVENT = 2175;
        public const int STIM_SYNC_EVENT = 2177;
        public const int XM_END_OF_SESSION = 2180;
        public const int IDLY_LABELLING = 2190;
        public const int IDLY_RESET_LABELLING = 2200;
        public const int EM_DRIFT_CORRECTION = 2210;
        public const int ARTIFACT_REJECTED = 2220;
        public const int PLAY_SOUND = 2230;
        public const int WAM_FEEDBACK = 2240;
        public const int WAM_HAND_FEEDBACK = 2242;
        public const int IDLE = 2250;
        public const int IDLE_DETECTION_ENDED = 2251;
        public const int PLANNER_CONTROL_CONFIG = 2260;
        public const int ROBOT_JOINT_COMMAND = 2270;
        public const int IDLEGATED_MOVEMENT_COMMAND = 2280;
        public const int CALIBRATION_STARTED = 2290;
        public const int CALIBRATION_DONE = 2291;
        public const int UNITY_SET_CURSOR_PROPERTY = 2300;
        public const int UNITY_SET_HOME_PROPERTY = 2301;
        public const int UNITY_SET_TARGET_PROPERTY = 2302;
        public const int UNITY_TARGET_UI_SWITCH = 2310;
        public const int UNITY_FEEDBACK_UI_SWITCH = 2311;
        public const int UNITY_OBJ_COLOR_SWITCH = 2312;
        public const int XM_ABORT_SESSION = 171;
        public const int PROCEED_TO_Failure = 196;
        public const int PROCEED_TO_NextState = 198;
        public const int GO_TO_STATE = 192;
        public const int PAUSE_EXPERIMENT = 180;
        public const int RESUME_EXPERIMENT = 181;
        public const int TRIAL_EVENT = 100;
        public const int TRIAL_CONFIG = 101;
        public const int TRIAL_STATUS = 102;
        public const int WASHING_WITH_MONKEYS = 133;
        public const int LICKING_BEGIN = 150;
        public const int LICKING_END = 151;
        public const int ROBOT_ACTUAL_STATE = 934;
        public const int ROBOT_CONTROL_STATE = 935;
        public const int ROBOT_CONTROL_SPACE_ACTUAL_STATE = 936;
        public const int GRASP_EVENT = 937;
        public const int ROBOT_CONTROL_CONFIG = 938;
        public const int GIVE_REWARD = 600;
        public const int IO_START_STREAM = 601;
        public const int IO_STOP_STREAM = 602;
        public const int JOYPAD_R1 = 610;
        public const int JOYPAD_R2 = 611;
        public const int JOYPAD_X = 612;
        public const int JOYPAD_PAD_BUTTON = 613;
        public const int READY_BUTTON = 614;
        public const int ANALOG_STREAM = 620;
        public const int IO_STREAM_STARTED = 621;
        public const int IO_STREAM_STOPPED = 622;
        public const int KNOB_TOUCHED = 640;
        public const int KNOB_TURNED = 641;
        public const int KNOB_ANTI_TURNED = 642;
        public const int KNOB_OVER_TURNED = 643;
        public const int DOOR_MOVED = 644;
        public const int DOOR_OPENED = 645;
        public const int DOOR_ANTI_OPENED = 646;
        public const int DOOR_OVER_OPENED = 647;
        public const int KNOB_MOVED = 648;
        public const int DOOR_UN_OPENED = 649;
        public const int KNOB_RELEASED = 650;
        public const int PAD_PRESSED = 660;
        public const int PAD_STEADY = 661;
        public const int PAD_PERTURBED = 662;
        public const int PAD_RELEASED = 663;
        public const int DENSO_CONFIG = 800;
        public const int DENSO_INITIALIZE = 801;
        public const int DENSO_MOVE = 802;
        public const int DENSO_HALT = 803;
        public const int DENSO_SET_SPEED = 804;
        public const int DENSO_WIGGLE = 806;
        public const int DENSO_MOVE_CONTINUE = 807;
        public const int DENSO_READY = 850;
        public const int DENSO_NOT_READY = 851;
        public const int DENSO_MOVE_COMPLETE = 852;
        public const int DENSO_MOVE_FAILED = 853;
        public const int DENSO_MOVE_INVALID = 854;
        public const int DENSO_HALTED = 855;
        public const int KILL_KILL_KILL_EM = 300;
        public const int EM_MOVEMENT_COMMAND = 350;
        public const int EM_AUX_MOVEMENT_COMMAND = 355;
        public const int COMPOSITE_MOVEMENT_COMMAND = 366;
        public const int ROBOT_MOVEMENT_COMMAND = 351;
        public const int PLANNER_MOVEMENT_COMMAND = 352;
        public const int PLANNER_STATE = 353;
        public const int PLAN_PROCESSOR_STATE = 354;
        public const int FM_MOVEMENT_COMMAND = 430;
        public const int OVERRIDE_COMMAND = 480;
        public const int JVEL_COMMAND = 481;
        public const int COMPONENT_DELAY_MSG_TYPES = 200;
        public const int ESTIMATED_DELAY = 201;
        public const int MEASURED_DELAY = 202;
        public const int NOOP = 998;
        public const int KEYBOARD = 1002;
        public const int CLEAR_FUNCTION = 1003;
        public const int LATE_ADAPT_NOW = 1005;
        public const int DUMMY_MESSAGE = 2000;
        public const int TARG_CLOUD = 1006;
        public const int ATTENTION = 1659;
    }

    [StructLayout(LayoutKind.Sequential)]
    public class MID
    {
        public const int MESSAGE_MANAGER = 0;
        public const int COMMAND_MODULE = 1;
        public const int APPLICATION_MODULE = 2;
        public const int NETWORK_RELAY = 3;
        public const int STATUS_MODULE = 4;
        public const int QUICKLOGGER = 5;
        public const int EXEC_MOD = 10;
        public const int SPM_MOD = 20;
        public const int SPM_MOD1 = 21;
        public const int SPM_MOD2 = 22;
        public const int SPM_MOD3 = 23;
        public const int SPM_MOD4 = 24;
        public const int IO_MOD = 60;
        public const int DENSO_MOD = 80;
        public const int DENSO_TRY = 81;
        public const int WATCHDOG = 97;
        public const int SILICON_MONKEY = 72;
        public const int WAM = 73;
        public const int OPTOTRAK = 74;
        public const int SIMPLE_PLANNER = 76;
        public const int EXTRACTION_MOD = 50;
        public const int VIZ = 85;
        public const int HANDY_DANDY = 86;
        public const int DRIFTY = 93;
        public const int THE_DECIDER = 94;
        public const int PS3_COMMAND_MODULE = 95;
        public const int PS3_RAW_MODULE = 96;
        public const int SILICON_MONKEY_BRAIN = 91;
        public const int PS3_MODULE = 92;
        public const int TEST_MOD = 99;
        public const int GROBOT_RAW_FEEDBACK = 19;
        public const int GROBOT_FEEDBACK = 18;
        public const int DIGITAL_IO = 17;
        public const int TASK_JUDGE = 16;
        public const int VRFORCE_JUDGE = 26;
        public const int SI_MOVEMENT = 15;
        public const int INPUT_TRANSFORM = 14;
        public const int SIMPLE_ARBITRATOR = 13;
        public const int OUTPUT_TRANSFORM = 12;
        public const int FEEDBACK_TRANSFORM = 11;
        public const int SAMPLE_GENERATOR = 29;
        public const int VIRTUAL_FIXTURING = 28;
        public const int CANNED_MOVEMENT = 27;
        public const int HAND_VIZ = 30;
        public const int IDLE_MONKEY = 36;
        public const int CALIBRATION = 37;
        public const int SSH_CONTROLLER = 35;
        public const int IDLE_DETECTOR = 38;
        public const int ARDUINO_IO = 39;
        public const int POSITION_CONTROLLER = 40;
        public const int JOINT_CONTROLLER = 42;
        public const int WAM_BHAND = 25;
        public const int EM_OVERRIDE_CONFIG = 31;
        public const int OPTO_MPL_CTRL = 32;
        public const int OBSTACLE_COURSE = 33;
        public const int SKELETON_CTRL = 34;
        public const int GROBOT_SEGMENT_PERCEPTS = 56;
        public const int CERESTIM_CONFIG = 57;
        public const int CERESTIM_CONTROL = 58;
        public const int COMMAND_SPACE_FEEDBACK_GUI = 89;
        public const int MESSAGE_WATCHER = 88;
    }

    [StructLayout(LayoutKind.Sequential)]
    public class HID
    {
        public const int LOCAL_HOST = 0;
        public const int ALL_HOSTS = 32767;
        public const int MAIN_HOST = 1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public class MDF
    {
        [StructLayout(LayoutKind.Sequential)]
        public class FAIL_SUBSCRIBE
        {
            public short mod_id;
            public short reserved;
            public int msg_type;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class FAILED_MESSAGE
        {
            public short dest_mod_id;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public short[] reserved = {0,0,0};
            public double time_of_failure;
            [StructLayout(LayoutKind.Sequential)]
            public class msg_header_type
            {
                public int msg_type;
                public int msg_count;
                public double send_time;
                public double recv_time;
                public short src_host_id;
                public short src_mod_id;
                public short dest_host_id;
                public short dest_mod_id;
                public int num_data_bytes;
                public int remaining_bytes;
                public int is_dynamic;
                public int reserved;
            }
            public msg_header_type msg_header = new msg_header_type();

        }

        public sbyte[] MM_ERROR;
        public sbyte[] MM_INFO;
        [StructLayout(LayoutKind.Sequential)]
        public class CONNECT
        {
            public short logger_status;
            public short daemon_status;
        }

        public int SUBSCRIBE;
        public int UNSUBSCRIBE;
        public int PAUSE_SUBSCRIPTION;
        public int RESUME_SUBSCRIPTION;
        [StructLayout(LayoutKind.Sequential)]
        public class FORCE_DISCONNECT
        {
            public int mod_id;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MODULE_READY
        {
            public int pid;
        }

        public sbyte[] DYNAMIC_DD_READ_ERR;
        public sbyte[] DEBUG_TEXT;
        public sbyte[] START_APP;
        public sbyte[] STOP_APP;
        public sbyte[] RESTART_APP;
        public sbyte[] KILL_APP;
        public sbyte[] SLAVE_START_APP;
        [StructLayout(LayoutKind.Sequential)]
        public class SLAVE_START_APP_ACK
        {
            public int num_remote_hosts;
        }

        public sbyte[] SLAVE_STOP_APP;
        public sbyte[] SLAVE_KILL_APP;
        public sbyte[] SLAVE_RESTART_APP;
        public sbyte[] AM_ERROR;
        public sbyte[] FAIL_START_APP;
        public sbyte[] FAIL_STOP_APP;
        public sbyte[] FAIL_KILL_APP;
        public sbyte[] AM_CONFIG_FILE_DATA;
        public sbyte[] AM_APP_NAME;
        public sbyte[] SLAVE_FAIL_START_APP;
        public sbyte[] SLAVE_AM_ERROR;
        public sbyte[] APP_ERROR;
        [StructLayout(LayoutKind.Sequential)]
        public class TIMER_EXPIRED
        {
            public int timer_id;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class TIMED_OUT
        {
            public int timer_id;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class SET_TIMER_FAILED
        {
            public short mod_id;
            public int timer_id;
            public int snooze_time;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class SET_TIMER
        {
            public int timer_id;
            public int snooze_time;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class CANCEL_TIMER
        {
            public int timer_id;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class SAVE_MESSAGE_LOG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public sbyte[] pathname = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public int pathname_length;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class TIMING_TEST
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public double[] time = {0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PS3_BUTTON_PRESS
        {
            public int whichButton;
            public int val;
            public int controllerId;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] buttonMask = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] buttonVal = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] continuousMask = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] continuousVal = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] accelMask = {0,0};
            public int spacer;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] accelVal = {0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PS3_BUTTON_RELEASE
        {
            public int whichButton;
            public int val;
            public int controllerId;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] buttonMask = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] buttonVal = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] continuousMask = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] continuousVal = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] accelMask = {0,0};
            public int spacer;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] accelVal = {0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PS3_RAW_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] stickCommandDOFMap = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] stickCommandJointMap = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public double[] stickScale = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public double[] stickOffset = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] accelScale = {0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] accelOffset = {0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] DOFscale = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] accelDOFMap = {0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public int[] use_controller = {0,0,0,0,0,0,0,0,0,0};
            public int free_run;
            public int spacer;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PS3_SIMPLE_BUTTON_PRESS
        {
            public int whichButton;
            public int controllerId;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PS3_SIMPLE_BUTTON_RELEASE
        {
            public int whichButton;
            public int controllerId;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PS3_GENERIC_DATA
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public int controllerId;
            public int spacer;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public double[] dof_vals = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class EM_START_SESSION
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] Dimensions = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class RELOAD_CONFIGURATION
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] Dimensions = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class EM_RESET_AGGREGATION
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] regressionGroups = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class EM_RESUME_COLLECTION
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] regressionGroups = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class EM_AGGREGATE_DATA_NOW
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] regressionGroups = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class EM_PAUSE_COLLECTION
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] regressionGroups = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class EM_RESET_STATE
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] initial_position = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] initial_velocity = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] target_position = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public int reset_history;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class EM_START_TRIAL
        {
            public int data_index;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class EM_ADAPT_NOW
        {
            public int first_data_index;
            public int last_data_index;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class EM_UPDATE_DRIFT_CORRECTION
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] drift_correction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        public double EM_MOD_DEPTH_CUTOFF;
        public sbyte[] EM_SET_PDS;
        public sbyte[] EM_PDS;
        [StructLayout(LayoutKind.Sequential)]
        public class PVA_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] Norm2RealFactor = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public double ModDepthCutoff;
            public double RSquaredCutoff;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public double[] PredictFRFilter = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public double[] AdaptFRFilter = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public double[] TargetFilter = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] RegressionGroups = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] ControlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public double numAdaptReps;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PVA_STATE
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1600)]
            public double[] PV = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 200)]
            public int[] usedIndices = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PVA_ATTENUATE_COMMAND
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] targTag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 200)]
            public double[] attenuationLevel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class RAW_SPIKECOUNT
        {
            public int source_index;
            public int reserved;
            public double source_timestamp;
            public double count_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 768)]
            public byte[] counts = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class SPM_SPIKECOUNT
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] source_timestamp = {0,0};
            public double count_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1536)]
            public byte[] counts = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class SAMPLE_GENERATED
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] source_timestamp = {0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class SAMPLE_RESPONSE
        {
            public double sample_response_timestamp;
            public double sample_alignment_timestamp;
            public uint sample_response_count;
            public uint sample_alignment_count;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class INPUT_DOF_DATA
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public double[] dof_vals = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class OPERATOR_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class FIXTURED_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class SHADOW_COMPOSITE_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class FIXTURED_COMPOSITE_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PROBOT_FEEDBACK
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public double[] tool_pos = {0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public double[] wrist_pos = {0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class GROBOT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] command = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public int mode;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class GROBOT_BYPASS
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] command = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public int mode;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class OPTO_CNTRL_CMD
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public double[] Cmd = {0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class OPTO_POS_CMD
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public double[] Cmd = {0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class KIN_POS_CMD
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public double[] Cmd = {0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class KINECT_SKELETON
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public double[] x = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public double[] y = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public double[] z = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public double[] w = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public int Which;
            public int Reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class GROBOT_SEGMENT_PERCEPTS
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] ind_force = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] mid_force = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] rng_force = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] lit_force = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] thb_force = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] ind_accel = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] mid_accel = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] rng_accel = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] lit_accel = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] thb_accel = {0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class CERESTIM_CONFIG_MODULE
        {
            public int configID;
            public int afcf;
            public double pulses;
            public double amp1;
            public double amp2;
            public double width1;
            public double width2;
            public double frequency;
            public double interphase;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class CERESTIM_CONFIG_CHAN
        {
            public int stop;
            public int group_stimulus;
            public int group_numChans;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public int[] group_channel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public int[] group_pattern = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public int manual_stimulus;
            public int manual_channel;
            public int manual_pattern;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class GROBOT_RAW_FEEDBACK
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
            public double[] j_ang = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
            public double[] j_vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
            public double[] j_trq = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class GROBOT_FEEDBACK
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] position = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] velocity = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public double[] cori_matrix = {0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class SESSION_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public sbyte[] data_dir = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class GLOVE_DATA
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
            public double[] data = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MICROSTRAIN_DATA
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
            public double[] data = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class EM_OVERRIDE_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1728)]
            public int[] chosen_channel_mask = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class CHANGE_TOOL
        {
            public int next_tool_id;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class CHANGE_TOOL_COMPLETE
        {
            public int tool_id;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class TASK_STATE_CONFIG
        {
            public int id;
            public int rep_num;
            public int trial_num;
            public int reserved;
            public int use_for_vel_calib;
            public int use_for_force_calib;
            public int target_combo_index;
            public int timed_out_conseq;
            public int idle_gateable;
            public int reach_offset;
            public short planner_vel;
            public short planner_force;
            public short show_target;
            public short show_home;
            public short make_choice;
            public short num_of_target;
            public short reserved1;
            public short reserved2;
            public double contact_angle_threshold;
            public double vr_force_thr;
            public double idle_timeout;
            public double ts_time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public double[] target = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public double[] present_target = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public double[] judge_target = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public double[] coriMatrix = {0,0,0,0,0,0,0,0,0};
            public double trans_threshold;
            public double force_threshold;
            public double ori_threshold;
            public double trans_threshold_f;
            public double force_threshold_f;
            public double ori_threshold_f;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public double[] finger_threshold = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public int[] finger_threshold_judging_method = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public int[] finger_threshold_judging_polarity = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public int trans_threshold_judging_polarity;
            public int ori_threshold_judging_polarity;
            public int trans_threshold_f_judging_polarity;
            public int ori_threshold_f_judging_polarity;
            public double timeout;
            public double trans_duration;
            public double trans_duration_percent;
            public double force_duration;
            public double force_duration_percent;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tags = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class JUDGE_VERDICT
        {
            public int id;
            public int reserved;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] reason = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class END_TASK_STATE
        {
            public int id;
            public int outcome;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] reason = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class RAW_SAMPLE_RESPONSE
        {
            public int source_index;
            public int reserved;
            public double source_timestamp;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class CODE_VERSION
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] module_name = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] version = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class SPM_FIRINGRATE
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double source_timestamp;
            public double count_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1536)]
            public double[] rates = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        public byte[] EM_DECODER_CONFIGURATION;
        [StructLayout(LayoutKind.Sequential)]
        public class LOAD_DECODER_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public sbyte[] full_path = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class XM_START_SESSION
        {
            public int load_calibration;
            public int calib_session_id;
            public int num_reps;
            public int reserved;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] subject_name = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PING
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] module_name = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PING_ACK
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] module_name = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class DEBUG_VECTOR
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public double[] data = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class APP_START
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] config = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MODULE_START
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] module = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class SPM_SPIKE_SNIPPET
        {
            public double time;
            public int chan;
            public int unit;
            public int box_id;
            public int length;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public short[] snippet = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class SPIKE_SNIPPET
        {
            [StructLayout(LayoutKind.Sequential)]
            public class ss_type
            {
                public int source_index;
                public int channel;
                public int unit;
                public int reserved;
                public double source_timestamp;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
                public double[] fPattern = {0,0,0};
                public int nPeak;
                public int nValley;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
                public short[] snippet = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            }
            public ss_type ss = new ss_type();

        }

        [StructLayout(LayoutKind.Sequential)]
        public class REJECTED_SNIPPET
        {
            [StructLayout(LayoutKind.Sequential)]
            public class rs_type
            {
                public int source_index;
                public short channel;
                public byte unit;
                public byte reserved1;
                public double source_timestamp;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
                public double[] fPattern = {0,0,0};
                public short nPeak;
                public short nValley;
                public int rejectType;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
                public short[] snippet = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            }
            public rs_type rs = new rs_type();

        }

        [StructLayout(LayoutKind.Sequential)]
        public class RAW_CTSDATA
        {
            public int source_index;
            public int reserved;
            public double source_timestamp;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1440)]
            public short[] data = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class DIGITAL_EVENT
        {
            public int source_index;
            public int channel;
            public double source_timestamp;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public uint[] data = {0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class STIM_SYNC_EVENT
        {
            public int source_index;
            public int channel;
            public double source_timestamp;
            public uint data;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class IDLY_LABELLING
        {
            public int state;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class EM_DRIFT_CORRECTION
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] drift_correction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class DENSO_WIGGLE
        {
            public int movement_id;
            public int num_cycles;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] sequence = {0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] amplitude = {0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PLAY_SOUND
        {
            public int id;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class ARTIFACT_REJECTED
        {
            public double time;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class IDLE
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double score;
            public double gain;
            public int idle;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class WAM_FEEDBACK
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double RTMA_received_time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public double[] CoriMatrix = {0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class WAM_HAND_FEEDBACK
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double RTMA_received_time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public double[] CoriMatrix = {0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PLANNER_CONTROL_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] target = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public double[] coriMatrix = {0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class ROBOT_JOINT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public double[] pos = {0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] overrideDims = {0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class IDLEGATED_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class UNITY_SET_CURSOR_PROPERTY
        {
            public int obj_index;
            public int reserved;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] color = {0,0,0};
            public double alpha;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] scale = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] impedance = {0,0,0};
            public double deformation_radius;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class UNITY_SET_HOME_PROPERTY
        {
            public int obj_index;
            public int reserved;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] color = {0,0,0};
            public double alpha;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] scale = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] impedance = {0,0,0};
            public double deformation_radius;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class UNITY_SET_TARGET_PROPERTY
        {
            public int obj_index;
            public int reserved;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] color = {0,0,0};
            public double alpha;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] scale = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] impedance = {0,0,0};
            public double deformation_radius;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class UNITY_TARGET_UI_SWITCH
        {
            public int status;
            public int spacer;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class UNITY_FEEDBACK_UI_SWITCH
        {
            public int status;
            public int spacer;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class UNITY_OBJ_COLOR_SWITCH
        {
            public int status;
            public int spacer;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class TRIAL_EVENT
        {
            public double event_time;
            public int event_code;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class TRIAL_CONFIG
        {
            public int rep_no;
            public int trial_no;
            public int num_reward_states;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class TRIAL_STATUS
        {
            public int success;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class ROBOT_ACTUAL_STATE
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double RTMA_received_time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public double[] Jpos = {0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public double[] Jvel = {0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] Cpos = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] Cori = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] Cforce = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] Ctrq = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] Cvel = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] CangVel = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public double[] Hpos = {0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public double[] Hstrain = {0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] Jtrq = {0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class ROBOT_CONTROL_STATE
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [StructLayout(LayoutKind.Sequential)]
            public class autoControl_type
            {
                [StructLayout(LayoutKind.Sequential)]
                public class sample_header_type
                {
                    public int SerialNo;
                    public int Flags;
                    public double DeltaTime;
                }
                public sample_header_type sample_header = new sample_header_type();

                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] targetPos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            }
            public autoControl_type autoControl = new autoControl_type();

            [StructLayout(LayoutKind.Sequential)]
            public class overrideCommand_type
            {
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] DOFCommand = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
                public double[] JposCommand = {0,0,0,0,0,0,0};
                public int controllerId;
                public int j0nks;
            }
            public overrideCommand_type overrideCommand = new overrideCommand_type();

            public double RTMA_received_time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] actualControlPos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] actualControlVel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] actualControlForce = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoControlPos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoControlVel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoControlForce = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoPosControlFraction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoVelControlFraction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoForceControlFraction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] orthPosImpedance = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] orthVelImpedance = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] orthForceImpedance = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] intrinsicVelControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] intrinsicPosControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] intrinsicForceControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] extrinsicVelControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] extrinsicPosControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] extrinsicForceControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] overrideDimensions = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public uint actualCommandComposition;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class ROBOT_CONTROL_SPACE_ACTUAL_STATE
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double RTMA_received_time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public double[] CoriMatrix = {0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class ROBOT_CONTROL_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] target = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public double[] coriMatrix = {0,0,0,0,0,0,0,0,0};
            [StructLayout(LayoutKind.Sequential)]
            public class trialEvent_type
            {
                public double event_time;
                public int event_code;
                public int reserved;
            }
            public trialEvent_type trialEvent = new trialEvent_type();

            [StructLayout(LayoutKind.Sequential)]
            public class autoControlParams_type
            {
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] virtualPadPosition = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
                public double[] centralPointPosition = {0,0,0};
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] posMin = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] posMax = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] velMin = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] velMax = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
                public double graspingGraspApertureTarget;
                public double graspingOpenApertureTarget;
                public double graspingIntermediateApertureTarget;
                public double maxApproachSwingAngle;
                public double graspTooCloseIfClosedRadius;
            }
            public autoControlParams_type autoControlParams = new autoControlParams_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoPosControlFraction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoVelControlFraction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoForceControlFraction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] orthPosImpedance = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] orthVelImpedance = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] orthForceImpedance = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] extrinsicVelControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] extrinsicPosControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] extrinsicForceControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] importantDOF = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class GIVE_REWARD
        {
            public double duration_ms;
            public double num_clicks;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class IO_START_STREAM
        {
            [StructLayout(LayoutKind.Sequential)]
            public class limits_type
            {
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
                public double[] high = {0,0,0,0,0,0,0,0,0,0,0,0};
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
                public double[] low = {0,0,0,0,0,0,0,0,0,0,0,0};
            }
            public limits_type limits = new limits_type();

            public int reserved;
            public int internal_sampling;
            public double sample_interval;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class ANALOG_STREAM
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public double[] data = {0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class KNOB_TOUCHED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class KNOB_TURNED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class KNOB_ANTI_TURNED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class KNOB_OVER_TURNED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class DOOR_MOVED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class DOOR_OPENED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class DOOR_ANTI_OPENED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class DOOR_OVER_OPENED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class KNOB_MOVED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class DOOR_UN_OPENED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class KNOB_RELEASED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PAD_PRESSED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PAD_STEADY
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PAD_PERTURBED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PAD_RELEASED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class DENSO_MOVE
        {
            public int position_no;
            public int movement_id;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class DENSO_SET_SPEED
        {
            public double speed;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class DENSO_MOVE_CONTINUE
        {
            public int position_no;
            public int movement_id;
        }

        public sbyte[] DENSO_NOT_READY;
        [StructLayout(LayoutKind.Sequential)]
        public class DENSO_MOVE_COMPLETE
        {
            public int movement_id;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class DENSO_MOVE_FAILED
        {
            public int movement_id;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class DENSO_MOVE_INVALID
        {
            public int movement_id;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class DENSO_HALTED
        {
            public int movement_id;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class EM_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class EM_AUX_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class COMPOSITE_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class ROBOT_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PLANNER_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PLANNER_STATE
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] targetPos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PLAN_PROCESSOR_STATE
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 576)]
            public double[] D = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class FM_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class OVERRIDE_COMMAND
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] DOFCommand = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public double[] JposCommand = {0,0,0,0,0,0,0};
            public int controllerId;
            public int j0nks;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class JVEL_COMMAND
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
            public double[] cmd = {0,0,0,0,0,0,0,0,0,0,0};
        }

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public int[] COMPONENT_DELAY_MSG_TYPES = {0,0,0,0,0,0};
        [StructLayout(LayoutKind.Sequential)]
        public class ESTIMATED_DELAY
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public double[] Components = {0,0,0,0,0,0};
            public double Total;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MEASURED_DELAY
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public double[] Components = {0,0,0,0,0,0};
            public double Total;
        }

        public sbyte[] CLEAR_FUNCTION;
        [StructLayout(LayoutKind.Sequential)]
        public class TARG_CLOUD
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 576)]
            public double[] cloud = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public int nTargs;
            public int spacer;
        }

        public double ATTENTION;
    }

    [StructLayout(LayoutKind.Sequential)]
    public class MESSAGE_HEADER
    {
        public int msg_type;
        public int msg_count;
        public double send_time;
        public double recv_time;
        public short src_host_id;
        public short src_mod_id;
        public short dest_host_id;
        public short dest_mod_id;
        public int num_data_bytes;
        public int remaining_bytes;
        public int is_dynamic;
        public int reserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    public class defines
    {
        public const int MAX_MODULES = 200;
        public const int DYN_MOD_ID_START = 100;
        public const int MAX_HOSTS = 5;
        public const int MAX_MESSAGE_TYPES = 10000;
        public const int MIN_STREAM_TYPE = 9000;
        public const int MAX_TIMERS = 100;
        public const int MAX_INTERNAL_TIMERS = 20;
        public const int MAX_DRAGONFLY_MSG_TYPE = 99;
        public const int MAX_DRAGONFLY_MODULE_ID = 9;
        public const string DF_MSG_HEADER_FIELDS = "MSG_TYPE	msg_type; 	MSG_COUNT	msg_count; 	double	send_time; 	double	recv_time; 	HOST_ID		src_host_id; 	MODULE_ID	src_mod_id; 	HOST_ID		dest_host_id; 	MODULE_ID	dest_mod_id; 	int			num_data_bytes; 	int			remaining_bytes; 	int			is_dynamic; 	int			reserved";
        public const int MAX_CONTIGUOUS_MESSAGE_DATA = 9000;
        public const int MID_MESSAGE_MANAGER = 0;
        public const int MID_COMMAND_MODULE = 1;
        public const int MID_APPLICATION_MODULE = 2;
        public const int MID_NETWORK_RELAY = 3;
        public const int MID_STATUS_MODULE = 4;
        public const int MID_QUICKLOGGER = 5;
        public const int HID_LOCAL_HOST = 0;
        public const int HID_ALL_HOSTS = 32767;
        public const int ALL_MESSAGE_TYPES = 2147483647;
        public const int MT_EXIT = 0;
        public const int MT_KILL = 1;
        public const int MT_ACKNOWLEDGE = 2;
        public const int MT_FAIL_SUBSCRIBE = 6;
        public const int MT_FAILED_MESSAGE = 7;
        public const int MT_MM_ERROR = 83;
        public const int MT_MM_INFO = 84;
        public const int MT_CONNECT = 13;
        public const int MT_DISCONNECT = 14;
        public const int MT_SUBSCRIBE = 15;
        public const int MT_UNSUBSCRIBE = 16;
        public const int MT_PAUSE_SUBSCRIPTION = 85;
        public const int MT_RESUME_SUBSCRIPTION = 86;
        public const int MT_SHUTDOWN_DRAGONFLY = 17;
        public const int MT_SHUTDOWN_APP = 18;
        public const int MT_FORCE_DISCONNECT = 82;
        public const int MT_CORE_MODULE_REINIT_ACK = 25;
        public const int MT_MODULE_READY = 26;
        public const int MT_DYNAMIC_DD_READ_ERR = 90;
        public const int MT_DEBUG_TEXT = 91;
        public const int MT_AM_EXIT = 30;
        public const int MT_START_APP = 31;
        public const int MT_STOP_APP = 32;
        public const int MT_RESTART_APP = 33;
        public const int MT_KILL_APP = 34;
        public const int MT_AM_RE_READ_CONFIG_FILE = 89;
        public const int MT_AM_GET_APP_NAME = 92;
        public const int MT_SLAVE_START_APP = 64;
        public const int MT_SLAVE_START_APP_ACK = 65;
        public const int MT_SLAVE_STOP_APP = 66;
        public const int MT_SLAVE_KILL_APP = 67;
        public const int MT_SLAVE_RESTART_APP = 68;
        public const int MT_AM_ERROR = 35;
        public const int MT_AM_ACKNOWLEDGE = 36;
        public const int MT_FAIL_START_APP = 37;
        public const int MT_FAIL_STOP_APP = 38;
        public const int MT_FAIL_KILL_APP = 39;
        public const int MT_APP_START_COMPLETE = 2121;
        public const int MT_APP_SHUTODWN_COMPLETE = 41;
        public const int MT_APP_RESTART_COMPLETE = 42;
        public const int MT_APP_KILL_COMPLETE = 43;
        public const int MT_ALL_MODULES_READY = 44;
        public const int MT_CORE_MODULE_REINIT = 45;
        public const int MT_AM_CONFIG_FILE_DATA = 46;
        public const int MT_AM_APP_NAME = 93;
        public const int MT_SLAVE_ALL_MODULES_READY = 69;
        public const int MT_SLAVE_FAIL_START_APP = 70;
        public const int MT_SLAVE_FAIL_STOP_APP = 71;
        public const int MT_SLAVE_FAIL_KILL_APP = 72;
        public const int MT_SLAVE_APP_SHUTODWN_COMPLETE = 74;
        public const int MT_SLAVE_APP_RESTART_COMPLETE = 75;
        public const int MT_SLAVE_APP_KILL_COMPLETE = 76;
        public const int MT_SLAVE_AM_ERROR = 77;
        public const int MT_APP_ERROR = 47;
        public const int MT_SM_EXIT = 48;
        public const int MT_CLOCK_SYNC = 49;
        public const int MT_TIMER_EXPIRED = 50;
        public const int MT_TIMED_OUT = 73;
        public const int MT_SET_TIMER_FAILED = 51;
        public const int MT_TM_EXIT = 52;
        public const int MT_SET_TIMER = 53;
        public const int MT_CANCEL_TIMER = 54;
        public const int MT_LM_EXIT = 55;
        public const int MT_MM_READY = 94;
        public const int MT_LM_READY = 96;
        public const int MT_SAVE_MESSAGE_LOG = 56;
        public const int MAX_LOGGER_FILENAME_LENGTH = 256;
        public const int MT_MESSAGE_LOG_SAVED = 57;
        public const int MT_PAUSE_MESSAGE_LOGGING = 58;
        public const int MT_RESUME_MESSAGE_LOGGING = 59;
        public const int MT_RESET_MESSAGE_LOG = 60;
        public const int MT_DUMP_MESSAGE_LOG = 61;
        public const int MT_TIMING_TEST = 62;
        public const int MAX_TIMING_TEST_TIME_POINTS = 12;
        public const int HID_MAIN_HOST = 1;
        public const int MID_EXEC_MOD = 10;
        public const int MID_SPM_MOD = 20;
        public const int MID_SPM_MOD1 = 21;
        public const int MID_SPM_MOD2 = 22;
        public const int MID_SPM_MOD3 = 23;
        public const int MID_SPM_MOD4 = 24;
        public const int MID_IO_MOD = 60;
        public const int MID_DENSO_MOD = 80;
        public const int MID_DENSO_TRY = 81;
        public const int MID_WATCHDOG = 97;
        public const int MID_SILICON_MONKEY = 72;
        public const int MID_WAM = 73;
        public const int MID_OPTOTRAK = 74;
        public const int MID_SIMPLE_PLANNER = 76;
        public const int MID_EXTRACTION_MOD = 50;
        public const int MID_VIZ = 85;
        public const int MID_HANDY_DANDY = 86;
        public const int MID_DRIFTY = 93;
        public const int MID_THE_DECIDER = 94;
        public const int MID_PS3_COMMAND_MODULE = 95;
        public const int MID_PS3_RAW_MODULE = 96;
        public const int MID_SILICON_MONKEY_BRAIN = 91;
        public const int MID_PS3_MODULE = 92;
        public const int MID_TEST_MOD = 99;
        public const string check_flag_bits = "( A, bitmask)  (((A) & (bitmask)) == (bitmask))";
        public const string clear_flag_bits = "( A, bitmask)  ((A) &= ~(bitmask))";
        public const string set_flag_bits = "( A, bitmask)    ((A) |= (bitmask))";
        public const int SF_ALIGNMENT = 1;
        public const int SF_UNFREEZE = 2;
        public const int SF_IRREGULAR = 4;
        public const int SF_FRACTINT = 8;
        public const int MAX_CONTROL_DIMS = 18;
        public const int MAX_EM_DIMS = 18;
        public const int TAG_LENGTH = 64;
        public const int NUM_D_COLS = 16;
        public const int MAX_D_COLS = 32;
        public const int MAX_INPUT_DOFS = 21;
        public const int MAX_FILENAME_LENGTH = 256;
        public const int PS3_B_L1 = 10;
        public const int PS3_B_L2 = 8;
        public const int PS3_B_R1 = 11;
        public const int PS3_B_R2 = 9;
        public const int PS3_B_LDIR = 7;
        public const int PS3_B_RDIR = 5;
        public const int PS3_B_UDIR = 4;
        public const int PS3_B_DDIR = 6;
        public const int PS3_B_TRIANGLE = 12;
        public const int PS3_B_SQUARE = 15;
        public const int PS3_B_CIRCLE = 13;
        public const int PS3_B_X = 14;
        public const int PS3_B_SELECT = 0;
        public const int PS3_B_START = 3;
        public const int PS3_B_L3 = 1;
        public const int PS3_B_R3 = 2;
        public const int PS3_C_LSTICKH = 0;
        public const int PS3_C_LSTICKV = 1;
        public const int PS3_C_RSTICKH = 2;
        public const int PS3_C_RSTICKV = 3;
        public const int PS3_C_L1 = 14;
        public const int PS3_C_L2 = 12;
        public const int PS3_C_R1 = 15;
        public const int PS3_C_R2 = 13;
        public const int PS3_C_LDIR = 11;
        public const int PS3_C_RDIR = 9;
        public const int PS3_C_UDIR = 8;
        public const int PS3_C_DDIR = 10;
        public const int PS3_C_TRIANGLE = 16;
        public const int PS3_C_SQUARE = 19;
        public const int PS3_C_CIRCLE = 17;
        public const int PS3_C_X = 18;
        public const int PS3_N_SENSORS = 21;
        public const int PS3_N_ACCEL = 2;
        public const int BUTTON_PRESS = 2135;
        public const int BUTTON_RELEASE = 2136;
        public const int STICK_READING = 2137;
        public const int MT_PS3_BUTTON_PRESS = 2135;
        public const int MT_PS3_BUTTON_RELEASE = 2136;
        public const int MT_PS3_STICK_READING = 2137;
        public const double DOF_SCALE = 0.3;
        public const double JOINT_SCALE = 0.3;
        public const int MAX_CONTROLLERS = 10;
        public const int MT_PS3_RAW_CONFIG = 6543;
        public const int MT_PS3_SIMPLE_BUTTON_PRESS = 6544;
        public const int MT_PS3_SIMPLE_BUTTON_RELEASE = 6545;
        public const int MT_PS3_GENERIC_DATA = 6546;
        public const int MAX_REDUCED_SPIKE_CHANS = 200;
        public const int MAX_EM_DIMENSIONS = 18;
        public const int MT_EM_START_SESSION = 1600;
        public const int MT_EM_END_SESSION = 1601;
        public const int MT_EM_FREEZE = 1602;
        public const int MT_EM_RESET_STATE = 1603;
        public const int MT_EM_UNFREEZE = 1604;
        public const int MT_EM_START_TRIAL = 1605;
        public const int MT_EM_END_TRIAL = 1606;
        public const int MT_EM_DISCARD_TRIAL = 1607;
        public const int MT_EM_ADAPT_NOW = 1608;
        public const int MT_EM_FEEDBACK = 1609;
        public const int MT_EM_MOD_DEPTH_CUTOFF = 1610;
        public const int MT_EM_PAUSE_COLLECTION = 1611;
        public const int MT_EM_RESUME_COLLECTION = 1612;
        public const int MT_EM_GET_PDS = 1613;
        public const int MT_EM_SET_PDS = 1614;
        public const int MT_EM_AGGREGATE_DATA_NOW = 1615;
        public const int MT_EM_RESET_AGGREGATION = 1616;
        public const int MT_EM_CORRECT_DRIFT_NOW = 1617;
        public const int MT_EM_UPDATE_DRIFT_CORRECTION = 1618;
        public const int MT_RELOAD_PVA_CONFIG = 1619;
        public const int MT_EM_READY = 1650;
        public const int MT_EM_FROZEN = 1651;
        public const int MT_EM_ADAPT_DONE = 1652;
        public const int MT_EM_ADAPT_FAILED = 1653;
        public const int MT_EM_MOD_DEPTH_FAILED = 1654;
        public const int MT_EM_MOD_DEPTH_SUCCEEDED = 1655;
        public const int MT_EM_PDS = 1656;
        public const int MT_EM_ALREADY_FROZEN = 1657;
        public const int MT_EM_DRIFT_CORRECTED = 1658;
        public const int MT_RELOAD_CONFIGURATION = 1004;
        public const int MT_PVA_CONFIG = 382;
        public const int MT_PVA_STATE = 383;
        public const int MT_DECISION = 384;
        public const int MT_TRAINING_BEGIN = 385;
        public const int MT_DO_IT_DECIDER = 386;
        public const int MT_PVA_ATTENUATE_COMMAND = 387;
        public const int MAX_SPIKE_SOURCES = 2;
        public const int MAX_SPIKE_CHANS_PER_SOURCE = 128;
        public const int MAX_ANALOG_CHANS = 16;
        public const int MAX_UNITS_PER_CHAN = 6;
        public const int MAX_TOTAL_SPIKE_CHANS_PER_SOURCE = 768;
        public const int MAX_TOTAL_SPIKE_CHANS = 1536;
        public const int MAX_DIG_PER_SAMPLE = 10;
        public const int RAW_COUNTS_PER_SAMPLE = 2;
        public const int MSEC_PER_RAW_SAMPLE = 10;
        public const double SAMPLE_DT = 0.02;
        public const int MID_GROBOT_RAW_FEEDBACK = 19;
        public const int MID_GROBOT_FEEDBACK = 18;
        public const int MID_DIGITAL_IO = 17;
        public const int MID_TASK_JUDGE = 16;
        public const int MID_VRFORCE_JUDGE = 26;
        public const int MID_SI_MOVEMENT = 15;
        public const int MID_INPUT_TRANSFORM = 14;
        public const int MID_SIMPLE_ARBITRATOR = 13;
        public const int MID_OUTPUT_TRANSFORM = 12;
        public const int MID_FEEDBACK_TRANSFORM = 11;
        public const int MID_SAMPLE_GENERATOR = 29;
        public const int MID_VIRTUAL_FIXTURING = 28;
        public const int MID_CANNED_MOVEMENT = 27;
        public const int MID_HAND_VIZ = 30;
        public const int MID_IDLE_MONKEY = 36;
        public const int MID_CALIBRATION = 37;
        public const int MID_SSH_CONTROLLER = 35;
        public const int MID_IDLE_DETECTOR = 38;
        public const int MID_ARDUINO_IO = 39;
        public const int MID_POSITION_CONTROLLER = 40;
        public const int MID_JOINT_CONTROLLER = 42;
        public const int MID_WAM_BHAND = 25;
        public const int MID_EM_OVERRIDE_CONFIG = 31;
        public const int MID_OPTO_MPL_CTRL = 32;
        public const int MID_OBSTACLE_COURSE = 33;
        public const int MID_SKELETON_CTRL = 34;
        public const int MID_GROBOT_SEGMENT_PERCEPTS = 56;
        public const int MID_CERESTIM_CONFIG = 57;
        public const int MID_CERESTIM_CONTROL = 58;
        public const int MID_COMMAND_SPACE_FEEDBACK_GUI = 89;
        public const int MID_MESSAGE_WATCHER = 88;
        public const int MT_GROBOT_SEGMENT_PERCEPTS = 1888;
        public const int MT_CERESTIM_CONFIG_MODULE = 1889;
        public const int MT_CERESTIM_CONFIG_CHAN = 1890;
        public const int MT_GROBOT_COMMAND = 1700;
        public const int MT_GROBOT_RAW_FEEDBACK = 1701;
        public const int MT_GROBOT_FEEDBACK = 1702;
        public const int MT_COMMANDSPACE_FEEDBACK = 1703;
        public const int MT_GROBOT_BYPASS = 1704;
        public const int MT_GROBOT_END_BYPASS = 1707;
        public const int MT_MICROSTRAIN_DATA = 1705;
        public const int MT_GLOVE_DATA = 1706;
        public const int MT_EM_OVERRIDE_CONFIG = 1708;
        public const int MT_OPTO_CNTRL_CMD = 1709;
        public const int MT_OPTO_POS_CMD = 1712;
        public const int MT_KIN_POS_CMD = 1713;
        public const int MT_KINECT_SKELETON = 1711;
        public const int MT_SESSION_CONFIG = 1710;
        public const int MT_RAW_SPIKECOUNT = 1750;
        public const int MT_SPM_SPIKECOUNT = 1751;
        public const int MT_SAMPLE_GENERATED = 1752;
        public const int MT_SAMPLE_RESPONSE = 1753;
        public const int MT_RESET_SAMPLE_ALIGNMENT = 1754;
        public const int MT_SYNCH_NOW = 1800;
        public const int MT_SYNCH_START = 1801;
        public const int MT_SYNCH_DONE = 1802;
        public const int MT_INPUT_DOF_DATA = 1850;
        public const int MT_OPERATOR_MOVEMENT_COMMAND = 1900;
        public const int MT_FIXTURED_MOVEMENT_COMMAND = 1910;
        public const int MT_SHADOW_COMPOSITE_MOVEMENT_COMMAND = 1919;
        public const int MT_FIXTURED_COMPOSITE_MOVEMENT_COMMAND = 1920;
        public const int MT_PROBOT_FEEDBACK = 1930;
        public const int MAX_PROBOT_FEEDBACK_DIMS = 7;
        public const int MT_CHANGE_TOOL = 1940;
        public const int MT_CHANGE_TOOL_INVALID = 1941;
        public const int MT_CHANGE_TOOL_COMPLETE = 1942;
        public const int MT_CHANGE_TOOL_FAILED = 1943;
        public const int MT_TASK_STATE_CONFIG = 1950;
        public const int MT_JUDGE_VERDICT = 1960;
        public const int MT_END_TASK_STATE = 1970;
        public const int MT_RAW_SAMPLE_RESPONSE = 1980;
        public const int MT_CODE_VERSION = 1990;
        public const int MT_TRIAL_DATA_SAVED = 2080;
        public const int MT_EM_DECODER_CONFIGURATION = 2090;
        public const int MT_SPM_FIRINGRATE = 2100;
        public const int MT_LOAD_DECODER_CONFIG = 2110;
        public const int MT_APP_START = 2120;
        public const int MT_MODULE_START = 2125;
        public const int MT_MODULE_START_COMPLETE = 2126;
        public const int MT_EXIT_ACK = 2130;
        public const int MT_PING = 2140;
        public const int MT_PING_ACK = 2141;
        public const int MT_XM_START_SESSION = 2150;
        public const int MT_DEBUG_VECTOR = 2160;
        public const int MT_SPM_SPIKE_SNIPPET = 2170;
        public const int MT_REJECTED_SNIPPET = 2171;
        public const int MT_RAW_CTSDATA = 2172;
        public const int MT_SPIKE_SNIPPET = 2174;
        public const int MT_DIGITAL_EVENT = 2175;
        public const int MT_STIM_SYNC_EVENT = 2177;
        public const int MT_XM_END_OF_SESSION = 2180;
        public const int MT_IDLY_LABELLING = 2190;
        public const int MT_IDLY_RESET_LABELLING = 2200;
        public const int MT_EM_DRIFT_CORRECTION = 2210;
        public const int MT_ARTIFACT_REJECTED = 2220;
        public const int MT_PLAY_SOUND = 2230;
        public const int MT_WAM_FEEDBACK = 2240;
        public const int MT_WAM_HAND_FEEDBACK = 2242;
        public const int MT_IDLE = 2250;
        public const int MT_IDLE_DETECTION_ENDED = 2251;
        public const int MT_PLANNER_CONTROL_CONFIG = 2260;
        public const int MT_ROBOT_JOINT_COMMAND = 2270;
        public const int MT_IDLEGATED_MOVEMENT_COMMAND = 2280;
        public const int MT_CALIBRATION_STARTED = 2290;
        public const int MT_CALIBRATION_DONE = 2291;
        public const int MT_UNITY_SET_CURSOR_PROPERTY = 2300;
        public const int MT_UNITY_SET_HOME_PROPERTY = 2301;
        public const int MT_UNITY_SET_TARGET_PROPERTY = 2302;
        public const int MT_UNITY_TARGET_UI_SWITCH = 2310;
        public const int MT_UNITY_FEEDBACK_UI_SWITCH = 2311;
        public const int MT_UNITY_OBJ_COLOR_SWITCH = 2312;
        public const string DEFAULT_MM_IP = "localhost:7111";
        public const int SNIPPETS_PER_MESSAGE = 25;
        public const int SAMPLES_PER_SNIPPET = 48;
        public const int LFPSAMPLES_PER_HEARTBEAT = 10;
        public const int MAX_GROBOT_JOINTS = 28;
        public const int MAX_GROBOT_COMMAND_DIMS = 18;
        public const int MAX_GROBOT_FEEDBACK_DIMS = 18;
        public const int MAX_OPTO_CTRL_JOINTS = 6;
        public const int MAX_OPTO_POS = 4;
        public const int MAX_KIN_POS = 4;
        public const int NUM_FINGER_DIMS = 10;
        public const int KINECT_JOINTS = 20;
        public const int MAX_JOINT_DIMS = 8;
        public const int MPL_AT_ARM_EPV_FING_JV = 0;
        public const int MPL_AT_ARM_EPV_FING_JP = 1;
        public const int MPL_AT_ARM_JV_FING_JP = 2;
        public const int MPL_AT_ALL_JV = 3;
        public const int MPL_AT_ALL_JP = 4;
        public const int MPL_AT_ARM_EPP_FING_JP = 5;
        public const int MAX_DATA_DIR_LEN = 128;
        public const int MAX_CYBER_GLOVE_DIMS = 30;
        public const int MAX_EM_CHANNELS = 1728;
        public const int MAX_FINGER_DIMS = 10;
        public const int MAX_PERCEPT_DIMS = 15;
        public const int MAX_HAND_DIMS = 25;
        public const int MT_XM_ABORT_SESSION = 171;
        public const int MT_PROCEED_TO_Failure = 196;
        public const int MT_PROCEED_TO_NextState = 198;
        public const int MT_GO_TO_STATE = 192;
        public const int MT_PAUSE_EXPERIMENT = 180;
        public const int MT_RESUME_EXPERIMENT = 181;
        public const int MT_TRIAL_EVENT = 100;
        public const int MT_TRIAL_CONFIG = 101;
        public const int MT_TRIAL_STATUS = 102;
        public const int MT_WASHING_WITH_MONKEYS = 133;
        public const int MT_LICKING_BEGIN = 150;
        public const int MT_LICKING_END = 151;
        public const int MT_ROBOT_ACTUAL_STATE = 934;
        public const int MT_ROBOT_CONTROL_STATE = 935;
        public const int MT_ROBOT_CONTROL_SPACE_ACTUAL_STATE = 936;
        public const int MT_GRASP_EVENT = 937;
        public const int MT_ROBOT_CONTROL_CONFIG = 938;
        public const int MT_GIVE_REWARD = 600;
        public const int NUM_ANALOG_STREAM_CHANS = 12;
        public const int ASC_MONKEY_KNOB = 0;
        public const int ASC_MONKEY_DOOR = 1;
        public const int ASC_ROBOT_KNOB = 2;
        public const int ASC_ROBOT_DOOR = 3;
        public const int ASC_ARMREST_LF = 4;
        public const int ASC_ARMREST_LB = 5;
        public const int ASC_ARMREST_RF = 6;
        public const int ASC_ARMREST_RB = 7;
        public const int ASC_JOYPAD_LEFT_UD = 8;
        public const int ASC_JOYPAD_LEFT_LR = 9;
        public const int ASC_JOYPAD_RIGHT_UD = 10;
        public const int ASC_JOYPAD_RIGHT_LR = 11;
        public const int MT_IO_START_STREAM = 601;
        public const int MT_IO_STOP_STREAM = 602;
        public const int MT_JOYPAD_R1 = 610;
        public const int MT_JOYPAD_R2 = 611;
        public const int MT_JOYPAD_X = 612;
        public const int MT_JOYPAD_PAD_BUTTON = 613;
        public const int MT_READY_BUTTON = 614;
        public const int MT_ANALOG_STREAM = 620;
        public const int MT_IO_STREAM_STARTED = 621;
        public const int MT_IO_STREAM_STOPPED = 622;
        public const int MT_KNOB_TOUCHED = 640;
        public const int MT_KNOB_TURNED = 641;
        public const int MT_KNOB_ANTI_TURNED = 642;
        public const int MT_KNOB_OVER_TURNED = 643;
        public const int MT_DOOR_MOVED = 644;
        public const int MT_DOOR_OPENED = 645;
        public const int MT_DOOR_ANTI_OPENED = 646;
        public const int MT_DOOR_OVER_OPENED = 647;
        public const int MT_KNOB_MOVED = 648;
        public const int MT_DOOR_UN_OPENED = 649;
        public const int MT_KNOB_RELEASED = 650;
        public const int MT_PAD_PRESSED = 660;
        public const int MT_PAD_STEADY = 661;
        public const int MT_PAD_PERTURBED = 662;
        public const int MT_PAD_RELEASED = 663;
        public const int MT_DENSO_CONFIG = 800;
        public const int MT_DENSO_INITIALIZE = 801;
        public const int MT_DENSO_MOVE = 802;
        public const int MT_DENSO_HALT = 803;
        public const int MT_DENSO_SET_SPEED = 804;
        public const int MT_DENSO_WIGGLE = 806;
        public const int MT_DENSO_MOVE_CONTINUE = 807;
        public const int MT_DENSO_READY = 850;
        public const int MT_DENSO_NOT_READY = 851;
        public const int MT_DENSO_MOVE_COMPLETE = 852;
        public const int MT_DENSO_MOVE_FAILED = 853;
        public const int MT_DENSO_MOVE_INVALID = 854;
        public const int MT_DENSO_HALTED = 855;
        public const int MT_KILL_KILL_KILL_EM = 300;
        public const int MT_EM_MOVEMENT_COMMAND = 350;
        public const int MT_EM_AUX_MOVEMENT_COMMAND = 355;
        public const int MT_COMPOSITE_MOVEMENT_COMMAND = 366;
        public const int MT_ROBOT_MOVEMENT_COMMAND = 351;
        public const int MT_PLANNER_MOVEMENT_COMMAND = 352;
        public const int MT_PLANNER_STATE = 353;
        public const int MT_PLAN_PROCESSOR_STATE = 354;
        public const int MT_FM_MOVEMENT_COMMAND = 430;
        public const int MT_OVERRIDE_COMMAND = 480;
        public const int MT_JVEL_COMMAND = 481;
        public const int NUM_COMPONENT_DELAYS = 6;
        public const int MT_COMPONENT_DELAY_MSG_TYPES = 200;
        public const int MT_ESTIMATED_DELAY = 201;
        public const int MT_MEASURED_DELAY = 202;
        public const int MT_NOOP = 998;
        public const int MT_KEYBOARD = 1002;
        public const int MT_CLEAR_FUNCTION = 1003;
        public const int MT_LATE_ADAPT_NOW = 1005;
        public const int MT_DUMMY_MESSAGE = 2000;
        public const int MT_TARG_CLOUD = 1006;
        public const int MT_ATTENTION = 1659;
    }

    [StructLayout(LayoutKind.Sequential)]
    public class typedefs
    {
        public short MODULE_ID;
        public short HOST_ID;
        public int MSG_TYPE;
        public int MSG_COUNT;
        [StructLayout(LayoutKind.Sequential)]
        public class DF_MSG_HEADER
        {
            public int msg_type;
            public int msg_count;
            public double send_time;
            public double recv_time;
            public short src_host_id;
            public short src_mod_id;
            public short dest_host_id;
            public short dest_mod_id;
            public int num_data_bytes;
            public int remaining_bytes;
            public int is_dynamic;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class DF_MESSAGE
        {
            public int msg_type;
            public int msg_count;
            public double send_time;
            public double recv_time;
            public short src_host_id;
            public short src_mod_id;
            public short dest_host_id;
            public short dest_mod_id;
            public int num_data_bytes;
            public int remaining_bytes;
            public int is_dynamic;
            public int reserved;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9000)]
            public sbyte[] data = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        public sbyte[] STRING_DATA;
        [StructLayout(LayoutKind.Sequential)]
        public class MDF_FAIL_SUBSCRIBE
        {
            public short mod_id;
            public short reserved;
            public int msg_type;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_FAILED_MESSAGE
        {
            public short dest_mod_id;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public short[] reserved = {0,0,0};
            public double time_of_failure;
            [StructLayout(LayoutKind.Sequential)]
            public class msg_header_type
            {
                public int msg_type;
                public int msg_count;
                public double send_time;
                public double recv_time;
                public short src_host_id;
                public short src_mod_id;
                public short dest_host_id;
                public short dest_mod_id;
                public int num_data_bytes;
                public int remaining_bytes;
                public int is_dynamic;
                public int reserved;
            }
            public msg_header_type msg_header = new msg_header_type();

        }

        public sbyte[] MDF_MM_ERROR;
        public sbyte[] MDF_MM_INFO;
        [StructLayout(LayoutKind.Sequential)]
        public class MDF_CONNECT
        {
            public short logger_status;
            public short daemon_status;
        }

        public int MDF_SUBSCRIBE;
        public int MDF_UNSUBSCRIBE;
        public int MDF_PAUSE_SUBSCRIPTION;
        public int MDF_RESUME_SUBSCRIPTION;
        [StructLayout(LayoutKind.Sequential)]
        public class MDF_FORCE_DISCONNECT
        {
            public int mod_id;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_MODULE_READY
        {
            public int pid;
        }

        public sbyte[] MDF_DYNAMIC_DD_READ_ERR;
        public sbyte[] MDF_DEBUG_TEXT;
        public sbyte[] MDF_START_APP;
        public sbyte[] MDF_STOP_APP;
        public sbyte[] MDF_RESTART_APP;
        public sbyte[] MDF_KILL_APP;
        public sbyte[] MDF_SLAVE_START_APP;
        [StructLayout(LayoutKind.Sequential)]
        public class MDF_SLAVE_START_APP_ACK
        {
            public int num_remote_hosts;
        }

        public sbyte[] MDF_SLAVE_STOP_APP;
        public sbyte[] MDF_SLAVE_KILL_APP;
        public sbyte[] MDF_SLAVE_RESTART_APP;
        public sbyte[] MDF_AM_ERROR;
        public sbyte[] MDF_FAIL_START_APP;
        public sbyte[] MDF_FAIL_STOP_APP;
        public sbyte[] MDF_FAIL_KILL_APP;
        public sbyte[] MDF_AM_CONFIG_FILE_DATA;
        public sbyte[] MDF_AM_APP_NAME;
        public sbyte[] MDF_SLAVE_FAIL_START_APP;
        public sbyte[] MDF_SLAVE_AM_ERROR;
        public sbyte[] MDF_APP_ERROR;
        [StructLayout(LayoutKind.Sequential)]
        public class MDF_TIMER_EXPIRED
        {
            public int timer_id;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_TIMED_OUT
        {
            public int timer_id;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_SET_TIMER_FAILED
        {
            public short mod_id;
            public int timer_id;
            public int snooze_time;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_SET_TIMER
        {
            public int timer_id;
            public int snooze_time;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_CANCEL_TIMER
        {
            public int timer_id;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_SAVE_MESSAGE_LOG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public sbyte[] pathname = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public int pathname_length;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_TIMING_TEST
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public double[] time = {0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class SAMPLE_HEADER
        {
            public int SerialNo;
            public int Flags;
            public double DeltaTime;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MOVEMENT_COMMAND_DATA
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class INPUT_DOF_DATA
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public double[] dof_vals = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class TRIAL_EVENT
        {
            public double event_time;
            public int event_code;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PLAN_PROCESSOR_STATE
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 576)]
            public double[] D = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class AUTOMAGIC_CONTROLLER_PARAMS
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] virtualPadPosition = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] centralPointPosition = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] posMin = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] posMax = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] velMin = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] velMax = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public double graspingGraspApertureTarget;
            public double graspingOpenApertureTarget;
            public double graspingIntermediateApertureTarget;
            public double maxApproachSwingAngle;
            public double graspTooCloseIfClosedRadius;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class ROBOT_CONTROL_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] target = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public double[] coriMatrix = {0,0,0,0,0,0,0,0,0};
            [StructLayout(LayoutKind.Sequential)]
            public class trialEvent_type
            {
                public double event_time;
                public int event_code;
                public int reserved;
            }
            public trialEvent_type trialEvent = new trialEvent_type();

            [StructLayout(LayoutKind.Sequential)]
            public class autoControlParams_type
            {
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] virtualPadPosition = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
                public double[] centralPointPosition = {0,0,0};
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] posMin = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] posMax = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] velMin = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] velMax = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
                public double graspingGraspApertureTarget;
                public double graspingOpenApertureTarget;
                public double graspingIntermediateApertureTarget;
                public double maxApproachSwingAngle;
                public double graspTooCloseIfClosedRadius;
            }
            public autoControlParams_type autoControlParams = new autoControlParams_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoPosControlFraction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoVelControlFraction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoForceControlFraction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] orthPosImpedance = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] orthVelImpedance = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] orthForceImpedance = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] extrinsicVelControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] extrinsicPosControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] extrinsicForceControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] importantDOF = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class ROBOT_ACTUAL_STATE
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double RTMA_received_time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public double[] Jpos = {0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public double[] Jvel = {0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] Cpos = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] Cori = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] Cforce = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] Ctrq = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] Cvel = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] CangVel = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public double[] Hpos = {0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public double[] Hstrain = {0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] Jtrq = {0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class ROBOT_CONTROL_SPACE_ACTUAL_STATE
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double RTMA_received_time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public double[] CoriMatrix = {0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PLANNER_STATE
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] targetPos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class JVEL_COMMAND
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
            public double[] cmd = {0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class OVERRIDE_COMMAND
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] DOFCommand = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public double[] JposCommand = {0,0,0,0,0,0,0};
            public int controllerId;
            public int j0nks;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class ROBOT_CONTROL_STATE
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [StructLayout(LayoutKind.Sequential)]
            public class autoControl_type
            {
                [StructLayout(LayoutKind.Sequential)]
                public class sample_header_type
                {
                    public int SerialNo;
                    public int Flags;
                    public double DeltaTime;
                }
                public sample_header_type sample_header = new sample_header_type();

                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] targetPos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            }
            public autoControl_type autoControl = new autoControl_type();

            [StructLayout(LayoutKind.Sequential)]
            public class overrideCommand_type
            {
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] DOFCommand = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
                public double[] JposCommand = {0,0,0,0,0,0,0};
                public int controllerId;
                public int j0nks;
            }
            public overrideCommand_type overrideCommand = new overrideCommand_type();

            public double RTMA_received_time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] actualControlPos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] actualControlVel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] actualControlForce = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoControlPos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoControlVel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoControlForce = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoPosControlFraction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoVelControlFraction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoForceControlFraction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] orthPosImpedance = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] orthVelImpedance = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] orthForceImpedance = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] intrinsicVelControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] intrinsicPosControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] intrinsicForceControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] extrinsicVelControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] extrinsicPosControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] extrinsicForceControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] overrideDimensions = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public uint actualCommandComposition;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PS3_DATA
        {
            public int whichButton;
            public int val;
            public int controllerId;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] buttonMask = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] buttonVal = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] continuousMask = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] continuousVal = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] accelMask = {0,0};
            public int spacer;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] accelVal = {0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PS3_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] stickCommandDOFMap = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] stickCommandJointMap = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public double[] stickScale = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public double[] stickOffset = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public int use_controller;
            public int use_label_controller;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PS3_BUTTON_PRESS
        {
            public int whichButton;
            public int val;
            public int controllerId;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] buttonMask = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] buttonVal = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] continuousMask = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] continuousVal = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] accelMask = {0,0};
            public int spacer;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] accelVal = {0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PS3_BUTTON_RELEASE
        {
            public int whichButton;
            public int val;
            public int controllerId;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] buttonMask = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] buttonVal = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] continuousMask = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] continuousVal = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] accelMask = {0,0};
            public int spacer;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] accelVal = {0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PS3_RAW_DATA
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] buttonMask = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] buttonVal = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] continuousMask = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] continuousVal = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] accelMask = {0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] accelVal = {0,0};
            public int controllerId;
            public int spacer;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PS3_GENERIC_DATA
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public int controllerId;
            public int spacer;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public double[] dof_vals = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PS3_BUTTON_DATA
        {
            public int whichButton;
            public int controllerId;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PS3_RAW_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] stickCommandDOFMap = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] stickCommandJointMap = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public double[] stickScale = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public double[] stickOffset = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] accelScale = {0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] accelOffset = {0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] DOFscale = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] accelDOFMap = {0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public int[] use_controller = {0,0,0,0,0,0,0,0,0,0};
            public int free_run;
            public int spacer;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PS3_ACCEL_DATA
        {
            public int controllerId;
            public int ax;
            public int ay;
            public int az;
            public double time;
            public double ddx;
            public double ddy;
            public double ddz;
            public double dx;
            public double dy;
            public double dz;
            public double x;
            public double y;
            public double z;
            public double roll;
            public double pitch;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PS3_RAW_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] stickCommandDOFMap = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] stickCommandJointMap = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public double[] stickScale = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public double[] stickOffset = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] accelScale = {0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] accelOffset = {0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] DOFscale = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] accelDOFMap = {0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public int[] use_controller = {0,0,0,0,0,0,0,0,0,0};
            public int free_run;
            public int spacer;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PS3_SIMPLE_BUTTON_PRESS
        {
            public int whichButton;
            public int controllerId;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PS3_SIMPLE_BUTTON_RELEASE
        {
            public int whichButton;
            public int controllerId;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PS3_GENERIC_DATA
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public int controllerId;
            public int spacer;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public double[] dof_vals = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class EM_PARAMS
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] Dimensions = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_EM_START_SESSION
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] Dimensions = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_RELOAD_CONFIGURATION
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] Dimensions = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class EM_PROCEDURE_MESSAGE
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] regressionGroups = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_EM_RESET_AGGREGATION
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] regressionGroups = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_EM_RESUME_COLLECTION
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] regressionGroups = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_EM_AGGREGATE_DATA_NOW
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] regressionGroups = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_EM_PAUSE_COLLECTION
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] regressionGroups = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_EM_RESET_STATE
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] initial_position = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] initial_velocity = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] target_position = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public int reset_history;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_EM_START_TRIAL
        {
            public int data_index;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_EM_ADAPT_NOW
        {
            public int first_data_index;
            public int last_data_index;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_EM_UPDATE_DRIFT_CORRECTION
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] drift_correction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        public double MDF_EM_MOD_DEPTH_CUTOFF;
        public sbyte[] MDF_EM_SET_PDS;
        public sbyte[] MDF_EM_PDS;
        [StructLayout(LayoutKind.Sequential)]
        public class PVAConfig
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] Norm2RealFactor = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public double ModDepthCutoff;
            public double RSquaredCutoff;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public double[] PredictFRFilter = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public double[] AdaptFRFilter = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public double[] TargetFilter = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] RegressionGroups = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] ControlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public double numAdaptReps;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PVA_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] Norm2RealFactor = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public double ModDepthCutoff;
            public double RSquaredCutoff;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public double[] PredictFRFilter = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public double[] AdaptFRFilter = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public double[] TargetFilter = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] RegressionGroups = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] ControlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public double numAdaptReps;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PVAState
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1600)]
            public double[] PV = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 200)]
            public int[] usedIndices = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PVA_STATE
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1600)]
            public double[] PV = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 200)]
            public int[] usedIndices = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PVAAttenuateCommand
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] targTag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 200)]
            public double[] attenuationLevel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PVA_ATTENUATE_COMMAND
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] targTag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 200)]
            public double[] attenuationLevel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_RAW_SPIKECOUNT
        {
            public int source_index;
            public int reserved;
            public double source_timestamp;
            public double count_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 768)]
            public byte[] counts = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        public byte SPIKE_COUNT_DATA_TYPE;
        [StructLayout(LayoutKind.Sequential)]
        public class MDF_SPM_SPIKECOUNT
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] source_timestamp = {0,0};
            public double count_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1536)]
            public byte[] counts = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_SAMPLE_GENERATED
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] source_timestamp = {0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_SAMPLE_RESPONSE
        {
            public double sample_response_timestamp;
            public double sample_alignment_timestamp;
            public uint sample_response_count;
            public uint sample_alignment_count;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_INPUT_DOF_DATA
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public double[] dof_vals = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_OPERATOR_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_FIXTURED_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_SHADOW_COMPOSITE_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_FIXTURED_COMPOSITE_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PROBOT_FEEDBACK
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public double[] tool_pos = {0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public double[] wrist_pos = {0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_GROBOT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] command = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public int mode;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_GROBOT_BYPASS
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] command = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public int mode;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_OPTO_CNTRL_CMD
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public double[] Cmd = {0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_OPTO_POS_CMD
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public double[] Cmd = {0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_KIN_POS_CMD
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public double[] Cmd = {0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_KINECT_SKELETON
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public double[] x = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public double[] y = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public double[] z = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public double[] w = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public int Which;
            public int Reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_GROBOT_SEGMENT_PERCEPTS
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] ind_force = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] mid_force = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] rng_force = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] lit_force = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] thb_force = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] ind_accel = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] mid_accel = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] rng_accel = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] lit_accel = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] thb_accel = {0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_CERESTIM_CONFIG_MODULE
        {
            public int configID;
            public int afcf;
            public double pulses;
            public double amp1;
            public double amp2;
            public double width1;
            public double width2;
            public double frequency;
            public double interphase;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_CERESTIM_CONFIG_CHAN
        {
            public int stop;
            public int group_stimulus;
            public int group_numChans;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public int[] group_channel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public int[] group_pattern = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public int manual_stimulus;
            public int manual_channel;
            public int manual_pattern;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_GROBOT_RAW_FEEDBACK
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
            public double[] j_ang = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
            public double[] j_vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
            public double[] j_trq = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_GROBOT_FEEDBACK
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] position = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] velocity = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public double[] cori_matrix = {0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_SESSION_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public sbyte[] data_dir = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_GLOVE_DATA
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
            public double[] data = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_MICROSTRAIN_DATA
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
            public double[] data = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_EM_OVERRIDE_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1728)]
            public int[] chosen_channel_mask = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_CHANGE_TOOL
        {
            public int next_tool_id;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_CHANGE_TOOL_COMPLETE
        {
            public int tool_id;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_TASK_STATE_CONFIG
        {
            public int id;
            public int rep_num;
            public int trial_num;
            public int reserved;
            public int use_for_vel_calib;
            public int use_for_force_calib;
            public int target_combo_index;
            public int timed_out_conseq;
            public int idle_gateable;
            public int reach_offset;
            public short planner_vel;
            public short planner_force;
            public short show_target;
            public short show_home;
            public short make_choice;
            public short num_of_target;
            public short reserved1;
            public short reserved2;
            public double contact_angle_threshold;
            public double vr_force_thr;
            public double idle_timeout;
            public double ts_time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public double[] target = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public double[] present_target = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public double[] judge_target = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public double[] coriMatrix = {0,0,0,0,0,0,0,0,0};
            public double trans_threshold;
            public double force_threshold;
            public double ori_threshold;
            public double trans_threshold_f;
            public double force_threshold_f;
            public double ori_threshold_f;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public double[] finger_threshold = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public int[] finger_threshold_judging_method = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public int[] finger_threshold_judging_polarity = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public int trans_threshold_judging_polarity;
            public int ori_threshold_judging_polarity;
            public int trans_threshold_f_judging_polarity;
            public int ori_threshold_f_judging_polarity;
            public double timeout;
            public double trans_duration;
            public double trans_duration_percent;
            public double force_duration;
            public double force_duration_percent;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tags = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_JUDGE_VERDICT
        {
            public int id;
            public int reserved;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] reason = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_END_TASK_STATE
        {
            public int id;
            public int outcome;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] reason = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_RAW_SAMPLE_RESPONSE
        {
            public int source_index;
            public int reserved;
            public double source_timestamp;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_CODE_VERSION
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] module_name = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] version = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_SPM_FIRINGRATE
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double source_timestamp;
            public double count_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1536)]
            public double[] rates = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        public byte[] MDF_EM_DECODER_CONFIGURATION;
        [StructLayout(LayoutKind.Sequential)]
        public class MDF_LOAD_DECODER_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public sbyte[] full_path = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_XM_START_SESSION
        {
            public int load_calibration;
            public int calib_session_id;
            public int num_reps;
            public int reserved;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] subject_name = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PING
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] module_name = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PING_ACK
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] module_name = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_DEBUG_VECTOR
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public double[] data = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_APP_START
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] config = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_MODULE_START
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] module = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_SPM_SPIKE_SNIPPET
        {
            public double time;
            public int chan;
            public int unit;
            public int box_id;
            public int length;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public short[] snippet = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class SPIKE_SNIPPET
        {
            public int source_index;
            public int channel;
            public int unit;
            public int reserved;
            public double source_timestamp;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] fPattern = {0,0,0};
            public int nPeak;
            public int nValley;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public short[] snippet = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_SPIKE_SNIPPET
        {
            [StructLayout(LayoutKind.Sequential)]
            public class ss_type
            {
                public int source_index;
                public int channel;
                public int unit;
                public int reserved;
                public double source_timestamp;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
                public double[] fPattern = {0,0,0};
                public int nPeak;
                public int nValley;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
                public short[] snippet = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            }
            public ss_type ss = new ss_type();

        }

        [StructLayout(LayoutKind.Sequential)]
        public class REJECTED_SNIPPET
        {
            public int source_index;
            public short channel;
            public byte unit;
            public byte reserved1;
            public double source_timestamp;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] fPattern = {0,0,0};
            public short nPeak;
            public short nValley;
            public int rejectType;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public short[] snippet = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_REJECTED_SNIPPET
        {
            [StructLayout(LayoutKind.Sequential)]
            public class rs_type
            {
                public int source_index;
                public short channel;
                public byte unit;
                public byte reserved1;
                public double source_timestamp;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
                public double[] fPattern = {0,0,0};
                public short nPeak;
                public short nValley;
                public int rejectType;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
                public short[] snippet = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            }
            public rs_type rs = new rs_type();

        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_RAW_CTSDATA
        {
            public int source_index;
            public int reserved;
            public double source_timestamp;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1440)]
            public short[] data = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_DIGITAL_EVENT
        {
            public int source_index;
            public int channel;
            public double source_timestamp;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public uint[] data = {0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_STIM_SYNC_EVENT
        {
            public int source_index;
            public int channel;
            public double source_timestamp;
            public uint data;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_IDLY_LABELLING
        {
            public int state;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_EM_DRIFT_CORRECTION
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] drift_correction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_DENSO_WIGGLE
        {
            public int movement_id;
            public int num_cycles;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] sequence = {0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] amplitude = {0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PLAY_SOUND
        {
            public int id;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_ARTIFACT_REJECTED
        {
            public double time;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_IDLE
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double score;
            public double gain;
            public int idle;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_WAM_FEEDBACK
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double RTMA_received_time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public double[] CoriMatrix = {0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_WAM_HAND_FEEDBACK
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double RTMA_received_time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public double[] CoriMatrix = {0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PLANNER_CONTROL_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] target = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public double[] coriMatrix = {0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_ROBOT_JOINT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public double[] pos = {0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] overrideDims = {0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_IDLEGATED_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class UNITY_SET_OBJ_PROPERTY
        {
            public int obj_index;
            public int reserved;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] color = {0,0,0};
            public double alpha;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] scale = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] impedance = {0,0,0};
            public double deformation_radius;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_UNITY_SET_CURSOR_PROPERTY
        {
            public int obj_index;
            public int reserved;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] color = {0,0,0};
            public double alpha;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] scale = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] impedance = {0,0,0};
            public double deformation_radius;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_UNITY_SET_HOME_PROPERTY
        {
            public int obj_index;
            public int reserved;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] color = {0,0,0};
            public double alpha;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] scale = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] impedance = {0,0,0};
            public double deformation_radius;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_UNITY_SET_TARGET_PROPERTY
        {
            public int obj_index;
            public int reserved;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] color = {0,0,0};
            public double alpha;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] scale = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] impedance = {0,0,0};
            public double deformation_radius;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class UNITY_UI_SWITCH
        {
            public int status;
            public int spacer;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_UNITY_TARGET_UI_SWITCH
        {
            public int status;
            public int spacer;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_UNITY_FEEDBACK_UI_SWITCH
        {
            public int status;
            public int spacer;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_UNITY_OBJ_COLOR_SWITCH
        {
            public int status;
            public int spacer;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_TRIAL_EVENT
        {
            public double event_time;
            public int event_code;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_TRIAL_CONFIG
        {
            public int rep_no;
            public int trial_no;
            public int num_reward_states;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_TRIAL_STATUS
        {
            public int success;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_ROBOT_ACTUAL_STATE
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double RTMA_received_time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public double[] Jpos = {0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public double[] Jvel = {0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] Cpos = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] Cori = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] Cforce = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] Ctrq = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] Cvel = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] CangVel = {0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public double[] Hpos = {0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public double[] Hstrain = {0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public double[] Jtrq = {0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_ROBOT_CONTROL_STATE
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [StructLayout(LayoutKind.Sequential)]
            public class autoControl_type
            {
                [StructLayout(LayoutKind.Sequential)]
                public class sample_header_type
                {
                    public int SerialNo;
                    public int Flags;
                    public double DeltaTime;
                }
                public sample_header_type sample_header = new sample_header_type();

                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] targetPos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            }
            public autoControl_type autoControl = new autoControl_type();

            [StructLayout(LayoutKind.Sequential)]
            public class overrideCommand_type
            {
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] DOFCommand = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
                public double[] JposCommand = {0,0,0,0,0,0,0};
                public int controllerId;
                public int j0nks;
            }
            public overrideCommand_type overrideCommand = new overrideCommand_type();

            public double RTMA_received_time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] actualControlPos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] actualControlVel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] actualControlForce = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoControlPos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoControlVel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoControlForce = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoPosControlFraction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoVelControlFraction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoForceControlFraction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] orthPosImpedance = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] orthVelImpedance = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] orthForceImpedance = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] intrinsicVelControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] intrinsicPosControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] intrinsicForceControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] extrinsicVelControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] extrinsicPosControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] extrinsicForceControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] overrideDimensions = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public uint actualCommandComposition;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_ROBOT_CONTROL_SPACE_ACTUAL_STATE
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double RTMA_received_time;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public double[] CoriMatrix = {0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_ROBOT_CONTROL_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] target = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public double[] coriMatrix = {0,0,0,0,0,0,0,0,0};
            [StructLayout(LayoutKind.Sequential)]
            public class trialEvent_type
            {
                public double event_time;
                public int event_code;
                public int reserved;
            }
            public trialEvent_type trialEvent = new trialEvent_type();

            [StructLayout(LayoutKind.Sequential)]
            public class autoControlParams_type
            {
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] virtualPadPosition = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
                public double[] centralPointPosition = {0,0,0};
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] posMin = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] posMax = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] velMin = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
                public double[] velMax = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
                public double graspingGraspApertureTarget;
                public double graspingOpenApertureTarget;
                public double graspingIntermediateApertureTarget;
                public double maxApproachSwingAngle;
                public double graspTooCloseIfClosedRadius;
            }
            public autoControlParams_type autoControlParams = new autoControlParams_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoPosControlFraction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoVelControlFraction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] autoForceControlFraction = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] orthPosImpedance = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] orthVelImpedance = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] orthForceImpedance = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] extrinsicVelControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] extrinsicPosControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] extrinsicForceControlled = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] importantDOF = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_GIVE_REWARD
        {
            public double duration_ms;
            public double num_clicks;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_IO_START_STREAM
        {
            [StructLayout(LayoutKind.Sequential)]
            public class limits_type
            {
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
                public double[] high = {0,0,0,0,0,0,0,0,0,0,0,0};
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
                public double[] low = {0,0,0,0,0,0,0,0,0,0,0,0};
            }
            public limits_type limits = new limits_type();

            public int reserved;
            public int internal_sampling;
            public double sample_interval;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_ANALOG_STREAM
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public double[] data = {0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class KNOB_EVENT_DATA
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_KNOB_TOUCHED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_KNOB_TURNED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_KNOB_ANTI_TURNED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_KNOB_OVER_TURNED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_DOOR_MOVED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_DOOR_OPENED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_DOOR_ANTI_OPENED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_DOOR_OVER_OPENED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_KNOB_MOVED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_DOOR_UN_OPENED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_KNOB_RELEASED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PAD_PRESSED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PAD_STEADY
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PAD_PERTURBED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PAD_RELEASED
        {
            public double source_time;
            public double event_time;
            public int sample_no;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_DENSO_MOVE
        {
            public int position_no;
            public int movement_id;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_DENSO_SET_SPEED
        {
            public double speed;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_DENSO_MOVE_CONTINUE
        {
            public int position_no;
            public int movement_id;
        }

        public sbyte[] MDF_DENSO_NOT_READY;
        [StructLayout(LayoutKind.Sequential)]
        public class RESPONSE_DATA_TO_DENSO_MOVE
        {
            public int movement_id;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_DENSO_MOVE_COMPLETE
        {
            public int movement_id;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_DENSO_MOVE_FAILED
        {
            public int movement_id;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_DENSO_MOVE_INVALID
        {
            public int movement_id;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_DENSO_HALTED
        {
            public int movement_id;
            public int reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_EM_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_EM_AUX_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_COMPOSITE_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_ROBOT_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PLANNER_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PLANNER_STATE
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] targetPos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_PLAN_PROCESSOR_STATE
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 576)]
            public double[] D = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_FM_MOVEMENT_COMMAND
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            public double sample_interval;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] pos = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] vel = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] force = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public int[] controlledDims = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public sbyte[] tag = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_OVERRIDE_COMMAND
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public double[] DOFCommand = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public double[] JposCommand = {0,0,0,0,0,0,0};
            public int controllerId;
            public int j0nks;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_JVEL_COMMAND
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
            public double[] cmd = {0,0,0,0,0,0,0,0,0,0,0};
        }

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public int[] MDF_COMPONENT_DELAY_MSG_TYPES = {0,0,0,0,0,0};
        [StructLayout(LayoutKind.Sequential)]
        public class DELAY_DATA
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public double[] Components = {0,0,0,0,0,0};
            public double Total;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_ESTIMATED_DELAY
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public double[] Components = {0,0,0,0,0,0};
            public double Total;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_MEASURED_DELAY
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public double[] Components = {0,0,0,0,0,0};
            public double Total;
        }

        public sbyte[] MDF_CLEAR_FUNCTION;
        [StructLayout(LayoutKind.Sequential)]
        public class TARG_CLOUD
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 576)]
            public double[] cloud = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public int nTargs;
            public int spacer;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class MDF_TARG_CLOUD
        {
            [StructLayout(LayoutKind.Sequential)]
            public class sample_header_type
            {
                public int SerialNo;
                public int Flags;
                public double DeltaTime;
            }
            public sample_header_type sample_header = new sample_header_type();

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 576)]
            public double[] cloud = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            public int nTargs;
            public int spacer;
        }

        public double MDF_ATTENTION;
    }

}

