using System;
using System.IO;
namespace Registro
{
    class Program
    {
         private static string Informacion;
        static void Main(string[] args)
        {
            Informacion = args[0];

                if (!File.Exists(Informacion))
            {
                using (StreamWriter file = new StreamWriter(Informacion))
                {
                    file.WriteLine("Cedula" + "," + "Nombre" + "," + "Apellido" + "," + "Edad");
                }
            }
                    programa:
                    string Nom, Ape, A1, A2, Cedu;
                    double Edad;
                    
                    
                        StreamWriter archivo = File.AppendText(Informacion);
                        Console.Write("Cedula:");
                        Cedu = Console.ReadLine();
                        Console.Write("Nombre:");
                        Nom = Console.ReadLine();
                        Console.Write("Apellido:");
                        Ape =Console.ReadLine();
                        Console.Write("Edad:");
                        Edad =Convert.ToDouble (Console.ReadLine());
                        Console.WriteLine("Quieres guardar?");
                        Console.WriteLine("SI [S]  ||  No [N]  ||  Cerrar [C] ");
                        A1 =Console.ReadLine();
                        A2 = A1.ToLower();

                        if(A2 == "s")
                        {
                             archivo.WriteLine(Cedu + "," + Nom + "," + Ape + "," + Edad);
                             archivo.Close();
                        }
                        if(A2 == "n")
                        {
                                archivo.Close();
                                goto programa;
                        }
                    
                    if(A2 == "c")
                        {
                                archivo.Close();
                                goto Final;
                        }
                    Final :
                    Console.WriteLine("finalizado el programa.......");
                    
        }
    }
}
