using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TryCatchLab001
{
    class Authorization
    {
        private List<string> Names = new List<string>();
        
        public int readNames(string _path)
        {
            try
            {
                StreamReader myStreamReader = new StreamReader(_path);
                string _buffer = "";
                do
                {
                    _buffer = myStreamReader.ReadLine();
                    if (_buffer == null)
                    {
                        return 0;
                    }
                    Names.Add(_buffer);
                    Console.WriteLine(_buffer);
                } while (_buffer != null);
            }
            catch (Exception ex001)
            {
                
                Console.WriteLine(ex001.Message);
            }
            return Names.Count;
        }

    }
}
