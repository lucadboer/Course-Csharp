using System.Globalization;
namespace Course
{
    class Produto
    {
        private string _nome;
        private double _preco;
        public int Quantidade { get; private set; }
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            Quantidade = quantidade;
        }

        public string Nome {

            get { return _nome; } 
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            } 
        
        }
    
        /*public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }
        */
        public double ValorTotalEmEstoque()
        {
            return _preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}