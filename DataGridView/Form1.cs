using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ave, ave1;
            string txt1,txt2,txt3,txt4,txt5,txt6,ERROR="";
            int cal1, cal2, cal3;

            txt1 = textBox1.Text;
            txt2 = textBox2.Text;
            txt3 =textBox3.Text;
            txt4= textBox4.Text;
            txt5= textBox5.Text;
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;




            if (string.IsNullOrWhiteSpace(txt1))
            {
                ERROR += " NO PUEDES DEJAR VACIO EL CAMPO NAME";
                textBox1.BackColor = Color.DarkRed;

            }



            if (string.IsNullOrWhiteSpace(txt2))
            {
                ERROR += " NO PUEDES DEJAR VACIO EL CAMPO LAST NAME";
                textBox2.BackColor = Color.DarkRed;

            }
            if (string.IsNullOrWhiteSpace(txt3))
            {
                ERROR += " NO PUEDES DEJAR VACIO EL CAMPO U1";
                textBox3.BackColor = Color.DarkRed;

            }
            if (string.IsNullOrWhiteSpace(txt4))
            {
                ERROR += " NO PUEDES DEJAR VACIO EL CAMPO U2";
                textBox4.BackColor = Color.DarkRed;

            }
            if (string.IsNullOrWhiteSpace(txt5))
            {
                ERROR += " NO PUEDES DEJAR VACIO EL CAMPO U3";
                textBox5.BackColor = Color.DarkRed;

            }

            if (ERROR != "")
            {
                MessageBox.Show(ERROR, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



           if(Convert.ToInt32(txt3)>100 || (Convert.ToInt32(txt3))<0){


               ERROR += " SOLO PUEDES INTRODUCIR VALORES ENTRE 0 Y 100";
               textBox3.BackColor = Color.DarkRed;
           }
           if (Convert.ToInt32(txt4) > 100 || (Convert.ToInt32(txt4)) < 0)
           {


               ERROR += " SOLO PUEDES INTRODUCIR VALORES ENTRE 0 Y 100";
               textBox4.BackColor = Color.DarkRed;
           }

           if (Convert.ToInt32(txt5) > 100 || (Convert.ToInt32(txt5)) < 0)
           {


               ERROR += " SOLO PUEDES INTRODUCIR VALORES ENTRE 0 Y 100";
               textBox5.BackColor = Color.DarkRed;
           }

           if (ERROR != "")
           {
               MessageBox.Show(ERROR, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
           }




            ave = (Convert.ToDouble(txt3) + Convert.ToDouble(txt4) + Convert.ToDouble(txt5)) / 3;
            txt6 = ave.ToString();
            //AGREGAR RENGLONES AL DATAGRIDVIEW
            DG1.Rows.Add(txt1, txt2,txt3,txt4,txt5,txt6);


            int totalu = 0;
            double prom = 0;
           double prom2 = 0;
            foreach (DataGridViewRow row1 in DG1.Rows)
            {
                totalu++;
      
                    cal1 = Convert.ToInt32(DG1[2, row1.Index].Value);
                    cal2 = Convert.ToInt32(DG1[3, row1.Index].Value);
                    cal3 = Convert.ToInt32(DG1[4, row1.Index].Value);
                   ave1 = Convert.ToDouble(DG1[5, row1.Index].Value);
                   prom2 = ave1;
                    if (cal1 < 80)
                    {
                        DG1[2, row1.Index].Style.BackColor = Color.Red;
                    }

                    if (cal2 < 80)
                    {
                        DG1[3, row1.Index].Style.BackColor = Color.Red;
                    }
                    if (cal3 < 80)
                    {
                        DG1[4, row1.Index].Style.BackColor = Color.Red;
                    }
                    if (ave1 < 80)
                    {
                        DG1[5, row1.Index].Style.BackColor = Color.Red;
                    }



                    prom += prom2 / totalu;
            }
      
            label7.Text = Convert.ToString(prom);
            }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Back);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Back);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
