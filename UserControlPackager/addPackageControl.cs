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
    public partial class addPackageControl : UserControl
    {
        public addPackageControl()
        {
            InitializeComponent();
        }
        public Package ToPackage()
        {
            return new Package(nameBox.Text, float.Parse(heightBox.Text), float.Parse(widthBox.Text), float.Parse(depthBox.Text), String.Join(" ",streetAddrBox.Lines), buildingNumBox.Text, cityBox.Text, stateBox.Text, countyBox.Text, zipCodeBox.Text);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Program.addPackage(ToPackage());
        }
    }
}
