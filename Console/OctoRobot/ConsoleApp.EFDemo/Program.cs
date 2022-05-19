// See https://aka.ms/new-console-template for more information
using ConsoleApp.EFDemo.Service;

var ss = new TeacherService();
ss.Create();
ss.ListAll();