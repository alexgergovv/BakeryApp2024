using BakeryApp2024.Core.Models.Statistics;

namespace BakeryApp2024.Core.Contracts
{
	public interface IStatisticService
	{
		Task<StatisticServiceModel> TotalAsync();
	}
}
