using Core.Interfaces.ECommerceItems;

namespace Core.Interfaces.Services
{
    public interface ILaptopService<T> : IAddable<T>, ICallable<T>, IRemovable<T> where T : ILaptop
    {
    }
}