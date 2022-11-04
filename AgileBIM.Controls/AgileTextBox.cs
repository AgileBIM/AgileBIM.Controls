using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

// Further research needs to be done on the memory implications of this design
// https://agsmith.wordpress.com/2008/04/07/propertydescriptor-addvaluechanged-alternative/
// https://web.archive.org/web/20210130171250/https://agsmith.wordpress.com/2008/04/07/propertydescriptor-addvaluechanged-alternative/


namespace AgileBIM.Controls
{
    public class AgileTextBox : TextBox
    {
        new protected void OnInitialized(EventArgs e)
        {   
            base.OnInitialized(e);
            DependencyPropertyDescriptor.FromProperty(UIElement.IsFocusedProperty, typeof(AgileTextBox))?.AddValueChanged(this, (s, evnt) => ReValidate());
        }

        static AgileTextBox()
        {
            TextBox.TextProperty.OverrideMetadata(typeof(AgileTextBox), new FrameworkPropertyMetadata(
                string.Empty,
                FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | FrameworkPropertyMetadataOptions.Journal,
                new PropertyChangedCallback(AgileTextChanged),
                new CoerceValueCallback(AgileCoerceText),
                true,
                UpdateSourceTrigger.PropertyChanged));
        }

        private void ReValidate()
        {
            AgileTextBox.ValidationPopupController(this, this.Text);
        }

        private static object AgileCoerceText(DependencyObject d, object value)
        {
            return value ?? String.Empty;
        }

        private static void AgileTextChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            AgileTextBox tbx = obj as AgileTextBox;
            AgileTextBox.ValidationPopupController(tbx, e.NewValue.ToString());
            tbx.RaiseEvent(new TextChangedEventArgs(AgileTextBox.TextChangedEvent, UndoAction.None));
        }

        private static void ValidationPopupController(AgileTextBox tbx, string value)
        {
            if (tbx != null && tbx.IsFocused == true && string.IsNullOrEmpty(tbx.ValidationRegexString) == false)
            {
                value = tbx.ValidateValueAsTrimmed ? value.Trim() : value;
                if (tbx.ValidationRegexString == "*")
                {
                    tbx.ValidationPopupIsOpen = true;
                }
                else if (value == "")
                {
                    if (tbx.ValidationPopupIsOpen == true)
                        tbx.ValidationPopupIsOpen = false;
                }
                else
                {
                    bool result = !Regex.IsMatch(value, tbx.ValidationRegexString);
                    if (tbx.ValidationPopupIsOpen != result)
                        tbx.ValidationPopupIsOpen = result;
                }
            }
        }



        public Brush WatermarkForeground { get { return (Brush)GetValue(WatermarkForegroundProperty); } set { SetValue(WatermarkForegroundProperty, value); } }
        public static readonly DependencyProperty WatermarkForegroundProperty =
            DependencyProperty.Register("WatermarkForeground", typeof(Brush), typeof(AgileTextBox), new PropertyMetadata(Brushes.LightGray));

        public FontFamily WatermarkFontFamily { get { return (FontFamily)GetValue(WatermarkFontFamilyProperty); } set { SetValue(WatermarkFontFamilyProperty, value); } }
        public static readonly DependencyProperty WatermarkFontFamilyProperty =
            DependencyProperty.Register("WatermarkFontFamily", typeof(FontFamily), typeof(AgileTextBox), new PropertyMetadata());

        public string Watermark { get { return (string)GetValue(WatermarkProperty); } set { SetValue(WatermarkProperty, value); } }
        public static readonly DependencyProperty WatermarkProperty =
            DependencyProperty.Register("Watermark", typeof(string), typeof(AgileTextBox), new PropertyMetadata(""));




        public CornerRadius BorderRadius { get { return (CornerRadius)GetValue(BorderRadiusProperty); } set { SetValue(BorderRadiusProperty, value); } }
        public static readonly DependencyProperty BorderRadiusProperty =
            DependencyProperty.Register("BorderRadius", typeof(CornerRadius), typeof(AgileTextBox), new PropertyMetadata(new CornerRadius(0)));

        public Brush BorderBrushFocused { get { return (Brush)GetValue(BorderBrushFocusedProperty); } set { SetValue(BorderBrushFocusedProperty, value); } }
        public static readonly DependencyProperty BorderBrushFocusedProperty =
            DependencyProperty.Register("BorderBrushFocused", typeof(Brush), typeof(AgileTextBox), new PropertyMetadata(new BrushConverter().ConvertFromString("#FF569DE5") as Brush));




