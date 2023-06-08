using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    class FailListBox : ListBox, IFailure
    {
        public bool HasFailed
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Fails
        {
            get
            {
                return 0;
            }
            set
            {
                
            }
        }
    }
}
