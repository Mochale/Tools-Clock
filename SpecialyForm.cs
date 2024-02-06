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
    public partial class SpecialyForm : Form
    {
        public SpecialyForm()
        {
            InitializeComponent();
        }

        private void TextLeave(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            if (text.Text == "")
            {
                text.Text = "0";
            }
        }

        private void TextBoxEnter(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;

            text.SelectAll();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Clock C1 = new Clock(int.Parse(txtFirstH.Text), int.Parse(txtFirstM.Text),
                0, false);
            Clock C2 = new Clock(int.Parse(txtSecoundH.Text), int.Parse(txtSecoundM.Text),
                0, false);

            Clock C3 = C1 + C2;
            txtResultH.Text = C3.Hour.ToString();
            txtResultM.Text = C3.Minute.ToString();

            reset_focus();
        }

        private void reset_focus()
        {
            txtFirstH.Focus();
        }

        private void btnMinues_Click(object sender, EventArgs e)
        {
            Clock C1 = new Clock(int.Parse(txtFirstH.Text), int.Parse(txtFirstM.Text),
                0, false);
            Clock C2 = new Clock(int.Parse(txtSecoundH.Text), int.Parse(txtSecoundM.Text),
                0, false);

            Clock C3 = C1 - C2;
            txtResultH.Text = C3.Hour.ToString();
            txtResultM.Text = C3.Minute.ToString();

            reset_focus();
        }

        private void btnCache_Click(object sender, EventArgs e)
        {
            string result = $"{int.Parse(txtResultH.Text).ToString("00")}:{int.Parse(txtResultM.Text).ToString("00")}";
            if (result.Length == 5 && result != "00:00")
            {
                lstCache.Items.Add(result);
            }
            txtResultH.Text = txtResultM.Text = "0";
        }

        private void btnMoveToList_Click(object sender, EventArgs e)
        {
            string result = $"{int.Parse(txtResultH.Text).ToString("00")}:{int.Parse(txtResultM.Text).ToString("00")}";
            if (result.Length == 5 && result != "00:00")
            {
                lstTimesList.Items.Add(result);
            }
            txtResultH.Text = txtResultM.Text = "0";
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            lstTimesList.Items.Clear();
        }

        private void btnClearCache_Click(object sender, EventArgs e)
        {
            lstCache.Items.Clear();
        }

        private void btnCalculateList_Click(object sender, EventArgs e)
        {
            Clock result = new Clock();
            foreach (var item in lstTimesList.Items)
            {
                int hour = int.Parse(item.ToString().Split(':')[0]);
                int minute = int.Parse(item.ToString().Split(':')[1]);
                Clock holder = new Clock(hour, minute,0,false);

                result += holder;
            }

            txtResultH.Text = result.Hour.ToString();
            txtResultM.Text = result.Minute.ToString();
        }

        private void btnCalculateCache_Click(object sender, EventArgs e)
        {
            Clock result = new Clock();
            foreach (var item in lstCache.Items)
            {
                int hour = int.Parse(item.ToString().Split(':')[0]);
                int minute = int.Parse(item.ToString().Split(':')[1]);
                Clock holder = new Clock(hour, minute, 0, false);

                result += holder;
            }

            txtResultH.Text = result.Hour.ToString();
            txtResultM.Text = result.Minute.ToString();
        }
    }
}
