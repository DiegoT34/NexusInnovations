namespace Nexus_Innovations
{
    partial class ventanaDeIngresar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaDeIngresar));
            bSalir2 = new Button();
            pictureBox1 = new PictureBox();
            comboCategoria = new ComboBox();
            cajaNombre = new TextBox();
            cajaIdentificador = new TextBox();
            cajaAñosDeExperiencia = new TextBox();
            checkJava = new CheckBox();
            checkHtml = new CheckBox();
            checkPython = new CheckBox();
            checkC = new CheckBox();
            checkPhp = new CheckBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            checkLaravel = new CheckBox();
            checkDjango = new CheckBox();
            checkFundation = new CheckBox();
            checkBotstrap = new CheckBox();
            checkReact = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            cajaSueldoBase = new TextBox();
            label5 = new Label();
            cajaBonoPorLenguaje = new TextBox();
            label7 = new Label();
            cajaBonoFramework = new TextBox();
            bProcesar = new Button();
            bLimpiar = new Button();
            cajaBonoPorAños = new TextBox();
            label8 = new Label();
            cajaEdad = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // bSalir2
            // 
            bSalir2.BackColor = Color.Black;
            bSalir2.Cursor = Cursors.Hand;
            bSalir2.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            bSalir2.FlatAppearance.BorderSize = 3;
            bSalir2.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            bSalir2.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            bSalir2.FlatStyle = FlatStyle.Flat;
            bSalir2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bSalir2.ForeColor = SystemColors.Control;
            bSalir2.Location = new Point(290, 463);
            bSalir2.Name = "bSalir2";
            bSalir2.Size = new Size(116, 36);
            bSalir2.TabIndex = 3;
            bSalir2.Text = "Salir";
            bSalir2.UseVisualStyleBackColor = false;
            bSalir2.Click += bSalir2_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2_560;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // comboCategoria
            // 
            comboCategoria.BackColor = SystemColors.InactiveCaptionText;
            comboCategoria.Cursor = Cursors.Hand;
            comboCategoria.FlatStyle = FlatStyle.Flat;
            comboCategoria.ForeColor = SystemColors.Info;
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Items.AddRange(new object[] { "FullStack", "FrontEnd", "BackEnd" });
            comboCategoria.Location = new Point(487, 261);
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(121, 23);
            comboCategoria.TabIndex = 5;
            // 
            // cajaNombre
            // 
            cajaNombre.BackColor = SystemColors.InactiveCaptionText;
            cajaNombre.BorderStyle = BorderStyle.FixedSingle;
            cajaNombre.ForeColor = SystemColors.Info;
            cajaNombre.Location = new Point(46, 262);
            cajaNombre.MaxLength = 10;
            cajaNombre.Name = "cajaNombre";
            cajaNombre.Size = new Size(121, 23);
            cajaNombre.TabIndex = 6;
            cajaNombre.TextChanged += cajaNombre_TextChanged;
            // 
            // cajaIdentificador
            // 
            cajaIdentificador.BackColor = SystemColors.InactiveCaptionText;
            cajaIdentificador.BorderStyle = BorderStyle.FixedSingle;
            cajaIdentificador.ForeColor = SystemColors.Info;
            cajaIdentificador.Location = new Point(194, 262);
            cajaIdentificador.MaxLength = 11;
            cajaIdentificador.Name = "cajaIdentificador";
            cajaIdentificador.Size = new Size(121, 23);
            cajaIdentificador.TabIndex = 7;
            cajaIdentificador.TextChanged += cajaIdentificador_TextChanged;
            // 
            // cajaAñosDeExperiencia
            // 
            cajaAñosDeExperiencia.BackColor = SystemColors.InactiveCaptionText;
            cajaAñosDeExperiencia.BorderStyle = BorderStyle.FixedSingle;
            cajaAñosDeExperiencia.ForeColor = SystemColors.Info;
            cajaAñosDeExperiencia.Location = new Point(339, 262);
            cajaAñosDeExperiencia.MaxLength = 2;
            cajaAñosDeExperiencia.Name = "cajaAñosDeExperiencia";
            cajaAñosDeExperiencia.Size = new Size(121, 23);
            cajaAñosDeExperiencia.TabIndex = 8;
            cajaAñosDeExperiencia.TextChanged += cajaAñosDeExperiencia_TextChanged;
            // 
            // checkJava
            // 
            checkJava.AutoSize = true;
            checkJava.BackColor = Color.Black;
            checkJava.Location = new Point(6, 45);
            checkJava.Name = "checkJava";
            checkJava.Size = new Size(110, 25);
            checkJava.TabIndex = 11;
            checkJava.Text = "JavaScript";
            checkJava.UseVisualStyleBackColor = false;
            checkJava.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkHtml
            // 
            checkHtml.AutoSize = true;
            checkHtml.BackColor = Color.Black;
            checkHtml.Location = new Point(6, 70);
            checkHtml.Name = "checkHtml";
            checkHtml.Size = new Size(113, 25);
            checkHtml.TabIndex = 12;
            checkHtml.Text = "Html Y Css";
            checkHtml.UseVisualStyleBackColor = false;
            // 
            // checkPython
            // 
            checkPython.AutoSize = true;
            checkPython.BackColor = Color.Black;
            checkPython.Location = new Point(6, 95);
            checkPython.Name = "checkPython";
            checkPython.Size = new Size(85, 25);
            checkPython.TabIndex = 13;
            checkPython.Text = "Python";
            checkPython.UseVisualStyleBackColor = false;
            // 
            // checkC
            // 
            checkC.AutoSize = true;
            checkC.BackColor = Color.Black;
            checkC.Location = new Point(6, 120);
            checkC.Name = "checkC";
            checkC.Size = new Size(131, 25);
            checkC.TabIndex = 14;
            checkC.Text = "C# || C++ || C";
            checkC.UseVisualStyleBackColor = false;
            // 
            // checkPhp
            // 
            checkPhp.AutoSize = true;
            checkPhp.BackColor = Color.Black;
            checkPhp.Location = new Point(6, 145);
            checkPhp.Name = "checkPhp";
            checkPhp.Size = new Size(62, 25);
            checkPhp.TabIndex = 15;
            checkPhp.Text = "PHP";
            checkPhp.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(checkPhp);
            groupBox1.Controls.Add(checkC);
            groupBox1.Controls.Add(checkPython);
            groupBox1.Controls.Add(checkHtml);
            groupBox1.Controls.Add(checkJava);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(423, 318);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(161, 181);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Que Lenguajes maneja";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(checkLaravel);
            groupBox2.Controls.Add(checkDjango);
            groupBox2.Controls.Add(checkFundation);
            groupBox2.Controls.Add(checkBotstrap);
            groupBox2.Controls.Add(checkReact);
            groupBox2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(593, 318);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(161, 181);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Que Frameworks maneja";
            // 
            // checkLaravel
            // 
            checkLaravel.AutoSize = true;
            checkLaravel.Location = new Point(6, 145);
            checkLaravel.Name = "checkLaravel";
            checkLaravel.Size = new Size(86, 25);
            checkLaravel.TabIndex = 15;
            checkLaravel.Text = "Laravel";
            checkLaravel.UseVisualStyleBackColor = true;
            // 
            // checkDjango
            // 
            checkDjango.AutoSize = true;
            checkDjango.Location = new Point(6, 120);
            checkDjango.Name = "checkDjango";
            checkDjango.Size = new Size(85, 25);
            checkDjango.TabIndex = 14;
            checkDjango.Text = "Django";
            checkDjango.UseVisualStyleBackColor = true;
            // 
            // checkFundation
            // 
            checkFundation.AutoSize = true;
            checkFundation.Location = new Point(6, 95);
            checkFundation.Name = "checkFundation";
            checkFundation.Size = new Size(109, 25);
            checkFundation.TabIndex = 13;
            checkFundation.Text = "Fundation";
            checkFundation.UseVisualStyleBackColor = true;
            // 
            // checkBotstrap
            // 
            checkBotstrap.AutoSize = true;
            checkBotstrap.Location = new Point(6, 70);
            checkBotstrap.Name = "checkBotstrap";
            checkBotstrap.Size = new Size(108, 25);
            checkBotstrap.TabIndex = 12;
            checkBotstrap.Text = "Bootstrap";
            checkBotstrap.UseVisualStyleBackColor = true;
            // 
            // checkReact
            // 
            checkReact.AutoSize = true;
            checkReact.Location = new Point(6, 45);
            checkReact.Name = "checkReact";
            checkReact.Size = new Size(73, 25);
            checkReact.TabIndex = 11;
            checkReact.Text = "React";
            checkReact.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(46, 235);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 17;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(185, 239);
            label2.Name = "label2";
            label2.Size = new Size(139, 19);
            label2.TabIndex = 18;
            label2.Text = "Identificador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Unispace", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(339, 222);
            label3.Name = "label3";
            label3.Size = new Size(107, 36);
            label3.TabIndex = 19;
            label3.Text = "Años de \r\nexperiencia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Unispace", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(486, 222);
            label4.Name = "label4";
            label4.Size = new Size(98, 36);
            label4.TabIndex = 20;
            label4.Text = "Seleccione\r\nuna opcion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(631, 220);
            label6.Name = "label6";
            label6.Size = new Size(119, 38);
            label6.TabIndex = 23;
            label6.Text = "Sueldo del \r\nProgramador";
            // 
            // cajaSueldoBase
            // 
            cajaSueldoBase.BackColor = SystemColors.InactiveCaptionText;
            cajaSueldoBase.BorderStyle = BorderStyle.FixedSingle;
            cajaSueldoBase.ForeColor = SystemColors.Info;
            cajaSueldoBase.Location = new Point(631, 262);
            cajaSueldoBase.MaxLength = 10;
            cajaSueldoBase.Name = "cajaSueldoBase";
            cajaSueldoBase.Size = new Size(138, 23);
            cajaSueldoBase.TabIndex = 22;
            cajaSueldoBase.TextChanged += cajaSueldoBase_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(213, 296);
            label5.Name = "label5";
            label5.Size = new Size(176, 51);
            label5.TabIndex = 25;
            label5.Text = "Cuantos $ adicionales gana\r\npor cada lenguaje\r\nque domina";
            // 
            // cajaBonoPorLenguaje
            // 
            cajaBonoPorLenguaje.BackColor = SystemColors.InactiveCaptionText;
            cajaBonoPorLenguaje.BorderStyle = BorderStyle.FixedSingle;
            cajaBonoPorLenguaje.ForeColor = SystemColors.Info;
            cajaBonoPorLenguaje.Location = new Point(213, 350);
            cajaBonoPorLenguaje.MaxLength = 10;
            cajaBonoPorLenguaje.Name = "cajaBonoPorLenguaje";
            cajaBonoPorLenguaje.Size = new Size(121, 23);
            cajaBonoPorLenguaje.TabIndex = 24;
            cajaBonoPorLenguaje.TextChanged += cajaBonoPorLenguaje_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(213, 378);
            label7.Name = "label7";
            label7.Size = new Size(131, 51);
            label7.TabIndex = 27;
            label7.Text = "¿Cuantos $ gana\r\npor cada framework\r\nque domina?";
            // 
            // cajaBonoFramework
            // 
            cajaBonoFramework.BackColor = SystemColors.InactiveCaptionText;
            cajaBonoFramework.BorderStyle = BorderStyle.FixedSingle;
            cajaBonoFramework.ForeColor = SystemColors.Info;
            cajaBonoFramework.Location = new Point(213, 434);
            cajaBonoFramework.MaxLength = 10;
            cajaBonoFramework.Name = "cajaBonoFramework";
            cajaBonoFramework.Size = new Size(121, 23);
            cajaBonoFramework.TabIndex = 26;
            cajaBonoFramework.TextChanged += cajaBonoFramework_TextChanged;
            // 
            // bProcesar
            // 
            bProcesar.BackColor = Color.Black;
            bProcesar.Cursor = Cursors.Hand;
            bProcesar.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            bProcesar.FlatAppearance.BorderSize = 3;
            bProcesar.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            bProcesar.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            bProcesar.FlatStyle = FlatStyle.Flat;
            bProcesar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bProcesar.ForeColor = SystemColors.Control;
            bProcesar.Location = new Point(46, 463);
            bProcesar.Name = "bProcesar";
            bProcesar.Size = new Size(116, 36);
            bProcesar.TabIndex = 28;
            bProcesar.Text = "Procesar";
            bProcesar.UseVisualStyleBackColor = false;
            bProcesar.Click += bProcesar_Click;
            // 
            // bLimpiar
            // 
            bLimpiar.BackColor = Color.Black;
            bLimpiar.Cursor = Cursors.Hand;
            bLimpiar.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            bLimpiar.FlatAppearance.BorderSize = 3;
            bLimpiar.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            bLimpiar.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            bLimpiar.FlatStyle = FlatStyle.Flat;
            bLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bLimpiar.ForeColor = SystemColors.Control;
            bLimpiar.Location = new Point(168, 463);
            bLimpiar.Name = "bLimpiar";
            bLimpiar.Size = new Size(116, 36);
            bLimpiar.TabIndex = 29;
            bLimpiar.Text = "Limpiar";
            bLimpiar.UseVisualStyleBackColor = false;
            bLimpiar.Click += bLimpiar_Click;
            // 
            // cajaBonoPorAños
            // 
            cajaBonoPorAños.BackColor = SystemColors.InactiveCaptionText;
            cajaBonoPorAños.BorderStyle = BorderStyle.FixedSingle;
            cajaBonoPorAños.ForeColor = SystemColors.Info;
            cajaBonoPorAños.Location = new Point(50, 350);
            cajaBonoPorAños.MaxLength = 10;
            cajaBonoPorAños.Name = "cajaBonoPorAños";
            cajaBonoPorAños.Size = new Size(121, 23);
            cajaBonoPorAños.TabIndex = 30;
            cajaBonoPorAños.TextChanged += cajaBonoPorAños_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(50, 295);
            label8.Name = "label8";
            label8.Size = new Size(116, 52);
            label8.TabIndex = 31;
            label8.Text = "¿Cuantos Porcentaje \r\nse le agregara \r\npor tener mas de 5 \r\naños de experencia?";
            // 
            // cajaEdad
            // 
            cajaEdad.BackColor = SystemColors.InactiveCaptionText;
            cajaEdad.BorderStyle = BorderStyle.FixedSingle;
            cajaEdad.ForeColor = SystemColors.Info;
            cajaEdad.Location = new Point(50, 434);
            cajaEdad.MaxLength = 2;
            cajaEdad.Name = "cajaEdad";
            cajaEdad.Size = new Size(121, 23);
            cajaEdad.TabIndex = 32;
            cajaEdad.TextChanged += cajaEdad_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Black;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(50, 395);
            label9.Name = "label9";
            label9.Size = new Size(131, 34);
            label9.TabIndex = 33;
            label9.Text = "Coloque la edad del\r\nProgramar";
            // 
            // ventanaDeIngresar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Diseño_sin_título;
            ClientSize = new Size(800, 511);
            Controls.Add(label9);
            Controls.Add(cajaEdad);
            Controls.Add(label8);
            Controls.Add(cajaBonoPorAños);
            Controls.Add(bLimpiar);
            Controls.Add(bProcesar);
            Controls.Add(label7);
            Controls.Add(cajaBonoFramework);
            Controls.Add(label5);
            Controls.Add(cajaBonoPorLenguaje);
            Controls.Add(label6);
            Controls.Add(cajaSueldoBase);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(cajaAñosDeExperiencia);
            Controls.Add(cajaIdentificador);
            Controls.Add(cajaNombre);
            Controls.Add(comboCategoria);
            Controls.Add(pictureBox1);
            Controls.Add(bSalir2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 550);
            MinimumSize = new Size(816, 550);
            Name = "ventanaDeIngresar";
            Text = "Nexus Innovations";
            Load += ventanaDeIngresar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bSalir2;
        private PictureBox pictureBox1;
        private ComboBox comboCategoria;
        private TextBox cajaNombre;
        private TextBox cajaIdentificador;
        private TextBox cajaAñosDeExperiencia;
        private CheckBox checkJava;
        private CheckBox checkHtml;
        private CheckBox checkPython;
        private CheckBox checkC;
        private CheckBox checkPhp;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox checkLaravel;
        private CheckBox checkDjango;
        private CheckBox checkFundation;
        private CheckBox checkBotstrap;
        private CheckBox checkReact;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox cajaSueldoBase;
        private Label label5;
        private TextBox cajaBonoPorLenguaje;
        private Label label7;
        private TextBox cajaBonoFramework;
        private Button bProcesar;
        private Button bLimpiar;
        private TextBox cajaBonoPorAños;
        private Label label8;
        private TextBox cajaEdad;
        private Label label9;
    }
}