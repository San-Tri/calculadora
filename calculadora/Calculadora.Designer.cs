namespace calculadora
{
    partial class Calculadora
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
            btnSumar = new Button();
            tbxScreen = new TextBox();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnN7 = new Button();
            btnN8 = new Button();
            btnN9 = new Button();
            btnN4 = new Button();
            btnN5 = new Button();
            btnN6 = new Button();
            btnN2 = new Button();
            btnN3 = new Button();
            btnN1 = new Button();
            btnN0 = new Button();
            btnIgual = new Button();
            btnPunto = new Button();
            btnLimpiar = new Button();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.BackColor = SystemColors.Info;
            btnSumar.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnSumar.Location = new Point(21, 99);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(47, 28);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = false;
            btnSumar.Click += button1_Click;
            // 
            // tbxScreen
            // 
            tbxScreen.BackColor = SystemColors.InactiveCaption;
            tbxScreen.BorderStyle = BorderStyle.FixedSingle;
            tbxScreen.Cursor = Cursors.PanWest;
            tbxScreen.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tbxScreen.Location = new Point(31, 54);
            tbxScreen.Name = "tbxScreen";
            tbxScreen.ReadOnly = true;
            tbxScreen.Size = new Size(187, 34);
            tbxScreen.TabIndex = 1;
            tbxScreen.TextAlign = HorizontalAlignment.Right;
            // 
            // btnRestar
            // 
            btnRestar.BackColor = SystemColors.Info;
            btnRestar.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnRestar.Location = new Point(74, 99);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(47, 28);
            btnRestar.TabIndex = 2;
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = false;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.BackColor = SystemColors.Info;
            btnMultiplicar.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnMultiplicar.Location = new Point(127, 99);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(47, 28);
            btnMultiplicar.TabIndex = 3;
            btnMultiplicar.Text = "*";
            btnMultiplicar.UseVisualStyleBackColor = false;
            btnMultiplicar.Click += button3_Click;
            // 
            // btnDividir
            // 
            btnDividir.BackColor = SystemColors.Info;
            btnDividir.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnDividir.Location = new Point(180, 99);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(47, 28);
            btnDividir.TabIndex = 4;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnN7
            // 
            btnN7.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnN7.Location = new Point(25, 141);
            btnN7.Name = "btnN7";
            btnN7.Size = new Size(43, 33);
            btnN7.TabIndex = 5;
            btnN7.Text = "7";
            btnN7.UseVisualStyleBackColor = true;
            btnN7.Click += btnN7_Click;
            // 
            // btnN8
            // 
            btnN8.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnN8.Location = new Point(78, 141);
            btnN8.Name = "btnN8";
            btnN8.Size = new Size(43, 33);
            btnN8.TabIndex = 6;
            btnN8.Text = "8";
            btnN8.UseVisualStyleBackColor = true;
            btnN8.Click += btnN8_Click;
            // 
            // btnN9
            // 
            btnN9.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnN9.Location = new Point(131, 141);
            btnN9.Name = "btnN9";
            btnN9.Size = new Size(43, 33);
            btnN9.TabIndex = 7;
            btnN9.Text = "9";
            btnN9.UseVisualStyleBackColor = true;
            btnN9.Click += button7_Click;
            // 
            // btnN4
            // 
            btnN4.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnN4.Location = new Point(25, 180);
            btnN4.Name = "btnN4";
            btnN4.Size = new Size(43, 33);
            btnN4.TabIndex = 8;
            btnN4.Text = "4";
            btnN4.UseVisualStyleBackColor = true;
            btnN4.Click += btnN4_Click;
            // 
            // btnN5
            // 
            btnN5.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnN5.Location = new Point(78, 180);
            btnN5.Name = "btnN5";
            btnN5.Size = new Size(43, 33);
            btnN5.TabIndex = 9;
            btnN5.Text = "5";
            btnN5.UseVisualStyleBackColor = true;
            btnN5.Click += btnN5_Click;
            // 
            // btnN6
            // 
            btnN6.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnN6.Location = new Point(131, 180);
            btnN6.Name = "btnN6";
            btnN6.Size = new Size(43, 33);
            btnN6.TabIndex = 10;
            btnN6.Text = "6";
            btnN6.UseVisualStyleBackColor = true;
            btnN6.Click += btnN6_Click;
            // 
            // btnN2
            // 
            btnN2.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnN2.Location = new Point(78, 219);
            btnN2.Name = "btnN2";
            btnN2.Size = new Size(43, 33);
            btnN2.TabIndex = 12;
            btnN2.Text = "2";
            btnN2.UseVisualStyleBackColor = true;
            btnN2.Click += btnN2_Click;
            // 
            // btnN3
            // 
            btnN3.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnN3.Location = new Point(131, 219);
            btnN3.Name = "btnN3";
            btnN3.Size = new Size(43, 33);
            btnN3.TabIndex = 13;
            btnN3.Text = "3";
            btnN3.UseVisualStyleBackColor = true;
            btnN3.Click += button13_Click;
            // 
            // btnN1
            // 
            btnN1.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnN1.Location = new Point(25, 219);
            btnN1.Name = "btnN1";
            btnN1.Size = new Size(43, 33);
            btnN1.TabIndex = 11;
            btnN1.Text = "1";
            btnN1.UseVisualStyleBackColor = true;
            btnN1.Click += button11_Click;
            // 
            // btnN0
            // 
            btnN0.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnN0.Location = new Point(25, 258);
            btnN0.Name = "btnN0";
            btnN0.Size = new Size(96, 33);
            btnN0.TabIndex = 18;
            btnN0.Text = "0";
            btnN0.UseVisualStyleBackColor = true;
            btnN0.Click += btnN0_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = SystemColors.Info;
            btnIgual.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnIgual.Location = new Point(180, 219);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(47, 72);
            btnIgual.TabIndex = 21;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnPunto
            // 
            btnPunto.BackColor = SystemColors.Info;
            btnPunto.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnPunto.Location = new Point(127, 263);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(47, 28);
            btnPunto.TabIndex = 22;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = false;
            btnPunto.Click += btnPunto_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.Info;
            btnLimpiar.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnLimpiar.Location = new Point(180, 143);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(47, 28);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "←";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = SystemColors.Info;
            btnBorrar.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnBorrar.Location = new Point(180, 180);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(47, 36);
            btnBorrar.TabIndex = 24;
            btnBorrar.Text = "CE";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 340);
            Controls.Add(btnBorrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnPunto);
            Controls.Add(btnIgual);
            Controls.Add(btnN0);
            Controls.Add(btnN3);
            Controls.Add(btnN2);
            Controls.Add(btnN1);
            Controls.Add(btnN6);
            Controls.Add(btnN5);
            Controls.Add(btnN4);
            Controls.Add(btnN9);
            Controls.Add(btnN8);
            Controls.Add(btnN7);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(tbxScreen);
            Controls.Add(btnSumar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private TextBox tbxScreen;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnN7;
        private Button btnN8;
        private Button btnN9;
        private Button btnN4;
        private Button btnN5;
        private Button btnN6;
        private Button btnN2;
        private Button btnN3;
        private Button btnN1;
        private Button btnN0;
        private Button btnIgual;
        private Button btnPunto;
        private Button btnLimpiar;
        private Button btnBorrar;
    }
}
