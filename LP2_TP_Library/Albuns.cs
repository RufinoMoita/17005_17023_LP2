///  <author> Rui Costa</author>
///  <author> Helder Sá</author>
///  <date> xx/xx/2020 </date>
///  <version> 1.0 </version>
///  <email> a17005@alunos.ipca.pt </email>
///  <email> a17023@alunos.ipca.pt </email>
///  <desc></desc>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2_TP_Library
{
    public class Albuns
    {
         #region Estado

        int codigoAlbum;
        string titulo;
        int ano;
        string estilo;
        int unidadesVendidas;
        List<Musicas> musicas = new List<Musicas>();

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Albuns()
        {

        }


        /// <summary>
        /// Construtor de Albuns
        /// </summary>
        /// <param name="codigoAlbum"></param>
        /// <param name="titulo"></param>
        /// <param name="ano"></param>
        /// <param name="estilo"></param>
        /// <param name="unidadesVendidas"></param>
        public Albuns(int codigoAlbum, string titulo, int ano, string estilo, int unidadesVendidas)
        {
            this.codigoAlbum = codigoAlbum;
            this.titulo = titulo;
            this.ano = ano;
            this.estilo = estilo;
            this.unidadesVendidas = unidadesVendidas;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém e define o código do album
        /// </summary>
        public int CodigoAlbum
        {
            get { return codigoAlbum; }
            set { codigoAlbum = value; }
        }

        /// <summary>
        /// Obtém e define o titulo do album
        /// </summary>
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        /// <summary>
        /// Obtém e define o ano do album
        /// </summary>
        public int Ano
        {
            get { return ano; }
            set { ano = value;  }
        }

        /// <summary>
        /// Obtém e define o estilo do album
        /// </summary>
        public string Estilo
        {
            get { return estilo; }
            set { estilo = value; }
        }

        /// <summary>
        /// Obtém e define o numero de unidades vendidas
        /// </summary>
        public int UnidadesVendidas
        {
            get { return unidadesVendidas; }
            set { value = unidadesVendidas; }
        }

        /// <summary>
        /// Obtém e define a lista de músicas
        /// </summary>
        public List<Musicas> M
        {
            get { return musicas; }
            set { value = musicas; }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Obter posição do album na lista
        /// </summary>
        /// <param name="albuns"></param>
        /// <param name="titulo"></param>
        /// <returns></returns>
        public static int ObterAlbumIndex(List<Albuns> albuns, string titulo)
        {
            for (int i = 0; i < albuns.Count; i++)
            {
                //Se encontrar o album
                if (albuns[i].titulo == titulo)
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
        public static bool ExisteAlbum(List<Albuns> albuns, string titulo)
        {
            int index = ObterAlbumIndex(albuns, titulo);
            if (index != -1)
            {
                //Se o titulo do album de indice index corresponder a titulo
                if (albuns[index].titulo == titulo)
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
        public static bool RegistarAlbum(List<Albuns> albuns, Albuns novoAlbum)
        {
            //Se não existir nenhum album com o mesmo titulo
            if (ExisteAlbum(albuns, novoAlbum.titulo) == false)
            {
                //Adicionar um novo album
                albuns.Add(novoAlbum);
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
        public static bool RemoverAlbum(List<Albuns> albuns, string titulo)
        {
            int index = ObterAlbumIndex(albuns, titulo);
            if (index != -1)
            {
                //Se encontrar um album com o titulo lido
                if (albuns[index].titulo == titulo)
                {
                    //Remover o album de indice index
                    albuns.RemoveAt(index);
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
        public static bool AtribuirMusica(List<Albuns> albuns, string titulo, List<Musicas> musicas, string nome)
        {
            int albumIndex = ObterAlbumIndex(albuns, titulo);
            //Se o album existir
            if (albumIndex != -1)
            {
                if (!Musicas.ExisteMusica(albuns[albumIndex].musicas, nome))
                {
                    //Descobrir a posição da musica
                    int musicaIndex = LP2_TP_Library.Musicas.ObterMusicaIndex(musicas, nome);
                    //Se a musica existir
                    if (musicaIndex != -1)
                    {
                        //Adicionar a musica ao album
                        albuns[albumIndex].musicas.Add(musicas[musicaIndex]);
                        return true;
                    }
                }
            }
            //Retorna false se não foi possivel atribuir
            return false;
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Override que retorna toda a informação sobre os albuns
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string output = string.Format("\nTitulo: {0}\nCódigo: {1}\nAno de lançamento: {2}\nEstilo: {3}\nUnidades vendidas: {4}"
                , titulo, codigoAlbum, ano, estilo, unidadesVendidas);

        //Percorrer todas as musicas do album
        for (int i = 0; i < musicas.Count; i++)
            {
                output = output + string.Format("{0}", musicas[i].ToString());
            }

         return output;   
        }

        #endregion
        //completar override
    }
}
