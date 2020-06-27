﻿using System;
using System.Windows.Forms;

namespace CefSharp.RequestIntercept.CefHandler
{
    public class KeyBoardHandler: IKeyboardHandler
    {
        public bool OnKeyEvent(IWebBrowser browserControl, IBrowser browser, KeyType type, int windowsKeyCode, int nativeKeyCode, CefEventFlags modifiers, bool isSystemKey)
        {
            if (type != KeyType.KeyUp || !Enum.IsDefined(typeof(Keys), windowsKeyCode))
            {
                return false;
            }
            Keys key = (Keys)windowsKeyCode;
            switch (key)
            {
                case Keys.F12:
                    browser.ShowDevTools();
                    break;
                case Keys.F5:
                    if (modifiers == CefEventFlags.ControlDown)
                    {
                        browser.Reload(true); //强制忽略缓存
                    }
                    else
                    {
                        browser.Reload();
                    }
                    break;
            }
            return false;
        }

        public bool OnPreKeyEvent(IWebBrowser browserControl, IBrowser browser, KeyType type, int windowsKeyCode, int nativeKeyCode, CefEventFlags modifiers, bool isSystemKey, ref bool isKeyboardShortcut)
        {
            return false;
        }
    }
}