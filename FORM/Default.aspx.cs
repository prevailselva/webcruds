using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using MySql.Data.MySqlClient;

public partial class FORM_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            count_stud();
            count_dme_stud();
            count_dce_stud();
            count_dmt_stud();
        }
    }

    public void count_stud()
    {
        AccessDb dbcon = new AccessDb();
        DataSet ds = dbcon.execDataTable("SELECT count(*) as `total` from personal");

        if (dbcon.ds.Tables[0].Rows.Count > 0)
        {
            lbl_stud_count.Text = dbcon.ds.Tables[0].Rows[0]["total"].ToString();
        }
    }

    public void count_dme_stud()
    {
        AccessDb dbcon = new AccessDb();
        DataSet ds = dbcon.execDataTable("SELECT count(*) as `total` from personal where `course`='DME'");

        if (dbcon.ds.Tables[0].Rows.Count > 0)
        {
            lbl_dme_count.Text = dbcon.ds.Tables[0].Rows[0]["total"].ToString();
        }
    }

    public void count_dce_stud()
    {
        AccessDb dbcon = new AccessDb();
        DataSet ds = dbcon.execDataTable("SELECT count(*) as `total` from personal where `course`='DCE'");

        if (dbcon.ds.Tables[0].Rows.Count > 0)
        {
            lbl_dce_count.Text = dbcon.ds.Tables[0].Rows[0]["total"].ToString();
        }
    }

    public void count_dmt_stud()
    {
        AccessDb dbcon = new AccessDb();
        DataSet ds = dbcon.execDataTable("SELECT count(*) as `total` from personal where `course`='DMTE'");

        if (dbcon.ds.Tables[0].Rows.Count > 0)
        {
            lbl_dmt_count.Text = dbcon.ds.Tables[0].Rows[0]["total"].ToString();
        }
    }
}