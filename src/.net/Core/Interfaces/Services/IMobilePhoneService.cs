using Core.Interfaces.ECommerceItems;

namespace Core.Interfaces.Services
{
    public interface IMobilePhoneService<T> : IAddable<T>, ICallable<T>, IRemovable<T> where T : IMobilePhone
    {
    }
}