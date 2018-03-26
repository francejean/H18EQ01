using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjEq01_CommonForm
{
    public enum States { AJOUT, MODIFICATION, DESTRUCTION };

	public interface IButtons
	{
		void Add();
		void Edit();
		void Delete();
		void Undo();
		void Save();

		void Go_Start();
		void Go_Back();
		void Go_Forward();
		void Go_End();

        int State { get; set; }
	}
}
