using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tester
{
    /// <summary>
    /// These controls often use base 64 encoded templates and decoupled Xaml to avoid the following error:
    ///     Cannot set Name attribute value 'MyName' on element 'SomeControl'. 'SomeControl' is under the scope of element 'SomeOtherControl'
    /// This Tester application is using the problematic definitions under the assumption we won't need names during tests and I didn't
    /// want to lose the ability of designing Xaml within a single project. When the application is built in Release mode, the decoupling
    /// operations mentioned above takes over, the Xaml is moved into a separate namespace and the problem goes away.
    /// The following Visual Studio extension was used to generate the Base64 strings:
    ///     https://marketplace.visualstudio.com/items?itemName=moonspace-labs-llc.Base64EncodeDecode
    /// </summary>


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
