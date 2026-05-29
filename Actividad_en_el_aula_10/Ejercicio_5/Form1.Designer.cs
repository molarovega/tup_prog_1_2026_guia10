namespace Ejercicio_5
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
            this.rbExcelente = new System.Windows.Forms.RadioButton();
            this.rbBueno = new System.Windows.Forms.RadioButton();
            this.rbInsuficiente = new System.Windows.Forms.RadioButton();
            this.btnVotar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbExcelentes = new System.Windows.Forms.Label();
            this.lbBuenos = new System.Windows.Forms.Label();
            this.lbInsuficientes = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVotar);
            this.groupBox1.Controls.Add(this.rbInsuficiente);
            this.groupBox1.Controls.Add(this.rbBueno);
            this.groupBox1.Controls.Add(this.rbExcelente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valoracion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbInsuficientes);
            this.groupBox2.Controls.Add(this.lbBuenos);
            this.groupBox2.Controls.Add(this.lbExcelentes);
            this.groupBox2.Controls.Add(this.lbTotal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recuento de votos";
            // 
            // rbExcelente
            // 
            this.rbExcelente.AutoSize = true;
            this.rbExcelente.Location = new System.Drawing.Point(21, 35);
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
            this.rbBueno.Location = new System.Drawing.Point(22, 66);
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
            this.rbInsuficiente.Location = new System.Drawing.Point(22, 98);
            this.rbInsuficiente.Name = "rbInsuficiente";
            this.rbInsuficiente.Size = new System.Drawing.Size(79, 17);
            this.rbInsuficiente.TabIndex = 2;
            this.rbInsuficiente.TabStop = true;
            this.rbInsuficiente.Text = "Insuficiente";
            this.rbInsuficiente.UseVisualStyleBackColor = true;
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(126, 55);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(108, 39);
            this.btnVotar.TabIndex = 3;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excelentes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de Votaciones:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Buenos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Insuficientes:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(151, 29);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(10, 13);
            this.lbTotal.TabIndex = 4;
            this.lbTotal.Text = "-";
            // 
            // lbExcelentes
            // 
            this.lbExcelentes.AutoSize = true;
            this.lbExcelentes.Location = new System.Drawing.Point(151, 62);
            this.lbExcelentes.Name = "lbExcelentes";
            this.lbExcelentes.Size = new System.Drawing.Size(10, 13);
            this.lbExcelentes.TabIndex = 5;
            this.lbExcelentes.Text = "-";
            // 
            // lbBuenos
            // 
            this.lbBuenos.AutoSize = true;
            this.lbBuenos.Location = new System.Drawing.Point(151, 95);
            this.lbBuenos.Name = "lbBuenos";
            this.lbBuenos.Size = new System.Drawing.Size(10, 13);
            this.lbBuenos.TabIndex = 6;
            this.lbBuenos.Text = "-";
            // 
            // lbInsuficientes
            // 
            this.lbInsuficientes.AutoSize = true;
            this.lbInsuficientes.Location = new System.Drawing.Point(151, 125);
            this.lbInsuficientes.Name = "lbInsuficientes";
            this.lbInsuficientes.Size = new System.Drawing.Size(10, 13);
            this.lbInsuficientes.TabIndex = 7;
            this.lbInsuficientes.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 352);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Encuesta de Servicio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.RadioButton rbInsuficiente;
        private System.Windows.Forms.RadioButton rbBueno;
        private System.Windows.Forms.RadioButton rbExcelente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbInsuficientes;
        private System.Windows.Forms.Label lbBuenos;
        private System.Windows.Forms.Label lbExcelentes;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

