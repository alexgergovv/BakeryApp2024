namespace BakeryApp2024.Infrastructure.Data.Common
{
	public interface IRepository
	{
		IQueryable<T> All<T>() where T : class;
		IQueryable<T> AllReadOnly<T>() where T : class;
	}
}
