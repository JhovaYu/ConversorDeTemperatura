using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConversorDeTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            Form2 popup = new Form2();
            popup.Show();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

   

     

        private void TB_GradosCelsisus_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                float Celsius = float.Parse(TB_GradosCelsisus.Text);
                float Farenheit = (Celsius * 9f / 5f) + 32;
                TB_GradosFarenheit.Text = Farenheit.ToString();
            }
        }

        private void TB_GradosFarenheit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                float Farenheit = float.Parse(TB_GradosFarenheit.Text);
                float Celsius = (Farenheit * 9f / 5f) + 32;
                TB_GradosCelsisus.Text = Celsius.ToString();
            }
        }

        private void TB_GradosCelsisus_Enter(object sender, EventArgs e)
        {
            TB_GradosCelsisus.Text = "";
        }

        private void TB_GradosFarenheit_Enter(object sender, EventArgs e)
        {
            TB_GradosFarenheit.Text = "";
        }

        private void TB_GradosCelsisus_Leave_1(object sender, EventArgs e)
        {
            if (TB_GradosCelsisus.Text == "")
            {
                TB_GradosCelsisus.Text = "Ingrese Grados Celsius";
            }
        }

        private void TB_GradosFarenheit_Leave_1(object sender, EventArgs e)
        {
            if (TB_GradosFarenheit.Text == "")
            {
                TB_GradosFarenheit.Text = "Ingrese Grados Farenheit";
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TB_GradosFarenheit.Text = "Ingrese grados Celsius"; 
            TB_GradosCelsisus.Text = "Ingrese grados Farenheit";
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            LB_CleanInfo.Visible = true;
        }

        private void LB_CleanInfo_MouseLeave(object sender, EventArgs e)
        {
            LB_CleanInfo.Visible = false;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            LB_CleanInfo.Visible = false;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            LB_CleanInfo.Visible = true;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.ActiveControl = CleanImg;
        }

       
    }
}
