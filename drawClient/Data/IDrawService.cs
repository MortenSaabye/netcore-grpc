using System;
using System.Threading.Tasks;

namespace drawClient.Data
{
    public interface IDrawService
    {
        Task SendPoint(int x, int y, string colorHex);
    }
}
