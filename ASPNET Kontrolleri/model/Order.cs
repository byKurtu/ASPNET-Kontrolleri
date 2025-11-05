using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET_Kontrolleri.model
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string ShipName { get; set; }
        public decimal? Freight { get; set; }
        public string ShipCountry { get; set; }
        public string ShipCity { get; set; }
        public string ShipAddress { get; set; }
        public string ShipPostalCode { get; set; }
    }
}