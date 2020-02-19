using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProject {
    
    public class BronseWidget : IProduct {

        private Product Product { get; set; }

        public double GetPrice() {
            return Product.GetPrice();
        }

        public BronseWidget() {
            Product = new Product {
                Code = "BW",
                Name = "Bronse Widget",
                Model = ModelType.Bronse
            };
        }
    }
}
