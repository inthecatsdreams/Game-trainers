using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace t5
{
   
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        public Mem Memlib = new Mem();
        private void Form1_Load(object sender, EventArgs e)
        {
           

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Memlib.OpenProcess("plutonium-bootstrapper-win32"))
            {
                label1.Text = "Connected";
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "Something went wrong";
                label1.ForeColor = Color.Red;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                    //first weapon
            Memlib.WriteMemory("base+0x1808F00", "int", "999999");
                    //second weapon
            Memlib.WriteMemory("base+1808F10", "int", "999999");

             
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            string address = "base+22295A8";
            string addType = "float";
            string finalValue = trackBar1.Value.ToString();
            Memlib.WriteMemory(address, addType, finalValue);        }

        private void button2_Click(object sender, EventArgs e)
        {
            Memlib.WriteMemory("base+180A6C8", "int", Int32.MaxValue.ToString());
        }
    }
}
