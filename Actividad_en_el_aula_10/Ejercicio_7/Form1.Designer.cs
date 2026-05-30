namespace Ejercicio_7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVotar = new System.Windows.Forms.Button();
            this.rbExcelente = new System.Windows.Forms.RadioButton();
            this.rbBueno = new System.Windows.Forms.RadioButton();
            this.rbInsuficiente = new System.Windows.Forms.RadioButton();
            this.rbBase = new System.Windows.Forms.RadioButton();
            this.rbFULL = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbExcelentes = new System.Windows.Forms.Label();
            this.lbBuenos = new System.Windows.Forms.Label();
            this.lbInsuficientes = new System.Windows.Forms.Label();
            this.lbBase = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbFULL = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbInsuficiente);
            this.groupBox1.Controls.Add(this.rbBueno);
            this.groupBox1.Controls.Add(this.rbExcelente);
            this.groupBox1.Location = new System.Drawing.Point(20, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opinion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFULL);
            this.groupBox2.Controls.Add(this.rbBase);
            this.groupBox2.Location = new System.Drawing.Point(20, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 78);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Producto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbFULL);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lbBase);
            this.groupBox3.Controls.Add(this.lbInsuficientes);
            this.groupBox3.Controls.Add(this.lbBuenos);
            this.groupBox3.Controls.Add(this.lbExcelentes);
            this.groupBox3.Controls.Add(this.lbTotal);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(20, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 201);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados de la encuesta";
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(171, 97);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(89, 33);
            this.btnVotar.TabIndex = 3;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // rbExcelente
            // 
            this.rbExcelente.AutoSize = true;
            this.rbExcelente.Location = new System.Drawing.Point(14, 19);
            this.rbExcelente.Name = "rbExcelente";
            this.rbExcelente.Size = new System.Drawing.Size(72, 17);
            this.rbExcelente.TabIndex = 0;
            this.rbExcelente.TabStop = true;
            this.rbExcelente.Text = "Excelente";
            this.rbExcelente.UseVisualStyleBackColor = true;
            // 
            // rbBueno
            // 
            this.rbBueno.AutoSize = true;
            this.rbBueno.Location = new System.Drawing.Point(14, 42);
            this.rbBueno.Name = "rbBueno";
            this.rbBueno.Size = new System.Drawing.Size(56, 17);
            this.rbBueno.TabIndex = 1;
            this.rbBueno.TabStop = true;
            this.rbBueno.Text = "Bueno";
            this.rbBueno.UseVisualStyleBackColor = true;
            // 
            // rbInsuficiente
            // 
            this.rbInsuficiente.AutoSize = true;
            this.rbInsuficiente.Location = new System.Drawing.Point(14, 65);
            this.rbInsuficiente.Name = "rbInsuficiente";
            this.rbInsuficiente.Size = new System.Drawing.Size(79, 17);
            this.rbInsuficiente.TabIndex = 2;
            this.rbInsuficiente.TabStop = true;
            this.rbInsuficiente.Text = "Insuficiente";
            this.rbInsuficiente.UseVisualStyleBackColor = true;
            // 
            // rbBase
            // 
            this.rbBase.AutoSize = true;
            this.rbBase.Location = new System.Drawing.Point(15, 23);
            this.rbBase.Name = "rbBase";
            this.rbBase.Size = new System.Drawing.Size(49, 17);
            this.rbBase.TabIndex = 0;
            this.rbBase.TabStop = true;
            this.rbBase.Text = "Base";
            this.rbBase.UseVisualStyleBackColor = true;
            // 
            // rbFULL
            // 
            this.rbFULL.AutoSize = true;
            this.rbFULL.Location = new System.Drawing.Point(14, 48);
            this.rbFULL.Name = "rbFULL";
            this.rbFULL.Size = new System.Drawing.Size(51, 17);
            this.rbFULL.TabIndex = 1;
            this.rbFULL.TabStop = true;
            this.rbFULL.Text = "FULL";
            this.rbFULL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Votaciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de Excelentes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de Buenos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de Insuficientes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad de Base:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(148, 26);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(10, 13);
            this.lbTotal.TabIndex = 5;
            this.lbTotal.Text = "-";
            // 
            // lbExcelentes
            // 
            this.lbExcelentes.AutoSize = true;
            this.lbExcelentes.Location = new System.Drawing.Point(148, 53);
            this.lbExcelentes.Name = "lbExcelentes";
            this.lbExcelentes.Size = new System.Drawing.Size(10, 13);
            this.lbExcelentes.TabIndex = 6;
            this.lbExcelentes.Text = "-";
            // 
            // lbBuenos
            // 
            this.lbBuenos.AutoSize = true;
            this.lbBuenos.Location = new System.Drawing.Point(148, 83);
            this.lbBuenos.Name = "lbBuenos";
            this.lbBuenos.Size = new System.Drawing.Size(10, 13);
            this.lbBuenos.TabIndex = 7;
            this.lbBuenos.Text = "-";
            // 
            // lbInsuficientes
            // 
            this.lbInsuficientes.AutoSize = true;
            this.lbInsuficientes.Location = new System.Drawing.Point(148, 111);
            this.lbInsuficientes.Name = "lbInsuficientes";
            this.lbInsuficientes.Size = new System.Drawing.Size(10, 13);
            this.lbInsuficientes.TabIndex = 8;
            this.lbInsuficientes.Text = "-";
            // 
            // lbBase
            // 
            this.lbBase.AutoSize = true;
            this.lbBase.Location = new System.Drawing.Point(148, 138);
            this.lbBase.Name = "lbBase";
            this.lbBase.Size = new System.Drawing.Size(10, 13);
            this.lbBase.TabIndex = 9;
            this.lbBase.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cantidad de FULL:";
            // 
            // lbFULL
            // 
            this.lbFULL.AutoSize = true;
            this.lbFULL.Location = new System.Drawing.Point(148, 166);
            this.lbFULL.Name = "lbFULL";
            this.lbFULL.Size = new System.Drawing.Size(10, 13);
            this.lbFULL.TabIndex = 11;
            this.lbFULL.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 411);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Encuesta de servicio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbInsuficiente;
        private System.Windows.Forms.RadioButton rbBueno;
        private System.Windows.Forms.RadioButton rbExcelente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.RadioButton rbFULL;
        private System.Windows.Forms.RadioButton rbBase;
        private System.Windows.Forms.Label lbBase;
        private System.Windows.Forms.Label lbInsuficientes;
        private System.Windows.Forms.Label lbBuenos;
        private System.Windows.Forms.Label lbExcelentes;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFULL;
        private System.Windows.Forms.Label label11;
    }
}