        public CornerRadius ValidationPopupBorderRadius { get { return (CornerRadius)GetValue(ValidationPopupBorderRadiusProperty); } set { SetValue(ValidationPopupBorderRadiusProperty, value); } }
        public static readonly DependencyProperty ValidationPopupBorderRadiusProperty =
            DependencyProperty.Register("ValidationPopupBorderRadius", typeof(CornerRadius), typeof(AgileTextBox), new PropertyMetadata(new CornerRadius(0, 0, 6, 6)));

        public Thickness ValidationPopupBorderThickness { get { return (Thickness)GetValue(ValidationPopupBorderThicknessProperty); } set { SetValue(ValidationPopupBorderThicknessProperty, value); } }
        public static readonly DependencyProperty ValidationPopupBorderThicknessProperty =
            DependencyProperty.Register("ValidationPopupBorderThickness", typeof(Thickness), typeof(AgileTextBox), new PropertyMetadata(new Thickness(1)));

        public Thickness ValidationPopupMargin { get { return (Thickness)GetValue(ValidationPopupMarginProperty); } set { SetValue(ValidationPopupMarginProperty, value); } }
        public static readonly DependencyProperty ValidationPopupMarginProperty =
            DependencyProperty.Register("ValidationPopupMargin", typeof(Thickness), typeof(AgileTextBox), new PropertyMetadata(new Thickness(5, 0, 5, 0)));

        public bool ValidationPopupIsOpen { get { return (bool)GetValue(ValidationPopupIsOpenProperty); } set { SetValue(ValidationPopupIsOpenProperty, value); } }
        public static readonly DependencyProperty ValidationPopupIsOpenProperty =
            DependencyProperty.Register("ValidationPopupIsOpen", typeof(bool), typeof(AgileTextBox), new PropertyMetadata(false));

        public Brush ValidationPopupBorderBrush
        { get { return (Brush)GetValue(ValidationPopupBorderBrushProperty); } set { SetValue(ValidationPopupBorderBrushProperty, value); } }
        public static readonly DependencyProperty ValidationPopupBorderBrushProperty =
            DependencyProperty.Register("ValidationPopupBorderBrush", typeof(Brush), typeof(AgileTextBox), new PropertyMetadata(Brushes.Black));

        public Brush ValidationPopupBackground
        { get { return (Brush)GetValue(ValidationPopupBackgroundProperty); } set { SetValue(ValidationPopupBackgroundProperty, value); } }
        public static readonly DependencyProperty ValidationPopupBackgroundProperty =
            DependencyProperty.Register("ValidationPopupBackground", typeof(Brush), typeof(AgileTextBox), new PropertyMetadata(Brushes.Red));

        public string ValidationRegexString { get { return (string)GetValue(ValidationRegexStringProperty); } set { SetValue(ValidationRegexStringProperty, value); } }
        public static readonly DependencyProperty ValidationRegexStringProperty =
            DependencyProperty.Register("ValidationRegexString", typeof(string), typeof(AgileTextBox), new PropertyMetadata(""));

        public bool ValidateValueAsTrimmed { get { return (bool)GetValue(ValidateValueAsTrimmedProperty); } set { SetValue(ValidateValueAsTrimmedProperty, value); } }
        public static readonly DependencyProperty ValidateValueAsTrimmedProperty =
            DependencyProperty.Register("ValidateValueAsTrimmed", typeof(bool), typeof(AgileTextBox), new PropertyMetadata(true));

        public string ValidationMessage { get { return (string)GetValue(ValidationMessageProperty); } set { SetValue(ValidationMessageProperty, value); } }
        public static readonly DependencyProperty ValidationMessageProperty =
            DependencyProperty.Register("ValidationMessage", typeof(string), typeof(AgileTextBox), new PropertyMetadata(""));

        public Thickness ValidationMessageMargin { get { return (Thickness)GetValue(ValidationMessageMarginProperty); } set { SetValue(ValidationMessageMarginProperty, value); } }
        public static readonly DependencyProperty ValidationMessageMarginProperty =
            DependencyProperty.Register("ValidationMessageMargin", typeof(Thickness), typeof(AgileTextBox), new PropertyMetadata(new Thickness(3)));

    }
}
