using KnockKnockDesktop.Helpers;
using KnockKnockDesktop.KnockKnockServiceRef;
using KnockKnockDesktop.Model;
using KnockKnockDesktop.Services;
using KnockKnockDesktop.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KnockKnockDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        RequestMainView _mainVM; 
        public MainWindow()
        {
            InitializeComponent();            
            _mainVM = new RequestMainView();
            DataContext = _mainVM;            
        }

        private void btnApprove_Click(object sender, RoutedEventArgs e)
        {
            RequestData dataRowView = (RequestData)grdRequests.SelectedItem;
            ProcessRequest(dataRowView,true);
        }

        private void BtnReject_Click(object sender, RoutedEventArgs e)
        {

            RequestData dataRowView = (RequestData)grdRequests.SelectedItem;
            ProcessRequest(dataRowView, false);
        }
            
        private async Task ProcessRequest(RequestData dataRowView, bool Action)
        {
            await Task.Run(() =>
            {
                try
                {
                    App.Current.Dispatcher.Invoke((Action)delegate
                    {
                        WCFServiceCall RequestsService = new WCFServiceCall();
                        int RequestID = dataRowView.RequestID;
                        bool res = RequestsService.UpdateRequestRecord(RequestID, Action);
                        if (res)
                        {
                            _mainVM.RequestList.Remove(dataRowView);
                        }
                    });
                }
                catch (Exception ex)
                {
                    AppLogger.LogExceptionInFile(ex.Message.ToString(), "ProcessRequest", ex);
                }
            });
        }
    }
}
