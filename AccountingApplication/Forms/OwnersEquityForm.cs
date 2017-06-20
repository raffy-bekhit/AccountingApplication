﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApplication.Forms
{
    public partial class OwnersEquityForm : Form
    {
        public OwnersEquityForm()
        {
            InitializeComponent();
        }

        private void OwnersEquityForm_Load(object sender, EventArgs e)
        {
            
            foreach (ArrayList array in Classes.OwnersEquity.GetOwnersEquityData())
            {
                OEGrid.Rows.Add(array.ToArray());
            }
        }
    }
}
