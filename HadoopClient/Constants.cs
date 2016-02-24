using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.HDInsight;

namespace HadoopClient
{
    public class Constants
    {
        public static Uri azureClusterUri = new Uri("https://AutomatclusterHDICluster.azurehdinsight.net:563");
        public static string thumbprint = "***";
        public static Guid subscriptionId = new Guid("***");
        public static string clusterName = "AutomatclusterHDICluster";
        public static string clusterUser = "romkapm";
        public static string hadoopUser = "hdp";
        public static string clusterPassword = "***";
        public static string storageAccount = "storagehadoopclient.blob.core.windows.net";
        public static string storageAccountKey = "***";
        public static string container = "myhadoopclientcontres";
        public static string wasbPath = "wasb://hadoopclientcont@storagehadoopclient.blob.core.windows.net";
    }
}
