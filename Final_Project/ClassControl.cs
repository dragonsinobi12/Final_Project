using Final_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class ClassControl:CSV                                                                                               
    {
        private List<Product> dataA = new List<Product>();
        public void addMember(int id, string tpye, string brand, string product_name, int amount)
        {
            Product newDataA = new Product()
            {
                ID = id,
                TPYE = tpye,
                BRAND = brand,
                PRODUCT_NAME = product_name,
                AMOUNT = amount


            };
            this.dataA.Add(newDataA);
        }

        public List<Product> getDataA()
        {
            return this.dataA;
        }                                                                                                                                                                                                                                                           
    }
}
