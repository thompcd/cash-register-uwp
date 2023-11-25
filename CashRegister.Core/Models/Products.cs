using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace CashRegister.Core.Models
{
    /// <summary>
    /// A class for a query for products available to purchase
    /// </summary>
    /// <param name="Data">Gets the listing data for the response.</param>
    public sealed record AvailableProductsQueryResponse(int count);

    /// <summary>
    /// Basic model for a product
    /// </summary>
    /// <param name="Id"></param>
    /// <param name="Name"></param>
    /// <param name="Description"></param>
    /// <param name="price"></param>
    public sealed record Product(string Id, string Name, string? Description, double price)
    {
    }

}
