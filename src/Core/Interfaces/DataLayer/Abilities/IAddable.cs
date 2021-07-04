using System.Threading.Tasks;

namespace Core.Interfaces.DataLayer.Abilities
{
    public interface IAddable<T>
    {
        T Add(T item);

        Task<T> AddAsync(T item);
    }
}