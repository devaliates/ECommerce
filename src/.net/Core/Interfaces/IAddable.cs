using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAddable<T>
    {
        T Add(T item);

        Task<T> AddAsync(T item);
    }
}