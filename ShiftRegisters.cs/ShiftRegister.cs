using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftRegisters.cs
{
    public partial class ShiftRegister : UserControl
    {
        private ShiftRegister rightside = null;

        public ShiftRegister()
        {
            InitializeComponent();
            disableButtons();
        }

        private void ShiftRegister_Load(object sender, EventArgs e)
        {
            disableButtons();
        }

        private void disableButtons()
        {
            /**
             * Make not clickable by user
             */
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
        }

        private void color(Color c)
        {
            button1.BackColor = c;
            button2.BackColor = c;
            button3.BackColor = c;
            button4.BackColor = c;
            button5.BackColor = c;
            button6.BackColor = c;
            button7.BackColor = c;
            button8.BackColor = c;
        }

        /**
         * Shifts a color
         * Returns QH' for output to another Shift Register
         */
        private Color shift(Color c)
        {
            Color QH = button8.BackColor;

            button8.BackColor = button7.BackColor;
            button7.BackColor = button6.BackColor;
            button6.BackColor = button5.BackColor;
            button5.BackColor = button4.BackColor;
            button4.BackColor = button3.BackColor;
            button3.BackColor = button2.BackColor;
            button2.BackColor = button1.BackColor;
            button1.BackColor = c;

            return QH;
        }

        public void impediance(Color c)
        {
            this.color(c);
            if (this.rightside != null)
            {
                // recursive
                this.rightside.impediance(c);
            }
        }

        public void shiftRight(Color c)
        {
            Color QH = this.shift(c);
            if(this.rightside != null)
            {
                // recursive
                this.rightside.shiftRight(QH);
            }
        }

        /**
         * Add a node
         */
        public ShiftRegister rightNode(ShiftRegister sr)
        {
            this.rightside = sr;
            return sr;
        }
    }
}
