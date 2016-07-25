using System;
using System.Collections.Generic;
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
using System.Windows.Forms;
using System.IO;
using System.Reflection;
namespace HW_9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<FileInfo> ListOfDLLs = new List<FileInfo>();
        List<Type> ListOfTypes = new List<Type>();
        List<FieldInfo> ListOfFields = new List<FieldInfo>();
        List<MethodInfo> ListOfMethods = new List<MethodInfo>();
        List<PropertyInfo> ListOfProperties = new List<PropertyInfo>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtSelectDirectory_Click(object sender, RoutedEventArgs e)
        {
            LBListOfFiles.Items.Clear();
            LBListOfTypes.Items.Clear();
            LBListOfComponents.Items.Clear();
            TBDirectoryPath.Text = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = @"c:\Users\Evgeny_Zaitsev@epam.com\Documents\Visual Studio 2015\Projects\Framework\Framework\bin\Debug\";
            TBDirectoryPath.Text = fbd.SelectedPath;
            while (fbd.SelectedPath == "")
            {
                fbd.ShowDialog();
                TBDirectoryPath.Text = fbd.SelectedPath;
            }
            DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
            ListOfDLLs = di.GetFiles().ToList().Where(x => x.Extension.ToLower() == ".dll").ToList();
            try
            {
                foreach (FileInfo file in ListOfDLLs)
                    LBListOfFiles.Items.Add(file.Name);
            }
            catch (NullReferenceException ex)
            {
            }
        }

        private void LBListOfFiles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TBDirectoryPath.Text != "" && LBListOfFiles.Items.Count != 0)
            {
                LBListOfTypes.Items.Clear();
                LBListOfComponents.Items.Clear();
                var item = LBListOfFiles.SelectedItem.ToString();
                var DLL = ListOfDLLs.Where(x => x.Name == item).ToList()[0];
                try
                {
                    Assembly a = Assembly.LoadFile(DLL.FullName);
                    ListOfTypes = a.GetTypes().ToList();
                }
                catch (ReflectionTypeLoadException ex)
                {
                    ListOfTypes = ex.Types.ToList();
                }
                catch(BadImageFormatException ex)
                { 
                }
                try
                {
                    foreach (var type in ListOfTypes)
                        LBListOfTypes.Items.Add(type.Name);
                }
                catch (NullReferenceException ex)
                {
                }
            }
        }

        private void LBListOfTypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LBListOfTypes.Items.Count != 0)
            {
                LBListOfComponents.Items.Clear();
                CBSelectedComponents.SelectedIndex = 0;
                var item = LBListOfTypes.SelectedItem.ToString();
                var type = ListOfTypes.Where(x => x.Name == item).ToList()[0];
                ListOfFields = type.GetFields().ToList();
                ListOfMethods = type.GetMethods().ToList();
                ListOfProperties = type.GetProperties().ToList();
                try
                {
                    foreach (var field in ListOfFields)
                        LBListOfComponents.Items.Add(field.Name);
                    foreach (var property in ListOfProperties)
                        LBListOfComponents.Items.Add(property.Name);
                    foreach (var method in ListOfMethods)
                        LBListOfComponents.Items.Add(method.Name);
                }
                catch (NullReferenceException ex)
                {
                }
            }
        }

        private void CBSelectedComponents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LBListOfTypes.Items.Count != 0 && LBListOfComponents.Items.Count != 0) { 
            LBListOfComponents.Items.Clear();
                try
                {
                    switch (CBSelectedComponents.SelectedIndex)
                    {
                        case 0:
                            {
                                foreach (var field in ListOfFields)
                                    LBListOfComponents.Items.Add(field.Name);
                                foreach (var property in ListOfProperties)
                                    LBListOfComponents.Items.Add(property.Name);
                                foreach (var method in ListOfMethods)
                                    LBListOfComponents.Items.Add(method.Name);
                                break;
                            }
                        case 1:
                            {
                                foreach (var method in ListOfMethods)
                                    LBListOfComponents.Items.Add(method.Name);
                                break;
                            }
                        case 2:
                            {
                                foreach (var property in ListOfProperties)
                                    LBListOfComponents.Items.Add(property.Name);
                                break;
                            }
                        case 3:
                            {
                                foreach (var field in ListOfFields)
                                    LBListOfComponents.Items.Add(field.Name);
                                break;
                            }
                    }
                }
                catch (NullReferenceException ex)
                {
                }
            }
        }
    }
}
