using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace IPModifer
{
    public class NetworkAdapterMannager
    {
        private Dictionary<string, string> AllNIC = new Dictionary<string, string>();
        private List<NetworkAdapter> ntks = new List<NetworkAdapter>();

        public NetworkAdapterMannager()
        {
            this.initNICItem();
            this.initNICInfo();
        }

        public Dictionary<string, string> AllNIC1
        {
            get
            {
                return AllNIC;
            }

            set
            {
                AllNIC = value;
            }
        }

        //刷新
        public void Refresh()
        {
            this.initNICItem();
            this.initNICInfo();
        }

        //获取网卡条目
        private void initNICItem()
        {
            this.AllNIC.Clear();
            ManagementClass wmi = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = wmi.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if (!(bool)mo["IPEnabled"]) continue;
                this.AllNIC.Add(mo["Caption"].ToString(), mo["SettingID"].ToString());
            }
        }

        /// <summary>
        ///  获取网卡信息
        /// </summary>
        private void initNICInfo()
        {
            ntks.Clear();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in nics)
            {
                NetworkAdapter ntk = new NetworkAdapter();
                ntk.Id = adapter.Id;
                ntk.Name = adapter.Name;

               //获取以太网卡网络接口信息
               IPInterfaceProperties ip = adapter.GetIPProperties();
               //获取单播地址集

               UnicastIPAddressInformationCollection ipCollection = ip.UnicastAddresses;
               foreach (UnicastIPAddressInformation ipadd in ipCollection)
               {
                    //InterNetwork    IPV4地址      InterNetworkV6        IPV6地址
                    //Max            MAX 位址
                    if (ipadd.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                            //判断是否为ipv4
                            ntk.Ip = ipadd.Address.ToString();//获取ip
                            ntk.Mask = ipadd.IPv4Mask.ToString();
                     }
                }
                //获取子网掩码
                if (ip.UnicastAddresses.Count > 0)
                {
                    Console.WriteLine("IP地址:" + ip.UnicastAddresses[0].Address.ToString());
                    Console.WriteLine("子网掩码:" + ip.UnicastAddresses[0].IPv4Mask.ToString());
                    //tbMask.Text = ip.UnicastAddresses[0].IPv4Mask.ToString();
                }
                //获取默认网关
                if (ip.GatewayAddresses.Count > 0)
                {
                    Console.WriteLine("默认网关:" + ip.GatewayAddresses[0].Address.ToString());   //默认网关
                    ntk.Gateway = ip.GatewayAddresses[0].Address.ToString();
                }
                //首选DNS与备用DNS
                int DnsCount = ip.DnsAddresses.Count;
                Console.WriteLine("DNS服务器地址：");
                if (DnsCount > 0)
                {
                    //其中第一个为首选DNS，第二个为备用的，余下的为所有DNS为DNS备用，按使用顺序排列
                    for (int i = 0; i < DnsCount; i++)
                    {
                        Console.WriteLine("i=" + i + ":" + ip.DnsAddresses[i].ToString());
                        if (i == 0)
                        {
                            ntk.Dns1 = ip.DnsAddresses[0].ToString();
                        }

                        if (i == 1)
                        {
                            ntk.Dns1 = ip.DnsAddresses[1].ToString();
                        }
                    }

                }
                ntks.Add(ntk);
            }
        }
    
        /// <summary>
        /// 将Caption转换为ID
        /// </summary>
        /// <param name="caption">网卡Caption</param>
        /// <returns>网卡ID</returns>
        private string Caption2Id(string caption)
        {
            string id = AllNIC1[caption];
            return id;
        }


        /// <summary>
        /// 通过网卡Caption获取网卡信息
        /// </summary>
        /// <param name="caption">网卡Caption</param>
        /// <returns>Network对象</returns>
        public NetworkAdapter getNICInfoByCaption(string caption)
        {
            string id = Caption2Id(caption);
            NetworkAdapter nk = new NetworkAdapter();
            foreach (NetworkAdapter ntk in ntks)
            {
                if (ntk.Id == id)
                {
                    nk = ntk;
                }
            }
            return nk;
        }

        /// <summary>
        /// 设置网卡信息
        /// </summary>
        /// <param name="SettingID"></param>
        /// <param name="ip"></param>
        /// <param name="submask"></param>
        /// <param name="gateway"></param>
        /// <param name="dns"></param>
        public void setNetwork(string SettingID, string[] ip, string[] submask, string[] gateway, string[] dns)
        {
            ManagementClass wmi = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = wmi.GetInstances();
            ManagementBaseObject inPar = null;
            ManagementBaseObject outPar = null;
            foreach (ManagementObject mo in moc)
            {
                //如果没有启用IP设置的网络设备则跳过
                if (!(bool)mo["IPEnabled"])
                    continue;
                if (mo["SettingID"].ToString() != SettingID)
                    continue;

                //设置IP地址和掩码
                if (ip != null && submask != null)
                {
                    inPar = mo.GetMethodParameters("EnableStatic");
                    inPar["IPAddress"] = ip;
                    inPar["SubnetMask"] = submask;
                    outPar = mo.InvokeMethod("EnableStatic", inPar, null);
                }

                //设置网关地址
                if (gateway != null)
                {
                    inPar = mo.GetMethodParameters("SetGateways");
                    inPar["DefaultIPGateway"] = gateway;
                    outPar = mo.InvokeMethod("SetGateways", inPar, null);
                }

                //设置DNS地址
                if (dns != null)
                {
                    inPar = mo.GetMethodParameters("SetDNSServerSearchOrder");
                    inPar["DNSServerSearchOrder"] = dns;
                    outPar = mo.InvokeMethod("SetDNSServerSearchOrder", inPar, null);
                }
            }
        }
    }
}
