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
    public class Musicas
    {
    #region Estado
        string nome;
        int codigoMusica;
    #endregion

    #region Construtores
    /// <summary>
    /// Construtor por omissão
    /// </summary>
    public Musicas()
    {

    }
    
    /// <summary>
    /// Construtor de música
    /// </summary>
    /// <param name="nome"></param>
    /// <param name="codigoMusica"></param>
    public Musicas(string nome, int codigoMusica)
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

        #region Metodos



        #endregion

        #region Overrides

        public override string ToString()
        {
            string output = string.Format("\nNome: {0}\nCódigo: {1}", nome, codigoMusica);
            //completar

            return output;
        }
        #endregion
        //completar override
    }
}
