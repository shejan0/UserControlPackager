
namespace UserControlPackager
{
    partial class listPackageControl
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
            this.packageList = new System.Windows.Forms.ListBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // packageList
            // 
            this.packageList.FormattingEnabled = true;
            this.packageList.ItemHeight = 16;
            this.packageList.Location = new System.Drawing.Point(19, 18);
            this.packageList.Name = "packageList";
            this.packageList.Size = new System.Drawing.Size(198, 340);
            this.packageList.TabIndex = 0;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(19, 364);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(198, 53);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Text = "Remove Top Package";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // listPackageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.packageList);
            this.Name = "listPackageControl";
            this.Size = new System.Drawing.Size(237, 420);
            this.Load += new System.EventHandler(this.listPackageControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox packageList;
        private System.Windows.Forms.Button removeBtn;
    }
}
