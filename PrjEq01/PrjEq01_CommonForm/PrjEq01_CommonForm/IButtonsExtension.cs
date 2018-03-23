using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjEq01_Application
{
    public static class IButtonsExtension
    {
        public static void AddExt(this PrjEq01_CommonForm.IButtons Ibutton)
        {
            Ibutton.State = (int)PrjEq01_CommonForm.States.AJOUT;
            Ibutton.Add();

        }

        public static void EditExt(this PrjEq01_CommonForm.IButtons Ibutton)
        {
            Ibutton.State = (int)PrjEq01_CommonForm.States.MODIFICATION;
            Ibutton.Edit();
        }

        public static void DeleteExt(this PrjEq01_CommonForm.IButtons Ibutton)
        {
            Ibutton.State = (int)PrjEq01_CommonForm.States.DESTRUCTION;
            Ibutton.Delete();
        }
    }
}
