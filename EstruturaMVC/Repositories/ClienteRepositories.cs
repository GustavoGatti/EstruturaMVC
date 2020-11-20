using EstruturaMVC.Database;
using EstruturaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaMVC.Repositories
{
    public class ClienteRepositories : IClienteRepositories
    {

        private LojaVirtualContext _banco;

        public ClienteRepositories(LojaVirtualContext banco)
        {
            _banco = banco;
        }

        public void Atualizar(Cliente cliente)
        {
            _banco.Update(cliente);
            _banco.SaveChanges();
        }

        public void Cadastrar(Cliente cliente)
        {
            _banco.Clientes.Add(cliente);
            _banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            Cliente cliente = ObterCliente(id);
            _banco.Remove(cliente);
            _banco.SaveChanges();
        }

        public Cliente Login(string Email, string senha)
        {
            Cliente cliente = _banco.Clientes.Where(m => m.Email == Email && m.Senha == senha).First();
            return cliente;
        }

        public Cliente ObterCliente(int id)
        {
            return _banco.Clientes.Find(id);
        }

        public List<Cliente> ObterTodosClientes()
        {
            return _banco.Clientes.ToList();
        }
    }
}
