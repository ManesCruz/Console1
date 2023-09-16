namespace Console1
{
    internal class Program
    {
        static void Main(string[] args)
                {
            		Console.WriteLine("Selecciona una opción:");
            		Console.WriteLine("5 Incrementar un número entero");
            		Console.WriteLine("6 Generar un número aleatorio incrementado");
            		Console.WriteLine("10 Calcular área y perímetro de un triángulo");
			Console.WriteLine("11 Calcular volumen del cilindro");
			Console.WriteLine("12 Pasar de centimetros a yardas");
			Console.WriteLine("121 Pasar de centimetros a metros");
			Console.WriteLine("122 Pasar de centimetros a pies");
			Console.WriteLine("123 Pasar de centimetros a pulgadas");
			Console.WriteLine("13 convertir de celsius a fahrenheit");
			Console.WriteLine("14 Calcular volumen cilindro solo positivos");
			Console.WriteLine("15 numeros divisibles");
		        Console.WriteLine("16 Porcentaje hombres y mujeres");
			Console.WriteLine("17 Evaluar numero positivo, negativo y nulo");
			Console.WriteLine("18 Evaluar numero mayor");
			Console.WriteLine("19 tipo de triangulo segun su lado");
			Console.WriteLine("20 docena de la ruleta");
			
            Console.Write("Ingresa tu elección: ");
            string input = Console.ReadLine();

            switch (input)
            {
                	    case "5":
                         int entero = incrementarEntero();
                         Console.WriteLine($"El número entero más uno es {entero}");
                   		      break;

                             case "6":
                           float numAumentado = generarAleatorioIncrementado();
                           Console.WriteLine($"Tu número aleatorio es más un 30% es {numAumentado}");
                                      break;

                	      case "10":
                            float area = calcularArea();
                            Console.WriteLine($"El área del triángulo es {area}");
			    float perimetro = calcularPerimetro();
			    Console.WriteLine($"El perímetro del triángulo es {perimetro}");
					break;
				case "11":
					 double volumen = volumenCilindro();
					 Console.WriteLine($"El perímetro del triángulo es {volumen}");
					break;
				case "12":
					double yardas =  converterYardas();
					Console.WriteLine($"La conversion de los centimetros en yardas es:{yardas}");
					break;
				case "121":
					double metros = converterMeters();
					Console.WriteLine($"La conversion de los centimetros en metros es:{metros}");
					break;
				case "122":
					double pies = converterPies();
					Console.WriteLine($"La conversion de los centimetros en pies es:{pies}");
					break;
				case "123":
					double pulgadas = converterPulgadas();
					Console.WriteLine($"La conversion de los centimetros en pies es:{pulgadas}");
					break;
				case "13":
					double Fareh = converterCelsius();
					Console.WriteLine($"La conversion de los celsius en fahrenheit es:{Fareh}");
				    break;
				case "14":
					double volumen1 = volumenCilindroRe();
					Console.WriteLine($"El volumen del cilindro es:{volumen1}");
				    break;
				case "15":
					string DivisibleRes = numeroDivisible();
					Console.WriteLine($"{DivisibleRes}");
					break;
				case "16":
                                        float porHombres = porcentajeGeneroHombres();
					Console.WriteLine($"El porcentaje de hombres es:{porHombres}%");
					float porMujeres = porcentajeGeneroMujeres();
					Console.WriteLine($"El porcentaje de mujeres es:{porMujeres}%");
					break;
				case "17":
					string numeroEvaluado = evaluarNumero();
					Console.WriteLine($"{numeroEvaluado}");
					break;
				case "18":
					string numeroMayor = Mayor();
					Console.WriteLine($"{numeroMayor}");
					break;
				case "19":
					string Tipo = tipoTriangulo();
					Console.WriteLine($"{Tipo}");
					break;
				case "20":
					string  resulRutela = ruleta();
					Console.WriteLine($"{resulRutela}");
					
					break;
				 default:
			    Console.WriteLine("No es valido el digito ingresado");
                    break;
            }
        }

        public static int incrementarEntero()
        {
            Console.WriteLine("Ingresa un número entero:");
            string entrada = Console.ReadLine();
            int numero = int.Parse(entrada);
            int numeroIncrementado = numero + 1;
            return numeroIncrementado;
        }
	
	    public static float generarAleatorioIncrementado()
	    {
            Random aleatorio = new Random();
            float resAleatorio = aleatorio.Next(0, 200);
            Console.WriteLine("Su número aleatorio es: " + resAleatorio);
            float porcentaje = ((resAleatorio * 30) / 100);
            float numAumentado = ((resAleatorio + porcentaje));
			return numAumentado;
	    }
	
        public static float calcularArea()
        {
            Console.WriteLine("Ingresa la base del triángulo:");
            string entradaBase = Console.ReadLine();
            float baseTriangulo = float.Parse(entradaBase);

            Console.WriteLine("Ingresa la altura del triángulo:");
            string entradaAltura = Console.ReadLine();
            float alturaTriangulo = float.Parse(entradaAltura);

            float area = (baseTriangulo * alturaTriangulo) / 2;
            return area;
        }

        public static float calcularPerimetro()
        {
            Console.WriteLine("Ingresa la base del triángulo:");
            string entradaBase = Console.ReadLine();
            float baseTriangulo = float.Parse(entradaBase);

            Console.WriteLine("Ingresa la altura del triángulo:");
            string entradaAltura = Console.ReadLine();
            float alturaTriangulo = float.Parse(entradaAltura);

            float hipotenusa = (float)Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
            float perimetro = baseTriangulo + alturaTriangulo + hipotenusa;
            return perimetro;
        }
	     public static double volumenCilindro()
	{
		    Console.WriteLine("Ingrese el valor del radio del cilindro:");
            String entrada3 = Console.ReadLine();
            double radio = float.Parse(entrada3);
            Console.WriteLine("Ingrese el valor de la altura del cilindro");
            String entrada4 = Console.ReadLine();
            double Altur = float.Parse(entrada4);
            double volumen = Math.PI * (Math.Pow(radio,2)) * Altur;
		    return volumen;
	}
	   public static double converterYardas()
	   {
		    Console.WriteLine("Ingrese el valor de la medida en centimetros");
            String centimetros = Console.ReadLine();
            double cen = float.Parse(centimetros);
	        double yardas= cen / 91.44;
		    return yardas;
	   }
	
	   public static double converterMeters()
	   {
	        Console.WriteLine("Ingrese el valor de la medida en centimetros");
            String centimetros = Console.ReadLine();
            double cen = float.Parse(centimetros);
		    double metros = cen / 100;
		    return metros;
	   }  
	
	   public static double converterPies()
	   {
	        Console.WriteLine("Ingrese el valor de la medida en centimetros");
            String centimetros = Console.ReadLine();
            double cen = float.Parse(centimetros);
		    double pies = cen / 30.48;
		    return pies;
	   }
	
	    public static double converterPulgadas()
	   {
		    Console.WriteLine("Ingrese el valor de la medida en centimetros");
            String centimetros = Console.ReadLine();
            double cen = float.Parse(centimetros);
	        double pulgadas = cen / 2.54;
			return pulgadas;
	   }
	    
	    public static double converterCelsius()
		{
		     Console.WriteLine("Ingrese el valor de la tempreatura en grados Celsius: ");

            String Celsius = Console.ReadLine();
            double cel =  Convert.ToDouble(Celsius);

               //Conversion Celsius a Fahrenheit
            var nuevecinco = Convert.ToDouble(9.0 / 5.0);
            double Fahre = (cel*nuevecinco)+32;
            return Fahre;
		}
	
	    public static double volumenCilindroRe()
		{
		Console.WriteLine("Ingrese el valor del radio del cilindro:");
           double radio1;

        while (true)
        {
            string entrada5 = Console.ReadLine();
            radio1 = double.Parse(entrada5);

            if (radio1 >= 0)
                break;
            Console.WriteLine("Ingrese un dato positivo para el radio :");
        }
        Console.WriteLine("Ingrese el valor de la altura del cilindro:");
        double Altur2;

        while (true)
        {
            string entrada6 = Console.ReadLine();
            Altur2 = double.Parse(entrada6);

            if (Altur2 >= 0)
                break;
            Console.WriteLine("ingrese un dato positivo para la altura: ");
        }
        double volumen1 = Math.PI * Math.Pow(radio1, 2) * Altur2;
        return volumen1;
		}
	    public static string numeroDivisible()
		{
		string DivisibleRes = "";
		Console.WriteLine("ingrese el valor numero 1:");
		  string input4 = Console.ReadLine();
          int numerova1 = Int32.Parse(input4);
		
	    Console.WriteLine("ingrese el valor numero 2:");
		  string input5 = Console.ReadLine();
          int numerova2 = Int32.Parse(input5);
		
		if (numerova2 != 0){
		 if(numerova2 % numerova1 == 0){
			 DivisibleRes = "el numero 2 es divisible por el numero 1";			 
		 }else{
		     DivisibleRes = "el numero 2 no es divisible por el numero 1";
	        }
	    }
			return DivisibleRes;
	 }
	
	    public static float porcentajeGeneroHombres()
	   {
			Console.WriteLine("ingrese el numero de hombres:");
		  string input6 = Console.ReadLine();
          int hombres = Int32.Parse(input6);
		
	    Console.WriteLine("ingrese el numero de mujeres:");
		  string input7 = Console.ReadLine();
          int mujeres = Int32.Parse(input7);
		
		//cien porciento de hombres y mujeres
		  int cien = hombres+mujeres;
		//porcentaje de hombres
		   float porHombres= (hombres*cien)/100; 
		//porcentaje de mujeres
		   float porMujeres= (mujeres*cien)/100;
			return porHombres;
	    }
		  public static float porcentajeGeneroMujeres()
	   {
		 Console.WriteLine("ingrese el numero de hombres:");
		  string input6 = Console.ReadLine();
          int hombres = Int32.Parse(input6);
		
	    Console.WriteLine("ingrese el numero de mujeres:");
		  string input7 = Console.ReadLine();
          int mujeres = Int32.Parse(input7);
		
		//cien porciento de hombres y mujeres
		  int cien = hombres+mujeres;
		//porcentaje de hombres
		   float porHombres= (hombres*cien)/100; 
		//porcentaje de mujeres
		   float porMujeres= (mujeres*cien)/100;
	       return porMujeres;
       }
	      public static string evaluarNumero()
	{
		string numeroEvaluado = "";
	    Console.WriteLine ("ingrese el numero a evaluar ");
		  string input8 = Console.ReadLine();
          int? ponenu = Int32.Parse(input8); 
		
            if(ponenu > 0){
                numeroEvaluado = "El numero ingresado es un numero positivo.";
			}
            if (ponenu < 0) {
                numeroEvaluado ="El numero ingresado es un numero negativo.";
            }
		    if(ponenu == null){
			     numeroEvaluado ="El numero ingresado es un numero nulo.";
		    }
	    return numeroEvaluado;
	  }
	        public static string Mayor()
			{
				string numeroMayor = "";             
				Console.WriteLine("ingrese el numero 1 ");
		  string input14 = Console.ReadLine();
          float numero1 = float.Parse(input14);
				  Console.WriteLine("ingrese el numero 2");
		  string input15 = Console.ReadLine();
          float numero2 = float.Parse(input15); 
				  Console.WriteLine("ingrese el numero 3 ");
		  string input16 = Console.ReadLine();
          float numero3 = float.Parse(input16); 
		 if (numero1 > numero2 && numero1 > numero3){
			numeroMayor = "el numero 1 es el mayor"; 
		 }		 
		if (numero2 > numero1 && numero2 > numero3){
			numeroMayor = "el numero 2 es el mayor"; 
		 }		
		if (numero3 > numero2 && numero3 > numero1){
			numeroMayor = "el numero 3 es el mayor"; 
		 }
		return numeroMayor;
			}
	public static string tipoTriangulo()
	{
		string Tipo = "";
	  Console.WriteLine("ingrese el valor del lado 1 ");
		  string input9 = Console.ReadLine();
          float lado1 = float.Parse(input9);
				  Console.WriteLine("ingrese el valor del lado 2 ");
		  string input10 = Console.ReadLine();
          float lado2 = float.Parse(input10); 
				  Console.WriteLine("ingrese el valor del lado 3 ");
		  string input11 = Console.ReadLine();
          float lado3 = float.Parse(input11); 
		
		if (lado1 != lado2 && lado2 != lado3){
		Tipo = "Es un triangulo Escaleno";
		}
		if ((lado1 == lado2 && lado2 != lado3)||(lado1 == lado3 && lado3 != lado2)||(lado2 == lado3 && lado3 != lado1)){
		Tipo = "Es un triangulo Isosceles";
		}
		if(lado1 == lado2 && lado2 == lado3){
		Tipo = "Es un triangulo Equilatero";
		}
	return Tipo;
	}
	public static string ruleta()
	{
		string resulRutela = "";
	 Console.WriteLine("cual fue el resultado de ruleta ");
		  string input12 = Console.ReadLine();
          int resul = Int32.Parse(input12);
		if(resul>=0 && resul<12){
		 resulRutela = "el resultado se encuentra en la primera docena ";
		}
		if(resul>=12 && resul<24){
		 resulRutela = "el resultado se encuentra en la segunda docena ";
		}
		if(resul>=24 && resul<36){
		 resulRutela = "el resultado se encuentra en la tercera docena ";
		}
		return resulRutela;
	  }
				
	}
