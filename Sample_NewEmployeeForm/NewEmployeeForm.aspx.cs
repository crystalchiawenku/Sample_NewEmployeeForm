using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewEmployeeForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int MyYear = System.DateTime.Now.Year;
            for (int i =0; i<=30; i++)
            {
                DropDownList1.Items.Add((MyYear - i).ToString());
            }
        }
    }

    protected void RadioButtonList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedValue == "M") 
        {
            Panel1.Visible = true;
        }

        else
        {
            Panel1.Visible = false;
        }

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Calendar1.TodaysDate = new DateTime(Convert.ToInt32((DropDownList1.SelectedValue)), (Convert.ToInt32(DropDownList2.SelectedValue)), 1);
    }


    protected void Button1_Click1(object sender, EventArgs e)
    {

        if (RadioButtonList1.SelectedValue == "M")
        {
            Response.Write("Name:" + TextBox1.Text + "<br/>");
            Response.Write("Gender:" + RadioButtonList1.SelectedItem.Text + "<br/>");
            Response.Write("Military Status:" + RadioButtonList2.SelectedItem.Text + "<br/>");
            Response.Write("Date of Birth:" + Calendar1.SelectedDate.ToShortDateString());
        }

        else
        {
            Response.Write("Name:" + TextBox1.Text + "<br/>");
            Response.Write("Gender:" + RadioButtonList1.SelectedItem.Text + "<br/>");
            Response.Write("Date of Birth:" + Calendar1.SelectedDate.ToShortDateString());

        }
    }
}