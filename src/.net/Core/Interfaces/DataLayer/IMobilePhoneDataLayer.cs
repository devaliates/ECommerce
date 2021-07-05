using Core.Interfaces.ECommerceItems;

namespace Core.Interfaces.DataLayer
{
    public interface IMobilePhoneDataLayer<T> : IAddable<T>, ICallable<T>, IRemovable<T> where T : IMobilePhone
    {
    }
}