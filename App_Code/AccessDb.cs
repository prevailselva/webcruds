using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;


/// <summary>
/// Summary description for AccessDb
/// </summary>
public class AccessDb
{
    MySqlConnection con = new MySqlConnection();
    public DataSet ds = new DataSet();

	public AccessDb()
	{
        con.ConnectionString = ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString;
	}

    public DataSet execDataTable(string command)
    {
        try
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand(command, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            da.Dispose();
        }
        catch (Exception ex)
        {
            HttpContext.Current.Response.Write("<script>alert('something wrong with the connection '" + ex.Message + ")</script>");
        }
        finally
        {
            con.Close();
        }
        return ds;
    }
}