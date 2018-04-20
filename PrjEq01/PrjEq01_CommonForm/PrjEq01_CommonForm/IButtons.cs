﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjEq01_CommonForm
{
    public enum States { ADD, EDIT, CONSULT };

	public interface IButtons
	{
		void Add();
		void Edit();
		void Delete();
		void Undo();
		bool Save();

		void Go_Start();
		void Go_Back();
		void Go_Forward();
		void Go_End();

        States State { get; set; }
	}
}
