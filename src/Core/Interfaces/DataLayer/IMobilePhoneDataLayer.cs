using Core.Interfaces.DataLayer.Abilities;
using Core.Interfaces.ECommerceItems;

namespace Core.Interfaces.DataLayer
{
    public interface IMobilePhoneDataLayer<T, TKey> : IAddable<T>, ICallable<T, TKey>, IRemovable<T, TKey> where T : IMobilePhone
    {
    }
}