using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Many_projects_2
{
    class Program
    {


        static void Main(string[] args)
        {
            // First time run second project if you did make changes in the second project. Because subsequent changes are not remembered in second project when run first project.  

            Console.WriteLine("Project 2");

            var v = System.IO.Path.Combine("../../../Many projects/bin/Debug", "Many projects.exe");  //  ../../../ => Debug => bin => Many Projects 2

            MessageBox.Show($"Project 1: {v}");

            Process.Start($"{v}");

            Environment.Exit(1);

            Console.ReadKey();
        }
    }
}
