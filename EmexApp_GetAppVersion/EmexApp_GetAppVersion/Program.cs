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
        [STAThread]
        static void Main(string[] args)
        {
            System.Diagnostics.Process.Start("http://tfs.emexmsk.local:8080/tfs/emex/v1.0/_apps/hub/ms.vss-ciworkflow.build-ci-hub?_a=edit-build-definition&id=611");
            var date = DateTime.Now;
            Clipboard.SetText(date.ToString("yyyy.MMdd.HHmm"));
        }
    }
}
