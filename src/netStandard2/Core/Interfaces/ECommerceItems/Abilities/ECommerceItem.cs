using System;

namespace Core.Interfaces.ECommerceItems.Abilities
{
    public interface ECommerceItem : IGuidKey, ISellable
    {
        String Title { get; set; }
    }
}