﻿using System;
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
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
        }

        public override bool PreProcessMessage(ref Message msg)
        {
            Console.WriteLine(msg.Msg);
            return base.PreProcessMessage(ref msg);
        }
    }
}
