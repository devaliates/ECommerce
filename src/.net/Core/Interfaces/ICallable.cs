using System;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICallable<T>
    {
        T Get(Guid id);

        Task<T> GetAsync(Guid id);
    }
}