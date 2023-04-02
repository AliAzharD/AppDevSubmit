using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace THA_W5_ALI_AZHAR_D
{
    

    public partial class Form_AliAzharD : Form
    {
        
        private List<Class_Category> DaftarCategory = new List<Class_Category> () ;
        private List<Class_Product> DaftarProduct = new List<Class_Product>() ;
        
       
        public Form_AliAzharD()
        {
            InitializeComponent();

             

            


           Class_Product Product1 = new Class_Product("J001", "Jas Hitam", "100000", "10", "C1");
            DaftarProduct.Add(Product1);
            Class_Product Product2 = new Class_Product("T001", "T-Shirt Balck Pink", "70000", "20", "C2");
            DaftarProduct.Add(Product2);
            Class_Product Product3 = new Class_Product("R002", "Rocca Shirt", "50000", "8", "C2");
            DaftarProduct.Add(Product3);
            Class_Product Product4 = new Class_Product("T002", "T-Shirt Obsessive", "75000", "16", "C2");
            DaftarProduct.Add(Product4);
            Class_Product Product5 = new Class_Product("R001", "Rok Mini", "82000", "26", "C3");
            DaftarProduct.Add(Product5);
            Class_Product Product6 = new Class_Product("J002", "Jeans Biru", "90000", "5", "C4");
            DaftarProduct.Add(Product6);
            Class_Product Product7 = new Class_Product("C001", "Celana Pendek C", "60000", "11", "C4");
            DaftarProduct.Add(Product7);
            Class_Product Product8 = new Class_Product("C002", "Cawat Blink-Blink", "1000000", "1", "C5");
            DaftarProduct.Add(Product8);

            foreach (var Product in DaftarProduct)
            {
                DGV_Product.Rows.Add(new object[] {Product.getIDProduct(), Product.getNameProduct(), Product.getHarga(), Product.getstock(), Product.getIDCategory() });
            }
            


            Class_Category Category1 = new Class_Category("C1","Jas");
            DaftarCategory.Add(Category1);
            Class_Category Category2 = new Class_Category("C2", "T-Shirt");
            DaftarCategory.Add(Category2);
            Class_Category Category3 = new Class_Category("C3", "Rok");
            DaftarCategory.Add(Category3);
            Class_Category Category4 = new Class_Category("C4", "Celana");
            DaftarCategory.Add(Category4);
            Class_Category Category5 = new Class_Category("C5", "Cawat");
            DaftarCategory.Add(Category5);

            foreach (var Category in DaftarCategory)
            {
                DGV_Category.Rows.Add(new object[] { Category.getIDCategory(), Category.getNamaCategory() });
            }

            
            for(int i = 0; i < DGV_Category.Rows.Count; i++)
            {
                comboBox_Category.Items.Add(DGV_Category.Rows[i].Cells[1].Value);
            }

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DGV_Product.Rows[e.RowIndex].Selected = true;
            }

            string IDCategory = "";

            for (int i = 0; i < DGV_Category.Rows.Count; i++)
            {
                if (DGV_Product.Rows[e.RowIndex].Cells[4].Value.ToString() == DGV_Category.Rows[i].Cells[0].Value.ToString())
                {
                    
                    IDCategory = DGV_Category.Rows[i].Cells[1].Value.ToString();
                }
            }
            
            
            textBox_NamaDetail.Text = DGV_Product.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox_Category.Text = IDCategory;
            textBox_Harga.Text = DGV_Product.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox_Stock.Text = DGV_Product.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_AddCategory_Click(object sender, EventArgs e)
        {

            Class_Category CategoryBaru = new Class_Category("C" + (DGV_Category.Rows.Count).ToString(), textBox_NamaCategory.Text);
            DGV_Category.Rows.Add(new object[] { "C" + (DGV_Category.Rows.Count).ToString(), textBox_NamaCategory.Text });
        }

        private void button2_AddProduct_Click(object sender, EventArgs e)
        {
            if(textBox_NamaDetail.Text != "" && comboBox_Category.Text != "" && textBox_Harga.Text != "" && textBox_Stock.Text != "")
            {
                string IDCategory = "";
                for (int i = 0; i < DGV_Category.Rows.Count; i++)
                {
                    if (comboBox_Category.Text == DGV_Category.Rows[i].Cells[1].Value.ToString())
                    {
                        IDCategory = DGV_Category.Rows[i].Cells[0].Value.ToString();
                    }
                }
                int JumlahID = 1;
                for (int i = 0; i < DGV_Product.Rows.Count; i++)
                {
                    if (DGV_Product.Rows[i].Cells[0].Value.ToString()[0] == textBox_NamaDetail.Text.ToUpper()[0])
                    {
                        JumlahID++;
                    }
                }
                Class_Product ProductBaru = new Class_Product(textBox_NamaDetail.Text.ToUpper()[0] + "00"+ (JumlahID).ToString(), textBox_NamaDetail.Text, textBox_Harga.Text, textBox_Stock.Text, IDCategory.ToString());
                DaftarProduct.Add(ProductBaru);
                DGV_Product.Rows.Add(new object[] { textBox_NamaDetail.Text.ToUpper()[0] +"00"+ (JumlahID).ToString(), textBox_NamaDetail.Text, textBox_Harga.Text, textBox_Stock.Text, IDCategory.ToString() });
            }
            else
            {
                MessageBox.Show("Error ada input yang salah");
            }
           
        }

        private void comboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox_Stock_TextChanged(object sender, EventArgs e)
        {
            double value;

            if (!double.TryParse(textBox_Stock.Text, out value))
            {
                // The value is not a number, handle the error
                textBox_Stock.Text = string.Empty;

            }
            else
            {
                // The value is a valid number, continue with the operation

            }
        }
        private void textBox_Harga_TextChanged(object sender, EventArgs e)
        {
            double value;

            if (!double.TryParse(textBox_Harga.Text, out value))
            {
                // The value is not a number, handle the error
                textBox_Harga.Text = string.Empty;

            }
            else
            {
                // The value is a valid number, continue with the operation

            }
        }

        private void DGV_Category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.RowIndex >= 0)
            {
                DGV_Category.Rows[e.RowIndex].Selected = true;
            }
            textBox_NamaCategory.Text = DGV_Category.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button_RemoveProduct_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in DGV_Product.SelectedRows)
            {
                // Do something with the selected row
                Class_Product DeleteProduct = new Class_Product(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
                DaftarProduct.Remove(DeleteProduct);
                DGV_Product.Rows.Remove(row);
            }

        }

        private void Form_AliAzharD_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button_RemoveCategory_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGV_Category.SelectedRows)
            {
                List<int> simpan = new List<int>();
                // Do something with the selected row
                for (int i = 0; i < DGV_Product.Rows.Count; i++)
                {
                    if (row.Cells[0].Value.ToString()== DGV_Product.Rows[i].Cells[4].Value.ToString())
                    {
                        simpan.Add(i);
                    }
                }
                foreach (var simpanx in simpan)
                {
                    DGV_Product.Rows.RemoveAt(simpanx);
                }
                
                Class_Category DeleteCategory = new Class_Category(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                DaftarCategory.Remove(DeleteCategory);
                DGV_Category.Rows.Remove(row);
            }
        }

        private void button_EditProduct_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGV_Product.SelectedRows)
            {
                row.Cells[1].Value = textBox_NamaDetail.Text;

                row.Cells[2].Value = textBox_Harga.Text;
                row.Cells[3].Value = textBox_Stock.Text;

                foreach (Class_Product product in DaftarProduct)
                {
                    if (product.getIDProduct() == row.Cells[0].Value.ToString())
                    {
                        product.setNameProduct(textBox_NamaDetail.Text);

                        product.setHarga(textBox_Harga.Text);
                        product.setstock(textBox_Stock.Text);

                        string IDCategory = "";

                        for (int i = 0; i < DGV_Category.Rows.Count; i++)
                        {
                            if (comboBox_Category.Text == DGV_Category.Rows[i].Cells[1].Value.ToString())
                            {
                                IDCategory = DGV_Category.Rows[i].Cells[0].Value.ToString();
                            }
                        }
                        row.Cells[4].Value = IDCategory;
                        product.setIDCategory(IDCategory);

                    }
                }


            }

        }

        private void button_All_Click(object sender, EventArgs e)
        {
            foreach (var Product in DaftarProduct)
            {
                DGV_Product.Rows.Add(new object[] { Product.getIDProduct(), Product.getNameProduct(), Product.getHarga(), Product.getstock(), Product.getIDCategory() });
            }
            foreach (var Category in DaftarCategory)
            {
                DGV_Category.Rows.Add(new object[] { Category.getIDCategory(), Category.getNamaCategory() });
            }
            comboBox1.Enabled = false;

            textBox_NamaDetail.Text = string.Empty;
            textBox_NamaCategory.Text = string.Empty;
            textBox_Harga.Text = string.Empty;
            textBox_Stock.Text = string.Empty;
            textBox_NamaCategory.Text = string.Empty;
            comboBox1.Text = string.Empty;
            comboBox_Category.Text = string.Empty;
            
        }

        private void button_Filter_Click(object sender, EventArgs e)
        {

            comboBox1.Enabled = true;
            comboBox1.Items.Clear();
            foreach (Class_Category categori in DaftarCategory)
            {
                comboBox1.Items.Add(categori.getNamaCategory());
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGV_Product.Rows.Clear();
            foreach (var Product in DaftarProduct)
            {
                string IDCategory = "";

                for (int i = 0; i < DGV_Category.Rows.Count; i++)
                {
                    if (comboBox1.Text == DGV_Category.Rows[i].Cells[1].Value.ToString())
                    {
                        IDCategory = DGV_Category.Rows[i].Cells[0].Value.ToString();

                    }

                }
                
                if(IDCategory == Product.getIDCategory())
                {
                    DGV_Product.Rows.Add(new object[] { Product.getIDProduct(), Product.getNameProduct(), Product.getHarga(), Product.getstock(), Product.getIDCategory() });
                }
                
            }
            foreach (var Category in DaftarCategory)
            {
                DGV_Category.Rows.Add(new object[] { Category.getIDCategory(), Category.getNamaCategory() });
            }
        }

        private void textBox_NamaDetail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
