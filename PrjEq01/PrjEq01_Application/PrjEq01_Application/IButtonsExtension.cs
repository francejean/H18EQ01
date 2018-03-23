using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjEq01_Application
{
    public static class IButtonsExtension
    {
        public static void Add(this PrjEq01_CommonForm.IButtons Ibutton)
        {
            Ibutton.State = (int)PrjEq01_CommonForm.States.AJOUT;
        }

        public static void Edit(this PrjEq01_CommonForm.IButtons Ibutton)
        {
            Ibutton.State = (int)PrjEq01_CommonForm.States.MODIFICATION;
        }

        public static void Delete(this PrjEq01_CommonForm.IButtons Ibutton)
        {
            Ibutton.State = (int)PrjEq01_CommonForm.States.DESTRUCTION;
        }
    }
}
