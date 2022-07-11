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
        //simple Stats interface
        public statsControl()
        {
            InitializeComponent();
        }
        public void updateStats() //callable from Form, updates the stats when changes are made
        {
            //update the form text with current stats from Program class.
            createdLbl.Text = "Created: " + Program.created;
            destroyedLbl.Text = "Removed: " + Program.destroyed;
            if (Program.packages != null) //Visual Studio work around
            {
                existsLbl.Text = "Currently exists: " + Program.packages.Count;
            }
        }
        private void statsControl_Load(object sender, EventArgs e)
        {
            updateStats(); 
        }
    }
}
