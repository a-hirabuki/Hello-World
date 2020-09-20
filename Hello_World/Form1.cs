using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Form_Message : Form
    {
        public Form_Message()
        {
            InitializeComponent();
        }

        private void button_Message_Click(object sender, EventArgs e)
        {
            textBox_Message.Text = "Hello World!";
        }
    }
}
