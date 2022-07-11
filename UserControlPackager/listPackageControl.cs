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
            //initially update the list
            updateList();
        }

        public void updateList()
        {
            //function to update List used from other places
            if (Program.packages != null) //getting around Visual Studio error, not neccessary for final since it will be init by Program
            {
                //Get items object
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
            try
            {
                Program.removeTopPackage(); //Program class informs the Form1 to update this list
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
            
        }

        private void packageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when a package in the list is selected allow the user to copy the Shipping Label format.
            //check if the selected item is a package
            if(packageList.SelectedItem is Package)
            {
                Package package = (Package)packageList.SelectedItem;
                //change Textbox, since its typable it will allow copy and paste
                shippingLbl.Lines = package.ToShippingLabelString().Split('\n');
            }
        }
    }
}
