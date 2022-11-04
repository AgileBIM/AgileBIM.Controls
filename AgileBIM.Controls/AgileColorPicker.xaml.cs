using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AgileBIM.Controls
{   
    public partial class AgileColorPicker : Border, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName = "") { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); }        
        public Color SelectedColor { get { return (SelectedBrush as SolidColorBrush).Color; } set { SelectedBrush = new SolidColorBrush(value); NotifyPropertyChanged(nameof(SelectedBrush)); } }
        public Brush SelectedBrush
        {
            get { return (Brush)GetValue(SelectedBrushProperty); }
            set { SetValue(SelectedBrushProperty, value); NotifyPropertyChanged(nameof(LabelColor)); }
        }
        public static readonly DependencyProperty SelectedBrushProperty =
            DependencyProperty.Register("SelectedBrush", typeof(Brush), typeof(AgileColorPicker), new PropertyMetadata(Brushes.Black));


        public Brush LabelColor { 
            get
            {
                var c = this.SelectedColor;
                int m = (c.R + c.G + c.B) / 3;
                if (m > 125)
                    return Brushes.Black;
                else
                    return Brushes.White;
            }
        }


        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); NotifyPropertyChanged(nameof(LabelColor)); }
        }
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(AgileColorPicker), new PropertyMetadata(""));



        public AgileColorPicker()
        {
            InitializeComponent();
            popColorPalette.CustomPopupPlacementCallback = placePopup;            
        }

        public CustomPopupPlacement[] placePopup(Size popupSize, Size targetSize, Point offset)
        {
            CustomPopupPlacement placement1 =
               new CustomPopupPlacement(new Point(-1 * ((popupSize.Width / 2.0) - (this.ActualWidth / 2.0)), this.ActualHeight), PopupPrimaryAxis.Horizontal);
            CustomPopupPlacement[] ttplaces =
                    new CustomPopupPlacement[] { placement1 };
            return ttplaces;
        }

        private void AgileColorPicker_Loaded(object sender, RoutedEventArgs e)
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
