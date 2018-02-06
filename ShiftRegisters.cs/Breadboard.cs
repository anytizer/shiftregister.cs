using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftRegisters.cs
{
    public partial class Breadboard : Form
    {
        private Color off = Color.White;
        private Color on = Color.Yellow;

        public Breadboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shiftRegister1.impediance((sender as Button).BackColor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shiftRegister1.impediance((sender as Button).BackColor);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            shiftRegister1.impediance((sender as Button).BackColor);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            shiftRegister1.shiftRight(on);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            shiftRegister1.shiftRight(off);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /**
             * Manage nodes
             */
            shiftRegister1.rightNode(shiftRegister2).rightNode(shiftRegister3).rightNode(shiftRegister4);
            shiftRegister4.rightNode(shiftRegister5).rightNode(shiftRegister6).rightNode(shiftRegister7);
            shiftRegister7.rightNode(shiftRegister8);
        }
    }
}
