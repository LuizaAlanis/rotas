using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace AppRoute.Models
{
    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Conteudo { get; set; }
        public DateTime Data  { get; set; }

        //essa classe vai ter o próprio método
        //retorna uma coleção de dados

        public IEnumerable<Noticia> TodasAsNoticias() //Generic
        {
            var retorno = new Collection<Noticia> //ObjectModel
            {
                new Noticia
                {
                    NoticiaId = 1,
                    Categoria = "Cultura",
                    Titulo = "Quarto livro da saga Jogos vorazes rende 500 mil cópias em uma semana",
                    Conteudo = "A Cantiga dos Pássaros e das Serpentes, novo livro da série Jogos Vorazes, superou as expectativas em seu lançamento nos Estados Unidos, ocorrido no dia 19 de maio...",
                    Data = new DateTime(2020/05/28)
                },

                new Noticia
                {
                    NoticiaId = 2,
                    Categoria = "Educação",
                    Titulo = "Os olhos da cara",
                    Conteudo = "Pai de joãozinho se revolta contra o boleto da escola -Se é ele que estuda menos a mensalidade devia ser menor!",
                    Data = new DateTime(2020/05/28)
                },

                new Noticia
                {
                    NoticiaId = 3,
                    Categoria = "Cultura",
                    Titulo = "Globoplay e Amazon lançam a 16ª temporada de Grey's Anatomy",
                    Conteudo = "O serviço da Amazon promete todas as 16 temporadas de uma só vez no catálogo enquanto a Globoplay só vai expor a 16° temporada.",
                    Data = new DateTime(2020/09/11)

                }
            };
            return retorno; //a minha coleção
        }

    }
}