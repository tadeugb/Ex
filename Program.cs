using System;
using System.IO;
using System.Reflection;
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

            // Console.WriteLine("Ex 1");
            // Console.WriteLine("Ex 2");
            // Console.WriteLine("Ex 3");
            // Console.WriteLine("Ex 4");
            // Console.WriteLine("Ex 5");
            // Console.WriteLine("Ex 6");
            // Console.WriteLine("Ex 7");
            // Console.WriteLine("Ex 8");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
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
                default:
                    Menu();
                    break;
            }

        }
        public static void Ex01()
        {
            //1) Escreva um programa que mostre na tela a mensagem "Olá, Mundo!"
            Console.WriteLine("Helo Word!");
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
        }
        public static void Ex09()
        {
            // 9) Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$) 
            // e mostre quantos dólares ela pode comprar. Considere US$1,00 = R$3,45.

            float carteira, soma;

            Console.WriteLine("Qual e seu valor da carteira");
            carteira = float.Parse(Console.ReadLine());
            
            soma = carteira * 1.00F;

            Console.WriteLine(soma);
        }
    }
}