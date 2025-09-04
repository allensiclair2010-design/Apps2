namespace apps
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btLogin = new System.Windows.Forms.Button();
            this.ctPass = new System.Windows.Forms.TextBox();
            this.ctUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ctFahrenheit2 = new System.Windows.Forms.TextBox();
            this.ctCelsius2 = new System.Windows.Forms.TextBox();
            this.btCaF = new System.Windows.Forms.Button();
            this.btFaC = new System.Windows.Forms.Button();
            this.ctCelsius1 = new System.Windows.Forms.TextBox();
            this.ctFahrenheit1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lClicks = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btContador = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lClasificacion = new System.Windows.Forms.Label();
            this.IMC = new System.Windows.Forms.Label();
            this.BtCalcular = new System.Windows.Forms.Button();
            this.ctAltura = new System.Windows.Forms.TextBox();
            this.ctPeso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 690);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btLogin);
            this.tabPage1.Controls.Add(this.ctPass);
            this.tabPage1.Controls.Add(this.ctUsuario);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(804, 661);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(242, 349);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(330, 92);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Iniciar Sesión";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // ctPass
            // 
            this.ctPass.Location = new System.Drawing.Point(388, 219);
            this.ctPass.Name = "ctPass";
            this.ctPass.PasswordChar = '*';
            this.ctPass.Size = new System.Drawing.Size(296, 22);
            this.ctPass.TabIndex = 1;
            // 
            // ctUsuario
            // 
            this.ctUsuario.Location = new System.Drawing.Point(388, 98);
            this.ctUsuario.Name = "ctUsuario";
            this.ctUsuario.Size = new System.Drawing.Size(296, 22);
            this.ctUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(133, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(127, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.ctFahrenheit2);
            this.tabPage2.Controls.Add(this.ctCelsius2);
            this.tabPage2.Controls.Add(this.btCaF);
            this.tabPage2.Controls.Add(this.btFaC);
            this.tabPage2.Controls.Add(this.ctCelsius1);
            this.tabPage2.Controls.Add(this.ctFahrenheit1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(804, 661);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Temp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(330, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Celsius (resultado)";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(330, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Fahrenheit (resultado)";
            // 
            // ctFahrenheit2
            // 
            this.ctFahrenheit2.Location = new System.Drawing.Point(330, 240);
            this.ctFahrenheit2.Name = "ctFahrenheit2";
            this.ctFahrenheit2.ReadOnly = true;
            this.ctFahrenheit2.Size = new System.Drawing.Size(150, 22);
            this.ctFahrenheit2.TabIndex = 2;
            // 
            // ctCelsius2
            // 
            this.ctCelsius2.Location = new System.Drawing.Point(330, 100);
            this.ctCelsius2.Name = "ctCelsius2";
            this.ctCelsius2.ReadOnly = true;
            this.ctCelsius2.Size = new System.Drawing.Size(150, 22);
            this.ctCelsius2.TabIndex = 3;
            // 
            // btCaF
            // 
            this.btCaF.Location = new System.Drawing.Point(220, 235);
            this.btCaF.Name = "btCaF";
            this.btCaF.Size = new System.Drawing.Size(80, 40);
            this.btCaF.TabIndex = 4;
            this.btCaF.Text = "C → F";
            this.btCaF.Click += new System.EventHandler(this.btCaF_Click);
            // 
            // btFaC
            // 
            this.btFaC.Location = new System.Drawing.Point(220, 95);
            this.btFaC.Name = "btFaC";
            this.btFaC.Size = new System.Drawing.Size(80, 40);
            this.btFaC.TabIndex = 5;
            this.btFaC.Text = "F → C";
            this.btFaC.Click += new System.EventHandler(this.btFaC_Click);
            // 
            // ctCelsius1
            // 
            this.ctCelsius1.Location = new System.Drawing.Point(50, 240);
            this.ctCelsius1.Name = "ctCelsius1";
            this.ctCelsius1.Size = new System.Drawing.Size(150, 22);
            this.ctCelsius1.TabIndex = 6;
            this.ctCelsius1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctCelsius1_KeyPress);
            // 
            // ctFahrenheit1
            // 
            this.ctFahrenheit1.Location = new System.Drawing.Point(50, 100);
            this.ctFahrenheit1.Name = "ctFahrenheit1";
            this.ctFahrenheit1.Size = new System.Drawing.Size(150, 22);
            this.ctFahrenheit1.TabIndex = 7;
            this.ctFahrenheit1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctFahrenheit1_KeyPress);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(50, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Celsius (entrada)";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(50, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fahrenheit (entrada)";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lClicks);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.btContador);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(804, 661);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Click";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lClicks
            // 
            this.lClicks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lClicks.Location = new System.Drawing.Point(319, 483);
            this.lClicks.Name = "lClicks";
            this.lClicks.Size = new System.Drawing.Size(138, 15);
            this.lClicks.TabIndex = 0;
            this.lClicks.Text = "_____";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(300, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "Presiona el botón:";
            // 
            // btContador
            // 
            this.btContador.Location = new System.Drawing.Point(237, 150);
            this.btContador.Name = "btContador";
            this.btContador.Size = new System.Drawing.Size(300, 100);
            this.btContador.TabIndex = 2;
            this.btContador.Text = "Haz Click Aquí";
            this.btContador.UseVisualStyleBackColor = true;
            this.btContador.Click += new System.EventHandler(this.btContador_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lClasificacion);
            this.tabPage4.Controls.Add(this.IMC);
            this.tabPage4.Controls.Add(this.BtCalcular);
            this.tabPage4.Controls.Add(this.ctAltura);
            this.tabPage4.Controls.Add(this.ctPeso);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(804, 661);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "IMC";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lClasificacion
            // 
            this.lClasificacion.Location = new System.Drawing.Point(283, 530);
            this.lClasificacion.Name = "lClasificacion";
            this.lClasificacion.Size = new System.Drawing.Size(100, 23);
            this.lClasificacion.TabIndex = 0;
            this.lClasificacion.Text = " ";
            // 
            // IMC
            // 
            this.IMC.Location = new System.Drawing.Point(283, 453);
            this.IMC.Name = "IMC";
            this.IMC.Size = new System.Drawing.Size(100, 23);
            this.IMC.TabIndex = 1;
            this.IMC.Text = "__________";
            // 
            // BtCalcular
            // 
            this.BtCalcular.Location = new System.Drawing.Point(235, 280);
            this.BtCalcular.Name = "BtCalcular";
            this.BtCalcular.Size = new System.Drawing.Size(309, 96);
            this.BtCalcular.TabIndex = 2;
            this.BtCalcular.Text = "Calcular IMC";
            this.BtCalcular.Click += new System.EventHandler(this.BtCalcular_Click);
            // 
            // ctAltura
            // 
            this.ctAltura.Location = new System.Drawing.Point(443, 183);
            this.ctAltura.Name = "ctAltura";
            this.ctAltura.Size = new System.Drawing.Size(112, 22);
            this.ctAltura.TabIndex = 3;
            this.ctAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctAltura_KeyPress);
            // 
            // ctPeso
            // 
            this.ctPeso.Location = new System.Drawing.Point(443, 91);
            this.ctPeso.Name = "ctPeso";
            this.ctPeso.Size = new System.Drawing.Size(112, 22);
            this.ctPeso.TabIndex = 4;
            this.ctPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctPeso_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(217, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Altura (m)";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(217, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Peso (Kg)";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(806, 687);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicación";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox ctPass;
        private System.Windows.Forms.TextBox ctUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btCaF;
        private System.Windows.Forms.Button btFaC;
        private System.Windows.Forms.TextBox ctCelsius1;
        private System.Windows.Forms.TextBox ctFahrenheit1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ctFahrenheit2;
        private System.Windows.Forms.TextBox ctCelsius2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox lClicks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btContador;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox ctPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtCalcular;
        private System.Windows.Forms.TextBox ctAltura;
        private System.Windows.Forms.Label IMC;
        private System.Windows.Forms.Label lClasificacion;
    }
}
