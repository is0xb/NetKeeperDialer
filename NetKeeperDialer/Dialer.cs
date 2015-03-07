using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading;

namespace iWay.NetKeeperDialer
{
    public class Dialer
    {
        Thread dialer;
        
        string rtIp;
        string rtAcc;
        string rtPsw;
        string lcCnn;
        string nkAcc;
        string nkPsw;
        string dlType;

        public void BeginRouterDial(string rtIp, string rtAcc, string rtPsw, string nkAcc, string nkPsw)
        {
            this.rtIp = rtIp;
            this.rtAcc = rtAcc;
            this.rtPsw = rtPsw;
            this.nkAcc = nkAcc;
            this.nkPsw = nkPsw;
            this.dlType = "Router";

            dialer = new Thread(Dial);
            dialer.IsBackground = true;
            dialer.Start();
        }

        public void BeginLocalDial(string lcCnn, string nkAcc, string nkPsw)
        {
            this.lcCnn = lcCnn;
            this.nkAcc = nkAcc;
            this.nkPsw = nkPsw;
            this.dlType = "Local";

            dialer = new Thread(Dial);
            dialer.IsBackground = true;
            dialer.Start();
        }

        public bool IsNetConnected(int timeout = 250)
        {
            if (timeout < 250)
                throw new Exception("Timeout >= 250.");
            DateTime startTime = DateTime.Now;
            while ((DateTime.Now - startTime).TotalMilliseconds <= timeout)
            {
                try
                {
                    Ping ping = new Ping();
                    PingReply rep = ping.Send("110.75.216.92", 250);
                    ping.Dispose();
                    if (rep.Status == IPStatus.Success)
                        return true;
                }
                catch { }
            }
            return false;
        }

        string dialInfo = "";

        void RouterDial()
        {
            string realAccount = NKAccount.ComputeRealAccount(nkAcc);
            RouterDialer rtdialer = new RouterDialer();
            rtdialer.SetRouterInfo(rtIp, rtAcc, rtPsw);
            rtdialer.SetPPPoEInfo(realAccount, nkPsw);
            rtdialer.BeginRouterDial();
            if (IsNetConnected(10000))
            {
                return;
            }
            throw new Exception("Router dial failed.");
        }

        void LocalDial()
        {
            ProcessStartInfo ifo = new ProcessStartInfo();
            ifo.UseShellExecute = false;
            ifo.CreateNoWindow = true;
            ifo.FileName = "rasdial.exe";
            ifo.Arguments = "\"" + lcCnn + "\"" +
                " \"" + NKAccount.ComputeRealAccount(nkAcc) + "\" " +
                "\"" + nkPsw + "\"";
            Process p = Process.Start(ifo);
            p.WaitForExit(10000);
            if (!p.HasExited)
            {
                p.Kill();
                p.Close();
            }
            if (IsNetConnected(5000))
            {
                return;
            }
            throw new Exception("Local dial failed.");
        }

        void Dial()
        {
            if(IsNetConnected())
            {
                dialInfo = "网络已连接，无需拨号。";
                return;
            }
            if (dlType == "Router")
            {
                try
                {
                    RouterDial();
                    dialInfo = "路由器连接成功！";
                }
                catch
                {
                    dialInfo = "路由器连接失败！请确认支持此路由器且所填信息正确。";
                }
            }
            if (dlType == "Local")
            {
                try
                {
                    LocalDial();
                    dialInfo = "本地直接连接成功！";
                }
                catch
                {
                    dialInfo = "本地直接连接失败！请确认已创建宽带连接且所填信息正确。";
                }
            }
        }

        public string GetState()
        {
            if (dialer == null)
            {
                return "Inited";
            }
            if (dialer.IsAlive)
            {
                return "Dialing";
            }
            else
            {
                return "DialEnd";
            }
        }

        public string GetDialInfo()
        {
            return dialInfo;
        }

        public void Reset()
        {
            if (dialer != null)
            {
                dialer.Abort();
                dialer = null;
            }

            rtIp = null;
            rtAcc = null;
            rtPsw = null;
            lcCnn = null;
            nkAcc = null;
            nkPsw = null;
            dlType = null;

            dialInfo = "";
        }
    }
}
