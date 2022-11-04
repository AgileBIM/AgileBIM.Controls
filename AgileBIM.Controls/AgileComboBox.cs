using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

/// Note: The AgileComboBox does not support IsEditable


namespace AgileBIM.Controls
{
    public class AgileComboBox : ComboBox
    {

        private static Type ThisControl = typeof(AgileComboBox);


        public Geometry ArrowGeometryOpened { get { return (Geometry)GetValue(ArrowGeometryOpenedProperty); } set { SetValue(ArrowGeometryOpenedProperty, value); } }
        public static readonly DependencyProperty ArrowGeometryOpenedProperty =
            DependencyProperty.Register("ArrowGeometryOpened", typeof(Geometry), ThisControl, new PropertyMetadata(PathGeometry.Parse("F1M0,12 L6,0 12,12 0,12 0,0z")));

        public Geometry ArrowGeometryClosed { get { return (Geometry)GetValue(ArrowGeometryClosedProperty); } set { SetValue(ArrowGeometryClosedProperty, value); } }
        public static readonly DependencyProperty ArrowGeometryClosedProperty =
            DependencyProperty.Register("ArrowGeometryClosed", typeof(Geometry), ThisControl, new PropertyMetadata(PathGeometry.Parse("F1M0,0 L6,0 12,0 6,12 0,0z")));

        public Brush ArrowBrush { get { return (Brush)GetValue(ArrowBrushProperty); } set { SetValue(ArrowBrushProperty, value); } }
        public static readonly DependencyProperty ArrowBrushProperty =
            DependencyProperty.Register("ArrowBrush", typeof(Brush), ThisControl, new PropertyMetadata(Brushes.Black));

        public Brush ArrowBrushHover { get { return (Brush)GetValue(ArrowBrushHoverProperty); } set { SetValue(ArrowBrushHoverProperty, value); } }
        public static readonly DependencyProperty ArrowBrushHoverProperty =
            DependencyProperty.Register("ArrowBrushHover", typeof(Brush), ThisControl, new PropertyMetadata(Brushes.Silver));

        public Brush ArrowBrushPressed { get { return (Brush)GetValue(ArrowBrushPressedProperty); } set { SetValue(ArrowBrushPressedProperty, value); } }
        public static readonly DependencyProperty ArrowBrushPressedProperty =
            DependencyProperty.Register("ArrowBrushPressed", typeof(Brush), ThisControl, new PropertyMetadata(Brushes.AliceBlue));

        public Thickness ArrowMargin { get { return (Thickness)GetValue(ArrowMarginProperty); } set { SetValue(ArrowMarginProperty, value); } }
        public static readonly DependencyProperty ArrowMarginProperty =
            DependencyProperty.Register("ArrowMargin", typeof(Thickness), ThisControl, new PropertyMetadata(new Thickness(4)));



