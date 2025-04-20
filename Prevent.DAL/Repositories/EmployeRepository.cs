using Microsoft.EntityFrameworkCore;
using Prevent.DAL.Interfaces;
using Prevent.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Repositories
{
	public class EmployeRepository(PreventDbContext context) : GenericRepository<Employe>(context), IEmployeRepository
	{
		//public async Task<Employe?> GetByName(string name)
		//{
		//    return await DbSet
		//        .AsTracking()
		//        .Where(b => b.BrandName == name)
		//        .SingleOrDefaultAsync();
		//}
		private bool disposedValue;

		public void DeleteEmploye(int employeID)
		{
			throw new NotImplementedException();
		}

		public Student GetEmployeByID(int employeId)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Employe> GetEmployes()
		{
			throw new NotImplementedException();
		}

		public void InsertEmploye(Employe Employe)
		{
			throw new NotImplementedException();
		}

		public void Save()
		{
			throw new NotImplementedException();
		}

		public void UpdateEmploye(Employe employe)
		{
			throw new NotImplementedException();
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					// TODO: supprimer l'état managé (objets managés)
				}

				// TODO: libérer les ressources non managées (objets non managés) et substituer le finaliseur
				// TODO: affecter aux grands champs une valeur null
				disposedValue = true;
			}
		}

		// // TODO: substituer le finaliseur uniquement si 'Dispose(bool disposing)' a du code pour libérer les ressources non managées
		// ~EmployeRepository()
		// {
		//     // Ne changez pas ce code. Placez le code de nettoyage dans la méthode 'Dispose(bool disposing)'
		//     Dispose(disposing: false);
		// }

		public void Dispose()
		{
			// Ne changez pas ce code. Placez le code de nettoyage dans la méthode 'Dispose(bool disposing)'
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}
}
