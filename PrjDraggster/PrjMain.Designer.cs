namespace PrjDraggster
{
    partial class PrjMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblVelocidade = new Label();
            lblRPM = new Label();
            lblMarcha = new Label();
            lblTempo = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pnlCar1 = new Panel();
            btnAcelerar = new Button();
            btnMarcha = new Button();
            lblRPMBarFill = new Panel();
            lblRPMBarBack = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            lblRPMBarBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblVelocidade
            // 
            lblVelocidade.AutoSize = true;
            lblVelocidade.Location = new Point(708, 426);
            lblVelocidade.Name = "lblVelocidade";
            lblVelocidade.Size = new Size(80, 15);
            lblVelocidade.TabIndex = 0;
            lblVelocidade.Text = "{{Velocidade}}";
            // 
            // lblRPM
            // 
            lblRPM.AutoSize = true;
            lblRPM.Location = new Point(628, 426);
            lblRPM.Name = "lblRPM";
            lblRPM.Size = new Size(48, 15);
            lblRPM.TabIndex = 1;
            lblRPM.Text = "{{RPM}}";
            // 
            // lblMarcha
            // 
            lblMarcha.AutoSize = true;
            lblMarcha.Location = new Point(531, 426);
            lblMarcha.Name = "lblMarcha";
            lblMarcha.Size = new Size(63, 15);
            lblMarcha.TabIndex = 2;
            lblMarcha.Text = "{{Marcha}}";
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.Location = new Point(729, 9);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(59, 15);
            lblTempo.TabIndex = 3;
            lblTempo.Text = "{{Tempo}}";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.asphalt;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnlCar1);
            panel1.Location = new Point(12, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 172);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(40, 20);
            panel2.TabIndex = 1;
            // 
            // pnlCar1
            // 
            pnlCar1.BackColor = SystemColors.ActiveCaptionText;
            pnlCar1.Location = new Point(0, 22);
            pnlCar1.Name = "pnlCar1";
            pnlCar1.Size = new Size(40, 20);
            pnlCar1.TabIndex = 0;
            // 
            // btnAcelerar
            // 
            btnAcelerar.Enabled = false;
            btnAcelerar.FlatStyle = FlatStyle.Flat;
            btnAcelerar.Location = new Point(12, 296);
            btnAcelerar.Name = "btnAcelerar";
            btnAcelerar.Size = new Size(75, 23);
            btnAcelerar.TabIndex = 5;
            btnAcelerar.Text = "button1";
            btnAcelerar.UseVisualStyleBackColor = true;
            btnAcelerar.Click += btnAcelerar_Click;
            btnAcelerar.MouseDown += btnAccelerate_MouseDown;
            btnAcelerar.MouseUp += btnAccelerate_MouseUp;
            // 
            // btnMarcha
            // 
            btnMarcha.Enabled = false;
            btnMarcha.FlatStyle = FlatStyle.Flat;
            btnMarcha.Location = new Point(93, 296);
            btnMarcha.Name = "btnMarcha";
            btnMarcha.Size = new Size(75, 23);
            btnMarcha.TabIndex = 6;
            btnMarcha.Text = "button2";
            btnMarcha.UseVisualStyleBackColor = true;
            btnMarcha.Click += btnMarcha_Click;
            // 
            // lblRPMBarFill
            // 
            lblRPMBarFill.BackColor = Color.FromArgb(0, 192, 0);
            lblRPMBarFill.Location = new Point(0, 3);
            lblRPMBarFill.Name = "lblRPMBarFill";
            lblRPMBarFill.Size = new Size(32, 12);
            lblRPMBarFill.TabIndex = 7;
            // 
            // lblRPMBarBack
            // 
            lblRPMBarBack.Controls.Add(lblRPMBarFill);
            lblRPMBarBack.Location = new Point(531, 396);
            lblRPMBarBack.Name = "lblRPMBarBack";
            lblRPMBarBack.Size = new Size(257, 18);
            lblRPMBarBack.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.faixa;
            pictureBox1.Location = new Point(738, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(13, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // PrjMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lblRPMBarBack);
            Controls.Add(btnMarcha);
            Controls.Add(btnAcelerar);
            Controls.Add(panel1);
            Controls.Add(lblTempo);
            Controls.Add(lblMarcha);
            Controls.Add(lblRPM);
            Controls.Add(lblVelocidade);
            Name = "PrjMain";
            Text = "Form1";
            Load += PrjMain_Load;
            panel1.ResumeLayout(false);
            lblRPMBarBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVelocidade;
        private Label lblRPM;
        private Label lblMarcha;
        private Label lblTempo;
        private Panel panel1;
        private Panel pnlCar1;
        private Button btnAcelerar;
        private Button btnMarcha;
        private Panel lblRPMBarFill;
        private Panel lblRPMBarBack;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}
