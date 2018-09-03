using System.Windows;
using System.Windows.Data;

namespace ColumnBindingExample {
    public class ColumnBindingHelper {
        public static readonly DependencyProperty BindingPathProperty = DependencyProperty.RegisterAttached("BindingPath", typeof(string), typeof(ColumnBindingHelper), new PropertyMetadata(null, OnBindingPathChanged));

        private static void OnBindingPathChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            var column = d as DevExpress.Xpf.Grid.GridColumn;
            if (column == null || e.NewValue == null)
                return;
            column.Binding = new Binding(e.NewValue.ToString());
        }

        public static string GetBindingPath(DependencyObject obj) {
            return (string)obj.GetValue(BindingPathProperty);
        }

        public static void SetBindingPath(DependencyObject obj, string value) {
            obj.SetValue(BindingPathProperty, value);
        }
    }
}
