namespace ConversorDeTemperatura
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.LB_Intro = new System.Windows.Forms.Label();
            this.PRESS_TO_CONTINUOS = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CelsiusImg = new System.Windows.Forms.PictureBox();
            this.TB_GradosCelsisus = new System.Windows.Forms.TextBox();
            this.Arrow1 = new System.Windows.Forms.PictureBox();
            this.InfoCelsius = new System.Windows.Forms.Label();
            this.FarenheitImg = new System.Windows.Forms.PictureBox();
            this.TB_GradosFarenheit = new System.Windows.Forms.TextBox();
            this.Arrow2 = new System.Windows.Forms.PictureBox();
            this.LB_InfoFarenheit = new System.Windows.Forms.Label();
            this.CleanImg = new System.Windows.Forms.PictureBox();
            this.Arrow3 = new System.Windows.Forms.PictureBox();
            this.InfoClean = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CelsiusImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FarenheitImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CleanImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Intro
            // 
            this.LB_Intro.AutoSize = true;
            this.LB_Intro.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Intro.ForeColor = System.Drawing.Color.Lavender;
            this.LB_Intro.Location = new System.Drawing.Point(236, 20);
            this.LB_Intro.Name = "LB_Intro";
            this.LB_Intro.Size = new System.Drawing.Size(605, 35);
            this.LB_Intro.TabIndex = 0;
            this.LB_Intro.Text = "BIENVENIDO AL CONVERSOR DE TEMPERATURA";
            this.LB_Intro.Click += new System.EventHandler(this.LB_Intro_Click);
            // 
            // PRESS_TO_CONTINUOS
            // 
            this.PRESS_TO_CONTINUOS.AutoSize = true;
            this.PRESS_TO_CONTINUOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRESS_TO_CONTINUOS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PRESS_TO_CONTINUOS.Location = new System.Drawing.Point(368, 298);
            this.PRESS_TO_CONTINUOS.Name = "PRESS_TO_CONTINUOS";
            this.PRESS_TO_CONTINUOS.Size = new System.Drawing.Size(235, 15);
            this.PRESS_TO_CONTINUOS.TabIndex = 1;
            this.PRESS_TO_CONTINUOS.Text = "PRESIONA [ESPACIO] PARA CONTINUAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1195, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 99);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CelsiusImg
            // 
            this.CelsiusImg.BackColor = System.Drawing.Color.Transparent;
            this.CelsiusImg.Image = ((System.Drawing.Image)(resources.GetObject("CelsiusImg.Image")));
            this.CelsiusImg.Location = new System.Drawing.Point(202, 133);
            this.CelsiusImg.Name = "CelsiusImg";
            this.CelsiusImg.Size = new System.Drawing.Size(125, 79);
            this.CelsiusImg.TabIndex = 9;
            this.CelsiusImg.TabStop = false;
            this.CelsiusImg.Visible = false;
            // 
            // TB_GradosCelsisus
            // 
            this.TB_GradosCelsisus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_GradosCelsisus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_GradosCelsisus.Enabled = false;
            this.TB_GradosCelsisus.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_GradosCelsisus.Location = new System.Drawing.Point(60, 219);
            this.TB_GradosCelsisus.Margin = new System.Windows.Forms.Padding(4);
            this.TB_GradosCelsisus.Name = "TB_GradosCelsisus";
            this.TB_GradosCelsisus.Size = new System.Drawing.Size(363, 29);
            this.TB_GradosCelsisus.TabIndex = 10;
            this.TB_GradosCelsisus.Text = "Ingrese el valor de Grados Celsius";
            this.TB_GradosCelsisus.Visible = false;
            // 
            // Arrow1
            // 
            this.Arrow1.Enabled = false;
            this.Arrow1.Image = ((System.Drawing.Image)(resources.GetObject("Arrow1.Image")));
            this.Arrow1.Location = new System.Drawing.Point(430, 168);
            this.Arrow1.Name = "Arrow1";
            this.Arrow1.Size = new System.Drawing.Size(85, 89);
            this.Arrow1.TabIndex = 11;
            this.Arrow1.TabStop = false;
            this.Arrow1.Visible = false;
            // 
            // InfoCelsius
            // 
            this.InfoCelsius.AutoSize = true;
            this.InfoCelsius.BackColor = System.Drawing.Color.Transparent;
            this.InfoCelsius.ForeColor = System.Drawing.SystemColors.Control;
            this.InfoCelsius.Location = new System.Drawing.Point(355, 119);
            this.InfoCelsius.Name = "InfoCelsius";
            this.InfoCelsius.Size = new System.Drawing.Size(248, 64);
            this.InfoCelsius.TabIndex = 12;
            this.InfoCelsius.Text = "Aqui puedes ingresar el valor de los \r\ngrados celsius y al presionar la \r\ntecla [" +
    "ENTER] te dara automaticamente \r\nel resultado";
            this.InfoCelsius.Visible = false;
            // 
            // FarenheitImg
            // 
            this.FarenheitImg.Image = ((System.Drawing.Image)(resources.GetObject("FarenheitImg.Image")));
            this.FarenheitImg.Location = new System.Drawing.Point(716, 133);
            this.FarenheitImg.Margin = new System.Windows.Forms.Padding(4);
            this.FarenheitImg.Name = "FarenheitImg";
            this.FarenheitImg.Size = new System.Drawing.Size(125, 79);
            this.FarenheitImg.TabIndex = 13;
            this.FarenheitImg.TabStop = false;
            this.FarenheitImg.Visible = false;
            // 
            // TB_GradosFarenheit
            // 
            this.TB_GradosFarenheit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_GradosFarenheit.Enabled = false;
            this.TB_GradosFarenheit.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_GradosFarenheit.Location = new System.Drawing.Point(565, 219);
            this.TB_GradosFarenheit.Margin = new System.Windows.Forms.Padding(4);
            this.TB_GradosFarenheit.Name = "TB_GradosFarenheit";
            this.TB_GradosFarenheit.Size = new System.Drawing.Size(383, 29);
            this.TB_GradosFarenheit.TabIndex = 14;
            this.TB_GradosFarenheit.Text = "Ingrese el valor de Grados Farenheit";
            this.TB_GradosFarenheit.Visible = false;
            // 
            // Arrow2
            // 
            this.Arrow2.Image = ((System.Drawing.Image)(resources.GetObject("Arrow2.Image")));
            this.Arrow2.Location = new System.Drawing.Point(475, 165);
            this.Arrow2.Name = "Arrow2";
            this.Arrow2.Size = new System.Drawing.Size(83, 92);
            this.Arrow2.TabIndex = 15;
            this.Arrow2.TabStop = false;
            this.Arrow2.Visible = false;
            // 
            // LB_InfoFarenheit
            // 
            this.LB_InfoFarenheit.AutoSize = true;
            this.LB_InfoFarenheit.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_InfoFarenheit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_InfoFarenheit.Location = new System.Drawing.Point(391, 108);
            this.LB_InfoFarenheit.Name = "LB_InfoFarenheit";
            this.LB_InfoFarenheit.Size = new System.Drawing.Size(287, 54);
            this.LB_InfoFarenheit.TabIndex = 16;
            this.LB_InfoFarenheit.Text = "Aqui puedes ingresar el valor de los grados \r\nFarenheit y al igual que el anterio" +
    "r, al presionar\r\n [ENTER] se mostrara en grados Celsius";
            this.LB_InfoFarenheit.Visible = false;
            this.LB_InfoFarenheit.Click += new System.EventHandler(this.LB_InfoFarenheit_Click);
            // 
            // CleanImg
            // 
            this.CleanImg.Image = ((System.Drawing.Image)(resources.GetObject("CleanImg.Image")));
            this.CleanImg.Location = new System.Drawing.Point(447, 198);
            this.CleanImg.Name = "CleanImg";
            this.CleanImg.Size = new System.Drawing.Size(88, 86);
            this.CleanImg.TabIndex = 17;
            this.CleanImg.TabStop = false;
            this.CleanImg.Visible = false;
            this.CleanImg.Click += new System.EventHandler(this.CleanImg_Click);
            // 
            // Arrow3
            // 
            this.Arrow3.Image = ((System.Drawing.Image)(resources.GetObject("Arrow3.Image")));
            this.Arrow3.Location = new System.Drawing.Point(365, 165);
            this.Arrow3.Name = "Arrow3";
            this.Arrow3.Size = new System.Drawing.Size(86, 83);
            this.Arrow3.TabIndex = 18;
            this.Arrow3.TabStop = false;
            this.Arrow3.Visible = false;
            this.Arrow3.Click += new System.EventHandler(this.Arrow3_Click);
            // 
            // InfoClean
            // 
            this.InfoClean.AutoSize = true;
            this.InfoClean.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoClean.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InfoClean.Location = new System.Drawing.Point(212, 144);
            this.InfoClean.Name = "InfoClean";
            this.InfoClean.Size = new System.Drawing.Size(391, 18);
            this.InfoClean.TabIndex = 19;
            this.InfoClean.Text = "Al hacer click aqui, borraras los datos ingresados anteriormente";
            this.InfoClean.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InfoClean.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(956, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 65);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1052, 322);
            this.Controls.Add(this.TB_GradosCelsisus);
            this.Controls.Add(this.Arrow1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Arrow3);
            this.Controls.Add(this.CleanImg);
            this.Controls.Add(this.Arrow2);
            this.Controls.Add(this.InfoClean);
            this.Controls.Add(this.LB_InfoFarenheit);
            this.Controls.Add(this.TB_GradosFarenheit);
            this.Controls.Add(this.FarenheitImg);
            this.Controls.Add(this.InfoCelsius);
            this.Controls.Add(this.CelsiusImg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PRESS_TO_CONTINUOS);
            this.Controls.Add(this.LB_Intro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CelsiusImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FarenheitImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CleanImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Intro;
        private System.Windows.Forms.Label PRESS_TO_CONTINUOS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox CelsiusImg;
        private System.Windows.Forms.TextBox TB_GradosCelsisus;
        private System.Windows.Forms.PictureBox Arrow1;
        private System.Windows.Forms.Label InfoCelsius;
        private System.Windows.Forms.PictureBox FarenheitImg;
        private System.Windows.Forms.TextBox TB_GradosFarenheit;
        private System.Windows.Forms.PictureBox Arrow2;
        private System.Windows.Forms.Label LB_InfoFarenheit;
        private System.Windows.Forms.PictureBox CleanImg;
        private System.Windows.Forms.PictureBox Arrow3;
        private System.Windows.Forms.Label InfoClean;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}