        public Brush BackgroundHover { get { return (Brush)GetValue(BackgroundHoverProperty); } set { SetValue(BackgroundHoverProperty, value); } }
        public static readonly DependencyProperty BackgroundHoverProperty =
            DependencyProperty.Register("BackgroundHover", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFECF4FC"))));

        public Brush BorderBrushHover { get { return (Brush)GetValue(BorderBrushHoverProperty); } set { SetValue(BorderBrushHoverProperty, value); } }
        public static readonly DependencyProperty BorderBrushHoverProperty =
            DependencyProperty.Register("BorderBrushHover", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7EB4EA"))));

        public Brush ForegroundHover { get { return (Brush)GetValue(ForegroundHoverProperty); } set { SetValue(ForegroundHoverProperty, value); } }
        public static readonly DependencyProperty ForegroundHoverProperty =
            DependencyProperty.Register("ForegroundHover", typeof(Brush), ThisControl, new PropertyMetadata(Brushes.Black));



        public Brush BackgroundPressed { get { return (Brush)GetValue(BackgroundPressedProperty); } set { SetValue(BackgroundPressedProperty, value); } }
        public static readonly DependencyProperty BackgroundPressedProperty =
            DependencyProperty.Register("BackgroundPressed", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFECF4FC"))));

        public Brush BorderBrushPressed { get { return (Brush)GetValue(BorderBrushPressedProperty); } set { SetValue(BorderBrushPressedProperty, value); } }
        public static readonly DependencyProperty BorderBrushPressedProperty =
            DependencyProperty.Register("BorderBrushPressed", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7EB4EA"))));

        public Brush ForegroundPressed { get { return (Brush)GetValue(ForegroundPressedProperty); } set { SetValue(ForegroundPressedProperty, value); } }
        public static readonly DependencyProperty ForegroundPressedProperty =
            DependencyProperty.Register("ForegroundPressed", typeof(Brush), ThisControl, new PropertyMetadata(Brushes.Black));



        public CornerRadius BorderRadius { get { return (CornerRadius)GetValue(BorderRadiusProperty); } set { SetValue(BorderRadiusProperty, value); } }
        public static readonly DependencyProperty BorderRadiusProperty =
            DependencyProperty.Register("BorderRadius", typeof(CornerRadius), ThisControl, new PropertyMetadata(new CornerRadius(0)));



        public CornerRadius PopupBorderRadius { get { return (CornerRadius)GetValue(PopupBorderRadiusProperty); } set { SetValue(PopupBorderRadiusProperty, value); } }
        public static readonly DependencyProperty PopupBorderRadiusProperty =
            DependencyProperty.Register("PopupBorderRadius", typeof(CornerRadius), ThisControl, new PropertyMetadata(new CornerRadius(0)));

        public Thickness PopupBorderThickness { get { return (Thickness)GetValue(PopupBorderThicknessProperty); } set { SetValue(PopupBorderThicknessProperty, value); } }
        public static readonly DependencyProperty PopupBorderThicknessProperty =
            DependencyProperty.Register("PopupBorderThickness", typeof(Thickness), ThisControl, new PropertyMetadata(new Thickness(1)));

        public Thickness PopupContentsMargin { get { return (Thickness)GetValue(PopupContentsMarginProperty); } set { SetValue(PopupContentsMarginProperty, value); } }
        public static readonly DependencyProperty PopupContentsMarginProperty =
            DependencyProperty.Register("PopupContentsMargin", typeof(Thickness), ThisControl, new PropertyMetadata(new Thickness(2, 2, 0, 2)));

        public Brush PopupBackground { get { return (Brush)GetValue(PopupBackgroundProperty); } set { SetValue(PopupBackgroundProperty, value); } }
        public static readonly DependencyProperty PopupBackgroundProperty =
            DependencyProperty.Register("PopupBackground", typeof(Brush), ThisControl, new PropertyMetadata(Brushes.WhiteSmoke));

        public Brush PopupBorderBrush { get { return (Brush)GetValue(PopupBorderBrushProperty); } set { SetValue(PopupBorderBrushProperty, value); } }
        public static readonly DependencyProperty PopupBorderBrushProperty =
            DependencyProperty.Register("PopupBorderBrush", typeof(Brush), ThisControl, new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7EB4EA"))));

        public PlacementMode PopupPlacement { get { return (PlacementMode)GetValue(PopupPlacementProperty); } set { SetValue(PopupPlacementProperty, value); } }
        public static readonly DependencyProperty PopupPlacementProperty =
            DependencyProperty.Register("PopupPlacement", typeof(PlacementMode), ThisControl, new PropertyMetadata(PlacementMode.Bottom));

        public PopupAnimation PopupAnimation { get { return (PopupAnimation)GetValue(PopupAnimationProperty); } set { SetValue(PopupAnimationProperty, value); } }
        public static readonly DependencyProperty PopupAnimationProperty =
            DependencyProperty.Register("PopupAnimation", typeof(PopupAnimation), ThisControl, new PropertyMetadata(PopupAnimation.Fade));

        public Brush PopupScrollBarBrush { get { return (Brush)GetValue(PopupScrollBarBrushProperty); } set { SetValue(PopupScrollBarBrushProperty, value); } }
        public static readonly DependencyProperty PopupScrollBarBrushProperty =
            DependencyProperty.Register("PopupScrollBarBrush", typeof(Brush), ThisControl, new PropertyMetadata(Brushes.Gray));
    }
}
