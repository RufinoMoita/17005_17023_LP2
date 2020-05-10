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
        /// <summary>
        /// Obter a posição da musica na lista
        /// </summary>
        /// <param name="musicas"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static int ObterMusicaIndex(List<Musicas> musicas, string nome)
        {
            for (int i = 0; i < musicas.Count; i++)
            {
                //Se encontrar a musica
                if (musicas[i].nome == nome)
                    //retorna a sua posição
                    return i;
            }
            //Se não encontrou retorna -1
            return -1;
        }

        /// <summary>
        /// Verifica se a musica existe
        /// </summary>
        /// <param name="musicas"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool ExisteMusica(List<Musicas> musicas, string nome)
        {
            int index = ObterMusicaIndex(musicas, nome);
            if (index != -1)
            {
                //Se o titulo da musica de indice index corresponder a titulo
                if (musicas[index].nome == nome)
                    //Retorna true pois existe
                    return true;
            }
            //Retorna falso se não existir
            return false;
        }

        /// <summary>
        /// Regista uma nova musica
        /// </summary>
        /// <param name="musicas"></param>
        /// <param name="novaMusica"></param>
        /// <returns></returns>
        public static bool RegistarMusica(List<Musicas> musicas, Musicas novaMusica)
        {
            //Se não existir nenhuma musica com o mesmo nome
            if (ExisteMusica(musicas, novaMusica.nome) == false)
            {
                //Adicionar uma nova musica
                musicas.Add(novaMusica);
                return true;
            }
            //Caso já exista uma musica com o nome lido retorna false
            return false;
        }
        
        /// <summary>
        /// Remover uma musica em especifico
        /// </summary>
        /// <param name="musicas"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool RemoverMusica(List<Musicas> musicas, string nome)
        {
            {
                int index = ObterMusicaIndex(musicas, nome);
                if (index != -1)
                {
                    //Se encontrar uma musica com o titulo lido
                    if (musicas[index].nome == nome)
                    {
                        //Remover a musica de indice index
                        musicas.RemoveAt(index);
                        //Retorna verdadeiro pq a musica foi removida
                        return true;
                    }
                }
                //Retorna false pq não conseguiu remover a musica
                return false;
            }
        }
    #endregion

    #region Overrides
        /// <summary>
        /// Override que retorna toda a informação sobre as musicas
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
