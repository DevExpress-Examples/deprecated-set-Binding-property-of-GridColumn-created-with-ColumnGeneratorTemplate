Imports System.Windows
Imports System.Windows.Data

Namespace ColumnBindingExample
    Public Class ColumnBindingHelper
        Public Shared ReadOnly BindingPathProperty As DependencyProperty = DependencyProperty.RegisterAttached("BindingPath", GetType(String), GetType(ColumnBindingHelper), New PropertyMetadata(Nothing, AddressOf OnBindingPathChanged))

        Private Shared Sub OnBindingPathChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            Dim column = TryCast(d, DevExpress.Xpf.Grid.GridColumn)
            If column Is Nothing OrElse e.NewValue Is Nothing Then
                Return
            End If
            column.Binding = New Binding(e.NewValue.ToString())
        End Sub

        Public Shared Function GetBindingPath(ByVal obj As DependencyObject) As String
            Return DirectCast(obj.GetValue(BindingPathProperty), String)
        End Function

        Public Shared Sub SetBindingPath(ByVal obj As DependencyObject, ByVal value As String)
            obj.SetValue(BindingPathProperty, value)
        End Sub
    End Class
End Namespace
