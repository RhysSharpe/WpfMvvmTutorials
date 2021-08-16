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
using System.Windows.Shapes;

namespace RIPTutorialMvvmDemo.View
{
    /***
     * There is nothing that needs to be added to the code behind for this example,
     * although this can vary depending on the needs of the application.
     * However, there are a few lines added to the XAML.
     * 
     * The Window needs a reference to the ViewModel namespace.
     * This is mapped to the XAML namespace xmlns:vm="clr-namespace:MyMVVMProject.ViewModel".
     * Next, the Window needs a DataContext. This is set to <vm:HelloWorldViewModel/>.
     * 
     * Now the label (or control of your choosing) can be added to the window.
     * The key point at this stage is to ensure that you set the Binding to the property
     * of the ViewModel that you wish to display as the label content.
     * In this case, it is {Binding HelloString} .
     */


    /// <summary>
    /// Interaction logic for HelloWorldView.xaml
    /// </summary>
    public partial class HelloWorldView : Window
    {
        public HelloWorldView()
        {
            InitializeComponent();
        }
    }
}
