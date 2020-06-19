namespace navscraper
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbx
            // 
            this.txtbx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtbx.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx.ForeColor = System.Drawing.Color.DimGray;
            this.txtbx.Location = new System.Drawing.Point(13, 12);
            this.txtbx.Name = "txtbx";
            this.txtbx.Size = new System.Drawing.Size(308, 30);
            this.txtbx.TabIndex = 0;
            this.txtbx.Text = " afadfaf";
            this.txtbx.TextChanged += new System.EventHandler(this.txtbx_TextChanged);
            this.txtbx.Leave += new System.EventHandler(this.txtbx_Leave);
            this.txtbx.Enter += new System.EventHandler(this.txtbx_Enter);
            this.txtbx.Validating += new System.ComponentModel.CancelEventHandler(this.txtbx_Validating);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtbx);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(335, 55);
            this.Tag = "Enter Value here";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx;
    }
}
