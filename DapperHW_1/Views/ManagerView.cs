using Dapper;
using DapperHW_1.Models;
using Microsoft.Data.SqlClient;

namespace DapperHW_1.Views;

public partial class ManagerView : Form
{
    SqlConnection? connection = null;
    ListBox lbox = null;
    public ManagerView(SqlConnection conn, ListBox lbox, bool Add)
    {
        InitializeComponent();
        connection = conn;
        this.lbox = lbox;
        if (!Add)
        {
            btn_Add.Text = "Edit";
            var text = lbox.SelectedItems[0].ToString().Split();
            tBox_Name.Text = text[1];
            tBox_Page.Text = text[2];
            tBox_Author.Text = text[3];
            tBox_Price.Text = text[4];
            tBox_Stock.Text = text[5];
        }
    }

    private void btn_Add_Click(object sender, EventArgs e)
    {
        if (btn_Add.Text== "Add")
        {
            if (tBox_Author.Text.Length > 0 && tBox_Name.Text.Length > 0 && tBox_Page.Text.Length > 0 && tBox_Price.Text.Length > 0 && tBox_Stock.Text.Length > 0)
            {
                Book book = new Book();
                book.Name = tBox_Name.Text;
                book.Page = Int32.Parse(tBox_Page.Text);
                book.Author = tBox_Author.Text;
                book.Price = Int32.Parse(tBox_Price.Text);
                book.Stock = Int32.Parse(tBox_Stock.Text);
                var command = @"INSERT INTO Book VALUES(@Name, @Page, @Author, @Price, @Stock)";
                connection.Execute(command, new { book.Name, book.Page, book.Author, book.Price, book.Stock });
                lbox.Items.Add(book);
                MessageBox.Show("Succesfully Added");
                this.Close();
            }
            else
            {
                MessageBox.Show("Fill All Blanks");
            }
        } 
        else
        {
            Book book = new Book();
            book.Id = Int32.Parse(lbox.SelectedItems[0].ToString().Split()[0]);
            book.Name = tBox_Name.Text;
            book.Page = Int32.Parse(tBox_Page.Text);
            book.Author = tBox_Author.Text;
            book.Price = Int32.Parse(tBox_Price.Text);
            book.Stock = Int32.Parse(tBox_Stock.Text);
            var command = @"UPDATE BOOK SET Name = @Name, Page = @Page, Author = @Author, Price = @Price, Stock = @Stock WHERE Id = @Id";
            connection.Execute(command, new { book.Name, book.Page, book.Author, book.Price, book.Stock, book.Id });
            MessageBox.Show("Succesfully Edited");
            this.Close();
        }
        
    }

    private void btn_Cancel_Click(object sender, EventArgs e) => this.Close();
}
