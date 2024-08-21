namespace ConversorDeTemperatura
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TB_GradosCelsisus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_GradosFarenheit = new System.Windows.Forms.TextBox();
            this.FarenheitImg = new System.Windows.Forms.PictureBox();
            this.CelsiusImg = new System.Windows.Forms.PictureBox();
            this.CleanImg = new System.Windows.Forms.PictureBox();
            this.LB_CleanInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FarenheitImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CelsiusImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CleanImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(956, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 86);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(215, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONVERSOR DE TEMPERATURA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox3.Location = new System.Drawing.Point(192, 37);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(555, 71);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // TB_GradosCelsisus
            // 
            this.TB_GradosCelsisus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_GradosCelsisus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_GradosCelsisus.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_GradosCelsisus.Location = new System.Drawing.Point(60, 218);
            this.TB_GradosCelsisus.Margin = new System.Windows.Forms.Padding(4);
            this.TB_GradosCelsisus.Name = "TB_GradosCelsisus";
            this.TB_GradosCelsisus.Size = new System.Drawing.Size(363, 29);
            this.TB_GradosCelsisus.TabIndex = 4;
            this.TB_GradosCelsisus.Text = "Ingrese el valor de Grados Celsius";
            this.TB_GradosCelsisus.Enter += new System.EventHandler(this.TB_GradosCelsisus_Enter);
            this.TB_GradosCelsisus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_GradosCelsisus_KeyDown);
            this.TB_GradosCelsisus.Leave += new System.EventHandler(this.TB_GradosCelsisus_Leave_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // TB_GradosFarenheit
            // 
            this.TB_GradosFarenheit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_GradosFarenheit.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_GradosFarenheit.Location = new System.Drawing.Point(565, 218);
            this.TB_GradosFarenheit.Margin = new System.Windows.Forms.Padding(4);
            this.TB_GradosFarenheit.Name = "TB_GradosFarenheit";
            this.TB_GradosFarenheit.Size = new System.Drawing.Size(383, 29);
            this.TB_GradosFarenheit.TabIndex = 6;
            this.TB_GradosFarenheit.Text = "Ingrese el valor de Grados Farenheit";
            this.TB_GradosFarenheit.Enter += new System.EventHandler(this.TB_GradosFarenheit_Enter);
            this.TB_GradosFarenheit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_GradosFarenheit_KeyDown);
            this.TB_GradosFarenheit.Leave += new System.EventHandler(this.TB_GradosFarenheit_Leave_1);
            // 
            // FarenheitImg
            // 
            this.FarenheitImg.Image = ((System.Drawing.Image)(resources.GetObject("FarenheitImg.Image")));
            this.FarenheitImg.Location = new System.Drawing.Point(720, 134);
            this.FarenheitImg.Margin = new System.Windows.Forms.Padding(4);
            this.FarenheitImg.Name = "FarenheitImg";
            this.FarenheitImg.Size = new System.Drawing.Size(87, 76);
            this.FarenheitImg.TabIndex = 7;
            this.FarenheitImg.TabStop = false;
            // 
            // CelsiusImg
            // 
            this.CelsiusImg.Image = ((System.Drawing.Image)(resources.GetObject("CelsiusImg.Image")));
            this.CelsiusImg.Location = new System.Drawing.Point(202, 135);
            this.CelsiusImg.Name = "CelsiusImg";
            this.CelsiusImg.Size = new System.Drawing.Size(100, 76);
            this.CelsiusImg.TabIndex = 8;
            this.CelsiusImg.TabStop = false;
            // 
            // CleanImg
            // 
            this.CleanImg.Image = ((System.Drawing.Image)(resources.GetObject("CleanImg.Image")));
            this.CleanImg.Location = new System.Drawing.Point(447, 198);
            this.CleanImg.Name = "CleanImg";
            this.CleanImg.Size = new System.Drawing.Size(99, 80);
            this.CleanImg.TabIndex = 9;
            this.CleanImg.TabStop = false;
            this.CleanImg.Click += new System.EventHandler(this.pictureBox5_Click);
            this.CleanImg.MouseEnter += new System.EventHandler(this.pictureBox5_MouseEnter);
            this.CleanImg.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            // 
            // LB_CleanInfo
            // 
            this.LB_CleanInfo.AutoSize = true;
            this.LB_CleanInfo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LB_CleanInfo.Location = new System.Drawing.Point(536, 152);
            this.LB_CleanInfo.Name = "LB_CleanInfo";
            this.LB_CleanInfo.Size = new System.Drawing.Size(177, 32);
            this.LB_CleanInfo.TabIndex = 10;
            this.LB_CleanInfo.Text = "Borra los valores de grados \r\nCelsius y Farenheit\r\n";
            this.LB_CleanInfo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 322);
            this.Controls.Add(this.LB_CleanInfo);
            this.Controls.Add(this.CleanImg);
            this.Controls.Add(this.CelsiusImg);
            this.Controls.Add(this.FarenheitImg);
            this.Controls.Add(this.TB_GradosFarenheit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_GradosCelsisus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FarenheitImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CelsiusImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CleanImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TB_GradosCelsisus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_GradosFarenheit;
        private System.Windows.Forms.PictureBox FarenheitImg;
        private System.Windows.Forms.PictureBox CelsiusImg;
        private System.Windows.Forms.PictureBox CleanImg;
        private System.Windows.Forms.Label LB_CleanInfo;
    }
}

