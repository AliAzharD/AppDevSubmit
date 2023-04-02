using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THA_W5_ALI_AZHAR_D
{
    internal class Class_Product
    {
        public string IDProduct;
        public string NameProduct;
        public string Harga;
        public string stock;
        public string IDCategory;

        public Class_Product(string iDProduct, string nameProduct, string harga, string stock, string iDCategory)
        {
            IDProduct = iDProduct;
            NameProduct = nameProduct;
            Harga = harga;
            this.stock = stock;
            IDCategory = iDCategory;
        }

        public string getIDProduct() 
        { 
            return IDProduct; 
        }
        public string getNameProduct()
        {
            return NameProduct;
        }
        public string getHarga()
        {
            return Harga;
        }
        public string getstock() 
        { 
            return stock;
        }
        public string getIDCategory()
        {
            return IDCategory;
        }
        public void setIDCategory(string IDcategory)
        {
            this.IDCategory = IDcategory;
        }
        public void setIDProduct(string IDproduct)
        {
            this.IDProduct = IDproduct;
        }
        public void setNameProduct(string Nameproduct)
        {
            this.NameProduct = Nameproduct;
        }
        public void setHarga(string Harga)
        {
            this.Harga = Harga;
        }
        public void setstock(string Stock)
        {
            this.stock = Stock;
        }
        
    }
}
