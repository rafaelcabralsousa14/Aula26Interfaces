using System.Collections.Generic;

namespace Aula26Interfaces
{
    public class Carrinho : iCarrinho
    {
        List<Produto> carrinho = new  List<Produto>();

        public float ValorTotal { get; set; }

        public void Alterar(int _codigo, Produto _produtoAlterado)
        {
            carrinho.Find(j => j.Codigo == _codigo).Nome = _produtoAlterado.Nome;
            carrinho.Find(z => z.Codigo == _codigo).Preco = _produtoAlterado.Preco;
        }

        public void Excluir(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void Incluir(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Ler()
        {
            foreach(Produto item in carrinho){
                System.Console.WriteLine($"Informação do Produto \nNome: {item.Nome} \nPreço: R${item.Preco}");
            }
        }

        public void MostrarTotal(){
            foreach(Produto item in carrinho){
                ValorTotal += item.Preco;
            }
            System.Console.WriteLine($"Valor total do carrinho é igual a R${ValorTotal}");
        }
    }
}