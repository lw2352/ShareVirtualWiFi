using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareVirtualWiFi
{
    class ShareWIFI
    {
        public string shareWiFI(string ssid,string password)
        {
            System.Diagnostics.Process _pCmd;

            _pCmd = new System.Diagnostics.Process();
            _pCmd.StartInfo.FileName = "cmd.exe";
            _pCmd.StartInfo.UseShellExecute = false;
            _pCmd.StartInfo.RedirectStandardOutput = true;
            _pCmd.StartInfo.RedirectStandardInput = true;
            _pCmd.StartInfo.CreateNoWindow = true;
            _pCmd.Start();

            string cmd = "netsh wlan set hostednetwork mode=allow ssid="+ssid+ " key=" +  password;

            try
            {
                _pCmd.StandardInput.WriteLine(cmd);
                _pCmd.StandardInput.WriteLine("netsh wlan start hostednetwork");
                //一定要关闭。
                _pCmd.StandardInput.WriteLine("exit");
                return "True";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return "False";
            }
        }

        public void CloseWIFI()
        {
            System.Diagnostics.Process _pCmd;

            _pCmd = new System.Diagnostics.Process();
            _pCmd.StartInfo.FileName = "cmd.exe";
            _pCmd.StartInfo.UseShellExecute = false;
            _pCmd.StartInfo.RedirectStandardOutput = true;
            _pCmd.StartInfo.RedirectStandardInput = true;
            _pCmd.StartInfo.CreateNoWindow = true;
            _pCmd.Start();

            string cmd = "netsh wlan stop hostednetwork";
            _pCmd.StandardInput.WriteLine(cmd);
            _pCmd.StandardInput.WriteLine("exit");
        }

    }
}
