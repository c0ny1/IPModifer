using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPModifer
{
    public class Network
    {
        private String nic;//网卡
        private String name;//网络名称
        private String id;//网卡编号
        private String ip;//ip地址
        private String mask;//子网掩码
        private String gateway;//网关
        private String dns1;//首选DNS
        private String dns2;//备选DNS


        public string Nic
        {
            get
            {
                return nic;
            }

            set
            {
                nic = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Ip
        {
            get
            {
                return ip;
            }

            set
            {
                ip = value;
            }
        }

        public string Mask
        {
            get
            {
                return mask;
            }

            set
            {
                mask = value;
            }
        }

        public string Gateway
        {
            get
            {
                return gateway;
            }

            set
            {
                gateway = value;
            }
        }

        public string Dns1
        {
            get
            {
                return dns1;
            }

            set
            {
                dns1 = value;
            }
        }

        public string Dns2
        {
            get
            {
                return dns2;
            }

            set
            {
                dns2 = value;
            }
        }


    }
}
