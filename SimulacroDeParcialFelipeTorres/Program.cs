using System;

namespace SimulacroDeParcialFelipeTorres
{
    class Program
    {
        static void Main(string[] args)
        {
            int Hora24;
            Console.WriteLine("Ingresar Hora");
            int Hora = int.Parse(Console.ReadLine()) ;
            Console.WriteLine("Ingresar Minutos");
            int Minutos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar Segundos");
            int Segundos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar AM o PM");
            var AM_PM = Console.ReadLine().ToUpper();

            if (AM_PM == "AM")
            {
                if (VerficarHora(Hora))
                {
                    if (Agregar0aHora(Hora))
                    {
                        if (VerificarMinutos(Minutos))
                        {
                            if (Agregar0aMinutos(Minutos))
                            {
                                if (VerificarSegundos(Segundos))
                                {
                                    if (Agregar0aSegundo(Segundos))
                                    {
                                        Console.WriteLine($"La Hora Ingresada es 0{Hora}:0{Minutos}:0{Segundos}AM");
                                        Console.Write($"Y en Formato 24Hs es 0{Hora}:0{Minutos}:0{Segundos}AM");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"La Hora Ingresada es 0{Hora}:0{Minutos}:{Segundos}AM");
                                        Console.Write($"Y en Formato 24Hs es 0{Hora}:0{Minutos}:{Segundos}AM");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Error. El Numero Que Ingresar En Segundo No Deve Ser Mayor a 60.");
                                }
                            }
                            else
                            {
                                if (VerificarSegundos(Segundos))
                                {
                                    if (Agregar0aSegundo(Segundos))
                                    {
                                        Console.WriteLine($"La Hora Ingresada es 0{Hora}:{Minutos}:0{Segundos}AM");
                                        Console.Write($"Y en Formato 24Hs es 0{Hora}:{Minutos}:0{Segundos}AM");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"La Hora Ingresada es 0{Hora}:{Minutos}:{Segundos}AM");
                                        Console.Write($"Y en Formato 24Hs es 0{Hora}:{Minutos}:{Segundos}AM");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Error. El Numero Que Ingresar En Segundo No Deve Ser Mayor a 60.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error. El Numero Que Ingresar En Minutos No Deve Ser Mayor a 60.");
                        }

                    }
                    else
                    {
                        if (VerificarMinutos(Minutos))
                        {
                            if (Agregar0aMinutos(Minutos))
                            {
                                if (VerificarSegundos(Segundos))
                                {
                                    if (Agregar0aSegundo(Segundos))
                                    {
                                        Console.WriteLine($"La Hora Ingresada es {Hora}:0{Minutos}:0{Segundos}AM");
                                        Console.Write($"Y en Formato 24Hs es {Hora}:0{Minutos}:0{Segundos}AM");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"La Hora Ingresada es {Hora}:0{Minutos}:{Segundos}AM");
                                        Console.Write($"Y en Formato 24Hs es {Hora}:0{Minutos}:0{Segundos}AM");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Error. El Numero Que Ingresar En Segundo No Deve Ser Mayor a 60.");
                                }
                            }
                            else
                            {
                                if (VerificarSegundos(Segundos))
                                {
                                    if (Agregar0aSegundo(Segundos))
                                    {
                                        Console.WriteLine($"La Hora Ingresada es {Hora}:{Minutos}:0{Segundos}AM");
                                        Console.Write($"Y en Formato 24Hs es {Hora}:{Minutos}:0{Segundos}AM");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"La Hora Ingresada es {Hora}:{Minutos}:{Segundos}AM");
                                        Console.Write($"Y en Formato 24Hs es {Hora}:{Minutos}:0{Segundos}AM");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Error. El Numero Que Ingresar En Segundo No Deve Ser Mayor a 60.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error. El Numero Que Ingresar En Minutos No Deve Ser Mayor a 60.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error. El Numero Que Ingresar En Hora Debeser De 1 a 12.");
                }

                Console.ReadLine();
            }
            else if (AM_PM == "PM")
            {
                if (VerficarHora(Hora))
                {
                    Hora24 = Hora + 12;
                    if (Hora24==0)
                    {
                        if (Agregar0aHora(Hora))
                        {
                            if (VerificarMinutos(Minutos))
                            {
                                if (Agregar0aMinutos(Minutos))
                                {
                                    if (VerificarSegundos(Segundos))
                                    {
                                        if (Agregar0aSegundo(Segundos))
                                        {
                                            Console.WriteLine($"La Hora Ingresada es 0{Hora}:0{Minutos}:0{Segundos}PM");
                                            Console.Write($"Y en Formato 24Hs es 0{Hora24}:0{Minutos}:0{Segundos}PM");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"La Hora Ingresada es 0{Hora}:0{Minutos}:{Segundos}PM");
                                            Console.Write($"Y en Formato 24Hs es 0{Hora24}:0{Minutos}:{Segundos}PM");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error. El Numero Que Ingresar En Segundo No Deve Ser Mayor a 60.");
                                    }
                                }
                                else
                                {
                                    if (VerificarSegundos(Segundos))
                                    {
                                        if (Agregar0aSegundo(Segundos))
                                        {
                                            Console.WriteLine($"La Hora Ingresada es 0{Hora}:{Minutos}:0{Segundos}PM");
                                            Console.Write($"Y en Formato 24Hs es 0{Hora24}:{Minutos}:0{Segundos}PM");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"La Hora Ingresada es 0{Hora}:{Minutos}:{Segundos}PM");
                                            Console.Write($"Y en Formato 24Hs es 0{Hora24}:{Minutos}:{Segundos}PM");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error. El Numero Que Ingresar En Segundo No Deve Ser Mayor a 60.");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error. El Numero Que Ingresar En Minutos No Deve Ser Mayor a 60.");
                            }

                        }
                        else
                        {
                            if (VerificarMinutos(Minutos))
                            {
                                if (Agregar0aMinutos(Minutos))
                                {
                                    if (VerificarSegundos(Segundos))
                                    {
                                        if (Agregar0aSegundo(Segundos))
                                        {
                                            Console.WriteLine($"La Hora Ingresada es {Hora}:0{Minutos}:0{Segundos}PM");
                                            Console.Write($"Y en Formato 24Hs es {Hora24}:0{Minutos}:0{Segundos}PM");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"La Hora Ingresada es {Hora}:0{Minutos}:{Segundos}PM");
                                            Console.Write($"Y en Formato 24Hs es {Hora24}:0{Minutos}:{Segundos}PM");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error. El Numero Que Ingresar En Segundo No Deve Ser Mayor a 60.");
                                    }
                                }
                                else
                                {
                                    if (VerificarSegundos(Segundos))
                                    {
                                        if (Agregar0aSegundo(Segundos))
                                        {
                                            Console.WriteLine($"La Hora Ingresada es {Hora}:{Minutos}:0{Segundos}AM");
                                            Console.Write($"Y en Formato 24Hs es {Hora24}:{Minutos}:0{Segundos}AM");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"La Hora Ingresada es {Hora}:{Minutos}:{Segundos}PM");
                                            Console.Write($"Y en Formato 24Hs es {Hora24}:{Minutos}:{Segundos}PM");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error. El Numero Que Ingresar En Segundo No Deve Ser Mayor a 60.");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error. El Numero Que Ingresar En Minutos No Deve Ser Mayor a 60.");
                            }
                        }
                    }
                    else
                    {
                        if (Agregar0aHora(Hora))
                        {
                            if (VerificarMinutos(Minutos))
                            {
                                if (Agregar0aMinutos(Minutos))
                                {
                                    if (VerificarSegundos(Segundos))
                                    {
                                        if (Agregar0aSegundo(Segundos))
                                        {
                                            Console.WriteLine($"La Hora Ingresada es 0{Hora}:0{Minutos}:0{Segundos}PM");
                                            Console.Write($"Y en Formato 24Hs es {Hora24}:0{Minutos}:0{Segundos}PM");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"La Hora Ingresada es 0{Hora}:0{Minutos}:{Segundos}PM");
                                            Console.Write($"Y en Formato 24Hs es 0{Hora24}:0{Minutos}:{Segundos}PM");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error. El Numero Que Ingresar En Segundo No Deve Ser Mayor a 60.");
                                    }
                                }
                                else
                                {
                                    if (VerificarSegundos(Segundos))
                                    {
                                        if (Agregar0aSegundo(Segundos))
                                        {
                                            Console.WriteLine($"La Hora Ingresada es 0{Hora}:{Minutos}:0{Segundos}PM");
                                            Console.Write($"Y en Formato 24Hs es 0{Hora24}:{Minutos}:0{Segundos}PM");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"La Hora Ingresada es 0{Hora}:{Minutos}:{Segundos}PM");
                                            Console.Write($"Y en Formato 24Hs es 0{Hora24}:{Minutos}:{Segundos}PM");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error. El Numero Que Ingresar En Segundo No Deve Ser Mayor a 60.");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error. El Numero Que Ingresar En Minutos No Deve Ser Mayor a 60.");
                            }

                        }
                        else
                        {
                            if (VerificarMinutos(Minutos))
                            {
                                if (Agregar0aMinutos(Minutos))
                                {
                                    if (VerificarSegundos(Segundos))
                                    {
                                        if (Agregar0aSegundo(Segundos))
                                        {
                                            Console.WriteLine($"La Hora Ingresada es {Hora}:0{Minutos}:0{Segundos}PM");
                                            Console.Write($"Y en Formato 24Hs es {Hora24}:0{Minutos}:0{Segundos}PM");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"La Hora Ingresada es {Hora}:0{Minutos}:{Segundos}PM");
                                            Console.Write($"Y en Formato 24Hs es {Hora24}:0{Minutos}:{Segundos}PM");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error. El Numero Que Ingresar En Segundo No Deve Ser Mayor a 60.");
                                    }
                                }
                                else
                                {
                                    if (VerificarSegundos(Segundos))
                                    {
                                        if (Agregar0aSegundo(Segundos))
                                        {
                                            Console.WriteLine($"La Hora Ingresada es {Hora}:{Minutos}:0{Segundos}AM");
                                            Console.Write($"Y en Formato 24Hs es {Hora24}:{Minutos}:0{Segundos}AM");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"La Hora Ingresada es {Hora}:{Minutos}:{Segundos}PM");
                                            Console.Write($"Y en Formato 24Hs es {Hora24}:{Minutos}:{Segundos}PM");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error. El Numero Que Ingresar En Segundo No Deve Ser Mayor a 60.");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error. El Numero Que Ingresar En Minutos No Deve Ser Mayor a 60.");
                            }
                        }
                    }
                   
                }
                else
                {
                    Console.WriteLine("Error. El Numero Que Ingresar En Hora Debeser De 1 a 12.");
                }

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Error. Solo se Acepta Ingresar AM o PM");
                Console.ReadLine();
            }
        }

        private static bool Agregar0aSegundo(int Segundos)
        {
            return Segundos < 10 || Segundos >(-1);
        }

        private static bool VerificarSegundos(int Segundos)
        {
            return Segundos <= 60 || Segundos >= (-1);
        }

        private static bool Agregar0aMinutos(int Minutos)
        {
            return (Minutos <= 9) || (Minutos >= 0);
        }

        private static bool VerificarMinutos(int Minutos)
        {
            return(Minutos<=60) || (Minutos>=0);
        }

        private static bool Agregar0aHora(int Hora)
        {
            return(Hora<=9) || (Hora>=0);
        }

        private static bool VerficarHora(int Hora)
        {
            return(Hora<=12) || (Hora>=1) ;
        }

        

    }
}
