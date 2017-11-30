﻿using System;

namespace ShellLink
{
    [Flags]
    public enum HotKeyFlags : Int16
    {
        None = 0,
        Key_0 = 0x30,
        Key_1,
        Key_2,
        Key_3,
        Key_4,
        Key_5,
        Key_6,
        Key_7,
        Key_8,
        Key_9,
        Key_A = 0x41,
        Key_B,
        Key_C,
        Key_D,
        Key_E,
        Key_F,
        Key_G,
        Key_H,
        Key_I,
        Key_J,
        Key_K,
        Key_L,
        Key_M,
        Key_N,
        Key_O,
        Key_P,
        Key_Q,
        Key_R,
        Key_S,
        Key_T,
        Key_U,
        Key_V,
        Key_W,
        Key_X,
        Key_Y,
        Key_Z,
        VK_F1 = 0X70,
        VK_F2,
        VK_F3,
        VK_F4,
        VK_F5,
        VK_F6,
        VK_F7,
        VK_F8,
        VK_F9,
        VK_F10,
        VK_F11,
        VK_F12,
        VK_F13,
        VK_F14,
        VK_F15,
        VK_F16,
        VK_F17,
        VK_F18,
        VK_F19,
        VK_F20,
        VK_F21,
        VK_F22,
        VK_F23,
        VK_F24,
        VK_NUMLOCK = 0x90,
        VK_SCROLL = 0x91,

        HOTKEYF_SHIFT = 0x0100,
        HOTKEYF_CONTROL = 0x0200,
        HOTKEYF_ALT = 0x0400,
    }
}