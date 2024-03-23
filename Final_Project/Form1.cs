using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        List<Product> product = new List<Product>();
        public Form1()
        {
            InitializeComponent();
        }
        int onoff = 0;
        string path = @"D:\Labtest\Final_Project\output\outputfile.csv";
        ClassControl product2 = new ClassControl();
        private void head2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tpyebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = tpyebox.SelectedIndex;
            for (int i = 0; i < tpyebox.Items.Count; i++)
            {
                if (i != idx)
                {
                    tpyebox.SetItemChecked(i, false);
                }
            }

        }
        private void inputtext1_TextChanged(object sender, EventArgs e)
        {

        }
        private void addtpye_Click(object sender, EventArgs e)
        {
            tpyebox.Items.Add(inputtext1.Text);
            inputtext1.Clear();
            inputtext1.Focus();
        }
        private void removetpye_Click(object sender, EventArgs e)
        {
            tpyebox.Items.Remove(inputtext1.Text);
            inputtext1.Clear();
            inputtext1.Focus();
        }

        private void brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx2 = brandbox.SelectedIndex;
            for (int i = 0; i < brandbox.Items.Count; i++)
            {
                if (i != idx2)
                {
                    brandbox.SetItemChecked(i, false);
                }
            }

        }
        private void inputtext2_TextChanged(object sender, EventArgs e)
        {

        }
        private void addtpye2_Click(object sender, EventArgs e)
        {
            brandbox.Items.Add(inputtext2.Text);
            inputtext2.Clear();
            inputtext2.Focus();
        }
        private void removetpye2_Click(object sender, EventArgs e)
        {
            brandbox.Items.Remove(inputtext2.Text);
            inputtext2.Clear();
            inputtext2.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool read1 = product2.ReadFromFile();
            if (product2.ReadProduct().Count == 0) 
            {
                int id = Convert.ToInt32(itemId.Text);
                string tpye = Convert.ToString(tpyebox.SelectedItem);
                string brand = Convert.ToString(brandbox.SelectedItem);
                string product_name = Convert.ToString(nitb.Text);
                int amount = Convert.ToInt32(itemAmount.Text);
                product2.addMember(id, tpye, brand, product_name, amount);
                bool result = product2.SavetoFile2(product2.getDataA());
                bool read2 = product2.ReadFromFile();
                dataGridView1.DataSource = product2.ReadProduct();
                dataGridView1.Refresh();
            }
            else 
            {
                foreach (Product item in product2.ReadProduct())
                {
                    int index = product2.ReadProduct().IndexOf(item);
                    if (item.ID == Convert.ToInt32(itemId.Text))
                    {   
                        item.ID = Convert.ToInt32(itemId.Text);
                        item.AMOUNT += Convert.ToInt32(itemAmount.Text);
                        item.PRODUCT_NAME = Convert.ToString(nitb.Text);
                        item.TPYE = Convert.ToString(tpyebox.SelectedItem);
                        item.BRAND = Convert.ToString(brandbox.SelectedItem);
                        bool result5 = product2.SavetoFile(product2.ReadProduct());
                        //Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                        //Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Open(path);
                        //Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.Worksheets["outputfile"];
                        //worksheet.Rows[index + 1].EntireRow.Delete(Microsoft.Office.Interop.Excel.XlDeleteShiftDirection.xlShiftUp);
                        //workbook.Save();
                        //workbook.Close();
                        //excelApp.Application.Quit();
                        bool read3 = product2.ReadFromFile();
                        dataGridView1.DataSource = product2.ReadProduct();
                        dataGridView1.Refresh();
                        break;
                    }
                    if (index == (product2.ReadProduct().Count)-1)
                    {
                          int id = Convert.ToInt32(itemId.Text);
                          string tpye = Convert.ToString(tpyebox.SelectedItem);
                          string brand = Convert.ToString(brandbox.SelectedItem);
                          string product_name = Convert.ToString(nitb.Text);
                          int amount = Convert.ToInt32(itemAmount.Text);
                          product2.addMember(id, tpye, brand, product_name, amount);
                          bool result = product2.SavetoFile2(product2.getDataA());
                          bool read4 = product2.ReadFromFile();
                          dataGridView1.DataSource = product2.ReadProduct();
                          dataGridView1.Refresh();
                          break;

                    }
                }
                this.Refresh();
            }



        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void itemId_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkstock_Click(object sender, EventArgs e)
        {
            bool read = product2.ReadFromFile();
            dataGridView1.DataSource = product2.ReadProduct();
            dataGridView1.Refresh();

        }

        private void nitb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
