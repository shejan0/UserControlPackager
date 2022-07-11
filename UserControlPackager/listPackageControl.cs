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
    public partial class listPackageControl : UserControl
    {
        public listPackageControl()
        {
            InitializeComponent();
            updateList();
        }

        public void updateList()
        {
            if (Program.packages != null) //getting around Visual Studio error, not neccessary for final since it will be init by Program
            {
                ListBox.ObjectCollection items = packageList.Items;
                items.Clear();
                items.AddRange(Program.packages.ToArray());
            }
            else
            {
                Console.Error.WriteLine("Packages doesn't exist");
            }
            
        }
        private void listPackageControl_Load(object sender, EventArgs e)
        {
            
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            //upon Dequeue it will update with timer
            try
            {
                Program.removeTopPackage();
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
            
        }

        private void packageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(packageList.SelectedItem is Package)
            {
                Package package = (Package)packageList.SelectedItem;

                shippingLbl.Lines = package.ToShippingLabelString().Split('\n');
            }
        }
    }
}
