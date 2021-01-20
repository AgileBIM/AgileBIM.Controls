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
    public partial class ColorPicker : Border, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName = "") { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); }        
        public Color SelectedColor { get { return (SelectedBrush as SolidColorBrush).Color; } set { SelectedBrush = new SolidColorBrush(value); NotifyPropertyChanged(nameof(SelectedBrush)); } }
        public Brush SelectedBrush
        {
            get { return (Brush)GetValue(SelectedBrushProperty); }
            set { SetValue(SelectedBrushProperty, value); }
        }
        public static readonly DependencyProperty SelectedBrushProperty =
            DependencyProperty.Register("SelectedBrush", typeof(Brush), typeof(ColorPicker), new PropertyMetadata(Brushes.Black));


        public ColorPicker()
        {   
            InitializeComponent();
        }

        private void ColorPicker_Loaded(object sender, RoutedEventArgs e)
        {
            this.icColorList.ItemsSource = typeof(Brushes).GetProperties().Where(p => p.Name != "Transparent").ToArray();
        }

        private void btnColorOption_Click(object sender, RoutedEventArgs e)
        {
            SelectedBrush = (sender as Button).Background;
            popColorPalette.IsOpen = false;
        }

        private void btnColor_Click(object sender, RoutedEventArgs e)
        {
            popColorPalette.IsOpen = !popColorPalette.IsOpen;
        }


    }
}
