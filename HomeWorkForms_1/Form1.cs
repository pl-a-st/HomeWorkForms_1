using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkForms_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Number1
        {
            get; private set;
        }
        public double Number2
        {
            get; private set;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckResolution();
        }
        private void CheckResolution()
        {
            if (resolutionCB.Checked)
            {
                calculateBt.Enabled=true;
            }
            else
            {
                calculateBt.Enabled = false;
            }
        }
        private void CheckInputData()
        {
           


        }
    }
}
