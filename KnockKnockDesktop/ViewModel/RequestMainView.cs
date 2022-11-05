using KnockKnockDesktop.KnockKnockServiceRef;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KnockKnockDesktop.Services;
using KnockKnockDesktop.Model;
using KnockKnockDesktop.Helpers;

namespace KnockKnockDesktop.ViewModel
{
    public class RequestMainView : RequestBase
    {
        private ObservableCollection<RequestData> _RequestList = null;
        public ObservableCollection<RequestData> RequestList
        {
            get { return _RequestList; }
            set
            {
                _RequestList = value;
                OnPropertyChanged("RequestList");
            }
        }

        public RequestMainView()
        {
            RequestList = new ObservableCollection<RequestData>();
            LoadData();            
        }

        private async Task LoadData()
        {
            await Task.Run(() =>
            {
                try
                {
                    while (true)
                    {
                        WCFServiceCall RequestsService = new WCFServiceCall();
                        List<RequestModel> RequestsFromService = RequestsService.CheckRecievedRequests();
                        int count = 0;
                        if (RequestsFromService.Count() > 0)
                        {
                            foreach (var ReqList in RequestsFromService)
                            {
                                string State = (ReqList.Status == 0) ? "Pending" : (ReqList.Status == 1) ? "Approved" : "Rejected";
                                count++;
                                App.Current.Dispatcher.Invoke((Action)delegate
                                {
                                    if (ReqList.Status == 0)
                                    {
                                        if (RequestList.Where(requestid => requestid.RequestID == ReqList.RequestID).FirstOrDefault() == null)
                                        {
                                            RequestList.Add(new RequestData { RequestID = ReqList.RequestID, No = count, CreatedAt = ReqList.CreatedAt, Status = State });
                                        }
                                    }
                                });
                            }
                        }
                        Thread.Sleep(10000);
                    }
                }
                catch(Exception ex)
                {
                    AppLogger.LogExceptionInFile(ex.Message.ToString(), "LoadData", ex);
                }
            });            
        }
    }
}
