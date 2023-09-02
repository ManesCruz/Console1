namespace Console1
{
    internal class Program
    {
        static void Main(string[] args)
         {

            //Ejercicio 18:


            //Ejercicio 17:
            Console.WriteLine("ingrese el numero a evaluar ");
            string input8 = Console.ReadLine();
            int? ponenu = Int32.Parse(input8);

            if (ponenu > 0)
            {
                Console.WriteLine("El numero ingresado " + ponenu + " es un numero positivo.");
            }
            if (ponenu < 0)
            {
                Console.WriteLine("El numero ingresado " + ponenu + " es un numero negativo.");
            }
            if (ponenu == null)
            {
                Console.WriteLine("El numero ingresado " + ponenu + " es un numero nulo.");
            }

            //Ejercicio 16:
            Console.WriteLine("ingrese el numero de hombres:");
            string input6 = Console.ReadLine();
            int hombres = Int32.Parse(input6);

            Console.WriteLine("ingrese el numero de mujeres:");
            string input7 = Console.ReadLine();
            int mujeres = Int32.Parse(input7);

            //cien porciento de hombres y mujeres
            int cien = hombres + mujeres;
            //porcentaje de hombres
            float porhombres = (hombres * cien) / 100;
            Console.WriteLine("el porcentaje de hombres es del: " + porhombres + " %");
            //porcentaje de mujeres
            float pormujeres = (mujeres * cien) / 100;
            Console.WriteLine("el porcentaje de mujeres es del: " + pormujeres + " %");

            Console.WriteLine();


            //Ejercicio 15:
            Console.WriteLine("ingrese el valor numero 1:");
            string input4 = Console.ReadLine();
            int numerova1 = Int32.Parse(input4);

            Console.WriteLine("ingrese el valor numero 2:");
            string input5 = Console.ReadLine();
            int numerova2 = Int32.Parse(input5);

            if (numerova2 != 0)
            {
                if (numerova2 % numerova1 == 0)
                {
                    Console.WriteLine("el " + numerova2 + " es divisible por " + numerova1);
                }
                else
                {
                    Console.WriteLine("el " + numerova2 + " no es divisible por " + numerova1);
                }
            }

            Console.WriteLine();

            //Ejercicio 14:
            Console.WriteLine("Ingrese el valor del radio del cilindro:");
            float radio1;

            while (true)
            {
                string entrada5 = Console.ReadLine();
                radio1 = float.Parse(entrada5);

                if (radio1 >= 0)
                    break;
                Console.WriteLine("Ingrese un dato positivo para el radio :");
            }
            Console.WriteLine("Ingrese el valor de la altura del cilindro:");
            float Altur2;

            while (true)
            {
                string entrada6 = Console.ReadLine();
                Altur2 = float.Parse(entrada6);

                if (Altur2 >= 0)
                    break;
                Console.WriteLine("ingrese un dato positivo para la altura: ");
            }
            double volumen1 = Math.PI * Math.Pow(radio1, 2) * Altur2;
            Console.WriteLine("El volumen del cilindro es: " + volumen1);


            Console.WriteLine();

            //Ejercicio 13
            Console.WriteLine("Ingrese el valor de la tempreatura en grados Celsius: ");

            String Celsius = Console.ReadLine();
            double cel = Convert.ToDouble(Celsius);

            //Conversion Celsius a Fahrenheit
            var nuevecinco = Convert.ToDouble(9.0 / 5.0);
            double Fahre = (cel * nuevecinco) + 32;
            Console.WriteLine("De Celsius a Fahrenheit es: " + Fahre);

            Console.WriteLine();

            //Ejercicio 12
            Console.WriteLine("Ingrese el valor de la medida en centimetros");
            String centimetros = Console.ReadLine();
            double cen = float.Parse(centimetros);

            //Centimetros a yardas
            double yardas = cen / 91.44;
            Console.WriteLine("De centimetros a yardas es: " + yardas);
            //Centimetros a metros
            double metros = cen / 100;
            Console.WriteLine("De centimetros a metros es: " + metros);
            //Centimetros a pies
            double pies = cen / 30.48;
            Console.WriteLine("De centimetros a pies es: " + pies);
            //Centimetros a pulgadas
            double pulgadas = cen / 2.54;
            Console.WriteLine("De centimetros a pulgadas es: " + pulgadas);

            Console.WriteLine();



            //Ejercicio 11
            Console.WriteLine("Ingrese el valor del radio del cilindro:");
            String entrada3 = Console.ReadLine();
            float radio = float.Parse(entrada3);
            Console.WriteLine("Ingrese el valor de la altura del cilindro");
            String entrada4 = Console.ReadLine();
            float Altur = float.Parse(entrada4);
            double volumen = Math.PI * (Math.Pow(radio, 2)) * Altur;
            Console.WriteLine("El volumen del cilindro es de: " + volumen);

            Console.WriteLine();

            //Ejercicio 10
            Console.WriteLine("Ingrese el valor de la base del triangulo:");
            String entrada = Console.ReadLine();
            float Base = float.Parse(entrada);
            Console.WriteLine("Ingrese el valor de la altura del triangulo:");
            String entrada2 = Console.ReadLine();
            float Altura = float.Parse(entrada2);
            //Hipotenusa para hallar el perimetro
            //Math.Sqrt(Base * Base + Altura * Altura);
            //Area
            float Area = ((Base * Altura) / 2);
            Console.WriteLine("El area del triangulo es: " + Area);
            //Perimetro
            double Perimetro = ((Math.Sqrt((Math.Pow(Base, 2)) + (Math.Pow(Altura, 2)))) + Base + Altura);
            Console.WriteLine("El perimetro del triangulo es: " + Perimetro);

            Console.WriteLine();


            //Ejercicio 6
            Random aleatorio = new Random();
            float resaleatorio = aleatorio.Next(0, 200);
            Console.WriteLine("Su número aleatorio es: " + resaleatorio);
            float porcentaje = ((resaleatorio * 30) / 100);
            float numaumentado = ((resaleatorio + porcentaje));
            Console.WriteLine("Su numero aumentado en un 30% es: " + numaumentado);

            Console.WriteLine();


            //Ejercicio 5
            Console.WriteLine("Ingrese un número entero ");

            string input = Console.ReadLine();
            int numero = Int32.Parse(input);
            Console.WriteLine("El numero siguiente a " + numero + " es:");
            Console.WriteLine(numero + 1);


        }
    }
