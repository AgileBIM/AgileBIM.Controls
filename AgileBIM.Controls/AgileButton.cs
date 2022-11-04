using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace AgileBIM.Controls
{
    public class AgileButton : Button
    {
        private static Type ThisControl = typeof(AgileButton);


        //public AgileButtonV2()
        //{
        //    this.Style = Application.Current.TryFindResource(typeof(AgileButtonV2)) as Style;
        //}



        public CornerRadius BorderRadius { get { return (CornerRadius)GetValue(BorderRadiusProperty); } set { SetValue(BorderRadiusProperty, value); } }
        public static readonly DependencyProperty BorderRadiusProperty =
            DependencyProperty.Register("BorderRadius", typeof(CornerRadius), ThisControl, new PropertyMetadata(new CornerRadius(0)));



        public Brush BorderBrushHover { get { return (Brush)GetValue(BorderBrushHoverProperty); } set { SetValue(BorderBrushHoverProperty, value); } }
        public static readonly DependencyProperty BorderBrushHoverProperty =
            DependencyProperty.Register("BorderBrushHover", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF3C7FB1"))));

        public Brush BackgroundHover { get { return (Brush)GetValue(BackgroundHoverProperty); } set { SetValue(BackgroundHoverProperty, value); } }
        public static readonly DependencyProperty BackgroundHoverProperty =
            DependencyProperty.Register("BackgroundHover", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFBEE6FD"))));

        public Brush ForegroundHover { get { return (Brush)GetValue(ForegroundHoverProperty); } set { SetValue(ForegroundHoverProperty, value); } }
        public static readonly DependencyProperty ForegroundHoverProperty =
            DependencyProperty.Register("ForegroundHover", typeof(Brush), ThisControl, new PropertyMetadata(Brushes.Black));



        public Brush BorderBrushPressed { get { return (Brush)GetValue(BorderBrushPressedProperty); } set { SetValue(BorderBrushPressedProperty, value); } }
        public static readonly DependencyProperty BorderBrushPressedProperty =
            DependencyProperty.Register("BorderBrushPressed", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF2C628B"))));

        public Brush BackgroundPressed { get { return (Brush)GetValue(BackgroundPressedProperty); } set { SetValue(BackgroundPressedProperty, value); } }
        public static readonly DependencyProperty BackgroundPressedProperty =
            DependencyProperty.Register("BackgroundPressed", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFC4E5F6"))));

        public Brush ForegroundPressed { get { return (Brush)GetValue(ForegroundPressedProperty); } set { SetValue(ForegroundPressedProperty, value); } }
        public static readonly DependencyProperty ForegroundPressedProperty =
            DependencyProperty.Register("ForegroundPressed", typeof(Brush), ThisControl, new PropertyMetadata(Brushes.Black));



        public Brush BorderBrushDisabled { get { return (Brush)GetValue(BorderBrushDisabledProperty); } set { SetValue(BorderBrushDisabledProperty, value); } }
        public static readonly DependencyProperty BorderBrushDisabledProperty =
            DependencyProperty.Register("BorderBrushDisabled", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFADB2B5"))));

        public Brush BackgroundDisabled { get { return (Brush)GetValue(BackgroundDisabledProperty); } set { SetValue(BackgroundDisabledProperty, value); } }
        public static readonly DependencyProperty BackgroundDisabledProperty =
            DependencyProperty.Register("BackgroundDisabled", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF4F4F4"))));

        public Brush ForegroundDisabled { get { return (Brush)GetValue(ForegroundDisabledProperty); } set { SetValue(ForegroundDisabledProperty, value); } }
        public static readonly DependencyProperty ForegroundDisabledProperty =
            DependencyProperty.Register("ForegroundDisabled", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF838383"))));
    }
}
