using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //Bu tip classlarda sadece özellikler bulunur.
        //CRUD operasyonları başka sınıflarda tutulur.
        
        public int Id { get; set; } // Ürün Id
        public int CategoryId { get; set; }  // referans anahtarları genellikle ikinci sıraya yazılır
        public string ProductName { get; set; } // ürün ismi
        public double  UnitPrice { get; set; } // Ürün fiyatı
        public int UnitInStock { get; set; } // Ürün stok adeti









    }
}
