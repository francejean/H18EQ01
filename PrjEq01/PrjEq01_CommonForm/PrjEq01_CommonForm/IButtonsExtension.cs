using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjEq01_CommonForm
{
    public static class IButtonsExtension
    {
        public static void AddExt(this PrjEq01_CommonForm.IButtons Ibutton)
        {
            Ibutton.State = PrjEq01_CommonForm.States.ADD;
            Ibutton.Add();

        }

        public static void EditExt(this PrjEq01_CommonForm.IButtons Ibutton)
        {
            Ibutton.State = PrjEq01_CommonForm.States.EDIT;
            Ibutton.Edit();
        }

        public static void DeleteExt(this PrjEq01_CommonForm.IButtons Ibutton)
        {
            Ibutton.State = PrjEq01_CommonForm.States.DELETE;
            Ibutton.Delete();
        }

        public static void UndoExt(this PrjEq01_CommonForm.IButtons Ibutton)
        {
            Ibutton.State = PrjEq01_CommonForm.States.UNDO;
            Ibutton.Undo();
        }

        public static void SaveExt(this PrjEq01_CommonForm.IButtons Ibutton)
        {
            Ibutton.State = PrjEq01_CommonForm.States.SAVE;
            Ibutton.Save();
        }

        public static void Go_StartExt(this PrjEq01_CommonForm.IButtons Ibutton)
        {
            Ibutton.State = PrjEq01_CommonForm.States.MOVE;
            Ibutton.Go_Start();
        }

        public static void Go_BackExt(this PrjEq01_CommonForm.IButtons Ibutton)
        {
            Ibutton.State = PrjEq01_CommonForm.States.MOVE;
            Ibutton.Go_Back();
        }

        public static void Go_ForwardExt(this PrjEq01_CommonForm.IButtons Ibutton)
        {
            Ibutton.State = PrjEq01_CommonForm.States.MOVE;
            Ibutton.Go_Forward();
        }

        public static void Go_EndExt(this PrjEq01_CommonForm.IButtons Ibutton)
        {
            Ibutton.State = PrjEq01_CommonForm.States.MOVE;
            Ibutton.Go_End();
        }
    }
}
