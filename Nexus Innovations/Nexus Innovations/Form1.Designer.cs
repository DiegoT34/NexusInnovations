namespace Nexus_Innovations
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            bIngresar = new Button();
            bSalir = new Button();
            cajaClave = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Blue_Black_Modern_Simple_Design_Hotel_and_Resort_Logo___Logos__1_;
            pictureBox1.Location = new Point(5, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bIngresar
            // 
            bIngresar.BackColor = Color.Black;
            bIngresar.Cursor = Cursors.Hand;
            bIngresar.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            bIngresar.FlatAppearance.BorderSize = 3;
            bIngresar.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            bIngresar.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            bIngresar.FlatStyle = FlatStyle.Flat;
            bIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bIngresar.ForeColor = SystemColors.ButtonFace;
            bIngresar.Location = new Point(63, 266);
            bIngresar.Name = "bIngresar";
            bIngresar.Size = new Size(116, 36);
            bIngresar.TabIndex = 1;
            bIngresar.Text = "Ingresar";
            bIngresar.UseVisualStyleBackColor = false;
            bIngresar.Click += bIngresar_Click;
            // 
            // bSalir
            // 
            bSalir.BackColor = Color.Black;
            bSalir.Cursor = Cursors.Hand;
            bSalir.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            bSalir.FlatAppearance.BorderSize = 3;
            bSalir.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            bSalir.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            bSalir.FlatStyle = FlatStyle.Flat;
            bSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bSalir.ForeColor = SystemColors.Control;
            bSalir.Location = new Point(63, 308);
            bSalir.Name = "bSalir";
            bSalir.Size = new Size(116, 36);
            bSalir.TabIndex = 2;
            bSalir.Text = "Salir";
            bSalir.UseVisualStyleBackColor = false;
            bSalir.Click += bSalir_Click;
            // 
            // cajaClave
            // 
            cajaClave.BackColor = Color.Black;
            cajaClave.BorderStyle = BorderStyle.FixedSingle;
            cajaClave.ForeColor = Color.White;
            cajaClave.Location = new Point(30, 235);
            cajaClave.MaxLength = 5;
            cajaClave.Name = "cajaClave";
            cajaClave.PasswordChar = 'o';
            cajaClave.Size = new Size(185, 23);
            cajaClave.TabIndex = 3;
            cajaClave.TextChanged += cajaClave_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(49, 217);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 4;
            label1.Text = "Coloque La Clave de Aceso";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(245, 371);
            Controls.Add(label1);
            Controls.Add(cajaClave);
            Controls.Add(bSalir);
            Controls.Add(bIngresar);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(261, 410);
            MinimumSize = new Size(261, 410);
            Name = "Form1";
            Text = "Nexus";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button bIngresar;
        private Button bSalir;
        private TextBox cajaClave;
        private Label label1;
    }
}