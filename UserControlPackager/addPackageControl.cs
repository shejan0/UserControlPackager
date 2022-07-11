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
            if (nameBox.TextLength != 0 &&
                heightBox.TextLength != 0 &&
                widthBox.TextLength != 0 &&
                depthBox.TextLength != 0 &&
                weightBox.TextLength != 0 &&
                streetAddrBox.TextLength != 0 &&
                cityBox.TextLength != 0 &&
                stateBox.TextLength != 0 &&
                countyBox.TextLength != 0 &&
                zipCodeBox.TextLength != 0)
            {
                return new Package(nameBox.Text, float.Parse(heightBox.Text), float.Parse(widthBox.Text), float.Parse(depthBox.Text), float.Parse(weightBox.Text), String.Join(" ", streetAddrBox.Lines), buildingNumBox.Text, cityBox.Text, stateBox.Text, countyBox.Text, zipCodeBox.Text);
            }
            else
            {
                Console.Error.WriteLine("Incomplete boxes on insertion");
                return null;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Package p = ToPackage();
            if (p == null)
            {
                addBtn.Text = "Fields not complete, click to retry";

            }
            else
            {
                Program.addPackage(p);
                addBtn.Text = "Add Package";
            }
            
            

        }
    }
}
