using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformMessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = this.Handle.ToString();
            CustomTextBox tb = new CustomTextBox();
            //this.Controls.Add(tb);
            CustomButton btn = new CustomButton();
            btn.Location = new Point(100, 100);
            //this.Controls.Add(btn);
            //this.IsInputChar()
            this.Shown += Form1_Shown;
        }

        void Form1_Shown(object sender, EventArgs e)
        {
            Console.WriteLine("Shown事件被引发");
        }

        protected override void OnShown(EventArgs e)
        {
            /*
             *  1、引发Shown事件
             *  2、被OnLoad调用
             */
            Console.WriteLine("OnShown");
            base.OnShown(e);
        }

        protected override void WndProc(ref Message m)
        {
            //if (m.Msg == 0x0102)
            //{
            //    Console.WriteLine(string.Format("Form1 WndProc msg={0},wparam={1},lparam={2}", m.Msg, m.WParam, m.LParam));
            //}
            if (m.Msg == 0x102)
            {
                Console.WriteLine(m.WParam);
            }
            base.WndProc(ref m);
        }

        public override bool PreProcessMessage(ref Message msg)
        {
            /* 
             *  1、只能接收键盘消息:wm_keydown wm_char wm_keyup
             *  2、先PreProcessMessage 后WndProc
             */

            /*
             *  Control.PreProcessMessage代码实现
             *  
             *  if 消息==wm_keydown或wm_syskeydown
             *  {    
             *      if ProcessCmdKey(ref msg, keyData)
             *      {
             *          return true
             *      }
             *      if this.IsInputKey(keyData)
             *      {
             *          return false;
             *      }
             *      return this.ProcessDialogKey(keyData)         
             *  }
             *  
             *  if 消息==wm_char或wm_syschar
             *  {
             *      return this.ProcessDialogChar((char) ((int) msg.WParam))
             *  }
             *  
             *  return false
             */

            Console.WriteLine(string.Format("Form1 PreProcessMessage msg={0},wparam={1},lparam={2}", msg.Msg, msg.WParam, msg.LParam));
            switch (msg.Msg)
            {
                default:
                    return base.PreProcessMessage(ref msg);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            /*
             *  1、被OnCreateControl调用 
             *  2、引发Load事件 
             */
            base.OnLoad(e);
        }

        protected override void OnCreateControl()
        {
            /*
             *  1、被CreateControl调用(public)(control类)
             */

            Console.WriteLine("OnCreateControl");
            base.OnCreateControl();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Load事件被引发");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            /*
             *  1、被PreProcessMessage调用
             */
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
