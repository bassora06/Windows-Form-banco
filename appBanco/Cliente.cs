using Banco;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBanco
{
    internal class Cliente
    {
        public string nome;
        public double saldo;

        public void Creditar(double valor)
        {
            if (valor <= 0)

            {
                valor = 0;
            }

            Conexao conexao = new Conexao();

            string query = "INSERT INTO movimentacao (operacao, valor) VALUES (@valor1, @valor2)";

            MySqlParameter[] param = new MySqlParameter[]
            {
                new MySqlParameter("@valor1", "credito"),
                new MySqlParameter("@valor2", valor)
            };

            conexao.ExecuteQueryWithParameters(query, param);

            this.saldo += valor;

        }
        public void Debitar(double valor)
        {
            Conexao conexao = new Conexao();

            string query = "INSERT INTO movimentacao (operacao, valor) VALUES (@valor1, @valor2)";

            MySqlParameter[] param = new MySqlParameter[]
            {
                new MySqlParameter("@valor1", "debito"),
                new MySqlParameter("@valor2", valor)
            };

            conexao.ExecuteQueryWithParameters(query, param);

            this.saldo -= valor;
        }
    }
}