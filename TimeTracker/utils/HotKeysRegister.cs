using System;
using System.Windows.Forms;
using Trustsoft.WideHotkeys;
//using NHotkey;

namespace TimeTracker.utils
{
    class HotKeysRegister
    {
        private HotkeyManager hkm = new HotkeyManager();
        public HotKeysRegister()
        {
            registerDefaultHotKeys();
        }

        private void registerDefaultHotKeys()
        {

        }

       
}

}


/*


     var hkm = new HotkeyManager();
        hkm.AddOrReplace("nombre", Keys.Control | Keys.Shift | Keys.Down, OnHotkey1);
        }

    private void OnHotkey1(object sender, HotkeyEventArgs e)
    {
        Console.WriteLine("Ctrl+Shift+ Hotkey pressed");

        e.Handled = true;
    }


    */
