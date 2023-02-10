using Dapper;
using DapperHW_1.Generator;
using DapperHW_1.Views;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DapperHW_1;

public partial class Form1 : Form
{
    SqlConnection? connection = null;
    string command = String.Empty;
    DataTable? dataTable = null;

    public Form1()
    {
        InitializeComponent();
        connection = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
        DBGenerator.CreateDB(connection);
        connection.ConnectionString = System.Configuration.ConfigurationManager.AppSettings["BookStoreCS"];
    }

    private void Form1_Load(object sender, EventArgs e) => FillData();

    private void FillData()
    {
        listBox1.Items.Clear();
        command = "SELECT * FROM Book";
        var reader = connection.ExecuteReader(command);
        dataTable = new DataTable();
        dataTable.Load(reader);

        foreach (DataRow item in dataTable.Rows)
            listBox1.Items.Add(item[0] + " " + item[1] + " " + item[2] + " " + item[3] + " " + item[4] + " " + item[5]);
    }


    private void btn_AddProduct_Click(object sender, EventArgs e)
    {
        ManagerView view = new(connection, listBox1, true);
        view.Show();
    }

    private void btn_EditProduct_Click(object sender, EventArgs e)
    {
        if (listBox1.SelectedIndex != -1)
        {
            ManagerView view = new(connection, listBox1, false);
            view.ShowDialog();
            FillData();
        }   
        else
            MessageBox.Show("Selection is empty!");
        
    }

    private void btn_RemoveProduct_Click(object sender, EventArgs e)
    {
        if (listBox1.SelectedIndex != -1)
            listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
        else
            MessageBox.Show("Selection is empty!");
    }

    private void btn_ClearList_Click(object sender, EventArgs e) => listBox1.Items.Clear();
}