///  <author> Rui Costa</author>
///  <author> Helder Sá</author>
///  <date> xx/xx/2020 </date>
///  <version> 1.0 </version>
///  <email> a17005@alunos.ipca.pt </email>
///  <email> a17023@alunos.ipca.pt </email>
///  Funções da classe musicas
using BO;
using DL;
using System;

namespace BL
{
    public class Musicas
    {
        /// <summary>
        /// Função que devolve o número total de artistas
        /// </summary>
        /// <returns></returns>
        public static int TotalMusicas()
        {
            return DL.Musicas.lstMusicas.Count;
        }

        /// <summary>
        /// Adiciona uma música à lista de músicas
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="codigoMusica"></param>
        public static void AdicionarMusica(string nome, int codigoMusica)
        {
            //Inicialização do album aux
            MusicaBO aux = new MusicaBO
            {
                Nome = nome,
                CodigoMusica = codigoMusica
            };

            //Adicionar a música à lista de musicas
            DL.Musicas.RegistarMusica(aux);
        }

        /// <summary>
        /// Remove uma musica da lista de musicas
        /// </summary>
        /// <param name="nome"></param>
        public static void RemoverMusica(string nome)
        {
            //Remover a música
            DL.Musicas.RemoverMusica(nome);
        }

        /// <summary>
        /// Lista musicas disponveis
        /// </summary>
        public static void MostraMusicasDisponiveis()
        {
            for (int i = 0; i < DL.Musicas.lstMusicas.Count; i++)
                Console.WriteLine(DL.Musicas.lstMusicas[i].ToString());
        }

    }
}
