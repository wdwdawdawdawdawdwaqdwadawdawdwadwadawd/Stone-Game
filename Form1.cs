using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoneGame
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)//right
        {
            rig = true;
        }

        private void button1_Click(object sender, EventArgs e)//left
        {
            leff = true;
        }


    }
}
