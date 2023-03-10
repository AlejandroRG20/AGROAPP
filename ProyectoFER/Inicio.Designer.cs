namespace ProyectoAJ
{
    partial class Inicio
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
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            chBasico = new CheckBox();
            chIntermedio = new CheckBox();
            chAvanzado = new CheckBox();
            btnSiguiente = new Button();
            bntCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(121, 328);
            label2.Name = "label2";
            label2.Size = new Size(291, 25);
            label2.TabIndex = 10;
            label2.Text = "Bienvenido a  AGROAPP";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ProyectoFER.Properties.Resources.WhatsApp_Image_2023_03_08_at_10_32_45_PM;
            pictureBox1.Location = new Point(151, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 258);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(72, 371);
            label1.Name = "label1";
            label1.Size = new Size(386, 72);
            label1.TabIndex = 12;
            label1.Text = "  Querido usuario en esta app encontrarás el \r\n conocimiento que deseas para llevar un buen \r\nmanejo de tu negocio, mediante un programa \r\n   interactivo que te brindará lo que necesites.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(85, 457);
            label3.Name = "label3";
            label3.Size = new Size(358, 36);
            label3.TabIndex = 13;
            label3.Text = "Para esto, necesito saber qué tanto sabes \r\n                      sobre finanzas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(72, 507);
            label4.Name = "label4";
            label4.Size = new Size(389, 36);
            label4.TabIndex = 14;
            label4.Text = "¿Que nivel consideras que tienes con respecto \r\n                  al manejo de las finanzas?";
            // 
            // chBasico
            // 
            chBasico.AutoSize = true;
            chBasico.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chBasico.Location = new Point(62, 595);
            chBasico.Name = "chBasico";
            chBasico.Size = new Size(83, 22);
            chBasico.TabIndex = 15;
            chBasico.Text = "Basico";
            chBasico.UseVisualStyleBackColor = true;
            chBasico.CheckedChanged += chBasico_CheckedChanged;
            // 
            // chIntermedio
            // 
            chIntermedio.AutoSize = true;
            chIntermedio.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chIntermedio.Location = new Point(190, 595);
            chIntermedio.Name = "chIntermedio";
            chIntermedio.Size = new Size(125, 22);
            chIntermedio.TabIndex = 16;
            chIntermedio.Text = "Intermedio";
            chIntermedio.UseVisualStyleBackColor = true;
            chIntermedio.CheckedChanged += chIntermedio_CheckedChanged;
            // 
            // chAvanzado
            // 
            chAvanzado.AutoSize = true;
            chAvanzado.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chAvanzado.Location = new Point(347, 595);
            chAvanzado.Name = "chAvanzado";
            chAvanzado.Size = new Size(114, 22);
            chAvanzado.TabIndex = 17;
            chAvanzado.Text = "Avanzado";
            chAvanzado.UseVisualStyleBackColor = true;
            chAvanzado.CheckedChanged += chAvanzado_CheckedChanged;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiguiente.Location = new Point(308, 672);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(90, 30);
            btnSiguiente.TabIndex = 18;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // bntCancelar
            // 
            bntCancelar.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bntCancelar.Location = new Point(151, 672);
            bntCancelar.Name = "bntCancelar";
            bntCancelar.Size = new Size(90, 30);
            bntCancelar.TabIndex = 19;
            bntCancelar.Text = "Cancelar";
            bntCancelar.UseVisualStyleBackColor = true;
            bntCancelar.Click += bntCancelar_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(522, 749);
            Controls.Add(bntCancelar);
            Controls.Add(btnSiguiente);
            Controls.Add(chAvanzado);
            Controls.Add(chIntermedio);
            Controls.Add(chBasico);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Name = "Inicio";
            Text = "Intermedio";
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label4;
        private CheckBox chBasico;
        private CheckBox chIntermedio;
        private CheckBox chAvanzado;
        private Button btnSiguiente;
        private Button bntCancelar;
    }
}