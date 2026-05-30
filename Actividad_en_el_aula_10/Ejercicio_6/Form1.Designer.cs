namespace Ejercicio_6
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
            this.chbNoSiempreSeDebeInicializar = new System.Windows.Forms.CheckBox();
            this.chbNuncaDebeInicializarse = new System.Windows.Forms.CheckBox();
            this.chbSiempreDebeInicializarse = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResponder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbNoSiempreSeDebeInicializar
            // 
            this.chbNoSiempreSeDebeInicializar.AutoSize = true;
            this.chbNoSiempreSeDebeInicializar.Location = new System.Drawing.Point(48, 33);
            this.chbNoSiempreSeDebeInicializar.Name = "chbNoSiempreSeDebeInicializar";
            this.chbNoSiempreSeDebeInicializar.Size = new System.Drawing.Size(165, 17);
            this.chbNoSiempreSeDebeInicializar.TabIndex = 0;
            this.chbNoSiempreSeDebeInicializar.Text = "No siempre se debe inicializar";
            this.chbNoSiempreSeDebeInicializar.UseVisualStyleBackColor = true;
            // 
            // chbNuncaDebeInicializarse
            // 
            this.chbNuncaDebeInicializarse.AutoSize = true;
            this.chbNuncaDebeInicializarse.Location = new System.Drawing.Point(48, 56);
            this.chbNuncaDebeInicializarse.Name = "chbNuncaDebeInicializarse";
            this.chbNuncaDebeInicializarse.Size = new System.Drawing.Size(141, 17);
            this.chbNuncaDebeInicializarse.TabIndex = 1;
            this.chbNuncaDebeInicializarse.Text = "Nunca debe inicializarse";
            this.chbNuncaDebeInicializarse.UseVisualStyleBackColor = true;
            // 
            // chbSiempreDebeInicializarse
            // 
            this.chbSiempreDebeInicializarse.AutoSize = true;
            this.chbSiempreDebeInicializarse.Location = new System.Drawing.Point(48, 79);
            this.chbSiempreDebeInicializarse.Name = "chbSiempreDebeInicializarse";
            this.chbSiempreDebeInicializarse.Size = new System.Drawing.Size(147, 17);
            this.chbSiempreDebeInicializarse.TabIndex = 2;
            this.chbSiempreDebeInicializarse.Text = "Siempre debe inicializarse";
            this.chbSiempreDebeInicializarse.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Una variable local:";
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(244, 45);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(73, 36);
            this.btnResponder.TabIndex = 5;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnResponder);
            this.groupBox1.Controls.Add(this.chbSiempreDebeInicializarse);
            this.groupBox1.Controls.Add(this.chbNuncaDebeInicializarse);
            this.groupBox1.Controls.Add(this.chbNoSiempreSeDebeInicializar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 107);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marque las opciones verdaderas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Resultado:";
            // 
            // lbResultado
            // 
            this.lbResultado.Location = new System.Drawing.Point(67, 135);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(297, 50);
            this.lbResultado.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 194);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Examen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbNoSiempreSeDebeInicializar;
        private System.Windows.Forms.CheckBox chbNuncaDebeInicializarse;
        private System.Windows.Forms.CheckBox chbSiempreDebeInicializarse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbResultado;
    }
}

