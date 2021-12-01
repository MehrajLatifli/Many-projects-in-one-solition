using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Many_projects
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //String appStartPath = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            //Process aProcess = new Process();
            //aProcess.StartInfo.FileName = appStartPath;// not sure if it's FilePath, just look through the properties
            //aProcess.Start();

            var v =System.IO.Path.Combine("../../../Many projects 2/bin/Debug", "Many projects 2.exe");  //  ../../../ => Debug => bin => Many Projects

            MessageBox.Show($"Project 2: {v}");

            Process.Start($"{v}");

            Environment.Exit(1);

        }
    }
}
