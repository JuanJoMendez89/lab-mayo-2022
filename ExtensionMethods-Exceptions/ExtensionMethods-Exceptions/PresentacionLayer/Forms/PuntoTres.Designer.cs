
namespace PresentacionLayer.Forms
{
    partial class PuntoTres
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
            this.btnDispararExcepcion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDispararExcepcion
            // 
            this.btnDispararExcepcion.Location = new System.Drawing.Point(119, 51);
            this.btnDispararExcepcion.Name = "btnDispararExcepcion";
            this.btnDispararExcepcion.Size = new System.Drawing.Size(75, 23);
            this.btnDispararExcepcion.TabIndex = 0;
            this.btnDispararExcepcion.Text = "Disparar Ex.";
            this.btnDispararExcepcion.UseVisualStyleBackColor = true;
            this.btnDispararExcepcion.Click += new System.EventHandler(this.btnDispararExcepcion_Click);
            // 
            // PuntoTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 124);
            this.Controls.Add(this.btnDispararExcepcion);
            this.Name = "PuntoTres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PuntoTres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PuntoTres_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDispararExcepcion;
    }
}