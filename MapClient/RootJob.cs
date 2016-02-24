using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Hadoop.MapReduce;
namespace MapClient
{
    class RootJob : HadoopJob<RootMapper, RootReducer>
    {
        public override HadoopJobConfiguration Configure(ExecutorContext context)
        {
            var config = new HadoopJobConfiguration
            {
                InputPath = "wasb:///test2.txt",
                OutputFolder = "wasb:///myresclust"
            };
            
            return config;

        }
    }
}
