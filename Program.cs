using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        bool Addmenu = true;
        while(Addmenu)
        {
            Console.WriteLine("Menu Principal");
            Console.WriteLine("1. Ingresar Universidad");
            Console.WriteLine("2. Salir");
            var option = Convert.ToString(Console.ReadLine());
            if(option =="1")
            {
                Console.WriteLine("Ingresar Numero de Universidades");
                var numerou = Convert.ToInt32(Console.ReadLine());
                for(int i=0;i<numerou;i++)
                {
                    Console.WriteLine("Universidad");
                    var nombreUni = Convert.ToString(Console.ReadLine());
                    bool votos = true;
                    var aceptan = 0;
                    var rechazan = 0;
                    var blancos = 0;
                    var nulos = 0;
                    while(votos)
                    {
                        Console.WriteLine("Votos (A=aceptan,R=rechazan,N=Nulo,B=Blancos) y 1 para salir: ");
                        var votoFinal = Console.ReadLine();
                        if(votoFinal == "A")
                        {
                            aceptan = aceptan + 1;
                        }
                        if(votoFinal == "B")
                        {
                            rechazan = rechazan + 1;
                        }
                        if(votoFinal == "N")
                        {
                            blancos = blancos+ 1;
                        }
                        if(votoFinal == "B")
                        {
                            nulos = nulos+ 1;
                        }
                        Console.WriteLine("Agregar otro voto");
                        if(votoFinal == "1")
                        {
                            votos = false;
                        }
                    }
                    Console.WriteLine($"Nombre Universidad: {nombreUni}");
                    Console.WriteLine($"Votos Aprovados: {aceptan}");
                    Console.WriteLine($"Votos Rechazan: {rechazan}");
                    Console.WriteLine($"Votos Nulos: {nulos}");
                    Console.WriteLine($"Votos Blanco: {blancos}");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}