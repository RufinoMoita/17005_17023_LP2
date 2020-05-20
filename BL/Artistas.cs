///  <author> Rui Costa</author>
///  <author> Helder Sá</author>
///  <date> xx/xx/2020 </date>
///  <version> 1.0 </version>
///  <email> a17005@alunos.ipca.pt </email>
///  <email> a17023@alunos.ipca.pt </email>
///  Funções da classe artistas

using BO;
using DL;
using System;

namespace BL
{
    public class Artistas
    {
        /// <summary>
        /// Função que devolve o número total de artistas
        /// </summary>
        /// <returns></returns>
        public static int TotalArtistas()
        {
            return DL.Artistas.lst_artistas.Count;
        }

        /// <summary>
        /// Adiciona artista à lista de artistas
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="nomeArtista"></param>
        /// <param name="codigoArtista"></param>
        /// <param name="data"></param>
        /// <param name="duracao"></param>
        public static void AdicionarArtista(string tipo, string nomeArtista, int codigoArtista, DateTime data, int duracao)
        {
            //Inicialização do album aux
            ArtistaBO aux = new ArtistaBO
            {
                Tipo = tipo,
                NomeArtista = nomeArtista,
                CodigoArtista = codigoArtista,
                Data = data,
                Duracao = duracao
            };

            //Adicionar o artista à lista de artistas
            DL.Artistas.RegistarArtista(aux);
        }

        /// <summary>
        /// Remover um artista da lista
        /// </summary>
        /// <param name="nome"></param>
        public static void RemoverArtista(string nome)
        {
            //Remover artista da lista
            DL.Artistas.RemoverArtista(nome);
        }

        /// <summary>
        /// Atribui um album a um artista
        /// </summary>
        /// <param name="nomeArtista"></param>
        /// <param name="nomeAlbum"></param>
        public static void AtribuirAlbum(string nomeArtista, string nomeAlbum)
        {
            //Atribuir o album ao artista
            DL.Artistas.AtribuirAlbum(nomeArtista, nomeAlbum, DL.Albuns.lst_albuns);
        }

        /// <summary>
        /// Listar artistas
        /// </summary>
        public static void ListarArtistas()
        {
            Console.Clear();
            Console.WriteLine("--Listagem de Artistas--\n\n");
            for (int i = 0; i < DL.Artistas.lst_artistas.Count; i++)
                Console.WriteLine("[{0}] {1}", i, DL.Artistas.lst_artistas[i].ToString());
            Console.ReadKey();
        }
    }
}
