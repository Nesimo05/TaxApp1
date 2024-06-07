using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaxApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultPageFlyout : ContentPage
    {
        public ListView ListView;

        public ResultPageFlyout()
        {
            InitializeComponent();

            BindingContext = new ResultPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class ResultPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ResultPageFlyoutMenuItem> MenuItems { get; set; }

            public ResultPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<ResultPageFlyoutMenuItem>(new[]
                {
                    new ResultPageFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new ResultPageFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new ResultPageFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new ResultPageFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new ResultPageFlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}