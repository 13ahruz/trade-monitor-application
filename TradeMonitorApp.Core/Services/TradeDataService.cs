using System;
using System.Collections.Generic;
using TradeMonitorApp.Core.Models;

namespace TradeMonitorApp.Core.Services
{
    public class TradeDataService
    {
        public event EventHandler<IEnumerable<TradeData>> TradeDataAdded;

        public void AddTradeData(IEnumerable<TradeData> data)
        {
            TradeDataAdded?.Invoke(this, data);
        }
    }
}
