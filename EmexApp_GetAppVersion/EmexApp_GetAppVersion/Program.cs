using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmexApp_GetAppVersion
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            Clipboard.SetText(date.ToString("yyyy.MMdd.HHmm"));
        }
    }
}
