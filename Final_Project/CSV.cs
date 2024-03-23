using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;
using System.Collections;

namespace Final_Project
{
    public class CSV
    {
        private string path = @"D:\Labtest\Final_Project\output\outputfile.csv";
        private List<Product> dataA = new List<Product>();
        
        
        public bool SavetoFile(List<Product> dataA)
        {
            

            bool result = false;
            if (dataA.Count == 0)
                return result;
            //save to csv file
            string content = string.Empty;
            foreach (Product pd in dataA)
            {
                content += pd.ID + "," +
                    pd.TPYE + "," +
                    pd.BRAND + "," +
                    pd.PRODUCT_NAME + "," +
                    pd.AMOUNT + "\r\n";
            }
            try
            {
                //write to file
                File.WriteAllText(path, content);
                result = true;
                //0980093741
            }
            catch (Exception ex)
            {
                return result;
            }

            return result;
        }
        public bool SavetoFile2(List<Product> dataA)
        {


            bool result = false;
            if (dataA.Count == 0)
                return result;
            //save to csv file
            string content = string.Empty;
            foreach (Product pd in dataA)
            {
                content += pd.ID + "," +
                    pd.TPYE + "," +
                    pd.BRAND + "," +
                    pd.PRODUCT_NAME + "," +
                    pd.AMOUNT + "\r\n";
            }
            try
            {
                //write to file
                File.AppendAllText(path, content);
                result = true;
                                dataA.Clear();

                //0980093741
            }
            catch (Exception ex)
            {
                return result;
            }

            return result;
        }
        public bool ReadFromFile()
        {
            bool result = false;
            try
            {
                //read file
                string content = File.ReadAllText(path);
                string[] row = content.Split("\r\n");
                if (row.Length > 0)
                {
                    this.dataA.Clear();
                    foreach (string line in row)
                    {
                        string[] data = line.Split(",");
                        if (data.Length > 0)
                        {
                            Product newDataA = new Product()
                            {
                                ID = Int32.Parse(data[0]),
                                TPYE = data[1],
                                BRAND = data[2],
                                PRODUCT_NAME = data[3],
                                AMOUNT = Int32.Parse(data[4]),
                            };
                            this.dataA.Add(newDataA);
                        }
                    }
                    result = true;
                }
            }
            catch { }
            return result;
        }

        public List<Product> ReadProduct()
        {
            return this.dataA;
        }


    }
}
