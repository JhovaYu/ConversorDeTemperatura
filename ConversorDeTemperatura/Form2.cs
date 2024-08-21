using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeTemperatura
{
    public partial class Form2 : Form
    {
        private int enterPressCount = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void LB_Intro_Click(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                enterPressCount++; // Incrementa el contador cada vez que se presiona Enter

                switch (enterPressCount)
                {
                    case 1:
                        this.Opacity = 0.9;
                        LB_Intro.Visible = false;
                        CelsiusImg.Visible = true;
                        TB_GradosCelsisus.Visible = true;
                        Arrow1.Visible = true;
                        InfoCelsius.Visible = true;
                        break;
                    case 2:
                        CelsiusImg.Visible = false;
                        TB_GradosCelsisus.Visible = false;
                        Arrow1.Visible = false;
                        InfoCelsius.Visible = false;
                        ////////
                        FarenheitImg.Visible = true;
                        TB_GradosFarenheit.Visible = true;
                        Arrow2.BackColor = Color.Transparent; 
                        Arrow2.Visible = true;
                        LB_InfoFarenheit.Visible = true;
                        break;
                    case 3:
                        FarenheitImg.Visible = false;
                        TB_GradosFarenheit.Visible = false;
                        Arrow2.BackColor = Color.Transparent;
                        Arrow2.Visible = false;
                        LB_InfoFarenheit.Visible = false;
                        ///////
                        CleanImg.Visible= true;
                        Arrow3.Visible= true;
                        InfoClean.Visible= true;

                        break;
                    case 4:
                        CelsiusImg.Visible = false;
                        Arrow3.Visible = false;
                        InfoClean.Visible = false;
                        //////
                        this.Close();
                        break;
                    default:
                        // Código para todas las demás veces
                        MessageBox.Show("Más de tres veces presionando Enter.");
                        break;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CleanImg_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void Arrow3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LB_InfoFarenheit_Click(object sender, EventArgs e)
        {

        }
    }
}
