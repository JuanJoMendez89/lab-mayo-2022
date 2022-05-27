
namespace poo_transportes
{
    partial class MainForm
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
            this.grpOmnibus = new System.Windows.Forms.GroupBox();
            this.btnAddOmnibus = new System.Windows.Forms.Button();
            this.txtPasajerosOmnibus = new System.Windows.Forms.TextBox();
            this.lblCantidadOmnibus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddTaxi = new System.Windows.Forms.Button();
            this.txtPasajerosTaxi = new System.Windows.Forms.TextBox();
            this.lblCantidadTaxis = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalidaTaxis = new System.Windows.Forms.TextBox();
            this.txtSalidaOmnibus = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpOmnibus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOmnibus
            // 
            this.grpOmnibus.Controls.Add(this.btnAddOmnibus);
            this.grpOmnibus.Controls.Add(this.txtPasajerosOmnibus);
            this.grpOmnibus.Controls.Add(this.lblCantidadOmnibus);
            this.grpOmnibus.Location = new System.Drawing.Point(15, 12);
            this.grpOmnibus.Name = "grpOmnibus";
            this.grpOmnibus.Size = new System.Drawing.Size(313, 128);
            this.grpOmnibus.TabIndex = 1;
            this.grpOmnibus.TabStop = false;
            this.grpOmnibus.Text = "Omnibus";
            // 
            // btnAddOmnibus
            // 
            this.btnAddOmnibus.Location = new System.Drawing.Point(119, 80);
            this.btnAddOmnibus.Name = "btnAddOmnibus";
            this.btnAddOmnibus.Size = new System.Drawing.Size(75, 23);
            this.btnAddOmnibus.TabIndex = 3;
            this.btnAddOmnibus.Text = "Agregar";
            this.btnAddOmnibus.UseVisualStyleBackColor = true;
            this.btnAddOmnibus.Click += new System.EventHandler(this.btnAddOmnibus_Click);
            // 
            // txtPasajerosOmnibus
            // 
            this.txtPasajerosOmnibus.Location = new System.Drawing.Point(141, 26);
            this.txtPasajerosOmnibus.MaxLength = 3;
            this.txtPasajerosOmnibus.Name = "txtPasajerosOmnibus";
            this.txtPasajerosOmnibus.Size = new System.Drawing.Size(100, 20);
            this.txtPasajerosOmnibus.TabIndex = 2;
            this.txtPasajerosOmnibus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasajerosOmnibus_KeyPress);
            // 
            // lblCantidadOmnibus
            // 
            this.lblCantidadOmnibus.AutoSize = true;
            this.lblCantidadOmnibus.Location = new System.Drawing.Point(15, 29);
            this.lblCantidadOmnibus.Name = "lblCantidadOmnibus";
            this.lblCantidadOmnibus.Size = new System.Drawing.Size(126, 13);
            this.lblCantidadOmnibus.TabIndex = 0;
            this.lblCantidadOmnibus.Text = "Cantidad pasajeros (0/5):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddTaxi);
            this.groupBox1.Controls.Add(this.txtPasajerosTaxi);
            this.groupBox1.Controls.Add(this.lblCantidadTaxis);
            this.groupBox1.Location = new System.Drawing.Point(15, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 128);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taxi";
            // 
            // btnAddTaxi
            // 
            this.btnAddTaxi.Location = new System.Drawing.Point(119, 81);
            this.btnAddTaxi.Name = "btnAddTaxi";
            this.btnAddTaxi.Size = new System.Drawing.Size(75, 23);
            this.btnAddTaxi.TabIndex = 6;
            this.btnAddTaxi.Text = "Agregar";
            this.btnAddTaxi.UseVisualStyleBackColor = true;
            this.btnAddTaxi.Click += new System.EventHandler(this.btnAddTaxi_Click);
            // 
            // txtPasajerosTaxi
            // 
            this.txtPasajerosTaxi.Location = new System.Drawing.Point(141, 31);
            this.txtPasajerosTaxi.MaxLength = 1;
            this.txtPasajerosTaxi.Name = "txtPasajerosTaxi";
            this.txtPasajerosTaxi.Size = new System.Drawing.Size(100, 20);
            this.txtPasajerosTaxi.TabIndex = 5;
            this.txtPasajerosTaxi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasajerosTaxi_KeyPress);
            // 
            // lblCantidadTaxis
            // 
            this.lblCantidadTaxis.AutoSize = true;
            this.lblCantidadTaxis.Location = new System.Drawing.Point(14, 31);
            this.lblCantidadTaxis.Name = "lblCantidadTaxis";
            this.lblCantidadTaxis.Size = new System.Drawing.Size(126, 13);
            this.lblCantidadTaxis.TabIndex = 0;
            this.lblCantidadTaxis.Text = "Cantidad pasajeros (0/5):";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Enabled = false;
            this.btnProcesar.Location = new System.Drawing.Point(97, 314);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 7;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSalidaTaxis);
            this.groupBox2.Controls.Add(this.txtSalidaOmnibus);
            this.groupBox2.Location = new System.Drawing.Point(346, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 348);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Listado taxis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Listado omnibus:";
            // 
            // txtSalidaTaxis
            // 
            this.txtSalidaTaxis.Location = new System.Drawing.Point(16, 201);
            this.txtSalidaTaxis.Multiline = true;
            this.txtSalidaTaxis.Name = "txtSalidaTaxis";
            this.txtSalidaTaxis.ReadOnly = true;
            this.txtSalidaTaxis.Size = new System.Drawing.Size(297, 130);
            this.txtSalidaTaxis.TabIndex = 8;
            this.txtSalidaTaxis.TabStop = false;
            // 
            // txtSalidaOmnibus
            // 
            this.txtSalidaOmnibus.Location = new System.Drawing.Point(16, 39);
            this.txtSalidaOmnibus.Multiline = true;
            this.txtSalidaOmnibus.Name = "txtSalidaOmnibus";
            this.txtSalidaOmnibus.ReadOnly = true;
            this.txtSalidaOmnibus.Size = new System.Drawing.Size(297, 130);
            this.txtSalidaOmnibus.TabIndex = 7;
            this.txtSalidaOmnibus.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(178, 314);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 373);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpOmnibus);
            this.Name = "MainForm";
            this.Text = "tp1 - Poo - Transportes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpOmnibus.ResumeLayout(false);
            this.grpOmnibus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOmnibus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddOmnibus;
        private System.Windows.Forms.TextBox txtPasajerosOmnibus;
        private System.Windows.Forms.Label lblCantidadOmnibus;
        private System.Windows.Forms.Button btnAddTaxi;
        private System.Windows.Forms.TextBox txtPasajerosTaxi;
        private System.Windows.Forms.Label lblCantidadTaxis;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSalidaOmnibus;
        private System.Windows.Forms.TextBox txtSalidaTaxis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
    }
}

