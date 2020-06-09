using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOmework_7
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void But_GetAllProducts_Click(object sender, EventArgs e)
        {
            //პროდუქტების სრული სია
            var products = (from p in DBSimulator.GetProducts()
                            join c in DBSimulator.GetProductCategories()
                            on p.CategotyID equals c.Id
                            orderby p.Code ascending
                            select new
                            {
                                Category = c.Name,
                                Name = p.Name,
                                Code = p.Code,
                                Measure = p.Measuring,
                                Amount = p.Price * p.Quantity,
                                Valute = p.Valute,
                                ExpirationDate = p.ExpirationDate,
                            }).ToList();
            dataGridView1.DataSource = products;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var product = (from p in DBSimulator.GetProducts()
                            //orderby p.ExpirationDate descending
                            //where p.ExpirationDate.HasValue && p.Price>100
                            select p
                            ).FirstOrDefault();
            dataGridView1.DataSource = product;

        }
    }
}
