using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjEq01_Application
{
    interface IInfoBox
    {
        void SetReadOnly(PrjEq01_CommonForm.States state);
		void WipeInformation();
    }
}
