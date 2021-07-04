using System.Threading.Tasks;

namespace Core.Interfaces.DataLayer.Abilities
{
    public interface ICallable<T, TKey>
    {
        T Get(T key);

        Task<T> GetAsync(TKey key);
    }
}