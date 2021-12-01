using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TodoApi.Models
{
    public class TodoRepository : ITodoRepository
    {
        /* ConcurrentDictionary - represents a thread-safe collection of
         * key value pairs than can be accesed by multiple
         * threads concurrently
         * 
         * Concurrent - Multiple computations are happening at the same time.
         */
        public static ConcurrentDictionary<string, TodoItem> _todos =
            new ConcurrentDictionary<string, TodoItem>();
    }
}
