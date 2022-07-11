using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace UserControlPackager
{
    public partial class Form1 : Form
    {
        UserControl userControl;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addPackageBtn_Click(object sender, EventArgs e)
        {
            if (userControl != null)
            {
                this.Controls.Remove(userControl);
                userControl.Dispose();
            }
            userControl = new addPackageControl();
            SuspendLayout();
            userControl.AutoSize = true;
            userControl.Location = new Point(250, 30);
            userControl.Name = "addPackageControl";
            userControl.Size = new Size(251, 330);
            userControl.TabIndex = 3;
            this.Controls.Add(userControl);
            ResumeLayout();
            PerformLayout();
        }

        private void statsBtn_Click(object sender, EventArgs e)
        {
            if (userControl != null)
            {
                this.Controls.Remove(userControl);
                userControl.Dispose();
            }
            userControl = new statsControl();
            SuspendLayout();
            userControl.AutoSize = true;
            userControl.Location = new Point(250, 30);
            userControl.Name = "addPackageControl";
            userControl.Size = new Size(150, 150);
            userControl.TabIndex = 3;
            this.Controls.Add(userControl);
            ResumeLayout();
            PerformLayout();
        }

        private void listPackageBtn_Click(object sender, EventArgs e)
        {
            if (userControl != null)
            {
                this.Controls.Remove(userControl);
                userControl.Dispose();
            }
            userControl = new listPackageControl();
            SuspendLayout();
            userControl.AutoSize = true;
            userControl.Location = new Point(250, 20);
            userControl.Name = "addPackageControl";
            userControl.Size = new Size(251, 330);
            userControl.TabIndex = 3;
            this.Controls.Add(userControl);
            ResumeLayout();
            PerformLayout();
        }
    }
}
