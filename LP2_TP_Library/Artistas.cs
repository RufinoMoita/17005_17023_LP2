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
    public class Artistas
    {
        #region Estado
        string tipo;
        string nomeArtista;
        int codigoArtista;
        DateTime data;
        int duracao;
        List<Albuns> albuns = new List<Albuns>();

        #endregion

        #region Construtores
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Artistas()
        {

        }

        /// <summary>
        /// Construtor de Artista
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="nomeArtista"></param>
        /// <param name="codigoArtista"></param>
        /// <param name="dia"></param>
        /// <param name="mes"></param>
        /// <param name="ano"></param>
        /// <param name="duracao"></param>
        /// <param name="fimContrato"></param>
        public Artistas(string tipo, string nomeArtista, int codigoArtista, DateTime data, int duracao)
        {
            this.tipo = tipo;
            this.nomeArtista = nomeArtista;
            this.codigoArtista = codigoArtista;
            this.data = data;
            this.duracao = duracao;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém e define tipo de artista (cantor, instrumentista, banda)
        /// </summary>
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Obtém e define o nome do artista
        /// </summary>
        public string NomeArtista
        {
            get { return nomeArtista; }
            set { nomeArtista = value; }
        }

        /// <summary>
        /// Obtém e define o código do artista
        /// </summary>
        public int CodigoArtista
        {
            get { return codigoArtista; }
            set { codigoArtista = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = DateTime.Now; }
        }



        /// <summary>
        /// Obtém e define a duração do contrato
        /// </summary>
        public int Duracao
        {
            get { return duracao; }
            set { duracao = value; }
        }


        /// <summary>
        /// Obtém e define a lista de albuns
        /// </summary>
        public List<Albuns> A
        {
            get { return albuns; }
            set { albuns = value;  }
        }


        #endregion

        #region Metodos
        /// <summary>
        /// Obter posição do artista na lista
        /// </summary>
        /// <param name="artistas"></param>
        /// <param name="nomeArtista"></param>
        /// <returns></returns>
        public static int ObterArtistaIndex(List<Artistas> artistas, string nomeArtista)
        {
            for (int i = 0; i < artistas.Count; i++)
            {
                if (artistas[i].NomeArtista == nomeArtista)
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
        public static bool ExisteArtista(List<Artistas> artistas, string nomeArtista)
        {
            int index = ObterArtistaIndex(artistas, nomeArtista);

            if (index != -1)
            {
                //Se o codigo de artista existir na posição de incide "index"
                if (artistas[index].NomeArtista == nomeArtista)
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
        public static bool RegistarArtista(List<Artistas> artistas, Artistas novoArtista)
        {
            //Se não existir nenhum artista com o mesmo codigo do artista a registar
            if (ExisteArtista(artistas, novoArtista.NomeArtista) == false)
            {
                //Adiciona um novo artista
                artistas.Add(novoArtista);
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
        public static bool RemoverArtista(List<Artistas> artistas, string nomeArtista)
        {
            int index = ObterArtistaIndex(artistas, nomeArtista);
            if (index != -1)
            {
                //Caso o artista exista
                if (artistas[index].NomeArtista == nomeArtista)
                {
                    //Remove o utilizador do indice "index"
                    artistas.RemoveAt(index);
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
        public static bool AtribuirAlbum(List<Artistas> artistas, string nomeArtista, List<Albuns> albuns, string titulo)
        {
            int artistaIndex = ObterArtistaIndex(artistas, nomeArtista);
            if (artistaIndex != -1)
            {
                if (!Albuns.ExisteAlbum(artistas[artistaIndex].albuns, titulo))
                {

                    int albumIndex = LP2_TP_Library.Albuns.ObterAlbumIndex(albuns, titulo);
                    if (albumIndex != -1)
                    {
                        //Adicionar o album ao artista
                        artistas[artistaIndex].albuns.Add(albuns[albumIndex]);
                        return true;
                    }
                }
            }
            return false;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Override que retorna toda a informação sobre os artistas
        /// </summary>
        /// <returns></returns>
        public override string ToString()
    {
        string output = string.Format("\nNome: {0}\nTipo: {1}\nCódigo: {2}\nInício do contrato:{3}\n",
            nomeArtista, tipo, codigoArtista, data);

            //Percorrer todos os albuns do artista
            for (int i = 0; i < albuns.Count; i++)
                {
                output = output + string.Format("{0}", albuns[i].ToString());
                }

            return output;
    }

        #endregion
    }
}
