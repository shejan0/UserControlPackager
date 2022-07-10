
namespace UserControlPackager
{
    partial class statsControl
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
            this.createdLbl = new System.Windows.Forms.Label();
            this.destroyedLbl = new System.Windows.Forms.Label();
            this.existsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createdLbl
            // 
            this.createdLbl.AutoSize = true;
            this.createdLbl.Location = new System.Drawing.Point(3, 24);
            this.createdLbl.Name = "createdLbl";
            this.createdLbl.Size = new System.Drawing.Size(46, 17);
            this.createdLbl.TabIndex = 0;
            this.createdLbl.Text = "label1";
            // 
            // destroyedLbl
            // 
            this.destroyedLbl.AutoSize = true;
            this.destroyedLbl.Location = new System.Drawing.Point(3, 53);
            this.destroyedLbl.Name = "destroyedLbl";
            this.destroyedLbl.Size = new System.Drawing.Size(46, 17);
            this.destroyedLbl.TabIndex = 1;
            this.destroyedLbl.Text = "label1";
            // 
            // existsLbl
            // 
            this.existsLbl.AutoSize = true;
            this.existsLbl.Location = new System.Drawing.Point(3, 85);
            this.existsLbl.Name = "existsLbl";
            this.existsLbl.Size = new System.Drawing.Size(46, 17);
            this.existsLbl.TabIndex = 2;
            this.existsLbl.Text = "label1";
            // 
            // statsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.existsLbl);
            this.Controls.Add(this.destroyedLbl);
            this.Controls.Add(this.createdLbl);
            this.Name = "statsControl";
            this.Load += new System.EventHandler(this.statsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createdLbl;
        private System.Windows.Forms.Label destroyedLbl;
        private System.Windows.Forms.Label existsLbl;
    }
}
