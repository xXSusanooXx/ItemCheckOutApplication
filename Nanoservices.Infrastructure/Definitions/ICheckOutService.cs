using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Nanoservices.Entities;

namespace Nanoservices.Infrastructure.Definitions {
  public interface ICheckOutService {
    public Task<List<CartItem>> GetAllCartItems();
    public Task<List<Product>> GetAllProducts();
    public Task<List<Customer>> GetAllCustomers();
    public Task<bool> IsItemAvailable(string productCode);
    public Task<bool> AddItemToCart(CartItem cartItem);
    public Task<bool> ProcessPayment(CartItem cartItem);
    public Task<bool> SendConfirmation(CartItem cartItem);
    public Task<bool> UpdateStock(CartItem cartItem);
  }
}
