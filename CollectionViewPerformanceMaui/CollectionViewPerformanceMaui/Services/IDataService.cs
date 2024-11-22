using CollectionViewPerformanceMaui.Models;

namespace CollectionViewPerformanceMaui.Services
{
	public interface IDataService
	{
		Task<List<Data>> GetData();
	}
}
