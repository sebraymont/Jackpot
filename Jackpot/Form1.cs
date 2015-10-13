using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jackpot
{
    public partial class Form1 : Form
    {
        public List<bet> bets = new List<bet>();
        public Label[] labels = new Label[10];
        public Label[] labels2 = new Label[10];
        public string[] lstcash = new string[10];
        public int i = 0;
        public int total = 0;
        public int subtotal1 = 0;
        public int subtotal2 = 0;
        public bool ready;
        public string percstring;
        int perc;

        public class bet
        {
            public string Name { get; set; }
            public string Cash { get; set; }
            public bet() { }
            public bet(string name, string cash)
            {
            name = Name;
            cash = Cash;
            }
        }

        public Form1()
        {

            InitializeComponent();
            for (int j = 0; j < 10; j++) { labels2[j] = new Label(); }
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ready = true;
            if (i < 10)
            {
                if (txtName.Text == "") { ready = false; MessageBox.Show("Please eneter a name"); }
                if (Int32.TryParse(txtCash.Text, out subtotal1)) { if (ready == false) { } else { ready = true; } } else { ready = false; MessageBox.Show("Please enter a number"); }
                if (ready == true)
                {
                    total = total + subtotal1;
                    lblbets.Text = "Bets: £"+ total.ToString();

                    lstcash[i] = txtCash.Text;

                    for (int j = 0; j < labels.Length; j++)
                    {
                        perc = (Int32.Parse(lstcash[j]) / total) * 100;
                        labels2[j].Text = " (" + perc.ToString() + "%)";
                        labels2[j].Location = new System.Drawing.Point(375, 50 + (j * 30));
                        this.Controls.Add(labels2[j]);
                    }

                    
                    labels[i] = new Label();
                    labels[i].AutoSize = true;
                    labels[i].Text = txtName.Text + " £" + txtCash.Text;
                    labels[i].Location = new System.Drawing.Point(315, 50 + (i * 30));
                    this.Controls.Add(labels[i]);
                    i++;
                }
            }


        }
    }
}
