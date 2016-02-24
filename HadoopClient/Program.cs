using System;
using System.Linq;
using Microsoft.WindowsAzure.Management.HDInsight;
using System.Security.Cryptography.X509Certificates;


namespace HadoopClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListClusters();
            CreateCluster();
            //DeleteCluster();
            Console.ReadKey();
        }

        public static void ListClusters()
        {
            var store = new X509Store();
            store.Open(OpenFlags.ReadOnly);

            var cert = store.Certificates.Cast<X509Certificate2>()
                .First(item => item.Thumbprint == Constants.thumbprint);

            var creds = new HDInsightCertificateCredential(Constants.subscriptionId, cert);
            var client = HDInsightClient.Connect(creds);

            var clusters = client.ListClusters();
            
            if (clusters.Count > 0)
            {
                foreach (var item in clusters)
                {
                    Console.WriteLine("Cluster: {0}, Nodes: {1}", item.Name, item.ClusterSizeInNodes);
                }
            }
            else
            {
                Console.WriteLine("Cluster not found!");
            }
        }
        public static void CreateCluster()
        {
            var store = new X509Store();
            store.Open(OpenFlags.ReadOnly);

            var cert = store.Certificates.Cast<X509Certificate2>()
                .First(item => item.Thumbprint == Constants.thumbprint);  
            
            var creds = new HDInsightCertificateCredential(Constants.subscriptionId, cert);
            var client = HDInsightClient.Connect(creds);

            //Cluster information
            var clusterInfo = new ClusterCreateParameters()
            {
                Name = Constants.clusterName,
                Location = "Central US",
                DefaultStorageAccountName = Constants.storageAccount,
                DefaultStorageAccountKey = Constants.storageAccountKey,
                DefaultStorageContainer = Constants.container,
                UserName = Constants.clusterUser,
                Password = Constants.clusterPassword,
                ClusterSizeInNodes = 1  
            };

            var clusterDetails = client.CreateCluster(clusterInfo);
            ListClusters();
        }

        public static void DeleteCluster()
        {
            var store = new X509Store();
            store.Open(OpenFlags.ReadOnly);
            
            var cert = store.Certificates.Cast<X509Certificate2>()
                .First(item => item.Thumbprint == Constants.thumbprint);
            
            var creds = new HDInsightCertificateCredential(Constants.subscriptionId, cert);
            var client = HDInsightClient.Connect(creds);

            client.DeleteCluster(Constants.clusterName);
            ListClusters();
        }
    }
}
