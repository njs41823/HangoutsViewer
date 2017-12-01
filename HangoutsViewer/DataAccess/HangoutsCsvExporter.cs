using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using ServiceStack.Text;
using HangoutsViewer.Models.Interfaces;
using HangoutsViewer.Models.Interfaces.HangoutEvents;

namespace HangoutsViewer.DataAccess
{
    public static class HangoutCsvExporter
    {
        public static async Task ExportHangout(IHangout hangout, string fileName)
        {
            using (StreamWriter file = new StreamWriter(fileName, false, Encoding.GetEncoding("Windows-1252")))
            {
                IEnumerable<HangoutEventCsv> hangoutEventCsvs = 
                    from IHangoutEvent h 
                    in hangout.HangoutEvents
                    select new HangoutEventCsv(h);
                await file.WriteAsync(CsvSerializer.SerializeToCsv(hangoutEventCsvs));
            }
        }

        private class HangoutEventCsv
        {
            private readonly IHangoutEvent _hangoutEvent;

            // this gets ReSharper to shut up about the following properties never being used
            // ReSharper disable UnusedMember.Local
            public string TimeStamp => _hangoutEvent.TimeStamp.ToString("yyyy-MM-dd hh:mm:ss tt");

            public string SenderId => _hangoutEvent.Sender.Id;

            public string SenderName => _hangoutEvent.Sender.Name;

            public string Text => _hangoutEvent.Text;

            public string Attachment => _hangoutEvent.Attachment;

            public HangoutEventCsv(IHangoutEvent hangoutEvent)
            {
                _hangoutEvent = hangoutEvent;
            }
        }
    }

    
}
