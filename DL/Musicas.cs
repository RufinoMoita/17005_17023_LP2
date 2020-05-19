using System.Collections.Generic;
using BO;

namespace DL
{
    public class Musicas
    {
        #region Objetos
        public static List<Musica> lst_musicas = new List<Musica>();
        #endregion

        #region Métodos
        /// <summary>
        /// Obter a posição da musica na lista
        /// </summary>
        /// <param name="musicas"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static int ObterMusicaIndex(string nome)
        {
            for (int i = 0; i < lst_musicas.Count; i++)
            {
                //Se encontrar a musica
                if (lst_musicas[i].Nome == nome)
                    //retorna a sua posição
                    return i;
            }
            //Se não encontrou retorna -1
            return -1;
        }

        /// <summary>
        /// Verifica se a musica existe
        /// </summary>
        /// <param name="musicas"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool ExisteMusica(string nome)
        {
            int index = ObterMusicaIndex(nome);
            if (index != -1)
            {
                //Se o titulo da musica de indice index corresponder a titulo
                if (lst_musicas[index].Nome == nome)
                    //Retorna true pois existe
                    return true;
            }
            //Retorna falso se não existir
            return false;
        }

        /// <summary>
        /// Regista uma nova musica
        /// </summary>
        /// <param name="musicas"></param>
        /// <param name="novaMusica"></param>
        /// <returns></returns>
        public static bool RegistarMusica(Musica novaMusica)
        {
            //Se não existir nenhuma musica com o mesmo nome
            if (ExisteMusica(novaMusica.Nome) == false)
            {
                //Adicionar uma nova musica
                lst_musicas.Add(novaMusica);
                return true;
            }
            //Caso já exista uma musica com o nome lido retorna false
            return false;
        }

        /// <summary>
        /// Remover uma musica em especifico
        /// </summary>
        /// <param name="musicas"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool RemoverMusica(string nome)
        {
            {
                int index = ObterMusicaIndex(nome);
                if (index != -1)
                {
                    //Se encontrar uma musica com o titulo lido
                    if (lst_musicas[index].Nome == nome)
                    {
                        //Remover a musica de indice index
                        lst_musicas.RemoveAt(index);
                        //Retorna verdadeiro pq a musica foi removida
                        return true;
                    }
                }
                //Retorna false pq não conseguiu remover a musica
                return false;
            }
        }
        #endregion
    }
}
