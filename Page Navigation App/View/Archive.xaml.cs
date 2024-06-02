using Page_Navigation_App.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
/*using Telerik.Windows.Controls; */ 

namespace Page_Navigation_App.View
{
    /// <summary>
    /// Interaction logic for Orders.xaml
    /// </summary>
    public partial class Archive : UserControl
    {
        public Archive()
        {
            InitializeComponent();
            this.fieldCarousel.ItemsSource = ArchiveHelpers.GetArchives();
            Mouse.OverrideCursor = Cursors.Hand;
        }

        

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
    
        }

        private void TopContainerChanged(object sender, RoutedEventArgs e)
        {
           

        }
        private void IsAnimatingchanged(object sender, RoutedEventArgs e)
        { }

    }
}
