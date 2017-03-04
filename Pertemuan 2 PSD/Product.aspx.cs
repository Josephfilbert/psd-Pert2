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
        DBConnection conn;
        string query;
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            viewProductList();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            nama = txtNama.Text;
            harga = Convert.ToInt32(txtHarga.Text);

            query = "INSERT INTO Product VALUES ('" + nama + "', " + harga + ")";

            conn.ExecuteUpdate(query);
            viewProductList();

        }

        void viewProductList()
        {
            query = "SELECT * FROM Product";
            dt = conn.ExecuteQuery(query);

            gvProduk.DataSource = dt;
            gvProduk.DataBind();
        }
    }
}