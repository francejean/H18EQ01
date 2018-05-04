using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjEq01_CommonForm
{
    public enum States { ADD, EDIT, CONSULT };

	public interface IButtons
	{
		bool Add();
		bool Edit();
		bool Delete();
		bool Undo();
		bool Save();

		void Go_Start();
		void Go_Back();
		void Go_Forward();
		void Go_End();

		void SetReadOnly(States state);

		void Fill();

        States State { get; set; }
	}
}
