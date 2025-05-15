namespace InterfazSistemasDigitales
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
            this.lblHumo = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblObjeto = new System.Windows.Forms.Label();
            this.lblMovimiento = new System.Windows.Forms.Label();
            this.btnServo = new System.Windows.Forms.Button();
            this.btnAdelante = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblDatosRecibidos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHumo
            // 
            this.lblHumo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblHumo.Location = new System.Drawing.Point(82, 27);
            this.lblHumo.Name = "lblHumo";
            this.lblHumo.Size = new System.Drawing.Size(127, 76);
            this.lblHumo.TabIndex = 0;
            this.lblHumo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPiso
            // 
            this.lblPiso.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblPiso.Location = new System.Drawing.Point(361, 27);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(127, 76);
            this.lblPiso.TabIndex = 1;
            this.lblPiso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblObjeto
            // 
            this.lblObjeto.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblObjeto.Location = new System.Drawing.Point(82, 197);
            this.lblObjeto.Name = "lblObjeto";
            this.lblObjeto.Size = new System.Drawing.Size(127, 76);
            this.lblObjeto.TabIndex = 2;
            this.lblObjeto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMovimiento
            // 
            this.lblMovimiento.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblMovimiento.Location = new System.Drawing.Point(361, 197);
            this.lblMovimiento.Name = "lblMovimiento";
            this.lblMovimiento.Size = new System.Drawing.Size(127, 76);
            this.lblMovimiento.TabIndex = 3;
            this.lblMovimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnServo
            // 
            this.btnServo.Location = new System.Drawing.Point(609, 63);
            this.btnServo.Name = "btnServo";
            this.btnServo.Size = new System.Drawing.Size(93, 40);
            this.btnServo.TabIndex = 4;
            this.btnServo.Text = "Abrir";
            this.btnServo.UseVisualStyleBackColor = true;
            // 
            // btnAdelante
            // 
            this.btnAdelante.Location = new System.Drawing.Point(609, 138);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(93, 40);
            this.btnAdelante.TabIndex = 5;
            this.btnAdelante.Text = "Arriba";
            this.btnAdelante.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(609, 215);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(93, 40);
            this.btnAtras.TabIndex = 6;
            this.btnAtras.Text = "Abajo";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // lblDatosRecibidos
            // 
            this.lblDatosRecibidos.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblDatosRecibidos.Location = new System.Drawing.Point(217, 325);
            this.lblDatosRecibidos.Name = "lblDatosRecibidos";
            this.lblDatosRecibidos.Size = new System.Drawing.Size(127, 76);
            this.lblDatosRecibidos.TabIndex = 7;
            this.lblDatosRecibidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDatosRecibidos.Click += new System.EventHandler(this.lblDatosRecibidos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDatosRecibidos);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAdelante);
            this.Controls.Add(this.btnServo);
            this.Controls.Add(this.lblMovimiento);
            this.Controls.Add(this.lblObjeto);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.lblHumo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHumo;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblObjeto;
        private System.Windows.Forms.Label lblMovimiento;
        private System.Windows.Forms.Button btnServo;
        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblDatosRecibidos;
    }
}

