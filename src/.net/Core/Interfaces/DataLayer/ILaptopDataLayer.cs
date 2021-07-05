using Core.Interfaces.ECommerceItems;

namespace Core.Interfaces.DataLayer
{
    public interface ILaptopDataLayer<T> : IAddable<T>, ICallable<T>, IRemovable<T> where T : ILaptop
    {
    }
}