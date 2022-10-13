namespace Lista2AcadDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIO 1
            /*
            double area, altura, baseDoTriangulo;

            Console.WriteLine("Base do triângulo: ");
            baseDoTriangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Altura do triângulo: ");
            altura = double.Parse(Console.ReadLine());

            if (altura == 0 || baseDoTriangulo == 0)
            {

                Console.WriteLine("Base ou altura do triângulo igual à zero!");

            }
            else {

                area = (baseDoTriangulo * altura) / 2;
                Console.WriteLine("Área do triângulo: " + area.ToString("F2"));
            
            }
            */


            //EXERCÍCIO 2
            /*
            int num;
            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {

                Console.WriteLine("O número é par.");

            }
            else {

                Console.WriteLine("O número é impar.");
            
            }
            */


            //EXERCÍCIO 3
            /*
            int a, b, c, d, media;
            Console.WriteLine("Digite o valor A: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor B: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor C: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor D: ");
            d = int.Parse(Console.ReadLine());

            media = (a + b + c + d) / 4;

            if (a > media)
            {

                Console.WriteLine("O valor A é acima da média. Valor: " + a);

            }
            if (b > media)
            {

                Console.WriteLine("O valor B é acima da média. Valor: " + b);

            }
            if (c > media)
            {

                Console.WriteLine("O valor C é acima da média. Valor: " + c);

            }
            if (d > media)
            {

                Console.WriteLine("O valor D é acima da média. Valor: "+ d);

            }
            */



            //EXERCÍCIO 4
            /*
            double horasA, horasB, valorA, valorB, salarioA, salarioB;

            Console.WriteLine("Horas dadas pelo professor A: ");
            horasA = double.Parse(Console.ReadLine());
            Console.WriteLine("Horas dadas pelo professor B: ");
            horasB = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor por hora do professor A: ");
            valorA = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor por hora do professor B: ");
            valorB = double.Parse(Console.ReadLine());

            salarioA = horasA * valorA;
            salarioB = horasB * valorB;

            if (salarioA > salarioB)
            {

                Console.WriteLine("O professor A recebe mais.");

            }
            else if (salarioB > salarioA)
            {

                Console.WriteLine("O professor B recebe mais.");

            }
            else {

                Console.WriteLine("Os professores recebem a mesma quantia.");
            
            }
            */



            //EXERCÍCIO 5
            /*
            double nota1, nota2, media, mediaFinal;

            Console.WriteLine("Valor da primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor da segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            if (media >= 7)
            {

                Console.WriteLine("Aprovado!");

            }
            else
            {
                Console.WriteLine("---------------------Exame final---------------------");
                Console.WriteLine("Digite a nota do exame: ");
                double nota3 = double.Parse(Console.ReadLine());

                mediaFinal = (nota3 + media) / 2;

                if (mediaFinal >= 5) {

                    Console.WriteLine("Aprovado!");

                }
                else {

                    Console.WriteLine("Reprovado.");
                
                }

            }
            */



            //EXERCÍCIO 6
            /*
            string nome = "";
            double altura, peso, imc;

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Peso: ");
            peso = double.Parse(Console.ReadLine());

            imc = peso / (Math.Pow(altura, 2));

            Console.Clear();
            Console.WriteLine("Cálculo do IMC: ");

            if (imc < 18)
            {

                Console.WriteLine("Peso baixo.");

            }
            else if (imc < 25)
            {

                Console.WriteLine("Peso normal.");

            }
            else if (imc < 30)
            {

                Console.WriteLine("Sobre peso.");

            }
            else if (imc < 35)
            {

                Console.WriteLine("Obesidade.");

            }
            else {

                Console.WriteLine("Obesidade grau sério.");
            
            }
            */



            //EXERCÍCIO 7
            /*
            string frase = "", palavra = "";

            Console.Write("Digite uma palavra: ");
            palavra = Console.ReadLine();

            Console.Write("Digite uma frase: ");
            frase = Console.ReadLine();

            if (frase.Contains(palavra))
            {
                Console.WriteLine("A palavra está na frase");
            }
            else
            {
                Console.WriteLine("A palavra não está na frase");
            }
            */



            //EXERCÍCIO 8
            /*
            double salario, vendas, aux;
            int cod;
            string nome = "";

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Salário base: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Código do vendedor: ");
            cod = int.Parse(Console.ReadLine());

            Console.Write("Dinheiro de vendas: ");
            vendas = double.Parse(Console.ReadLine());

            if (vendas>5000)
            {
                aux = vendas * 0.1;
            }
            else if (vendas > 1000)
            {
                aux = vendas * 0.07;
            }
            else
            {
                aux = vendas * 0.05;
            }

            salario += aux;

            Console.WriteLine("Salário final: " + salario);
            */



            //EXERCÍCIO 9
            /**/



        }
    }
}