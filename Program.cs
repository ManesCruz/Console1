namespace Console1
{
    internal class Program
    {
        static void Main(string[] args)
              {
		   //Ejercicio 10
		            Console.WriteLine("Ingrese el valor de la base del triangulo:");
		    String entrada = Console.ReadLine();
            int Base = Int32.Parse(entrada);
				    Console.WriteLine("Ingrese el valor de la altura del triangulo:");
		    String entrada2 = Console.ReadLine();
            int Altura = Int32.Parse(entrada2);
		  //Hipotenusa para hallar el perimetro
		     //Math.Sqrt(Base * Base + Altura * Altura);
		  //Area
		    double Area=((Base*Altura)/2);
		       Console.WriteLine("El area del triangulo es: " + Area);
		  //Perimetro
		    double Perimetro= ((Math.Sqrt(Base * Base + Altura * Altura))+Base+Altura);
		    Console.WriteLine("El perimetro del triangulo es: " + Perimetro);
		    
		 Console.WriteLine();
		    
		
            //Ejercicio 6
            Random aleatorio = new Random();
		    int resaleatorio = aleatorio.Next(0, 200);
		    Console.WriteLine("Su número aleatorio es: "+ resaleatorio);   
		    double porcentaje= ((resaleatorio*30)/100);
		    double numaumentado= ((resaleatorio+porcentaje));
		    Console.WriteLine("Su numero aumentado en un 30% es: "+ numaumentado);
		   
		Console.WriteLine();
		

            //Ejercicio 5
            Console.WriteLine("Ingrese un número entero ");
     
            string input = Console.ReadLine();
            int numero = Int32.Parse(input);
		    Console.WriteLine("El numero siguiente a "+ numero +" es:");  
            Console.WriteLine(numero + 1);
            

        }
    }
