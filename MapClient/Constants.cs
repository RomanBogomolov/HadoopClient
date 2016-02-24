using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapClient
{
    public class Constants
    {
       // public static Uri azureClusterUri = new Uri("https://AutomateclusterHDICluster.azurehdinsight.net:563");
        public static Uri azureClusterUri = new Uri("https://Autocluster12.azurehdinsight.net:443");
        public static string thumbprint = "FC3145E9D24C2BEBADB5E067A2F57A74F2C0AA82";
        public static Guid subscriptionId = new Guid("056c57ff-4837-4ec8-8aac-124e234fffb2");
       // public static string clusterName = "AutomateclusterHDICluster";
        public static string clusterName = "Autocluster12";
        public static string clusterUser = "romkapm";
        public static string hadoopUser = "hdp";
        public static string clusterPassword = "Password-1217";
        //public static string storageAccount = "storagehadoopclient.blob.core.windows.net";
        public static string storageAccount = "storagehadoopclient";
        public static string storageAccountKey = "JGP7qyV8P7uK9fd6dCafVbPT98IiFvFC5Hpaie8wSi1sXFIn4Nh0eKFM0KSvxDrW+TGxNa5HnH9vlU1VPOz42w==";
        public static string container = "autoclaster12";
        public static string wasbPath = "wasb://autoclaster12@storagehadoopclient.blob.core.windows.net";
    }
}
