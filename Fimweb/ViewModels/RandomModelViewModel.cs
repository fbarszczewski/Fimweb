using Fimweb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fimweb.ViewModels
{
    public class RandomModelViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}