namespace RenameFiles
{
    partial class frmPrincipal
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
            this.btnRename = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.txtRename = new System.Windows.Forms.TextBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(78, 131);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(177, 23);
            this.btnRename.TabIndex = 0;
            this.btnRename.Text = "Add Text";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(78, 63);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(177, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove Text";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(29, 37);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(226, 20);
            this.txtRemove.TabIndex = 2;
            // 
            // txtRename
            // 
            this.txtRename.Location = new System.Drawing.Point(29, 106);
            this.txtRename.Name = "txtRename";
            this.txtRename.Size = new System.Drawing.Size(226, 20);
            this.txtRename.TabIndex = 3;
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(203, 184);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(69, 23);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "END";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 219);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.txtRename);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRename);
            this.Name = "frmPrincipal";
            this.Text = "Rename Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.TextBox txtRename;
        private System.Windows.Forms.Button btnEnd;

    }
}

