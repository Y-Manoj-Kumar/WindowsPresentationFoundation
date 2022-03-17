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

using Microsoft.Win32;


//to work with word documents
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;

//to read convert and work with pdf files
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Parsing;


//for our theme
using Syncfusion.SfSkinManager;
using Syncfusion.Themes.FluentLight.WPF;

//to start a process we need the diagnostics namespace
using System.Diagnostics;


//to work with images;
using System.Drawing;

//to save and read file
using System.IO;
using System.Windows; 


namespace PDF_Converter_By_SyncFusion
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
    }
}
