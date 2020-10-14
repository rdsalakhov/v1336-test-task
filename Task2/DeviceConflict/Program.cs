using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace DeviceConflict
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Arguments not found");
                return;
            }

            try
            {
                var reader = new JsonDeviceReader(args[0]);
                var writer = new JsonConflictWriter(args[1]);
                var resolver = new DeviceResolver();
                resolver.Resolve(reader, writer);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            
        }

        
    }
}