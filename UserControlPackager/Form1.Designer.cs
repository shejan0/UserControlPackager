
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addPackageBtn = new System.Windows.Forms.Button();
            this.statsBtn = new System.Windows.Forms.Button();
            this.listPackageBtn = new System.Windows.Forms.Button();
            this.instructionsLbl = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addPackageBtn
            // 
            this.addPackageBtn.Location = new System.Drawing.Point(30, 90);
            this.addPackageBtn.Name = "addPackageBtn";
            this.addPackageBtn.Size = new System.Drawing.Size(124, 58);
            this.addPackageBtn.TabIndex = 0;
            this.addPackageBtn.Text = "Add a Package";
            this.addPackageBtn.UseVisualStyleBackColor = true;
            this.addPackageBtn.Click += new System.EventHandler(this.addPackageBtn_Click);
            // 
            // statsBtn
            // 
            this.statsBtn.Location = new System.Drawing.Point(30, 184);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(124, 58);
            this.statsBtn.TabIndex = 1;
            this.statsBtn.Text = "Stats";
            this.statsBtn.UseVisualStyleBackColor = true;
            this.statsBtn.Click += new System.EventHandler(this.statsBtn_Click);
            // 
            // listPackageBtn
            // 
            this.listPackageBtn.Location = new System.Drawing.Point(30, 274);
            this.listPackageBtn.Name = "listPackageBtn";
            this.listPackageBtn.Size = new System.Drawing.Size(124, 58);
            this.listPackageBtn.TabIndex = 2;
            this.listPackageBtn.Text = "List Packages";
            this.listPackageBtn.UseVisualStyleBackColor = true;
            this.listPackageBtn.Click += new System.EventHandler(this.listPackageBtn_Click);
            // 
            // instructionsLbl
            // 
            this.instructionsLbl.AutoSize = true;
            this.instructionsLbl.Location = new System.Drawing.Point(12, 9);
            this.instructionsLbl.MinimumSize = new System.Drawing.Size(100, 0);
            this.instructionsLbl.Name = "instructionsLbl";
            this.instructionsLbl.Size = new System.Drawing.Size(527, 51);
            this.instructionsLbl.TabIndex = 3;
            this.instructionsLbl.Text = resources.GetString("instructionsLbl.Text");
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(15, 352);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 17);
            this.errorLbl.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.instructionsLbl);
            this.Controls.Add(this.listPackageBtn);
            this.Controls.Add(this.statsBtn);
            this.Controls.Add(this.addPackageBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Shejan\'s Shipping Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Button addPackageBtn;
        private System.Windows.Forms.Button statsBtn;
        private System.Windows.Forms.Button listPackageBtn;
        private System.Windows.Forms.Label instructionsLbl;
        private System.Windows.Forms.Label errorLbl;
    }
}

