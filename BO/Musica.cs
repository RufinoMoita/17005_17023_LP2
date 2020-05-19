///  <author> Rui Costa</author>
///  <author> Helder Sá</author>
///  <date> xx/xx/2020 </date>
///  <version> 1.0 </version>
///  <email> a17005@alunos.ipca.pt </email>
///  <email> a17023@alunos.ipca.pt </email>
///  Definição da classe musica

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
