using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspAssignment
{
    public partial class Items : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemList.SelectedIndex == 1)
                Product.ImageUrl = "~/Images/Flour.jpg";
            if (ItemList.SelectedIndex == 2)
                Product.ImageUrl = "~/Images/Wheat Flour.jpg";
            if (ItemList.SelectedIndex == 3)
                Product.ImageUrl = "~/Images/GoodDay.jpg";
            if (ItemList.SelectedIndex == 4)
                Product.ImageUrl = "~/Images/Oreo.jpg";
            if (ItemList.SelectedIndex == 5)
                Product.ImageUrl = "~/Images/Yippee Noodles.jpg";
            if (ItemList.SelectedIndex == 6)
                Product.ImageUrl = "~/Images/Colgate.jpg";
            if (ItemList.SelectedIndex == 7)
                Product.ImageUrl = "~/Images/Himalaya Soap.jpg";
        }

        protected void CostBtn_Click(object sender, EventArgs e)
        {
            if (ItemList.SelectedIndex == 1)
            {
                var p = 55.00;
                Price.Text = "Price: " + p.ToString()+" per 1 500g unit";
            }
            if (ItemList.SelectedIndex == 2)
            {
                var p = 246.00;
                Price.Text = "Price: " + p.ToString()+" per 1 5kg unit";
            }
            if (ItemList.SelectedIndex == 3)
            {
                var p = 4.70;
                Price.Text = "Price: " + p.ToString()+" per 1 25.5g unit";
            }
            if (ItemList.SelectedIndex == 4)
            {
                var p = 30.00;
                Price.Text = "Price: " + p.ToString() + " per 1 unit";
            }
            if (ItemList.SelectedIndex == 5)
            {
                var p = 28.20;
                Price.Text = "Price: " + p.ToString() + " per 1 120g unit";
            }
            if (ItemList.SelectedIndex == 6)
            {
                var p = 54.50;
                Price.Text = "Price: " + p.ToString() + " per 1 100g unit";
            }
            if (ItemList.SelectedIndex == 7)
            {
                var p = 150.00;
                Price.Text = "Price: " + p.ToString() + " for 1 pack of 4 units";
            }
        }
    }
}
