///  <author> Rui Costa</author>
///  <author> Helder Sá</author>
///  <date> xx/xx/2020 </date>
///  <version> 1.0 </version>
///  <email> a17005@alunos.ipca.pt </email>
///  <email> a17023@alunos.ipca.pt </email>
///  Definição da classe albuns
using System.Collections.Generic;
using BO;
using System;

namespace DL
{
    public class Albuns
    {
        #region Objetos
        public static List<AlbumBO> lst_albuns = new List<AlbumBO>();
        #endregion

        #region Métodos
        /// <summary>
        /// Obter posição do album na lista
        /// </summary>
        /// <param name="albuns"></param>
        /// <param name="titulo"></param>
        /// <returns></returns>
        public static int ObterAlbumIndex(string titulo)
        {
            for (int i = 0; i < lst_albuns.Count; i++)
            {
                //Se encontrar o album
                if (lst_albuns[i].Titulo == titulo)
                    //retorna a sua posição
                    return i;
            }
            //Se não encontrou retorna -1
            return -1;
        }

        /// <summary>
        /// Verifica se o album existe
        /// </summary>
        /// <param name="albuns"></param>
        /// <param name="titulo"></param>
        /// <returns></returns>
        public static bool ExisteAlbum(string titulo)
        {
            int index = ObterAlbumIndex(titulo);
            if (index != -1)
            {
                //Se o titulo do album de indice index corresponder a titulo
                if (lst_albuns[index].Titulo == titulo)
                    //Retorna true pois existe
                    return true;
            }
            //Retorna falso se não existir
            return false;
        }

        /// <summary>
        /// Registar um novo album
        /// </summary>
        /// <param name="albuns"></param>
        /// <param name="novoAlbum"></param>
        /// <returns></returns>
        public static bool RegistarAlbum(AlbumBO novoAlbum)
        {
            //Se não existir nenhum album com o mesmo titulo
            if (ExisteAlbum(novoAlbum.Titulo) == false)
            {
                //Adicionar um novo album
                lst_albuns.Add(novoAlbum);
                return true;
            }
            //Caso já exista um album com o nome lido retorna false
            return false;
        }

        /// <summary>
        /// Eliminar um album especifico
        /// </summary>
        /// <param name="albuns"></param>
        /// <param name="titulo"></param>
        /// <returns></returns>
        public static bool RemoverAlbum(string titulo)
        {
            int index = ObterAlbumIndex(titulo);
            if (index != -1)
            {
                //Se encontrar um album com o titulo lido
                if (lst_albuns[index].Titulo == titulo)
                {
                    //Remover o album de indice index
                    lst_albuns.RemoveAt(index);
                    //Retorna verdadeiro pq o album foi removido
                    return true;
                }
            }

            //Retorna false pq não conseguiu remover o album
            return false;
        }

        /// <summary>
        /// Atribuir uma musica a um album
        /// </summary>
        /// <param name="albuns"></param>
        /// <param name="titulo"></param>
        /// <param name="musicas"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool AtribuirMusica(string titulo, string nome, List<MusicaBO>musicas)
        {
            int albumIndex = ObterAlbumIndex(titulo);
            //Se o album existir
            if (albumIndex != -1)
            {
                if (!Musicas.ExisteMusica(nome))
                {
                    //Descobrir a posição da musica
                    int musicaIndex = Musicas.ObterMusicaIndex(nome);
                    //Se a musica existir
                    if (musicaIndex != -1)
                    {
                        //Adicionar a musica ao album
                        lst_albuns[albumIndex].M.Add(musicas[musicaIndex]);
                        return true;
                    }
                }
            }
            //Retorna false se não foi possivel atribuir
            return false;
        }
        #endregion

    }
}
