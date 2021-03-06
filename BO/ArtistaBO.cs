﻿///  <author> Rui Costa</author>
///  <author> Helder Sá</author>
///  <date> xx/xx/2020 </date>
///  <version> 1.0 </version>
///  <email> a17005@alunos.ipca.pt </email>
///  <email> a17023@alunos.ipca.pt </email>
///  Definição da Classe artista

using System;
using System.Collections.Generic;

namespace BO
{
    public class ArtistaBO
    {
        #region Estado
        string tipo;
        string nomeArtista;
        int codigoArtista;
        DateTime data;
        int duracao;
        List<AlbumBO> albuns = new List<AlbumBO>();
        #endregion

        #region Construtores
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public ArtistaBO()
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
        public ArtistaBO(string tipo, string nomeArtista, int codigoArtista, DateTime data, int duracao)
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
        public List<AlbumBO> A
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
            return output;
        }

        #endregion
    }
}