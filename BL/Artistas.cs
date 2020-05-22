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
            return DL.Artistas.lstArtistas.Count;
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
        /// Verifica se o artista existe através do seu nome
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static int ExisteArtista(string nome)
        {
            //Caso exista devolve a posição
            if (DL.Artistas.ObterArtistaIndex(nome) != -1)
                return DL.Artistas.ObterArtistaIndex(nome);
            //caso não exista devolve 0
            else
                return 0;
        }


        /// <summary>
        /// Remover um artista da lista
        /// </summary>
        /// <param name="nome"></param>
        public static bool RemoverArtista(string nome)
        {
            bool aux;
            //Remover artista da lista
            aux = DL.Artistas.RemoverArtista(nome);

            if (aux == false)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Atribui um album a um artista
        /// </summary>
        /// <param name="nomeArtista"></param>
        /// <param name="nomeAlbum"></param>
        public static bool AtribuirAlbum(string nomeArtista, string nomeAlbum)
        {
            bool aux;
            //Atribuir o album ao artista
            aux = DL.Artistas.AtribuirAlbum(nomeArtista, nomeAlbum, DL.Albuns.lstAlbuns);

            //Retorna false caso não tenha conseguido associar o album ao artista
            if (aux == false)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Listar artistas
        /// </summary>
        public static bool ListarArtistas()
        {
            if (DL.Artistas.lstArtistas.Count != 0)
            {
                //Lista todos os artistas
                for (int i = 0; i < DL.Artistas.lstArtistas.Count; i++)
                    Console.WriteLine(DL.Artistas.lstArtistas[i].ToString());
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Lista os albuns de um artista específico
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool ListarAlbunsPorArtista(string nome)
        {
                for (int i = 0; i < DL.Artistas.lstArtistas.Count; i++)
                {
                    if (nome == DL.Artistas.lstArtistas[i].NomeArtista)
                    {
                    DL.Artistas.lstArtistas[i].A.ToString();
                    return true;
                    }
                }
            return false;
        }

        /// <summary>
        /// Edita os dados de um determinado artista
        /// </summary>
        /// <param name="index"></param>
        /// <param name="tipo"></param>
        /// <param name="nomeArtista"></param>
        /// <param name="duracao"></param>
        public static void EditarArtistaBO(int index, string tipo, string nomeArtista, int duracao)
        {
            int codigo;
            DateTime data;
            //Guardar o código e a data
            codigo = DL.Artistas.lstArtistas[index].CodigoArtista;
            data = DL.Artistas.lstArtistas[index].Data;
            //Remover o artista antigo
            DL.Artistas.lstArtistas.RemoveAt(index);

            //Adicionar um novo artista com o mesmo código e data de inicio de contrato
            AdicionarArtista(tipo, nomeArtista, codigo, data, duracao);
        }

        /// <summary>
        /// Devolve o tamanho da lista, para poder incrementar o código
        /// </summary>
        /// <returns></returns>
        public static int TamanhoListaArtistas()
        {
            //Devolve o tamanho da lista
            return DL.Artistas.lstArtistas.Count;
        }
    }
}
