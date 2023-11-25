using CashRegister.Core.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The default <see langword="interface"/> for a service that interacts with inventory
/// </summary>
namespace CashRegister.Core.Services
{
    public interface IInventoryService
    {
        /// <summary>
        /// Request a list of all available products at a location
        /// </summary>
        /// <param name="maxItems">Maximum number of products to return</param>
        /// <returns></returns>
        Task<AvailableProductsQueryResponse> GetAvailableProductsAsync(int maxItems);
    }
}
