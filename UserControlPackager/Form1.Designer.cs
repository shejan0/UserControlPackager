
namespace UserControlPackager
{
    partial class Form1
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
            this.addPackageBtn = new System.Windows.Forms.Button();
            this.statsBtn = new System.Windows.Forms.Button();
            this.listPackageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPackageBtn
            // 
            this.addPackageBtn.Location = new System.Drawing.Point(39, 72);
            this.addPackageBtn.Name = "addPackageBtn";
            this.addPackageBtn.Size = new System.Drawing.Size(124, 58);
            this.addPackageBtn.TabIndex = 0;
            this.addPackageBtn.Text = "Add a Package";
            this.addPackageBtn.UseVisualStyleBackColor = true;
            this.addPackageBtn.Click += new System.EventHandler(this.addPackageBtn_Click);
            // 
            // statsBtn
            // 
            this.statsBtn.Location = new System.Drawing.Point(39, 166);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(124, 58);
            this.statsBtn.TabIndex = 1;
            this.statsBtn.Text = "Stats";
            this.statsBtn.UseVisualStyleBackColor = true;
            this.statsBtn.Click += new System.EventHandler(this.statsBtn_Click);
            // 
            // listPackageBtn
            // 
            this.listPackageBtn.Location = new System.Drawing.Point(39, 256);
            this.listPackageBtn.Name = "listPackageBtn";
            this.listPackageBtn.Size = new System.Drawing.Size(124, 58);
            this.listPackageBtn.TabIndex = 2;
            this.listPackageBtn.Text = "List Packages";
            this.listPackageBtn.UseVisualStyleBackColor = true;
            this.listPackageBtn.Click += new System.EventHandler(this.listPackageBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.listPackageBtn);
            this.Controls.Add(this.statsBtn);
            this.Controls.Add(this.addPackageBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addPackageBtn;
        private System.Windows.Forms.Button statsBtn;
        private System.Windows.Forms.Button listPackageBtn;
    }
}

