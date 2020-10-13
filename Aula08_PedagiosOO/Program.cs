using System;
using System.Globalization;

namespace Aula08_PedagiosOO
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo nfi = new CultureInfo("pt-BR").NumberFormat;

            /**
             * Faça um programa em que deverá ser programada uma sequencia de objetos
             * que recebam localização e valor dos pedagios  de Mococa a São Paulo.
             * No fim da sequencia de objetos, apresente o valor total dos pedágios.
             */
            Pedagio p1 = new Pedagio();
            p1.Localizacao = "Entre Mococa e Casa Branca";
            p1.Valor = 6.10;

            Pedagio p2 = new Pedagio();
            p2.Localizacao = "Entre Casa Branca e Aguaí";
            p2.Valor = 6.40;

            /**
             * Variável p3 do tipo Pedágio recebe um novo objeto do tipo Pedágio criado a partir da classe Pedagio.
             * Definindo a propriedade localização com uma string
             * Definindo a propriedade valor como um número decimal
             */ 
            Pedagio p3 = new Pedagio();
            p3.Localizacao = "Entre Aguaí e Mogi Guaçu";
            p3.Valor = 7.10;

            Pedagio p4 = new Pedagio();
            p4.Localizacao = "Entre Mogi Guaçu e Campinas";
            p4.Valor = 12.00;

            Pedagio p5 = new Pedagio();
            p5.Localizacao = "Entre Campinas e Jundiaí";
            p5.Valor = 9.10;

            Pedagio p6 = new Pedagio();
            p6.Localizacao = "Entre Jundiaí e São Paulo";
            p6.Valor = 9.20;


            double total_pedagios = p1.Valor + p2.Valor + p3.Valor + p4.Valor + p5.Valor + p6.Valor;

            Console.WriteLine("O valor total dos pedágios é: {0}", total_pedagios.ToString("C", nfi));



            
        }
    }
}
