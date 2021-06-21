using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Nanoservices.Entities;

namespace Nanoservices.Infrastructure.Definitions {
  public interface ICheckOutRepository {
    Task<List<CartItem>> GetAllCartItems();

    Task<List<Product>> GetAllProducts();
    
    Task<List<Customer>> GetAllCustomers();
    
    public Task<bool> IsItemAvailable(string productCode);
    
    public Task<bool> AddItemToCart(CartItem cartItem);
    
    public Task<bool> ProcessPayment(CartItem cartItem);
    
    public Task<bool> SendConfirmation(CartItem cartItem);
    
    public Task<bool> UpdateStock(CartItem cartItem);
  }
}
