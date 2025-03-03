using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryString_2613827
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            //Go to the confirmation page with the encoded URL
            Response.Redirect
                (
                "ProductConfirmQueryString.aspx" +
                "?ddlCategory=" + ddlCategory.SelectedValue +
                "&ddlSupplier=" + ddlSupplier.SelectedValue +
                "&strProduct=" + txtProduct.Text +
                "&strDescription=" + txtDescription.Text +
                "&strImage=" + txtImage.Text +
                "&decPrice=" + txtPrice +
                "&byNumberInStock=" + txtNumberInStock.Text +
                "&byNumberOnOrder=" + txtNumberOnOrder.Text +
                "&byReorderLevel=" + txtRecorderLevel.Text


                );

                
        }
    }
}