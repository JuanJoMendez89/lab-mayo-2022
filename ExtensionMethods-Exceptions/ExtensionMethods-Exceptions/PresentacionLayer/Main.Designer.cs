
namespace PresentacionLayer
{
    partial class Main
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
            this.btnPuntoUno = new System.Windows.Forms.Button();
            this.btnPuntoDos = new System.Windows.Forms.Button();
            this.btnPuntoTres = new System.Windows.Forms.Button();
            this.btnPuntoCuatro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPuntoUno
            // 
            this.btnPuntoUno.Location = new System.Drawing.Point(119, 65);
            this.btnPuntoUno.Name = "btnPuntoUno";
            this.btnPuntoUno.Size = new System.Drawing.Size(75, 23);
            this.btnPuntoUno.TabIndex = 0;
            this.btnPuntoUno.Text = "Punto nº 1";
            this.btnPuntoUno.UseVisualStyleBackColor = true;
            this.btnPuntoUno.Click += new System.EventHandler(this.btnPuntoUno_Click);
            // 
            // btnPuntoDos
            // 
            this.btnPuntoDos.Location = new System.Drawing.Point(119, 114);
            this.btnPuntoDos.Name = "btnPuntoDos";
            this.btnPuntoDos.Size = new System.Drawing.Size(75, 23);
            this.btnPuntoDos.TabIndex = 1;
            this.btnPuntoDos.Text = "Punto nº 2";
            this.btnPuntoDos.UseVisualStyleBackColor = true;
            this.btnPuntoDos.Click += new System.EventHandler(this.btnPuntoDos_Click);
            // 
            // btnPuntoTres
            // 
            this.btnPuntoTres.Location = new System.Drawing.Point(119, 164);
            this.btnPuntoTres.Name = "btnPuntoTres";
            this.btnPuntoTres.Size = new System.Drawing.Size(75, 23);
            this.btnPuntoTres.TabIndex = 2;
            this.btnPuntoTres.Text = "Punto nº 3";
            this.btnPuntoTres.UseVisualStyleBackColor = true;
            this.btnPuntoTres.Click += new System.EventHandler(this.btnPuntoTres_Click);
            // 
            // btnPuntoCuatro
            // 
            this.btnPuntoCuatro.Location = new System.Drawing.Point(119, 217);
            this.btnPuntoCuatro.Name = "btnPuntoCuatro";
            this.btnPuntoCuatro.Size = new System.Drawing.Size(75, 23);
            this.btnPuntoCuatro.TabIndex = 3;
            this.btnPuntoCuatro.Text = "Punto nº4";
            this.btnPuntoCuatro.UseVisualStyleBackColor = true;
            this.btnPuntoCuatro.Click += new System.EventHandler(this.btnPuntoCuatro_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 304);
            this.Controls.Add(this.btnPuntoCuatro);
            this.Controls.Add(this.btnPuntoTres);
            this.Controls.Add(this.btnPuntoDos);
            this.Controls.Add(this.btnPuntoUno);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExtensionMethods + Exceptions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPuntoUno;
        private System.Windows.Forms.Button btnPuntoDos;
        private System.Windows.Forms.Button btnPuntoTres;
        private System.Windows.Forms.Button btnPuntoCuatro;
    }
}

