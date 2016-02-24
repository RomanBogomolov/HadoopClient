using System.Collections.Generic;
using System.Linq;
using Microsoft.Hadoop.MapReduce;

namespace MapClient
{
    class RootReducer : ReducerCombinerBase
    {   
        public override void Reduce(string key, IEnumerable<string> values, ReducerCombinerContext context)
        {
            var seek = values.GroupBy(x => x).OrderByDescending(x => x.Count()).First();

            string tmp =
                string.Concat(seek.Key, "\t\t", "Count:", "\t", seek.Key.Count().ToString());

            context.EmitKeyValue(key, tmp);
        }
    }
}
