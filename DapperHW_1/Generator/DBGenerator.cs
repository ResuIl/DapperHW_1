using Dapper;
using Microsoft.Data.SqlClient;

namespace DapperHW_1.Generator;

public class DBGenerator
{
    static public void CreateDB(SqlConnection? connection)
    {
        try
        {
            connection.Execute("CREATE DATABASE BookShop");

            connection.Execute(@"
						USE [BookShop]
						CREATE TABLE [dbo].[Book] (
						[Id]	INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
						[Name]	NVARCHAR(100) NOT NULL,
						[Page]	INT NOT NULL,
						[Author] NVARCHAR(MAX) NOT NULL,
						[Price] INT NOT NULL,
						[Stock] INT NOT NULL
			)
			");
            connection.Execute(@"
			USE [BookShop]
INSERT INTO [Book] VALUES('Book1', 100, 'Resul', 100, 5);
INSERT INTO [Book] VALUES('Book2', 101, 'Resul1', 101, 6);
INSERT INTO [Book] VALUES('Book3', 102, 'Resul2', 102, 7);
INSERT INTO [Book] VALUES('Book4', 103, 'Resul3', 103, 8);
INSERT INTO [Book] VALUES('Book5', 104, 'Resul4', 104, 9);
");
        }
        catch (Exception ex) {}
    }
}
