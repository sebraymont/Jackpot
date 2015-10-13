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
        public Label[] labels = new Label[10];
        public Label[] labels2 = new Label[10];
        public float[] lstcash = new float[10];
        public int i = 0;
        public float total = 0;
        public float subtotal1 = 0;
        public float subtotal2 = 0;
        public bool ready;
        public string percstring;
        float perc;

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
                if (txtName.Text == "") 
                { 
                    ready = false; 
                    MessageBox.Show("Please enter a name"); 
                }
                if (float.TryParse(txtCash.Text, out subtotal1)) 
                { 
                    if (ready == false) { } else { ready = true; } 
                } 
                else { ready = false; MessageBox.Show("Please enter a number"); }
                if (ready == true)
                {
<<<<<<< HEAD
                    total = total + subtotal1;
                    lblbets.Text = "Bets: £"+ total.ToString();

                    lstcash[i] = txtCash.Text;

                    
                    labels[i] = new Label();
                    labels[i].AutoSize = true;
                    labels[i].Text = txtName.Text + " £" + txtCash.Text;
                    labels[i].Location = new System.Drawing.Point(315, 50 + (i * 30));
                    this.Controls.Add(labels[i]);



                    for (int j = 0; j < i; j++)
=======
                    total += subtotal1;
                    lblbets.Text = string.Format("Bets: £{0}", total.ToString());
                    lstcash[i] = float.Parse(txtCash.Text);
                    for (int j = 0; j < labels.Count(); j++)
>>>>>>> origin/master
                    {
                        perc = lstcash[j] / (total / 100);
                        labels2[j].Text = " (" + perc.ToString() + "%)";
                        labels2[j].Location = new System.Drawing.Point(375, 50 + (j * 30));
                        this.Controls.Add(labels2[j]);
                    }
<<<<<<< HEAD





=======
                    labels[i] = new Label();
                    labels[i].AutoSize = true;
                    labels[i].Text = txtName.Text + " £" + txtCash.Text;
                    labels[i].Location = new System.Drawing.Point(315, 50 + (i * 30));
                    this.Controls.Add(labels[i]);
>>>>>>> origin/master
                    i++;
                }
            }
        }
    }
}
