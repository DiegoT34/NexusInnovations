namespace Nexus_Innovations
{
    partial class Nexus_Innovations_Prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nexus_Innovations_Prestamos));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            bEnviarPrestamo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image;
            pictureBox1.Location = new Point(58, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaptionText;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = SystemColors.Info;
            textBox1.Location = new Point(58, 188);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(58, 170);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 2;
            label1.Text = "Coloque  la cantidad";
            // 
            // bEnviarPrestamo
            // 
            bEnviarPrestamo.BackColor = Color.Black;
            bEnviarPrestamo.Cursor = Cursors.Hand;
            bEnviarPrestamo.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            bEnviarPrestamo.FlatAppearance.BorderSize = 3;
            bEnviarPrestamo.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            bEnviarPrestamo.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            bEnviarPrestamo.FlatStyle = FlatStyle.Flat;
            bEnviarPrestamo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bEnviarPrestamo.ForeColor = SystemColors.ButtonFace;
            bEnviarPrestamo.Location = new Point(94, 217);
            bEnviarPrestamo.Name = "bEnviarPrestamo";
            bEnviarPrestamo.Size = new Size(100, 36);
            bEnviarPrestamo.TabIndex = 17;
            bEnviarPrestamo.Text = "Enviar";
            bEnviarPrestamo.UseVisualStyleBackColor = false;
            bEnviarPrestamo.Click += bEnviarPrestamo_Click;
            // 
            // Nexus_Innovations_Prestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(294, 266);
            Controls.Add(bEnviarPrestamo);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(310, 305);
            MinimumSize = new Size(310, 305);
            Name = "Nexus_Innovations_Prestamos";
            Text = "Nexus Innovations Prestamos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private Button bEnviarPrestamo;
    }
}