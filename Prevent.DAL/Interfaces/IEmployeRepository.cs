using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prevent.DAL.Models;

namespace Prevent.DAL.Interfaces
{
	public interface IEmployeRepository : IDisposable
	{
		IEnumerable<Employe> GetEmployes();
        Employe GetEmployeByID(int employeId);
		void InsertEmploye(Employe Employe);
		void DeleteEmploye(int employeID);
		void UpdateEmploye(Employe employe);
		void Save();
	}
}
