using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noorani_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Clock c1 = new Clock();
        Clock c2 = new Clock();
        Clock c3 = new Clock();

        private void button1_Click(object sender, EventArgs e)
        {
            Clock C1 = new Clock(int.Parse(txtFirstHour.Text), int.Parse(txtFirstMinutes.Text),
                int.Parse(txtFirstSecond.Text), FirstChbx.Checked);
            Clock C2 = new Clock(int.Parse(txtSecondHour.Text), int.Parse(txtSecondMinutes.Text),
                int.Parse(txtSecondSecond.Text),SecondChbx.Checked);
            
            c1 = C1;
            c2 = C2;

            Clock C3 = c1 + c2;
            C3.AmPM_Enabled = ThridChbx.Checked;
            txtThridHour.Text = C3.Hour.ToString();
            txtThridMinutes.Text = C3.Minute.ToString();
            txtThridSecond.Text = C3.Second.ToString();
            c3 = C3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clock C1 = new Clock(int.Parse(txtFirstHour.Text), int.Parse(txtFirstMinutes.Text),
                int.Parse(txtFirstSecond.Text), FirstChbx.Checked);
            Clock C2 = new Clock(int.Parse(txtSecondHour.Text), int.Parse(txtSecondMinutes.Text),
                int.Parse(txtSecondSecond.Text), SecondChbx.Checked);
            c1 = C1;
            c2 = C2;

            Clock C3 = c1 - c2;
            txtThridHour.Text = C3.Hour.ToString();
            txtThridMinutes.Text = C3.Minute.ToString();
            txtThridSecond.Text = C3.Second.ToString();
            c3 = C3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string MyClock = string.Empty;
            
                if (FirstChbxLS.Checked)
                {
                    MyClock = Clock.GetLongTime(c1);
                    if (FirstChbx.Checked)
                    {
                        lblFirstAM.Text = MyClock.Split(':')[2].Split(' ')[1];
                    }
                    else
                        lblFirstAM.Text = string.Empty;

                    txtFirstHour.Text = MyClock.Split(':')[0];
                    txtFirstMinutes.Text = MyClock.Split(':')[1];
                    txtFirstSecond.Text = MyClock.Split(':')[2].Split(' ')[0];
                }
                if (SecondChbxLS.Checked)
                {
                    MyClock = Clock.GetLongTime(c2);
                    if (SecondChbx.Checked)
                    {
                        lblSecondAM.Text = MyClock.Split(':')[2].Split(' ')[1];
                    }
                    else
                        lblSecondAM.Text = string.Empty;

                    txtSecondHour.Text = MyClock.Split(':')[0];
                    txtSecondMinutes.Text = MyClock.Split(':')[1];
                    txtSecondSecond.Text = MyClock.Split(':')[2].Split(' ')[0];
                }
                if (ThridChbxLS.Checked)
                {
                    MyClock = Clock.GetLongTime(c3);
                    if (ThridChbx.Checked)
                    {
                        lblThridAM.Text = MyClock.Split(':')[2].Split(' ')[1];
                    }
                    else
                        lblThridAM.Text = string.Empty;

                    txtThridHour.Text = MyClock.Split(':')[0];
                    txtThridMinutes.Text = MyClock.Split(':')[1];
                    txtThridSecond.Text = MyClock.Split(':')[2].Split(' ')[0];
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string MyClock = string.Empty;
            
            try
            {
                if (FirstChbxLS.Checked)
                {
                    MyClock = Clock.GetShortTime(c1);
                    if (FirstChbx.Checked)
                    {
                        lblFirstAM.Text = MyClock.Split(':')[1].Split(' ')[1];
                    }
                    else
                        lblFirstAM.Text = string.Empty;
                    txtFirstHour.Text = MyClock.Split(':')[0];
                    txtFirstMinutes.Text = MyClock.Split(':')[1].Split(' ')[0];
                    txtFirstSecond.Text = string.Empty;
                }
                if (SecondChbxLS.Checked)
                {
                    MyClock = Clock.GetShortTime(c2);
                    if (SecondChbx.Checked)
                    {
                        lblSecondAM.Text = MyClock.Split(':')[1].Split(' ')[1];
                    }
                    else
                        lblSecondAM.Text = string.Empty;
                    txtSecondHour.Text = MyClock.Split(':')[0];
                    txtSecondMinutes.Text = MyClock.Split(':')[1].Split(' ')[0];
                    txtSecondSecond.Text = string.Empty;
                }
                if (ThridChbxLS.Checked)
                {
                    MyClock = Clock.GetShortTime(c3);
                    if (ThridChbx.Checked)
                    {
                        lblThridAM.Text = MyClock.Split(':')[1].Split(' ')[1];
                    }
                    else
                        lblThridAM.Text = string.Empty;
                    txtThridHour.Text = MyClock.Split(':')[0];
                    txtThridMinutes.Text = MyClock.Split(':')[1].Split(' ')[0];
                    txtThridSecond.Text = string.Empty;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("make sure your Clocks Valid !!\r\n(Thrid clock must be fill)", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }
    
        private void FirstChbx_CheckedChanged(object sender, EventArgs e)
        {
            c1.AmPM_Enabled = FirstChbx.Checked;
        }

        private void SecondChbx_CheckedChanged(object sender, EventArgs e)
        {
            c2.AmPM_Enabled = SecondChbx.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            c3.AmPM_Enabled = ThridChbx.Checked;
        }

        Computting co1 = new Computting();
        Computting co2 = new Computting();
        Computting co3 = new Computting();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtHour.Text == string.Empty)
            {
                txtHour.Text = "0";
                txtHour.Select(0,1);
            }
            co1.Hour = int.Parse(txtHour.Text);

            txtHourH.Text = co1.Hour.ToString();
            txtHourM.Text = co1.Minutes.ToString();
            txtHourS.Text = co1.Second.ToString();

        }

        private void txtMinutes_TextChanged(object sender, EventArgs e)
        {
            if (txtMinutes.Text == string.Empty)
            {
                txtMinutes.Text = "0";
                txtMinutes.Select(0,1);
            }
            co2.Minutes = int.Parse(txtMinutes.Text);

            txtMinutesH.Text = co2.Hour.ToString();
            txtMinutesM.Text = co2.Minutes.ToString();
            txtMinutesS.Text = co2.Second.ToString();

        }

        private void txtSecond_TextChanged(object sender, EventArgs e)
        {
            if (txtSecond.Text == string.Empty)
            {
                txtSecond.Text = "0";
                txtSecond.Select(0, 1);
            }
            co3.Second = int.Parse(txtSecond.Text);

            txtSecondH.Text = co3.Hour.ToString();
            txtSecondM.Text = co3.Minutes.ToString();
            txtSecondS.Text = co3.Second.ToString();

        }
    }
}
