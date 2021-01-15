using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek15_WarungBuDewi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int harga(int num)
        {
            
            if (num == 0) // nasigoreng
            {
                return (10000);
            }
            else if (num == 1) // nasigoreng spesial
            {
                return (12000);
            }
            else if (num == 2) // nasigoreng pete
            {
                return (15000);
            }
            else if (num == 3) // ayambakar
            {
                return (15000);
            }

            else if (num == 4) // es teh normal
            {
                return (5000);
            }
            else if (num == 5) // es teh jumbo
            {
                return (7000);
            }
            else if (num == 6) // teh hangat normal
            {
                return (3000);
            }
            else if (num == 7) // teh hangat jumbo
            {
                return (10000);
            }
            else if (num == 8) // nutrisari normal
            {
                return (6000);
            }
            else if (num == 9) // nutrisari jumbo
            {
                return (10000);
            }
            else if (num == 10) // aqua normal
            {
                return (2000);
            }
            else if (num == 11) // aqua jumbo
            {
                return (5000);
            }
            else
            {
                return (0);
            }
            
            //int nasigoreng = 10000;
            //int nasigorengspesial = 12000;
            //int nasigorengpete = 15000;
            //int ayambakar = 15000;

            //int estehnormal = 5000;
            //int estehjumbo = 7000;
            //int tehhangatnormal = 3000;
            //int tehhangatjumbo = 5000;
            //int nutrisarinormal = 6000;
            //int nutrisarijumbo = 10000;
            //int aquanormal = 2000;
            //int aquajumbo = 5000;
        }
        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonMakanan.Checked == true)
            {
                if (comboBoxMenu.SelectedIndex == 0) // Nasi Goreng
                {
                    labelHarga.Text = Convert.ToString(harga(0));
                }
                else if (comboBoxMenu.SelectedIndex == 1) // nasigorengspesial
                {
                    labelHarga.Text = Convert.ToString(harga(1));
                }
                else if (comboBoxMenu.SelectedIndex == 2) 
                {
                    labelHarga.Text = Convert.ToString(harga(2));
                }
                else if (comboBoxMenu.SelectedIndex == 3) 
                {
                    labelHarga.Text = Convert.ToString(harga(3));
                }
            }
            else if (radioButtonMinuman.Checked == true)
            {
                if (radioButtonNormal.Checked == true)
                {
                    if (comboBoxMenu.SelectedIndex == 0)
                    {
                        labelHarga.Text = Convert.ToString(harga(4)); // es teh
                    }
                    else if (comboBoxMenu.SelectedIndex == 1)
                    {
                        labelHarga.Text = Convert.ToString(harga(6)); // teh hangat
                    }
                    else if (comboBoxMenu.SelectedIndex == 2)
                    {
                        labelHarga.Text = Convert.ToString(harga(8)); // nutrisari
                    }
                    else if (comboBoxMenu.SelectedIndex == 3)
                    {
                        labelHarga.Text = Convert.ToString(harga(10)); // aqua
                    }

                }
                else if (radioButtonJumbo.Checked == true)
                {
                    if (comboBoxMenu.SelectedIndex == 0)
                    {
                        labelHarga.Text = Convert.ToString(harga(5)); // es teh
                    }
                    else if (comboBoxMenu.SelectedIndex == 1)
                    {
                        labelHarga.Text = Convert.ToString(harga(7)); // teh hangat
                    }
                    else if (comboBoxMenu.SelectedIndex == 2)
                    {
                        labelHarga.Text = Convert.ToString(harga(9)); // nutrisari
                    }
                    else if (comboBoxMenu.SelectedIndex == 3)
                    {
                        labelHarga.Text = Convert.ToString(harga(11)); // aqua
                    }
                }
                else
                {
                    labelHarga.Text = "0";
                }
            }
            
        }

        private void radioButtonMakanan_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMenu.Items.Clear();
            comboBoxMenu.Text = "";
            labelHarga.Text = "0";
            comboBoxMenu.Items.Add("Nasi Goreng");
            comboBoxMenu.Items.Add("Nasi Goreng Spesial");
            comboBoxMenu.Items.Add("Nasi Goreng Pete");
            comboBoxMenu.Items.Add("Ayam Bakar");

            labelSize.Visible = false;
            radioButtonNormal.Visible = false;
            radioButtonJumbo.Visible = false;
        }

        private void radioButtonMinuman_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMenu.Items.Clear();
            comboBoxMenu.Text = "";
            labelHarga.Text = "0";
            comboBoxMenu.Items.Add("Es Teh");
            comboBoxMenu.Items.Add("Teh Hangat");
            comboBoxMenu.Items.Add("NutriSari");
            comboBoxMenu.Items.Add("Aqua");

            labelSize.Visible = true;
            radioButtonNormal.Visible = true;
            radioButtonJumbo.Visible = true;
        }

        public void labelHarga_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButtonNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMinuman.Checked == true)
            {
                if (radioButtonNormal.Checked == true)
                {
                    if (comboBoxMenu.SelectedIndex == 0)
                    {
                        labelHarga.Text = Convert.ToString(harga(4)); // es teh
                    }
                    else if (comboBoxMenu.SelectedIndex == 1)
                    {
                        labelHarga.Text = Convert.ToString(harga(6)); // teh hangat
                    }
                    else if (comboBoxMenu.SelectedIndex == 2)
                    {
                        labelHarga.Text = Convert.ToString(harga(8)); // nutrisari
                    }
                    else if (comboBoxMenu.SelectedIndex == 3)
                    {
                        labelHarga.Text = Convert.ToString(harga(10)); // aqua
                    }

                }
                else if (radioButtonJumbo.Checked == true)
                {
                    if (comboBoxMenu.SelectedIndex == 0)
                    {
                        labelHarga.Text = Convert.ToString(harga(5)); // es teh
                    }
                    else if (comboBoxMenu.SelectedIndex == 1)
                    {
                        labelHarga.Text = Convert.ToString(harga(7)); // teh hangat
                    }
                    else if (comboBoxMenu.SelectedIndex == 2)
                    {
                        labelHarga.Text = Convert.ToString(harga(9)); // nutrisari
                    }
                    else if (comboBoxMenu.SelectedIndex == 3)
                    {
                        labelHarga.Text = Convert.ToString(harga(11)); // aqua
                    }
                }
                else
                {
                    labelHarga.Text = "0";
                }
            }
        }

        private void radioButtonJumbo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMinuman.Checked == true)
            {
                if (radioButtonNormal.Checked == true)
                {
                    if (comboBoxMenu.SelectedIndex == 0)
                    {
                        labelHarga.Text = Convert.ToString(harga(4)); // es teh
                    }
                    else if (comboBoxMenu.SelectedIndex == 1)
                    {
                        labelHarga.Text = Convert.ToString(harga(6)); // teh hangat
                    }
                    else if (comboBoxMenu.SelectedIndex == 2)
                    {
                        labelHarga.Text = Convert.ToString(harga(8)); // nutrisari
                    }
                    else if (comboBoxMenu.SelectedIndex == 3)
                    {
                        labelHarga.Text = Convert.ToString(harga(10)); // aqua
                    }

                }
                else if (radioButtonJumbo.Checked == true)
                {
                    if (comboBoxMenu.SelectedIndex == 0)
                    {
                        labelHarga.Text = Convert.ToString(harga(5)); // es teh
                    }
                    else if (comboBoxMenu.SelectedIndex == 1)
                    {
                        labelHarga.Text = Convert.ToString(harga(7)); // teh hangat
                    }
                    else if (comboBoxMenu.SelectedIndex == 2)
                    {
                        labelHarga.Text = Convert.ToString(harga(9)); // nutrisari
                    }
                    else if (comboBoxMenu.SelectedIndex == 3)
                    {
                        labelHarga.Text = Convert.ToString(harga(11)); // aqua
                    }
                }
                else
                {
                    labelHarga.Text = "0";
                }
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (comboBoxMenu.SelectedItem == null || labelHarga.Text == "0")
            {
                MessageBox.Show("Pilih Menu dengan benarrrrr");
            }
            else
            {
                listBoxNamaItems.Items.Add(comboBoxMenu.SelectedItem);
                listBoxHargaItems.Items.Add(labelHarga.Text);
            }

            if (listBoxNamaItems.Items == null)
            {
                buttonDelete.Enabled = false;
            }
            else
            {
                buttonDelete.Enabled = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxNamaItems.Items.Count == 0)
            {
                buttonDelete.Enabled = false;
            }
            else
            {
                buttonDelete.Enabled = true;
                listBoxNamaItems.Items.Remove(listBoxNamaItems.SelectedItem);
                listBoxNamaItems.Items.Remove(listBoxHargaItems.SelectedItem);
            }


        }

        private void listBoxNamaItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            if (listBoxNamaItems.Items.Count == 0)
            {
                MessageBox.Show("Pilih menuuu!!");
            }
            else if (listBoxNamaItems.Items != null)
            {
                var Form2 = new Form2();
                Form2.ShowDialog();
            }
        }

        private void listBoxHargaItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
