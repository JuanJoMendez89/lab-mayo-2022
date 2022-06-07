
namespace Practica.EF.UI.Forms
{
    partial class BaseForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(632, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(713, 24);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(713, 382);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvGrid
            // 
            this.dgvGrid.AllowUserToAddRows = false;
            this.dgvGrid.AllowUserToDeleteRows = false;
            this.dgvGrid.AllowUserToResizeColumns = false;
            this.dgvGrid.AllowUserToResizeRows = false;
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGrid.Location = new System.Drawing.Point(12, 53);
            this.dgvGrid.MultiSelect = false;
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.ReadOnly = true;
            this.dgvGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrid.Size = new System.Drawing.Size(776, 323);
            this.dgvGrid.TabIndex = 3;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvGrid);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button btnAdd;
        protected System.Windows.Forms.Button btnEdit;
        protected System.Windows.Forms.Button btnDelete;
        protected System.Windows.Forms.DataGridView dgvGrid;
    }
}