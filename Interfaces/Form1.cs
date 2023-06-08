using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ref link:https://www.youtube.com/watch?v=XXBQOH2x90U&list=PLAIBPfq19p2EJ6JY0f5DyQfybwBGVglcR&index=56
// How to implement interfaces and why you would want to use them
/*
 * vehicle : Boat
 * PlayThing : Toy
 * 
 * IHealthState
 * 
 * isscractehd
 * deterioration float
*/
namespace Interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckFailure();
        }

        private void CheckFailure()
        {
            foreach(Control control in this.Controls)
            {
                IFailure failControl = control as IFailure;

                if(failControl != null)
                {
                    failListBox1.Items.Add(control.Name + ": " + failControl.Fails);
                }
            }
        }
    }
}
