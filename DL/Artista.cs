///  <author> Rui Costa</author>
///  <author> Helder Sá</author>
///  <date> xx/xx/2020 </date>
///  <version> 1.0 </version>
///  <email> a17005@alunos.ipca.pt </email>
///  <email> a17023@alunos.ipca.pt </email>
///  Definição da classe artistas
using System.Collections.Generic;
using BO;
using System;

namespace DL
{
    public class Artistas
    {
        #region Objetos
        public static List<ArtistaBO> lst_artistas = new List<ArtistaBO>();
        #endregion

        #region Métodos
        /// <summary>
        /// Obter posição do artista na lista
        /// </summary>
        /// <param name="artistas"></param>
        /// <param name="nomeArtista"></param>
        /// <returns></returns>
        public static int ObterArtistaIndex(string nomeArtista)
        {
            for (int i = 0; i < lst_artistas.Count; i++)
            {
                if (lst_artistas[i].NomeArtista == nomeArtista)
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Verificar se o artista existe
        /// </summary>
        /// <param name="artistas"></param>
        /// <param name="nomeArtista"></param>
        /// <returns></returns>
        public static bool ExisteArtista(string nomeArtista)
        {
            int index = ObterArtistaIndex(nomeArtista);

            if (index != -1)
            {
                //Se o codigo de artista existir na posição de incide "index"
                if (lst_artistas[index].NomeArtista == nomeArtista)
                    return true;  //retorna true pq o artista foi encontrado
            }
            //Caso não encontre retorna false
            return false;
        }

        /// <summary>
        /// Registar um novo artista
        /// </summary>
        /// <param name="artistas"></param>
        /// <param name="novoArtista"></param>
        /// <returns></returns>
        public static bool RegistarArtista(ArtistaBO novoArtista)
        {
            //Se não existir nenhum artista com o mesmo codigo do artista a registar
            if (ExisteArtista(novoArtista.NomeArtista) == false)
            {
                //Adiciona um novo artista
                lst_artistas.Add(novoArtista);
                return true;
            }

            //Caso o nome já exista, retorna false
            return false;
        }

        /// <summary>
        /// Remover um artista específico
        /// </summary>
        /// <param name="artistas"></param>
        /// <param name="nomeArtista"></param>
        /// <returns></returns>
        public static bool RemoverArtista(string nomeArtista)
        {
            int index = ObterArtistaIndex(nomeArtista);
            if (index != -1)
            {
                //Caso o artista exista
                if (lst_artistas[index].NomeArtista == nomeArtista)
                {
                    //Remove o utilizador do indice "index"
                    lst_artistas.RemoveAt(index);
                    //Retorna true pois foi eliminado
                    return true;
                }
            }
            //Retorna false pois não conseguiu remover o artistas
            return false;
        }

        /// <summary>
        /// Atribuir um album a um artista
        /// </summary>
        /// <param name="artistas"></param>
        /// <param name="nomeArtista"></param>
        /// <param name="albuns"></param>
        /// <param name="titulo"></param>
        /// <returns></returns>
        public static bool AtribuirAlbum(string nomeArtista, string titulo, List<AlbumBO> albuns)
        {
            int artistaIndex = ObterArtistaIndex(nomeArtista);
            if (artistaIndex != -1)
            {
                if (!Albuns.ExisteAlbum(titulo))
                {

                    int albumIndex = Albuns.ObterAlbumIndex(titulo);
                    if (albumIndex != -1)
                    {
                        //Adicionar o album ao artista
                        lst_artistas[artistaIndex].A.Add(albuns[albumIndex]);
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion
    }
}
