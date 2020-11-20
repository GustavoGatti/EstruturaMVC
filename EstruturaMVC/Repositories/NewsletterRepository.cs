using EstruturaMVC.Database;
using EstruturaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaMVC.Repositories
{
    public class NewsletterRepository : INewLetterRepositories
    {
        LojaVirtualContext _banco;
        public NewsletterRepository(LojaVirtualContext banco)
        {
            _banco = banco;
        }

        public void Cadastrar(NewsletterEmail newsletter)
        {
            _banco.NewsletterEmails.Add(newsletter);
            _banco.SaveChanges();
        }

        public List<NewsletterEmail> ObterTodosNewsLetter()
        {
           return _banco.NewsletterEmails.ToList();
        }
    }
}
