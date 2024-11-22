using CollectionViewPerformanceXamarin.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollectionViewPerformanceXamarin.Services
{
	public sealed class DataService : IDataService
	{
		public async Task<List<Data>> GetData()
		{
			await Task.Delay(2000);

			return Enumerable.Range(0, 100)
				.Select(x => new Data())
				.ToList();
		}
	}
}
