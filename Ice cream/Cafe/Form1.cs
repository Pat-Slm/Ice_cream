using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LBORDER_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        double PR1, PR2, PR3, ORDER1, ORDER2, ORDER3, TB1, TB2, TB3, TB4, TB5, TB6, TB7, TB8, TB9, TB10, NUM1, NUM2, NUM3;
        string TTP1, TTP2, TTP3, TTP4, TTP5, TTP6, TTP7, TTP8, TTP9, TTP10;
        private void CBMENU_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(CBMENU1.SelectedIndex.ToString());
            switch (id)
            {
                case 0:
                    PR1 = 5;
                    break;
                case 1:
                    PR1 = 5;
                    break;
                case 2:
                    PR1 = 5;
                    break;
                case 3:
                    PR1 = 5;
                    break;
                case 4:
                    PR1 = 5;
                    break;
                case 5:
                    PR1 = 5;
                    break;
                case 6:
                    PR1 = 5;
                    break;
                case 7:
                    PR1 = 5;
                    break;
                case 8:
                    PR1 = 5;
                    break;
                case 9:
                    PR1 = 5;
                    break;
                case 10:
                    PR1 = 5;
                    break;
                case 11:
                    PR1 = 5;
                    break;
                case 12:
                    PR1 = 5;
                    break;
                case 13:
                    PR1 = 5;
                    break;
                case 14:
                    PR1 = 5;
                    break;
                default:
                    PR1 = 0;
                    break;
            }
            CALSUM();
        }

        private void CBTP1_CheckedChanged(object sender, EventArgs e)
        {
            if (CBTP1.Checked == true)
            {
                TB1 = 25;
                TTP1 = CBTP1.Text;
            }
            else
            {
                TB1 = 0;
                TTP1 = "";
            }
            CALSUM();
        }

        private void CBTP4_CheckedChanged(object sender, EventArgs e)
        {
            if (CBTP4.Checked == true)
            {
                TB4 = 12;
                TTP4 = CBTP4.Text;
            }
            else
            {
                TB4 = 0;
                TTP4 = "";
            }
            CALSUM();
        }

        private void CBTP2_CheckedChanged(object sender, EventArgs e)
        {
            if (CBTP2.Checked == true)
            {
                TB2 = 10;
                TTP2 = CBTP2.Text;
            }
            else
            {
                TB2 = 0;
                TTP2 = "";
            }
            CALSUM();
        }

        private void CBTP3_CheckedChanged(object sender, EventArgs e)
        {
            if (CBTP3.Checked == true)
            {
                TB3 = 5;
                TTP3 = CBTP3.Text;
            }
            else
            {
                TB3 = 0;
                TTP3 = "";
            }
            CALSUM();
        }
        private void CALSUM()
        {
            double PRALL;         
            PRALL = ORDER1 + ORDER2 + ORDER3 + TB1 + TB2 + TB3 + TB4 + TB5 + TB6 + TB7 + TB8 + TB9 + TB10;          
            LBPR.Text = PRALL.ToString();
        }
        private void CL()
        {
            CBMENU1.Text = "";
            CBMENU2.Text = "";
            CBMENU3.Text = "";
            CBNUM1.Text = "";
            CBNUM2.Text = "";
            CBNUM3.Text = "";
            CBTP1.Checked = false;
            CBTP2.Checked = false;
            CBTP3.Checked = false;
            CBTP4.Checked = false;
            CBTP5.Checked = false;
            CBTP6.Checked = false;
            CBTP7.Checked = false;
            CBTP8.Checked = false;
            CBTP9.Checked = false;
            CBTP10.Checked = false;
            LBPR.Text = "0";
        }
        private void BTF_Click(object sender, EventArgs e)
        {
            LBORDER.Items.Add(CBMENU1.Text.ToString() + CBNUM1.Text.ToString() + " " + CBMENU2.Text.ToString() + CBNUM2.Text.ToString() + " " + CBMENU3.Text.ToString() + CBNUM3.Text.ToString() + " "
                + TTP1 + TTP2 + TTP3 + TTP4 + TTP5 + TTP6 + TTP7 + TTP8 + TTP9 + TTP10 +" "+"ราคารวม"+" "+ LBPR.Text+" "+"บาท");
            CL();
        }

        private void RBST4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBST3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BTDL_Click(object sender, EventArgs e)
        {
            if (LBORDER.SelectedIndex != -1)
            {
                LBORDER.Items.RemoveAt(LBORDER.SelectedIndex);
            }
        }

        private void BTCC_Click(object sender, EventArgs e)
        {
            LBORDER.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CBMENU1.Text = " ";
            CBMENU2.Text = " ";
            CBMENU3.Text = " ";
            CBNUM1.Text = "";
            CBNUM2.Text = "";
            CBNUM3.Text = "";
                
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (CBTP1.Checked == true)
            {
                TB10 = 16;
                TTP10 = CBTP10.Text;
            }
            else
            {
                TB10 = 0;
                TTP10 = "";
            }
            CALSUM();
        }

        private void CBTP5_CheckedChanged(object sender, EventArgs e)
        {
            if (CBTP5.Checked == true)
            {
                TB5 = 15;
                TTP5 = CBTP5.Text;
            }
            else
            {
                TB5 = 0;
                TTP5 = "";
            }
            CALSUM();
        }

        private void CBTP6_CheckedChanged(object sender, EventArgs e)
        {
            if (CBTP6.Checked == true)
            {
                TB6 = 20;
                TTP6 = CBTP6.Text;
            }
            else
            {
                TB6 = 0;
                TTP6 = "";
            }
            CALSUM();
        }

        private void CBTP7_CheckedChanged(object sender, EventArgs e)
        {
            if (CBTP7.Checked == true)
            {
                TB7 = 2;
                TTP7 = CBTP7.Text;
            }
            else
            {
                TB7 = 0;
                TTP7 = "";
            }
            CALSUM();
        }

        private void CBTP8_CheckedChanged(object sender, EventArgs e)
        {
            if (CBTP8.Checked == true)
            {
                TB8 = 14;
                TTP8 = CBTP8.Text;
            }
            else
            {
                TB8 = 0;
                TTP8 = "";
            }
            CALSUM();
        }

        private void CBTP9_CheckedChanged(object sender, EventArgs e)
        {
            if (CBTP1.Checked == true)
            {
                TB9 = 8;
                TTP9 = CBTP9.Text;
            }
            else
            {
                TB9 = 0;
                TTP9 = "";
            }
            CALSUM();
        }

        private void CBMENU2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(CBMENU2.SelectedIndex.ToString());
            switch (id)
            {
                case 0:
                    PR2 = 5;
                    break;
                case 1:
                    PR2 = 5;
                    break;
                case 2:
                    PR2 = 5;
                    break;
                case 3:
                    PR2 = 5;
                    break;
                case 4:
                    PR2 = 5;
                    break;
                case 5:
                    PR2 = 5;
                    break;
                case 6:
                    PR2 = 5;
                    break;
                case 7:
                    PR2 = 5;
                    break;
                case 8:
                    PR2 = 5;
                    break;
                case 9:
                    PR2 = 5;
                    break;
                case 10:
                    PR2 = 5;
                    break;
                case 11:
                    PR2 = 5;
                    break;
                case 12:
                    PR2 = 5;
                    break;
                case 13:
                    PR1 = 5;
                    break;
                case 14:
                    PR2 = 5;
                    break;
                default:
                    PR2 = 0;
                    break;
            }
            CALSUM();
        }

        private void CBMENU3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(CBMENU3.SelectedIndex.ToString());
            switch (id)
            {
                case 0:
                    PR3 = 5;
                    break;
                case 1:
                    PR3 = 5;
                    break;
                case 2:
                    PR3 = 5;
                    break;
                case 3:
                    PR3 = 5;
                    break;
                case 4:
                    PR3 = 5;
                    break;
                case 5:
                    PR3 = 5;
                    break;
                case 6:
                    PR3 = 5;
                    break;
                case 7:
                    PR3 = 5;
                    break;
                case 8:
                    PR3 = 5;
                    break;
                case 9:
                    PR3 = 5;
                    break;
                case 10:
                    PR1 = 5;
                    break;
                case 11:
                    PR3 = 5;
                    break;
                case 12:
                    PR3 = 5;
                    break;
                case 13:
                    PR3 = 5;
                    break;
                case 14:
                    PR3 = 5;
                    break;
                default:
                    PR3 = 0;
                    break;
            }          
            CALSUM();
        }

        private void CBNUM1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(CBNUM1.SelectedIndex.ToString());
            switch (id)
            {
                case 0:
                    NUM1 = 1;
                    break;
                case 1:
                    NUM1 = 2;
                    break;
                case 2:
                    NUM1 = 3;
                    break;
                case 3:
                    NUM1 = 4;
                    break;
                case 4:
                    NUM1 = 5;
                    break;
                default:
                    NUM1 = 0;
                    break;
            }
            ORDER1 = PR1 * NUM1;
            CALSUM();
        }

        private void CBNUM2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(CBNUM2.SelectedIndex.ToString());
            switch (id)
            {
                case 0:
                    NUM2 = 1;
                    break;
                case 1:
                    NUM2 = 2;
                    break;
                case 2:
                    NUM2 = 3;
                    break;
                case 3:
                    NUM2 = 4;
                    break;
                case 4:
                    NUM2 = 5;
                    break;
                default:
                    NUM2 = 0;
                    break;
            }

            ORDER2 = PR2 * NUM2;
            CALSUM();
        }

        private void CBNUM3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(CBNUM3.SelectedIndex.ToString());
            switch (id)
            {
                case 0:
                    NUM3 = 1;
                    break;
                case 1:
                    NUM3 = 2;
                    break;
                case 2:
                    NUM3 = 3;
                    break;
                case 3:
                    NUM3 = 4;
                    break;
                case 4:
                    NUM3 = 5;
                    break;
                default:
                    NUM3 = 0;
                    break;
            }

            ORDER3 = PR3 * NUM3;
            CALSUM();
        }
    }
}