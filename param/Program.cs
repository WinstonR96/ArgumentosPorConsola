using System;
using System.Collections.Generic;

namespace param
{
    class Program
    {
        static Dictionary<string, string> paramList = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                string key = args[i].ToLower(); ;
                if (key.Equals("-h"))
                {
                    MostrarAyuda();
                }else if(!key.Equals("-n") && !key.Equals("-h") && !key.Equals("-a"))
                {
                    MostrarOpciones(key);
                    return;
                }
                else
                {
                    i++;
                    string value = args[i];
                    paramList.Add(key, value);
                }   
                           
            }

            
            //string valorH = paramList["-n"];
            //string valorT = paramList["-a"];
            //Console.WriteLine("Nombre: {0}", valorH);
            //Console.WriteLine("Apellido: {0}", valorT);
            Console.ReadLine();
        }

        private static void MostrarOpciones(string key)
        {
            Console.WriteLine("Opcion desconocida {0}", key);
            Console.WriteLine("Uso: param [-h] [-n <value>] [-a <value>]");
        }

        private static void MostrarAyuda()
        {
            Console.WriteLine("Uso: param [-h] [-n <value>] [-a <value>]");
            Console.WriteLine("\n Estos son los comando usados diferentes situaciones");
            Console.WriteLine("\n Agregar informacion");
            Console.WriteLine("-n         Nombre del usuario");
            Console.WriteLine("-a         Apellido del usuario");
        }
    }
}
