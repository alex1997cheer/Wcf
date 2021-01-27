using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace ReportServices
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“ReportService”。
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class ReportService : IReportService
    {
        public void ProcessReport()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50);
                OperationContext.Current.GetCallbackChannel<IReportServiceCallback>().Process(i);
            }
        }
    }
}
