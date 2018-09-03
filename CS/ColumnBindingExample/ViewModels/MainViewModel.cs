using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ColumnBindingExample.ViewModels {
    [POCOViewModel]
    public class MainViewModel {
        protected MainViewModel() {
            Data = new ObservableCollection<Dictionary<string, object>>();
            for (int i = 0; i < 25; i++)
                Data.Add(new Dictionary<string, object>() { { "ID", i }, { "Name", "Name" + i }, { "Date", DateTime.Now.Date }, { "Check", false } });
            Columns = new ObservableCollection<ColumnViewModel>();
            Columns.Add(new ColumnViewModel() { Header = "ID", FieldName = "[ID]" });
            Columns.Add(new ColumnViewModel() { Header = "Name", FieldName = "[Name]" });
            Columns.Add(new ColumnViewModel() { Header = "Date", FieldName = "[Date]" });
            Columns.Add(new ColumnViewModel() { Header = "Check", FieldName = "[Check]" });
        }

        public virtual ObservableCollection<ColumnViewModel> Columns { get; set; }
        public virtual ObservableCollection<Dictionary<string, object>> Data { get; set; }
    }

    public class ColumnViewModel {
        public string FieldName { get; set; }
        public string Header { get; set; }
    }
}