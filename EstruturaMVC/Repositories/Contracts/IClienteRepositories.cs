using EstruturaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaMVC.Repositories
{
    public interface IClienteRepositories
    {

        Cliente Login(string Email, string senha);

        //crud
        void Cadastrar(Cliente cliente);
        void Atualizar(Cliente cliente);
        void Excluir(int id);
        Cliente ObterCliente(int id);
        List<Cliente> ObterTodosClientes();


    }
}
