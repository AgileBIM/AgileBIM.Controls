using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace AgileBIM.Controls
{
    public partial class AgileTabItem : TabItem //, INotifyPropertyChanged
    {
        //public event PropertyChangedEventHandler PropertyChanged;
        //private void NotifyPropertyChanged(string propertyName = "") { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); }

        public AgileTabItem()
        {
            InitializeComponent();
        }

        public FontWeight TabFontWeight { get { return (FontWeight)GetValue(TabFontWeightProperty); } set { SetValue(TabFontWeightProperty, value); } }
        public static readonly DependencyProperty TabFontWeightProperty =
            DependencyProperty.Register("TabFontWeight", typeof(FontWeight), typeof(AgileTabItem), new PropertyMetadata(FontWeights.Bold));

        public double TabFontSize { get { return (double)GetValue(TabFontSizeProperty); } set { SetValue(TabFontSizeProperty, value); } }
        public static readonly DependencyProperty TabFontSizeProperty =
            DependencyProperty.Register("TabFontSize", typeof(double), typeof(AgileTabItem), new PropertyMetadata(SystemFonts.CaptionFontSize));



        public bool TabIsRotated { get { return (bool)GetValue(TabIsRotatedProperty); } set { SetValue(TabIsRotatedProperty, value); } }
        public static readonly DependencyProperty TabIsRotatedProperty = 
            DependencyProperty.Register("TabIsRotated", typeof(bool), typeof(AgileTabItem), new PropertyMetadata(false));



        public Brush TabBackgroundHover { get { return (Brush)GetValue(TabBackgroundHoverProperty); } set { SetValue(TabBackgroundHoverProperty, value); } }
        public static readonly DependencyProperty TabBackgroundHoverProperty =
            DependencyProperty.Register("TabBackgroundHover", typeof(Brush), typeof(AgileTabItem), new PropertyMetadata(Brushes.Khaki));

        public Brush TabBorderBrushHover { get { return (Brush)GetValue(TabBorderBrushHoverProperty); } set { SetValue(TabBorderBrushHoverProperty, value); } }
        public static readonly DependencyProperty TabBorderBrushHoverProperty =
            DependencyProperty.Register("TabBorderBrushHover", typeof(Brush), typeof(AgileTabItem), new PropertyMetadata(Brushes.DarkTurquoise));


        public Brush TabBackgroundSelected { get { return (Brush)GetValue(TabBackgroundSelectedProperty); } set { SetValue(TabBackgroundSelectedProperty, value); } }
        public static readonly DependencyProperty TabBackgroundSelectedProperty =
            DependencyProperty.Register("TabBackgroundSelected", typeof(Brush), typeof(AgileTabItem), new PropertyMetadata(Brushes.Gray));

        public Brush TabBorderBrushSelected { get { return (Brush)GetValue(TabBorderBrushSelectedProperty); } set { SetValue(TabBorderBrushSelectedProperty, value); } }
        public static readonly DependencyProperty TabBorderBrushSelectedProperty =
            DependencyProperty.Register("TabBorderBrushSelected", typeof(Brush), typeof(AgileTabItem), new PropertyMetadata(Brushes.Gray));


        public Brush TabBackground { get { return (Brush)GetValue(TabBackgroundProperty); } set { SetValue(TabBackgroundProperty, value); } }
        public static readonly DependencyProperty TabBackgroundProperty =
            DependencyProperty.Register("TabBackground", typeof(Brush), typeof(AgileTabItem), new PropertyMetadata(Brushes.Turquoise));

        public Brush TabBorderBrush { get { return (Brush)GetValue(TabBorderBrushProperty); } set { SetValue(TabBorderBrushProperty, value); } }
        public static readonly DependencyProperty TabBorderBrushProperty =
            DependencyProperty.Register("TabBorderBrush", typeof(Brush), typeof(AgileTabItem), new PropertyMetadata(Brushes.Black));



        public CornerRadius TabBorderRadius { get { return (CornerRadius)GetValue(TabBorderRadiusProperty); } set { SetValue(TabBorderRadiusProperty, value); } }
        public static readonly DependencyProperty TabBorderRadiusProperty =
            DependencyProperty.Register("TabBorderRadius", typeof(CornerRadius), typeof(AgileTabItem), new PropertyMetadata(new CornerRadius(0)));

        public Thickness TabBorderThickness { get { return (Thickness)GetValue(TabBorderThicknessProperty); } set { SetValue(TabBorderThicknessProperty, value); } }
        public static readonly DependencyProperty TabBorderThicknessProperty =
            DependencyProperty.Register("TabBorderThickness", typeof(Thickness), typeof(AgileTabItem), new PropertyMetadata(new Thickness(0)));

        public Thickness TabSelectedMargin { get { return (Thickness)GetValue(TabSelectedMarginProperty); } set { SetValue(TabSelectedMarginProperty, value); } }
        public static readonly DependencyProperty TabSelectedMarginProperty =
            DependencyProperty.Register("TabSelectedMargin", typeof(Thickness), typeof(AgileTabItem), new PropertyMetadata(new Thickness(0)));



    }
}
