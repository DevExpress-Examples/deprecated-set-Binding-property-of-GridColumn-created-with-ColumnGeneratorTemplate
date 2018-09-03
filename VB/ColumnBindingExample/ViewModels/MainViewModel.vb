Imports DevExpress.Mvvm.DataAnnotations
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Namespace ColumnBindingExample.ViewModels
    <POCOViewModel> _
    Public Class MainViewModel
        Protected Sub New()
            Data = New ObservableCollection(Of Dictionary(Of String, Object))()
            For i As Integer = 0 To 24
                Data.Add(New Dictionary(Of String, Object)() From { _
                    { "ID", i }, _
                    { "Name", "Name" & i }, _
                    { "Date", Date.Now.Date }, _
                    { "Check", False } _
                })
            Next i
            Columns = New ObservableCollection(Of ColumnViewModel)()
            Columns.Add(New ColumnViewModel() With { _
                .Header = "ID", _
                .FieldName = "[ID]" _
            })
            Columns.Add(New ColumnViewModel() With { _
                .Header = "Name", _
                .FieldName = "[Name]" _
            })
            Columns.Add(New ColumnViewModel() With { _
                .Header = "Date", _
                .FieldName = "[Date]" _
            })
            Columns.Add(New ColumnViewModel() With { _
                .Header = "Check", _
                .FieldName = "[Check]" _
            })
        End Sub

        Public Overridable Property Columns() As ObservableCollection(Of ColumnViewModel)
        Public Overridable Property Data() As ObservableCollection(Of Dictionary(Of String, Object))
    End Class

    Public Class ColumnViewModel
        Public Property FieldName() As String
        Public Property Header() As String
    End Class
End Namespace