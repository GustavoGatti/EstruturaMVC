using EstruturaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaMVC.Repositories
{
    public interface INewLetterRepositories
    {
       
        void Cadastrar(NewsletterEmail newsletter);
        List<NewsletterEmail> ObterTodosNewsLetter();

    }
}
