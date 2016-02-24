using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;
using Microsoft.Hadoop.MapReduce;

namespace MapClient
{
    class RootMapper : MapperBase
    {
        public override void Map(string inputLine, MapperContext context)
        {
            string[] words = 
                inputLine.Trim().Split(new char[] { ' ', '.', '?', ',', ':', '!','"', ')', '(', '-', '*', '$', '\'', ';', '\\', '/' }, 
                StringSplitOptions.RemoveEmptyEntries);
           
            for (int i = 0; i < words.Count() - 1; i++)
            {
                context.EmitKeyValue(words[i], words[i + 1]);
            }
        }

    }
}
