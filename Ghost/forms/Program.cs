namespace forms;
using System;
using System.Windows.Forms;
using Variables;

static class Program
{
    [STAThread]
    public static void Main()
    {
        VariableModel p = new VariableModel
        {
            firstName = "Tim",
            lastName = "Corey"
        };

        System.Console.WriteLine($"{ p.firstName } { p.lastName } is my name");
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
        Console.WriteLine("Test");

    }   
     
}