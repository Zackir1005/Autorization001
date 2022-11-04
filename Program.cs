using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TryCatchLab001
{
    class Program
    {
        static public void NameCheck()
        {
            Regex _regex = new Regex(@"\s\d{1}\w*");
            string _text = Console.ReadLine();
            MatchCollection _matches = _regex.Matches(_text);
            Console.WriteLine( _matches);

        }
        static void Main(string[] args)
        {
            NameCheck();
            try
            {
                //Lord Voldemort
                if (args[0] == "Voldemort")
                {
                    throw new Exception("Тсс! Это имя нельзя произносить!");
                }
                else
                {
                    if (args[0] == "Lord_Voldemort")
                    {
                        throw new Exception("Тсс! Это имя ТОЖЕ нельзя произносить!");
                    }
                    else
                    {
                        Console.WriteLine("Здравствуйте, {0}!", args[0]);
                    }

                }

            }
            catch (Exception ex001) when (ex001.Message == "Тсс! Это имя нельзя произносить!")
            {
                //Console.WriteLine("Случилось {0}", ex001.ToString());
                Console.WriteLine("Непроизносимое имя: {0}", ex001.Message);
                //throw;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Нет аргумента командной строки");
            }
            catch (Exception ex002)
            {
                Console.WriteLine("Возникло: {0}", ex002.ToString());
            }

            //finally
            //{

            //}

            Authorization myAuthorization = new Authorization();
            string _path = "Dwarfs.txt";
            int _count = myAuthorization.readNames(_path);
            Console.WriteLine("В файле {0} {1} строк", _path, _count);

        }
    }
}