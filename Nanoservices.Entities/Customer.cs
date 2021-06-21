using System;
using System.Collections.Generic;
using System.Text;

namespace Nanoservices.Entities {
  public class Customer {
    public Guid Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string EmailAddress { get; set; }
  }
}
