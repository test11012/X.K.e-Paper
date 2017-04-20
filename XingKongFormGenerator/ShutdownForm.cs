﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XingKongForm;

namespace XingKongFormGenerator
{
    public partial class ShutdownForm : XingKongFormBase
    {
        public ShutdownForm()
        {
            InitializeComponent();
        }

        private void ShutdownForm_Load(object sender, EventArgs e)
        {
            PortName = "COM4";

            XingKongWindow window = GetXingKongWindow();
            XingKongPanel.IsDebugEnabled = true;
            //LocalShow();
            ShowCode();
        }
    }
}
