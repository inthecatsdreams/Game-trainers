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
                label1.Text = "Status: Connected";
                label1.ForeColor = Color.Green;
                if (backgroundWorker1.IsBusy == false)
                    backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                label1.Text = "Status: Something went wrong";
                label1.ForeColor = Color.Red;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                    //first weapon
                

             
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
            Memlib.WriteMemory("base+180A6C8", "int", "999999999");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Memlib.WriteMemory("base+2228FF8", "int", "3");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true) //infinite loop
            {
                
                
                if (checkBox1.Checked) // ammo
                {
                    Memlib.WriteMemory("base+0x1808F00", "int", "999999");
                    Memlib.WriteMemory("base+1808F10", "int", "999999");
                    Memlib.WriteMemory("base+1808F18", "int", "999999");
                    Memlib.WriteMemory("base+1808F08", "int", "999999");
                    Memlib.WriteMemory("base+1808F20", "int", "999999");

                }
                if (checkBox3.Checked)
                    Memlib.WriteMemory("base+0x167987C", "int", "250");

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
