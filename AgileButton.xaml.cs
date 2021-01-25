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

namespace AgileBIM.Controls
{
    public partial class AgileButton : Button
    {
        public AgileButton()
        {
            InitializeComponent();
        }

        public CornerRadius BorderRadius { get { return (CornerRadius)GetValue(BorderRadiusProperty); } set { SetValue(BorderRadiusProperty, value); } }
        public static readonly DependencyProperty BorderRadiusProperty =
            DependencyProperty.Register("BorderRadius", typeof(CornerRadius), typeof(AgileButton), new PropertyMetadata(new CornerRadius(0)));

        public Brush BorderBrushHover { get { return (Brush)GetValue(BorderBrushHoverProperty); } set { SetValue(BorderBrushHoverProperty, value); } }
        public static readonly DependencyProperty BorderBrushHoverProperty =
            DependencyProperty.Register("BorderBrushHover", typeof(Brush), typeof(AgileButton), new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF3C7FB1"))));

        public Brush BackgroundHover { get { return (Brush)GetValue(BackgroundHoverProperty); } set { SetValue(BackgroundHoverProperty, value); } }
        public static readonly DependencyProperty BackgroundHoverProperty =
            DependencyProperty.Register("BackgroundHover", typeof(Brush), typeof(AgileButton), new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFBEE6FD"))));

        public Brush BorderBrushPressed { get { return (Brush)GetValue(BorderBrushPressedProperty); } set { SetValue(BorderBrushPressedProperty, value); } }
        public static readonly DependencyProperty BorderBrushPressedProperty =
            DependencyProperty.Register("BorderBrushPressed", typeof(Brush), typeof(AgileButton), new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF2C628B"))));

        public Brush BackgroundPressed { get { return (Brush)GetValue(BackgroundPressedProperty); } set { SetValue(BackgroundPressedProperty, value); } }
        public static readonly DependencyProperty BackgroundPressedProperty =
            DependencyProperty.Register("BackgroundPressed", typeof(Brush), typeof(AgileButton), new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC4E5F6"))));

        public Brush BorderBrushDisabled { get { return (Brush)GetValue(BorderBrushDisabledProperty); } set { SetValue(BorderBrushDisabledProperty, value); } }
        public static readonly DependencyProperty BorderBrushDisabledProperty =
            DependencyProperty.Register("BorderBrushDisabled", typeof(Brush), typeof(AgileButton), new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFADB2B5"))));

        public Brush BackgroundDisabled { get { return (Brush)GetValue(BackgroundDisabledProperty); } set { SetValue(BackgroundDisabledProperty, value); } }
        public static readonly DependencyProperty BackgroundDisabledProperty =
            DependencyProperty.Register("BackgroundDisabled", typeof(Brush), typeof(AgileButton), new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF4F4F4"))));

        public Brush ForegroundDisabled { get { return (Brush)GetValue(ForegroundDisabledProperty); } set { SetValue(ForegroundDisabledProperty, value); } }
        public static readonly DependencyProperty ForegroundDisabledProperty =
            DependencyProperty.Register("ForegroundDisabled", typeof(Brush), typeof(AgileButton), new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF838383"))));

    }
}
