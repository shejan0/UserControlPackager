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
        UserControl userControl;
        private Controller[] controllers = { new Controller(UserIndex.One), new Controller(UserIndex.Two), new Controller(UserIndex.Three), new Controller(UserIndex.Four) };
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Enabled = true;
        }
        public void refreshList()
        {
            if(userControl is listPackageControl)
            {
                listPackageControl s = (listPackageControl)userControl;
                s.updateList();
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach(Controller c in controllers)
            {
                if (c.IsConnected)
                {
                    State state = c.GetState();
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
                    else if ((state.Gamepad.Buttons & GamepadButtonFlags.A) != 0)
                    {
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
            
            if (e.Modifiers == Keys.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.V:
                        try
                        {
                            Program.addPackage(JsonConvert.DeserializeObject<Package>(Clipboard.GetText()));
                            errorLbl.Text = "";
                        }catch(Exception ex)
                        {
                            errorLbl.Text = "Paste failed, check console for error";
                            Console.Error.WriteLine(ex);
                        }
                        break;
                    case Keys.E:
                        Program.removeTopPackage();
                        break;
                }
            }
            else if(e.Modifiers==Keys.Alt)
            {
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
            changeUserControl(new statsControl(), new Point(250, 70), new Size(150, 150));
        }
         void changeToAddPackage()
        {
            changeUserControl(new addPackageControl(), new Point(250, 70), new Size(251, 330));
        }
         void changeToListPackage()
        {
            changeUserControl(new listPackageControl(), new Point(250, 70), new Size(251, 330));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void changeUserControl(UserControl control,Point location,Size size)
        {
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
            changeToAddPackage();
        }

        private void statsBtn_Click(object sender, EventArgs e)
        {
            changeToStats();
        }

        private void listPackageBtn_Click(object sender, EventArgs e)
        {
            changeToListPackage();
        }
    }
}
