using System;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand commandlist = new SqlCommand("Select * from Products", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            SqlDataReader dr = commandlist.ExecuteReader();

            DataList1.DataSource = dr;

            DataList1.DataBind();
            /*
            if (!IsPostBack)
            {
                Session["cartItems"] = new DataTable();
                InitializeCartDataTable();
            }

            UpdateCart();
        }
        
        protected void btnAddToCart1_Click(object sender, EventArgs e)
        {
            AddToCart("Ürün 1", 10);
        }

        protected void btnAddToCart2_Click(object sender, EventArgs e)
        {
            AddToCart("Ürün 2", 20);
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            // Ödeme işlemleri burada yapılabilir

            // Sepeti sıfırla
            Session["cartItems"] = new DataTable();
            InitializeCartDataTable();
            UpdateCart();

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Ödeme işlemi gerçekleştirildi!');", true);
        }


        protected void btnClearCart_Click(object sender, EventArgs e)
        {
            // Sepeti temizle
            Session["cartItems"] = new DataTable();
            InitializeCartDataTable();
            UpdateCart();
        }

        private void AddToCart(string productName, int productPrice)
        {
            var cartItems = (DataTable)Session["cartItems"];
            var newRow = cartItems.NewRow();
            newRow["ProductName"] = productName;
            newRow["ProductPrice"] = productPrice;
            cartItems.Rows.Add(newRow);

            UpdateCart();
        }

        private void UpdateCart()
        {
            var cartItems = (DataTable)Session["cartItems"];
            gridViewCart.DataSource = cartItems;
            gridViewCart.DataBind();

            lblTotalPrice.Text = CalculateTotalPrice(cartItems).ToString();
        }

        private int CalculateTotalPrice(DataTable cartItems)
        {
            int totalPrice = 0;

            foreach (DataRow row in cartItems.Rows)
            {
                totalPrice += Convert.ToInt32(row["ProductPrice"]);
            }

            return totalPrice;
        }

        private void InitializeCartDataTable()
        {
            var cartItems = (DataTable)Session["cartItems"];
            cartItems.Columns.Add("ProductName", typeof(string));
            cartItems.Columns.Add("ProductPrice", typeof(int));
        }
        */
        }
    }
}
