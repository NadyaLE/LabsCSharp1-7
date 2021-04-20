using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypeLibrary {
	public interface ILab4 {
		string[] GetAvailableVariables();
		void SetVariable(string variable, object val);
		double GetResult();
		int GetVariant();
	}
}
