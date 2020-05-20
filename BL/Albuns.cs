///  <author> Rui Costa</author>
///  <author> Helder Sá</author>
///  <date> xx/xx/2020 </date>
///  <version> 1.0 </version>
///  <email> a17005@alunos.ipca.pt </email>
///  <email> a17023@alunos.ipca.pt </email>
///  Funções da classe albuns
using BO;
using DL;
using System;

namespace BL
{
    public class Albuns
    {

        /// <summary>
        /// Adicionar album à lista de albuns
        /// </summary>
        /// <param name="codigoAlbum"></param>
        /// <param name="titulo"></param>
        /// <param name="ano"></param>
        /// <param name="estilo"></param>
        /// <param name="unidadesVendidas"></param>
        public static void AdicionarAlbumBO(int codigoAlbum, string titulo, int ano, string estilo, int unidadesVendidas)
        {
            //Inicialização do album aux
            AlbumBO aux = new AlbumBO
            {
                CodigoAlbum = codigoAlbum,
                Titulo = titulo,
                Ano = ano,
                Estilo = estilo,
                UnidadesVendidas = unidadesVendidas
            };

            //Adicionar o album à lista de albuns
            DL.Albuns.RegistarAlbum(aux);
        }

        /// <summary>
        /// Remover albuns da lista de albuns
        /// </summary>
        /// <param name="titulo"></param>
        public static void RemoverAlbumBO(string titulo)
        {
            //Remover o album específicado
            DL.Albuns.RemoverAlbum(titulo);
        }

        /// <summary>
        /// Atribuir musica a artista
        /// </summary>
        /// <param name="nomeAlbum"></param>
        /// <param name="nomeMusica"></param>
        public static void AssociarMusicaBO(string nomeAlbum, string nomeMusica)
        {
            //Atribuir uma musica a um artista
            DL.Albuns.AtribuirMusica(nomeAlbum, nomeMusica, DL.Musicas.lst_musicas);
        }

        /// <summary>
        /// Método que retorna o album menos vendido
        /// </summary>
        /// <returns></returns>
        public static AlbumBO MenosVendido()
        {
            AlbumBO min = new AlbumBO();
            min.UnidadesVendidas = 99999;
            for (int i = 0; i < DL.Albuns.lst_albuns.Count; i++)
            { 
                if (DL.Albuns.lst_albuns[i].UnidadesVendidas < min.UnidadesVendidas)
                {
                    min = DL.Albuns.lst_albuns[i];
                }
            }
            return min;  
        }    
        
        /// <summary>
        /// Método que retorna o album mais vendido
        /// </summary>
        /// <returns></returns>
        public static AlbumBO MaisVendido()
        {
            AlbumBO max = new AlbumBO();
            max.UnidadesVendidas = 0;
            for (int i = 0; i < DL.Albuns.lst_albuns.Count; i++)
            {
                if (DL.Albuns.lst_albuns[i].UnidadesVendidas > max.UnidadesVendidas)
                {
                    max = DL.Albuns.lst_albuns[i];
                }
            }
            return max;
        }

        /// <summary>
        /// Mostra Albuns disponiveis
        /// </summary>
        public static void MostraAlbunsDisponiveis()
        {
            for (int i = 0; i < DL.Albuns.lst_albuns.Count; i++)
                Console.WriteLine(DL.Albuns.lst_albuns[i].ToString());
        }
    }
}
