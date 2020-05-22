///  <author> Rui Costa</author>
///  <author> Helder Sá</author>
///  <date> xx/xx/2020 </date>
///  <version> 1.0 </version>
///  <email> a17005@alunos.ipca.pt </email>
///  <email> a17023@alunos.ipca.pt </email>
///  Definição da classe AlbumBO

using System;
using System.Collections.Generic;


namespace BO
{
    public class AlbumBO
    {
        #region Estado

        int codigoAlbum;
        string titulo;
        int ano;
        string estilo;
        int unidadesVendidas;
        List<MusicaBO> musicas = new List<MusicaBO>();

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public AlbumBO()
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
        public AlbumBO(int codigoAlbum, string titulo, int ano, string estilo, int unidadesVendidas)
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
            set { ano = value; }
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
            set { unidadesVendidas = value; }
        }

        /// <summary>
        /// Obtém e define a lista de músicas
        /// </summary>
        public List<MusicaBO> M
        {
            get { return musicas; }
            set { value = musicas; }
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

            return output;
        }

        #endregion
    }
}
