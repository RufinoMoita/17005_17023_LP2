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
    public class Editora
    {
        #region Estado

        List<Artistas> artistas = new List<Artistas>();

        #endregion

        #region Propriedades
    
        /// <summary>
        /// Obtem e define a lista de artistas
        /// </summary>
        public List<Artistas> Ar
        {
            get { return artistas; }
            set { artistas = value; }
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Indexador
        /// </summary>
        /// <param name="artistas"></param>
        /// <param name="codigoArtista"></param>
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
        /// Verifica se o artista existe
        /// </summary>
        /// <param name="artistas"></param>
        /// <param name="codigoArtista"></param>
        /// <returns></returns>
        public static bool ExisteArtista(List<Artistas> artistas, string nomeArtista)
        {
            int index = ObterArtistaIndex(artistas, nomeArtista);

            if(index != -1 )
                {
                //Se o codigo de artista existir na posição de incide "index"
                if (artistas[index].NomeArtista == nomeArtista)
                    return true;  //retorna true pq o artista foi encontrado
                }
            //Caso não encontre retorna false
            return false;
        }
       
        /// <summary>
        /// Regista um novo artista
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
        /// Remove um utilizador em específico
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
       
        
        
        #endregion

        #region Overrides

        public override string ToString()
        {
            output = string.Format("A editora está associada a:\n{0} Artistas\n{1} Albuns\n{2} Músicas", artistas.Count, , Musicas.Count);
            return output;
        }

        #endregion
        //corrigir override

    }
}
