using System;
using System.IO;
using System.IO.Pipes;
using System.Reflection;
using System.Security.AccessControl;
using Newtonsoft.Json; //dotnet add package Newtonsoft.Json --version 13.0.3

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista do Prof. Gustavo Guanabara
            Menu();
        }

        public static void Menu()
        {
            int opcao;

            Console.WriteLine("Digute um numero 1 ate 100");
            Console.WriteLine("Para sair digite 0");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0:
                    break;
                case 1:
                    Ex01();
                    break;
                case 2:
                    Ex02();
                    break;
                case 3:
                    Ex03();
                    break;
                case 4:
                    Ex04();
                    break;
                case 5:
                    Ex05();
                    break;
                case 6:
                    Ex06();
                    break;
                case 7:
                    Ex07();
                    break;
                case 8:
                    Ex08();
                    break;
                case 9:
                    Ex09();
                    break;
                case 10:
                    Ex10();
                    break;
                case 11:
                    Ex11();
                    break;
                case 12:
                    Ex12();
                    break;
                case 13:
                    Ex13();
                    break;
                case 14:
                    Ex14();
                    break;
                case 15:
                    Ex15();
                    break;
                case 16:
                    Ex16();
                    break;
                case 17:
                    Ex17();
                    break;
                case 18:
                    Ex18();
                    break;
                case 19:
                    Ex19();
                    break;
                case 20:
                    Ex20();
                    break;

                default:
                    Menu();
                    break;
            }

        }
        public static void Ex01()
        {
            //1) Escreva um programa que mostre na tela a mensagem "Olá, Mundo!"
            Console.WriteLine("Helo Word!");
            Menu();
        }
        public static void Ex02()
        {
            //2) Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boasvindas para ela:
            //Ex:
            //Qual é o seu nome? João da Silva
            //Olá João da Silva, é um prazer te conhecer!

            Console.WriteLine("Qual e seu nome?");
            string name = Console.ReadLine();

            Console.WriteLine($"Ola {name}, é um prazer te conhecer!");
            Menu();
        }

        public static void Ex03()
        {
            // 3) Crie um programa que leia o nome e o salário de um funcionário, mostrando no
            // final uma mensagem.
            // Ex:
            // Nome do Funcionário: Maria do Carmo
            // Salário: 1850,45
            // O funcionário Maria do Carmo tem um salário de R$1850,45 em Junho.
            double salario;

            Console.Write("Qual e nome do Funcionário: ");
            string name = Console.ReadLine();

            Console.Write("Salario: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"O funcionário {name} tem um salário de R$ {salario:F2}");
            Menu();
        }

        public static void Ex04()
        {
            // 4) Desenvolva um algoritmo que leia dois números inteiros e mostre o somatório entre eles.
            // Ex:
            // Digite um valor: 8
            // Digite outro valor: 5
            // A soma entre 8 e 5 é igual a 13.
            int numero1, numero2;

            Console.WriteLine("Dgite um numero");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dgite um numero");
            numero2 = int.Parse(Console.ReadLine());

            int soma = numero1 + numero2;

            Console.WriteLine($"Sua soma e {soma}");
            Menu();
        }
        public static void Ex05()
        {
            // 5) Faça um programa que leia as duas notas de um aluno em uma matéria e mostre na tela a sua média na disciplina.
            // Ex: 
            // Nota 1: 4.5
            // Nota 2: 8.5
            // A média entre 4.5 e 8.5 é igual a 6.5
            double nota1, nota2, media;

            Console.WriteLine("Digite as duas notas");
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            Console.WriteLine($"A média entre {nota1} e {nota2} é igual a {media}");
            Menu();
        }

        public static void Ex06()
        {
            // 6) Faça um programa que leia um número inteiro e mostre o seu antecessor e seu 
            // sucessor.
            // Ex: 
            // Digite um número: 9
            // O antecessor de 9 é 8
            // O sucessor de 9 é 10
            int numero;

            Console.WriteLine("Dgite um numero ira mostra seu antecessor e sucessor");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Seu numro e {numero} seu antecessor e {numero - 1} seu sucesor e {numero + 1}");
            Menu();

        }
        public static void Ex07()
        {
            // 7) Crie um algoritmo que leia um número real e mostre na tela o seu dobro e a 
            // sua terça parte.
            // Ex: 
            // Digite um número: 3.5
            // O dobro de 3.5 é 7.0
            // A terça parte de 3.5 é 1.16666
            double nota, dobro, tripulo;

            Console.WriteLine("Digite numero");
            nota = double.Parse(Console.ReadLine());

            dobro = nota * 2;
            tripulo = dobro / 3;

            Console.WriteLine($"Seu numero e {nota} seu dobro e {dobro} seu tripulo e {tripulo}");
            Menu();
        }

        public static void Ex08()
        {
            // 8) Desenvolva um programa que leia uma distância em metros e mostre os valores 
            // relativos em outras medidas.
            // Ex: 
            // Digite uma distância em metros: 185.72
            // A distância de 85.7m corresponde a:
            // 0.18572Km
            // 1.8572Hm
            // 18.572Dam
            // 1857.2dm
            // 18572.0cm
            // 185720.0mm

            double metros, km, hm, dam, dm, cm, mm;

            Console.WriteLine("Digite a sua distancia em metros e iremos mostra valores relativos em outros medidas");
            metros = double.Parse(Console.ReadLine());

            km = metros / 1000;
            hm = metros / 100;
            dam = metros / 10;
            dm = metros * 10;
            cm = metros * 100;
            mm = metros * 1000;

            Console.WriteLine($"A distância de {metros}m corresponde a:");
            Console.WriteLine($"{km} Km");
            Console.WriteLine($"{hm} Hm");
            Console.WriteLine($"{dam} Dam");
            Console.WriteLine($"{dm} dm");
            Console.WriteLine($"{cm} cm");
            Console.WriteLine($"{mm} mm");
            Menu();
        }
        public static void Ex09()
        {
            // 9) Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$) 
            // e mostre quantos dólares ela pode comprar. Considere US$1,00 = R$3,45.

            float carteira, soma;

            Console.WriteLine("Qual e seu valor da carteira");
            carteira = float.Parse(Console.ReadLine());

            soma = carteira * 5.47f;

            Console.WriteLine(soma);
            Menu();
        }
        public static void Ex10()
        {
            // 10) Faça um algoritmo que leia a largura e altura de uma parede, calcule e 
            // mostre a área a ser pintada e a quantidade de tinta necessária para o serviço, 
            // sabendo que cada litro de tinta pinta uma área de 2metros quadrados.
            decimal largura, altura, tinta;

            Console.WriteLine("Iremos calcular area pintada insira o valor da lagura e altura");
            largura = decimal.Parse(Console.ReadLine());
            altura = decimal.Parse(Console.ReadLine());

            tinta = (largura * altura) / 2;

            Console.WriteLine($"Litros gasto sera {tinta}");

            Menu();
        }
        public static void Ex11()
        {
            // 11) Desenvolva uma lógica que leia os valores de A, B e C de uma equação do 
            // segundo grau e mostre o valor de Delta. REVER COMO SE FAZ MATEMATICA
            double a, b, c, r;

            Console.WriteLine("Digite 3 numeos que sera os A B C para calular o delta");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            r = Math.Pow(b, 2) - 4 * (a * c);
            Console.WriteLine(r);

            Menu();
        }
        public static void Ex12()
        {
            // 12) Crie um programa que leia o preço de um produto, calcule e mostre o seu 
            // PREÇO PROMOCIONAL, com 5% de desconto.
            double desconto, valor, total;

            Console.WriteLine("Qual e seu valor e desconto oferecido");
            valor = double.Parse(Console.ReadLine());
            desconto = double.Parse(Console.ReadLine());

            total = valor * (desconto / 100);
            valor = valor - total; // pratica q nao deveria ser feita pois esta esta atribuido um novo valor na variavel que possa usanda no futuro.

            Console.WriteLine($"Valor final da compra sera R$ {valor:F2}");
            Menu();
        }
        public static void Ex13()
        {
            // 13) Faça um algoritmo que leia o salário de um funcionário, calcule e mostre o 
            // seu novo salário, com 15% de aumento.

            decimal salario, aumento, total;

            Console.WriteLine("Qual e seu valor e aumento em % oferecido");
            salario = decimal.Parse(Console.ReadLine());
            aumento = decimal.Parse(Console.ReadLine());

            total = salario + (aumento * salario);

            Console.WriteLine($"Valor final sera R$ {total:F2}");
            Menu();
        }
        public static void Ex14()
        {
            // 14) A locadora de carros precisa da sua ajuda para cobrar seus serviços. Escreva 
            // um programa que pergunte a quantidade de Km percorridos por um carro alugado e a 
            // quantidade de dias pelos quais ele foi alugado. Calcule o preço total a pagar, 
            // sabendo que o carro custa R$90 por dia e R$0,20 por Km rodado

            float km, total;
            int dia;

            Console.WriteLine("Quantos quilometros pecorrido?");
            km = float.Parse(Console.ReadLine());
            Console.WriteLine("Quantos dias?");
            dia = int.Parse(Console.ReadLine());

            km = km * 0.20f;
            dia = dia * 90;
            total = km + dia;

            Console.WriteLine($"Total a pagar R$ {total}");

            Menu();
        }
        public static void Ex15()
        {
            // 15) Crie um programa que leia o número de dias trabalhados em um mês e mostre o 
            // salário de um funcionário, sabendo que ele trabalha 8 horas por dia e ganha R$25 
            // por hora trabalhada.
            int salario, horas = 25, dia;

            Console.WriteLine("Quantos dias trabalhando");
            dia = int.Parse(Console.ReadLine());

            salario = dia * horas;

            Console.WriteLine($"Seu seu salrio sera {salario}");
            Menu();
        }
        public static void Ex16()
        {
            // 16) [DESAFIO] Escreva um programa para calcular a redução do tempo de vida de um 
            // fumante. Pergunte a quantidade de cigarros fumados por dias e quantos anos ele 
            // já fumou. Considere que um fumante perde 10 min de vida a cada cigarro. Calcule 
            // quantos dias de vida um fumante perderá e exiba o total em dias.
            int fumados, quantosAnosFumados;
            float anos, dias;

            Console.WriteLine("Quantos cigarro vc fumar por dia");
            fumados = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos anos fuma");
            quantosAnosFumados = int.Parse(Console.ReadLine());
            
            dias = (quantosAnosFumados * 365) * (fumados * 10); // FIZ A MUTIPLI DO ANOS EM DIAS DEPOIS PEGUEI OS FUMADOS QUE SERIA POR DIA E DEPOIS E MULTIPLICA TUDO
            anos = dias / (60 * 24); // ESSA PARTE E 60 QUE SERIA EM HORAS X TOTAL DO DIA =

            Console.WriteLine($"{anos:F2}");
            
            Menu();

        }
        public static void Ex17()
        {
        }
        public static void Ex18()
        {
        }
        public static void Ex19()
        {
        }
        public static void Ex20()
        {
        }
    }
}