﻿///  <author> Rui Costa</author>
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

        /// <summary>
        /// Verifica se a musica existe e caso exista devolve a sua posição na lista
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static int ExisteMusica(string nome)
        {
            int existe;
            existe = DL.Musicas.ObterMusicaIndex(nome);
            if (existe == -1)
                return 0;
            else
                return existe;
        }

        /// <summary>
        /// Lista as musicas de determinado album
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool ListarMusicasPorAlbum(string nome)
        {
            int existe;
            existe = DL.Albuns.ObterAlbumIndex(nome);
            if (existe == -1)
                return false;
            else
                DL.Albuns.lstAlbuns[existe].M.ToString();
            return true;
        }

        /// <summary>
        /// Edita uma determinada musica
        /// </summary>
        /// <param name="index"></param>
        /// <param name="nome"></param>
        public static void EditarMusicaBO(int index, string nome)
        {
            int codigo;
            //Guardar o código
            codigo = DL.Musicas.lstMusicas[index].CodigoMusica;
            //Remover a musica antiga
            DL.Musicas.lstMusicas.RemoveAt(index);
            //Adicionar uma nova musica com o mesmo código da antiga
            AdicionarMusica(nome, codigo);
        }
    }
}
