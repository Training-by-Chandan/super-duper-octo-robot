// See https://aka.ms/new-console-template for more information
using ConsoleApp.Data;

DbConnector db = new DbConnector();
//db.ReadInfomationTable();
db.DeleteData();

Console.ReadLine();