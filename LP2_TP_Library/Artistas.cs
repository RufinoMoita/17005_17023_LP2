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
        int dia;
        int mes;
        int ano;
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
        public Artistas(string tipo, string nomeArtista, int codigoArtista, int dia, int mes, int ano, int duracao)
        {
            this.tipo = tipo;
            this.nomeArtista = nomeArtista;
            this.codigoArtista = codigoArtista;
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
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
            set { value = nomeArtista; }
        }

        /// <summary>
        /// Obtém e define o código do artista
        /// </summary>
        public int CodigoArtista
        {
            get { return codigoArtista; }
            set { codigoArtista = value; }
        }

        /// <summary>
        /// Obtém e define o dia do inicio de contrato
        /// </summary>
        public int Dia
        {
            get { return dia; }
            set { if (value < 31) dia = value; }
        }

        /// <summary>
        /// Obtém e define o mes do inicio de contrato
        /// </summary>
        public int Mes
        {
            get { return mes; }
            set { if (value < 12) mes = value; }
        }

        /// <summary>
        /// Obtém e define o ano do inicio de contrato
        /// </summary>
        public int Ano
        {
            get { return ano; }
            set { if (value <= 2020 && value >= 0) ano = value; }
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



        #endregion

        #region Overrides

        /// <summary>
        /// Override que retorna toda a informação sobre os artistas
        /// </summary>
        /// <returns></returns>
        public override string ToString()
    {
        string output = string.Format("\nNome: {0}\nTipo: {1}\nCódigo: {2}\nInício do contrato:{3}/{4}/{5}\n", nomeArtista, tipo, codigoArtista, dia, mes, ano);
            ///completar
            return output;
    }

    #endregion
        ///corrigir override
    }
}
