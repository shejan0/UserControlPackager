using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlPackager
{
    public partial class statsControl : UserControl
    {
        public statsControl()
        {
            InitializeComponent();
        }

        private void statsControl_Load(object sender, EventArgs e)
        {
            createdLbl.Text = "Created: " + Program.created;
            destroyedLbl.Text = "Removed: " + Program.destroyed;
            existsLbl.Text = "Currently exists: " + Program.packages.Count;
        }
    }
}
