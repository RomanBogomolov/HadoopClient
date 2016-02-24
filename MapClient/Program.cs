using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Hadoop.MapReduce;
using Microsoft.WindowsAzure.Storage.File;
//using Microsoft.WindowsAzure.StorageClient.Protocol;
//using Microsoft.Hadoop.WebClient;
using Microsoft.WindowsAzure.Storage.Core;
using Microsoft.WindowsAzure.Storage.Core.Executor;
using System.Security.Cryptography.X509Certificates;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
//using Microsoft.WindowsAzure.Storage.Auth;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using Microsoft.Hadoop.WebClient.AmbariClient;
using Microsoft.Hadoop.WebClient.AmbariClient.Contracts;


namespace MapClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Const
            Environment.SetEnvironmentVariable("HADOOP_HOME", @"c:\hadoop");
            Environment.SetEnvironmentVariable("Java_HOME", @"c:\hadoop\jvm");
            
            DoCustomMapReduce();
            Console.ReadKey();
        }
        public static void DoCustomMapReduce()
        {
            Console.WriteLine("Starting MapReduce job...");
            IHadoop hadoop = Hadoop.Connect(Constants.azureClusterUri, Constants.clusterUser, Constants.hadoopUser, 
                Constants.clusterPassword, Constants.storageAccount, Constants.storageAccountKey, 
                Constants.container, true);

            var output = hadoop.MapReduceJob.ExecuteJob<RootJob>();

        }

    }
}
