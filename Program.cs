using System;
using System.Collections.Generic;

namespace Aula26Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();
            Produto p1 = new Produto(1, "Pequeno Príncipe", 20f);
            Produto p2 = new Produto(2, "Box Ciclo da Esperança", 220f);
            Produto p3 = new Produto(3, "Os Sonhadores", 37f);

            cart.Incluir(p1);
            cart.Incluir(p2);
            cart.Incluir(p3);

            cart.Excluir(p2);

            Produto p4 = new Produto(1, "O Velho e o Mar", 15f);
            cart.Alterar(1, p4);
            
            cart.Ler();

            cart.MostrarTotal();
        }
    }
}
