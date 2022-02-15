using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ListCategories();
            ListProducts();

        }

        private void ListProducts()
        {
            using (NorthwindContext context = new NorthwindContext()) //bu yapı garbagecollector beklemeden northwindcontect i uçurmak için kullanılıyor 
            {                         // Performans amaçlı yapıyoruz           
                dgwProduct.DataSource = context.Products.ToList(); //bu satırla birlikte  veri tabanına (select * from dediğimiz sorguyu yapıyoruz) 
            }
        }

        private void ListProductsByCategory(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext()) //bu yapı garbagecollector beklemeden northwindcontect i uçurmak için kullanılıyor 
            {                         // Performans amaçlı yapıyoruz           
                dgwProduct.DataSource = context.Products.Where(p=>p.CategoryId==categoryId).ToList(); //bu satırla birlikte  veri tabanına (select * from dediğimiz sorguyu yapıyoruz) 
            }
        }
        private void ListProductsByProductName(string key)
        {
            using (NorthwindContext context = new NorthwindContext()) //bu yapı garbagecollector beklemeden northwindcontect i uçurmak için kullanılıyor 
            {                         // Performans amaçlı yapıyoruz           
                dgwProduct.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower()).ToList();
            } //bu satırla birlikte  veri tabanına (select * from dediğimiz sorguyu yapıyoruz)
        }
        private void ListCategories()
        {
            using (NorthwindContext context = new NorthwindContext()) //bu yapı garbagecollector beklemeden northwindcontect i uçurmak için kullanılıyor 
            {                         // Performans amaçlı yapıyoruz           
                cbxCategory.DataSource = context.Categories.ToList(); //bu satırla birlikte  veri tabanına (select * from dediğimiz sorguyu yapıyoruz) 
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryId";
            
            }
        }

        private void gbxCategory_Enter(object sender, EventArgs e)
        {

        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch 
            {

               
            }
            
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearch.Text;
            if (string.IsNullOrEmpty(key))
            {
                ListProducts();
            }
            else
            {
                ListProductsByProductName(key);
            }




            
        }
    }
}
