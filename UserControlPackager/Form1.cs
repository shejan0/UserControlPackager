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
using SharpDX.XInput;
namespace UserControlPackager
{
    public partial class Form1 : Form
    {
        //handles changing User Controls and XInput operations
        UserControl userControl;
        private Controller[] controllers = { new Controller(UserIndex.One), new Controller(UserIndex.Two), new Controller(UserIndex.Three), new Controller(UserIndex.Four) };
        Timer timer; //use to check controller states
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 10; //set to 10ms, faster can cause driver overhead
            timer.Tick += Timer_Tick;
            timer.Enabled = true;
        }
        public void refreshInterface() //public reference for Program's remove and add to call here from a static reference
        {
            if(userControl is listPackageControl)
            {
                listPackageControl s = (listPackageControl)userControl;
                s.updateList();
            }
            if(userControl is statsControl)
            {
                statsControl s = (statsControl)userControl;
                s.updateStats();
            }
        }
        private void Timer_Tick(object sender, EventArgs e) //check controllers
        {
            foreach(Controller c in controllers) //check all possible controllers
            {
                if (c.IsConnected)
                {
                    State state = c.GetState();
                    //check Dpad
                    if ((state.Gamepad.Buttons & GamepadButtonFlags.DPadUp) != 0)
                    {
                        changeToStats();
                    }else if ((state.Gamepad.Buttons & GamepadButtonFlags.DPadLeft) != 0)
                    {
                        changeToAddPackage();
                    }
                    else if ((state.Gamepad.Buttons & GamepadButtonFlags.DPadRight) != 0)
                    {
                        changeToListPackage();
                    }
                    //check A and B
                    else if ((state.Gamepad.Buttons & GamepadButtonFlags.A) != 0)
                    {
                        //Clipboard and JsonConvert throw exceptions
                        try
                        {
                            Program.addPackage(JsonConvert.DeserializeObject<Package>(Clipboard.GetText()));
                        }catch(Exception ex)
                        {
                            Console.Error.WriteLine(ex);
                        }
                        
                    }
                    else if ((state.Gamepad.Buttons & GamepadButtonFlags.B) != 0)
                    {
                        Program.removeTopPackage();
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //handle button presses inside the form, use CTRL and ALT to avoid collision with text input   
            if (e.Modifiers == Keys.Control)
            {
                switch (e.KeyCode)
                {

                    case Keys.V:
                        //quick paste from Clipboard
                        try
                        {
                            //Clipboard and JsonConvert throw exceptions
                            Program.addPackage(JsonConvert.DeserializeObject<Package>(Clipboard.GetText()));
                            errorLbl.Text = "";
                        }catch(Exception ex)
                        {
                            // error caused by addPackage, probably due to incorrect Clipboard data
                            errorLbl.Text = "Paste failed, check console for error";
                            Console.Error.WriteLine(ex);
                        }
                        break;
                    case Keys.E:
                        //quick remove top
                        Program.removeTopPackage();
                        break;
                }
            }
            else if(e.Modifiers==Keys.Alt)
            {
                //change views using S,A,L
                switch (e.KeyCode)
                {
                    case Keys.S:
                        changeToStats();
                        break;
                    case Keys.A:
                        changeToAddPackage();
                        break;
                    case Keys.L:
                        changeToListPackage();
                        break;
                }
            }
        }
         void changeToStats()
        {
            //wrapper to change to Stats view from other places
            changeUserControl(new statsControl(), new Point(250, 70), new Size(150, 150));
        }
         void changeToAddPackage()
        {
            //wrapper to change to add Package view from other places
            changeUserControl(new addPackageControl(), new Point(250, 70), new Size(251, 330));
        }
         void changeToListPackage()
        {
            //wrapper to change to list Package view from other places

            changeUserControl(new listPackageControl(), new Point(250, 70), new Size(251, 330));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void changeUserControl(UserControl control,Point location,Size size)
        {
            //general function to the primary User Control for this form, any class that is a subclass of UserControl works too
            if (userControl != null)
            {
                this.Controls.Remove(userControl);
                userControl.Dispose();
            }
            userControl = control;
            SuspendLayout();
            userControl.AutoSize = true;
            userControl.Location = location;
            userControl.Name = "addPackageControl";
            userControl.Size = size;
            userControl.TabIndex = 3;
            this.Controls.Add(userControl);
            ResumeLayout();
            PerformLayout();
        }
        private void addPackageBtn_Click(object sender, EventArgs e)
        {
            //use wrapper
            changeToAddPackage();
        }

        private void statsBtn_Click(object sender, EventArgs e)
        {
            //use wrapper
            changeToStats();
        }

        private void listPackageBtn_Click(object sender, EventArgs e)
        {
            //use wrapper
            changeToListPackage();
        }
    }
}
