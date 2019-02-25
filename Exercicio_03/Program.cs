using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menulooping = true;
            bool menu2looping = true;
            List<int> lstNumeros = new List<int>();
            List<string> lstFruta = new List<string>();
            List<string> lstV_Fruta = new List<string>();
            // List<double> lstV_Fruta = new List<double>();


            String menu = "1 - Calcular Area do triangulo\n2 - Calcular equação do Segundo Grau\n3 - " +
                "Incluir Lista de Numeros\n4 - Cadastrar (Frutas)\n0 - Sair ";


            while (menulooping)

            {
                Console.WriteLine(menu);
                Console.Write("Opçao:");


                int m = int.Parse(Console.ReadLine());
                switch (m)
                {
                    case 1:




                        Console.WriteLine(" Informe os valores abaixo");
                        Console.WriteLine("Informe o Valor de A");
                        decimal basea = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Informe o Valor de B");
                        decimal baseb = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Informe o Valor de C");
                        decimal basec = decimal.Parse(Console.ReadLine());


                        string equ = "Triângulo equilátero: possui os três lados com medidas iguais.";
                        string iso = "Triângulo isósceles: possui dois lados com medidas iguais. ";
                        string esc = "Triângulo escaleno: possui os três lados com medidas diferentes. ";

                        if ((basea == baseb) && (baseb == basec))
                        {
                            Console.WriteLine(equ);

                        }
                        else if ((basea == baseb) || (baseb == basec) || (basea == basec))
                        {
                            Console.WriteLine(iso);

                        }

                        else if ((basea != baseb) && (baseb != basec))
                        {
                            Console.WriteLine(esc);
                        }



                        break;


                    case 2:
                        double delta, x1, x2;
                        Console.WriteLine("Equação do segundo GRAU");
                        Console.Write("Digite o valor de A");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o valor de B");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o valor de C");
                        double c = Convert.ToDouble(Console.ReadLine());


                        delta = Math.Pow(b, 2.0) - 4 * a * c;
                        if (a == 0 || delta < 0.0)
                        {
                            Console.WriteLine("Impossivel Calcular");
                        }
                        else
                        {
                            x1 = (-b + Math.Sqrt(delta)) / (2 * a);

                            x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                            Console.WriteLine("R1 = " + x1);
                            Console.WriteLine("R2 = " + x2);
                            Console.WriteLine("Delta" + delta);
                            Console.ReadLine();
                        }
                        break;

                    case 3:
                        int numero = 0;
                        Console.WriteLine("Digite os numeros da lista que deseja ordenar ");
                        Console.WriteLine("Para sair digite a letra 't' ");
                        numero = int.Parse(Console.ReadLine());
                        while (numero != 0)
                        {
                           
                            lstNumeros.Add(numero);
                            Console.WriteLine("Informar numeros da sua lista");
                            numero = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("****************************Return***************************");
                        lstNumeros.Sort();
                        foreach (int item in lstNumeros)
                        {


                            Console.WriteLine(item);





                        }

                        break;

                    case 4:

                        string valor = string.Empty;
                        string fruta = string.Empty;

                        while (fruta != "0" && valor != "0")
                        {
                            Console.WriteLine("Informe o nome da fruta");
                            fruta = Console.ReadLine();
                            lstFruta.Add(fruta);

                            if (fruta == "0")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("informe o valor : ");
                                valor = Console.ReadLine();
                                lstV_Fruta.Add(valor);
                            }
                        }
                        Console.WriteLine("****************************Return***************************");
                        foreach (var item in lstFruta)
                        {
                            if (item != "0")
                                Console.WriteLine(item);
                        }

                        foreach (var item2 in lstV_Fruta)
                        {
                            if (item2 != "0")
                                Console.WriteLine(item2);
                        }

                        break;

                    case 0:
                        menulooping = false;
                        break;


                    default:
                        Console.WriteLine("opçao invalida");
                        break;
                }
            }

        }


    }
}
