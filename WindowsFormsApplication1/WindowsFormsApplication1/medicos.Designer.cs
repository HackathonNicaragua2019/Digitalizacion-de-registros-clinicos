namespace WindowsFormsApplication1
{
    partial class medicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medicos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblfuncion = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblespecialidad = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cerrar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección";
            // 
            // lbltelefono
            // 
            this.lbltelefono.BackColor = System.Drawing.Color.Silver;
            this.lbltelefono.Location = new System.Drawing.Point(114, 261);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(324, 29);
            this.lbltelefono.TabIndex = 3;
            // 
            // lblcodigo
            // 
            this.lblcodigo.BackColor = System.Drawing.Color.Silver;
            this.lblcodigo.Location = new System.Drawing.Point(114, 300);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(324, 29);
            this.lblcodigo.TabIndex = 4;
            // 
            // lblusuario
            // 
            this.lblusuario.BackColor = System.Drawing.Color.Silver;
            this.lblusuario.Location = new System.Drawing.Point(114, 104);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(324, 29);
            this.lblusuario.TabIndex = 5;
            // 
            // lblnombre
            // 
            this.lblnombre.BackColor = System.Drawing.Color.Silver;
            this.lblnombre.Location = new System.Drawing.Point(114, 65);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(324, 29);
            this.lblnombre.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Especialidad";
            // 
            // lblfuncion
            // 
            this.lblfuncion.BackColor = System.Drawing.Color.Silver;
            this.lblfuncion.Location = new System.Drawing.Point(114, 181);
            this.lblfuncion.Name = "lblfuncion";
            this.lblfuncion.Size = new System.Drawing.Size(324, 30);
            this.lblfuncion.TabIndex = 8;
            // 
            // lbldireccion
            // 
            this.lbldireccion.BackColor = System.Drawing.Color.Silver;
            this.lbldireccion.Location = new System.Drawing.Point(114, 138);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(324, 29);
            this.lbldireccion.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Codigo Minsa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "N teléfono";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "Función";
            // 
            // lblespecialidad
            // 
            this.lblespecialidad.BackColor = System.Drawing.Color.Silver;
            this.lblespecialidad.Location = new System.Drawing.Point(114, 226);
            this.lblespecialidad.Name = "lblespecialidad";
            this.lblespecialidad.Size = new System.Drawing.Size(324, 29);
            this.lblespecialidad.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(324, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 38);
            this.label15.TabIndex = 14;
            this.label15.Text = "Medicos";
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(475, 245);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(226, 39);
            this.cerrar.TabIndex = 47;
            this.cerrar.Text = "Cerrar sesión";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(475, 200);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(226, 39);
            this.button5.TabIndex = 46;
            this.button5.Text = "Cambiar contraseña";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(475, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(226, 39);
            this.button4.TabIndex = 45;
            this.button4.Text = "Cambiar nombre de usuario";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(475, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 39);
            this.button3.TabIndex = 44;
            this.button3.Text = "Atender consultas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 39);
            this.button1.TabIndex = 48;
            this.button1.Text = "Buscar paciente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // medicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblespecialidad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.lblfuncion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "medicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atención de la población";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.medicos_FormClosed);
            this.Load += new System.EventHandler(this.medicos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblfuncion;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblespecialidad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}