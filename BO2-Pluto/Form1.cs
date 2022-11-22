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

namespace T6
{
    public partial class Form1 : Form
    {

        public Mem Memlib = new Mem();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Memlib.OpenProcess("plutonium-bootstrapper-win32"))
            {
                //MessageBox.Show("Connected!");
                if (backgroundWorker1.IsBusy == false)
                    backgroundWorker1.RunWorkerAsync();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Memlib.WriteMemory("base+1F47D68", "int", "999999");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {   
                if (checkBox1.Checked){
                    Memlib.WriteMemory("base+1F42BCC", "int", "999999"); //primary  
                    Memlib.WriteMemory("base+1F42BD4", "int", "999999");//secondary

                }

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            string value = trackBar1.Value.ToString();
            Memlib.WriteMemory("base+2611920", "float", value);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
