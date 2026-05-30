namespace Ejercicio_8
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
            this.lsbServicios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lsbServiciosElegidos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsbServicios
            // 
            this.lsbServicios.FormattingEnabled = true;
            this.lsbServicios.Items.AddRange(new object[] {
            "Cambio de aceite",
            "Reemplazo bateria",
            "Reemplazo filtros de aire",
            "Alineación y balanceo",
            "Verificación de frenos",
            "Verificación de luces",
            "Remplazo de bobina de arranque"});
            this.lsbServicios.Location = new System.Drawing.Point(12, 28);
            this.lsbServicios.Name = "lsbServicios";
            this.lsbServicios.Size = new System.Drawing.Size(176, 108);
            this.lsbServicios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servivios:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(194, 64);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(77, 33);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar ->";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(277, 142);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(62, 37);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lsbServiciosElegidos
            // 
            this.lsbServiciosElegidos.FormattingEnabled = true;
            this.lsbServiciosElegidos.Location = new System.Drawing.Point(277, 28);
            this.lsbServiciosElegidos.Name = "lsbServiciosElegidos";
            this.lsbServiciosElegidos.Size = new System.Drawing.Size(175, 108);
            this.lsbServiciosElegidos.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 201);
            this.Controls.Add(this.lsbServiciosElegidos);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbServicios);
            this.Name = "Form1";
            this.Text = "Servicio Técnico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbServicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ListBox lsbServiciosElegidos;
    }
}

