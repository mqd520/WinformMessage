using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformMessage
{
    public class CustomButton : Button
    {
        public override bool PreProcessMessage(ref Message msg)
        {
            Console.WriteLine(string.Format("CustomButton msg={0},wparam={1},lparam={2}", msg.Msg, msg.WParam, msg.LParam));
            switch (msg.Msg)
            {
                case 256:
                    return true;
                default:
                    return base.PreProcessMessage(ref msg);
            }
        }
    }
}
