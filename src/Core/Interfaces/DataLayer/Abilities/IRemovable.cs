using System.Threading.Tasks;

namespace Core.Interfaces.DataLayer.Abilities
{
    public interface IRemovable<T, TKey>
    {
        T Remove(TKey key);

        Task<T> RemoveAsync(TKey key);
    }
}