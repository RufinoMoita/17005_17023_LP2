using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Musica
    {
        #region Estado
        string nome;
        int codigoMusica;
        #endregion

        #region Construtores
        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Musica()
        {

        }

        /// <summary>
        /// Construtor de música
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="codigoMusica"></param>
        public Musica(string nome, int codigoMusica)
        {
            this.nome = nome;
            this.codigoMusica = codigoMusica;

        }
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtem e define o nome da música
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Obtem e define o código da música
        /// </summary>
        public int CodigoMusica
        {
            get { return codigoMusica; }
            set { codigoMusica = value; }
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Override que retorna toda a informação sobre a musica
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string output = string.Format("\nNome: {0}\nCódigo: {1}", nome, codigoMusica);
            return output;
        }
        #endregion
    }

}
