using System;
using System.Collections.Generic;

namespace BO
{
    public class Artista
    {
        #region Estado
        string tipo;
        string nomeArtista;
        int codigoArtista;
        DateTime data;
        int duracao;
        List<Album> albuns = new List<Album>();
        #endregion

        #region Construtores
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Artista()
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
        public Artista(string tipo, string nomeArtista, int codigoArtista, DateTime data, int duracao)
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
        public List<Album> A
        {
            get { return albuns; }
            set { albuns = value; }
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
