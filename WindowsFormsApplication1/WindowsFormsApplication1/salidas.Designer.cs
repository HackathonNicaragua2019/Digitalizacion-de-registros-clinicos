namespace WindowsFormsApplication1
{
    partial class salidas
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.depositoDataSet = new WindowsFormsApplication1.depositoDataSet();
            this.existenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.existenciaTableAdapter = new WindowsFormsApplication1.depositoDataSetTableAdapters.existenciaTableAdapter();
            this.depositoDataSet1 = new WindowsFormsApplication1.depositoDataSet1();
            this.existenciaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.existenciaTableAdapter1 = new WindowsFormsApplication1.depositoDataSet1TableAdapters.existenciaTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.depositoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.existenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.existenciaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Responsable de farmacia:";
            // 
            // nombre
            // 
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nombre.Location = new System.Drawing.Point(220, 9);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(366, 46);
            this.nombre.TabIndex = 1;
            this.nombre.Click += new System.EventHandler(this.nombre_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medicamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Registro de egresos de farmacia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(278, 132);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 25);
            this.textBox2.TabIndex = 9;
            // 
            // depositoDataSet
            // 
            this.depositoDataSet.DataSetName = "depositoDataSet";
            this.depositoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // existenciaBindingSource
            // 
            this.existenciaBindingSource.DataMember = "existencia";
            this.existenciaBindingSource.DataSource = this.depositoDataSet;
            // 
            // existenciaTableAdapter
            // 
            this.existenciaTableAdapter.ClearBeforeFill = true;
            // 
            // depositoDataSet1
            // 
            this.depositoDataSet1.DataSetName = "depositoDataSet1";
            this.depositoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // existenciaBindingSource1
            // 
            this.existenciaBindingSource1.DataMember = "existencia";
            this.existenciaBindingSource1.DataSource = this.depositoDataSet1;
            // 
            // existenciaTableAdapter1
            // 
            this.existenciaTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 99);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 25);
            this.textBox1.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(278, 165);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 25);
            this.textBox3.TabIndex = 14;
            // 
            // salidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 213);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "salidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salidas";
            this.Load += new System.EventHandler(this.salidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depositoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.existenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.existenciaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private depositoDataSet depositoDataSet;
        private System.Windows.Forms.BindingSource existenciaBindingSource;
        private depositoDataSetTableAdapters.existenciaTableAdapter existenciaTableAdapter;
        private depositoDataSet1 depositoDataSet1;
        private System.Windows.Forms.BindingSource existenciaBindingSource1;
        private depositoDataSet1TableAdapters.existenciaTableAdapter existenciaTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
    }
}