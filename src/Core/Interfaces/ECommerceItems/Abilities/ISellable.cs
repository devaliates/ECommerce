using System;

namespace Core.Interfaces.ECommerceItems.Abilities
{
    public interface ISellable
    {
        Boolean IsSellable { get; set; }
        Decimal Price { get; set; }
        Int16 Count { get; set; }
    }
}