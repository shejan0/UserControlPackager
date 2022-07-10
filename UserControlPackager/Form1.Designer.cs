
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
            this.addPackageControl1 = new UserControlPackager.addPackageControl();
            this.listPackageControl1 = new UserControlPackager.listPackageControl();
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
            // 
            // statsBtn
            // 
            this.statsBtn.Location = new System.Drawing.Point(39, 166);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(124, 58);
            this.statsBtn.TabIndex = 1;
            this.statsBtn.Text = "Stats";
            this.statsBtn.UseVisualStyleBackColor = true;
            // 
            // listPackageBtn
            // 
            this.listPackageBtn.Location = new System.Drawing.Point(39, 256);
            this.listPackageBtn.Name = "listPackageBtn";
            this.listPackageBtn.Size = new System.Drawing.Size(124, 58);
            this.listPackageBtn.TabIndex = 2;
            this.listPackageBtn.Text = "List Packages";
            this.listPackageBtn.UseVisualStyleBackColor = true;
            // 
            // addPackageControl1
            // 
            this.addPackageControl1.AutoSize = true;
            this.addPackageControl1.Location = new System.Drawing.Point(246, 52);
            this.addPackageControl1.Name = "addPackageControl1";
            this.addPackageControl1.Size = new System.Drawing.Size(251, 330);
            this.addPackageControl1.TabIndex = 3;
            // 
            // listPackageControl1
            // 
            this.listPackageControl1.Location = new System.Drawing.Point(540, 18);
            this.listPackageControl1.Name = "listPackageControl1";
            this.listPackageControl1.Size = new System.Drawing.Size(237, 420);
            this.listPackageControl1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listPackageControl1);
            this.Controls.Add(this.addPackageControl1);
            this.Controls.Add(this.listPackageBtn);
            this.Controls.Add(this.statsBtn);
            this.Controls.Add(this.addPackageBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPackageBtn;
        private System.Windows.Forms.Button statsBtn;
        private System.Windows.Forms.Button listPackageBtn;
        private addPackageControl addPackageControl1;
        private listPackageControl listPackageControl1;
    }
}

