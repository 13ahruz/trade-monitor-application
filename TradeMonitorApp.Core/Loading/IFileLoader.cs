using TradeMonitorApp.Core.Models;

namespace TradeMonitorApp.Core.Loading
{
    public interface IFileLoader
    {
        bool CanLoad(string filePath);
        IEnumerable<TradeData> Load(string filePath);
    }
}
