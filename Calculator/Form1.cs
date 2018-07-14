using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double value = 0;
        string Ops = "";
        bool op_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hasil.Focus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (Hasil.Text == "1" || (op_pressed ))
            {
                Hasil.Clear();
            }

            Button b = (Button)sender;
            Hasil.Text = Hasil.Text + b.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (Hasil.Text == "0" || (op_pressed))
            {
                Hasil.Clear();
            }

            Button b = (Button)sender;
            Hasil.Text = Hasil.Text + b.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (Hasil.Text == "2" || (op_pressed))
            {
                Hasil.Clear();
            }
            
            Button b = (Button)sender;
            Hasil.Text = Hasil.Text + b.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (Hasil.Text == "3" || (op_pressed))
            {
                Hasil.Clear();
            }

            Button b = (Button)sender;
            Hasil.Text = Hasil.Text + b.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (Hasil.Text == "4" || (op_pressed))
            {
                Hasil.Clear();
            }

            Button b = (Button)sender;
            Hasil.Text = Hasil.Text + b.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (Hasil.Text == "5" || (op_pressed))
            {
                Hasil.Clear();
            }

            Button b = (Button)sender;
            Hasil.Text = Hasil.Text + b.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (Hasil.Text == "6" || (op_pressed))
            {
                Hasil.Clear();
            }

            Button b = (Button)sender;
            Hasil.Text = Hasil.Text + b.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (Hasil.Text == "7" || (op_pressed))
            {
                Hasil.Clear();
            }

            Button b = (Button)sender;
            Hasil.Text = Hasil.Text + b.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (Hasil.Text == "8" || (op_pressed))
            {
                Hasil.Clear();
            }

            Button b = (Button)sender;
            Hasil.Text = Hasil.Text + b.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (Hasil.Text == "9" || (op_pressed))
            {
                Hasil.Clear();
            }

            Button b = (Button)sender;
            Hasil.Text = Hasil.Text + b.Text;
        }

        private void btnKoma_Click(object sender, EventArgs e)
        {
            if (Hasil.Text == "," || (op_pressed))
            {
                Hasil.Clear();
            }

            Button b = (Button)sender;
            Hasil.Text = Hasil.Text + b.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                Ops = b.Text;
                value = Double.Parse(Hasil.Text);

                op_pressed = true;
            }
            catch (Exception Ex) { }
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                Ops = b.Text;
                value = Double.Parse(Hasil.Text);

                op_pressed = true;
            }
            catch (Exception Ex) { }
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                Ops = b.Text;
                value = Double.Parse(Hasil.Text);

                op_pressed = true;
            }
            catch (Exception Ex) { }
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                Ops = b.Text;
                value = Double.Parse(Hasil.Text);

                op_pressed = true;
            }
            catch (Exception Ex) { }
        }

        private void btnPersen_Click(object sender, EventArgs e)
        {
            try
            {
                Hasil.Text = (Double.Parse(Hasil.Text) * 0.01).ToString();
            }
            catch (Exception Ex) { }
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Ops)
                {
                    case "+": Hasil.Text = (value + Double.Parse(Hasil.Text)).ToString();
                        break;
                    case "-": Hasil.Text = (value - Double.Parse(Hasil.Text)).ToString();
                        break;
                    case "*": Hasil.Text = (value * Double.Parse(Hasil.Text)).ToString();
                        break;
                    case "/": Hasil.Text = (value / Double.Parse(Hasil.Text)).ToString();
                        break;
                }
            }
            catch (Exception Ex) { }
        }

        private void btnAkar_Click(object sender, EventArgs e)
        {
            try
            {
                Hasil.Text = (Math.Sqrt(Double.Parse(Hasil.Text))).ToString();
            }
            catch (Exception Ex) { }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Hasil.Clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                Hasil.Text = Hasil.Text.Remove(Hasil.Text.Length - 1, 1);
            }
            catch (Exception Ex){}
        }

        private void btn0_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
