using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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

namespace AgileBIM.Controls
{   
    public partial class ColorPicker : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName = "") { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); }
        private Brush _color = Brushes.Black;        
        public Brush SelectedColor { get { return _color; } set { _color = value; NotifyPropertyChanged(nameof(SelectedColor)); } }
        private CornerRadius _radius = new CornerRadius(0);
        public CornerRadius BorderRadius { get { return _radius; } set { _radius = value; NotifyPropertyChanged(nameof(BorderRadius)); } }


        public ColorPicker()
        {
            InitializeComponent();
        }

        private void ColorPicker_Loaded(object sender, RoutedEventArgs e)
        {
            this.icColorList.ItemsSource = typeof(Brushes).GetProperties();
        }

        private void btnColorOption_Click(object sender, RoutedEventArgs e)
        {
            SelectedColor = (sender as Button).Background;
            popColorPalette.IsOpen = false;
        }

        private void btnColor_Click(object sender, RoutedEventArgs e)
        {
            popColorPalette.IsOpen = !popColorPalette.IsOpen;
        }
    }
}
