using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pertemuan_2_PSD
{
    public partial class Product : System.Web.UI.Page
    {
        string nama;
        int harga;
        string query;
        DataTable dt;

        ItemHandler itemHandler;

        protected void Page_Load(object sender, EventArgs e)
        {
            itemHandler = new ItemHandler();
            viewProductList();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            nama = txtNama.Text;
            harga = Convert.ToInt32(txtHarga.Text);

            itemHandler.AddItem(new Barang(nama, harga));

            viewProductList();

        }

        void viewProductList()
        {
            dt = itemHandler.getItems();

            gvProduk.DataSource = dt;
            gvProduk.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            itemHandler.DeleteItem(txtNama.Text);
            viewProductList();
        }
    }
}