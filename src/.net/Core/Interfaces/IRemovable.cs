using System;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRemovable<T>
    {
        T Remove(Guid id);

        Task<T> RemoveAsync(Guid id);
    }
}