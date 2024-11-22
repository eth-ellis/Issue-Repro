using CollectionViewPerformanceXamarin.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CollectionViewPerformanceXamarin.Services
{
	public interface IDataService
	{
		Task<List<Data>> GetData();
	}
}
