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
            DL.Albuns.AtribuirMusica(nomeAlbum, nomeMusica, DL.Musicas.lstMusicas);
        }

        /// <summary>
        /// Método que retorna o album menos vendido
        /// </summary>
        /// <returns></returns>
        public static void MenosVendido()
        {
            //Criar album auxiliar
            AlbumBO min = new AlbumBO();
            //Inicializar as unidades vendidas a 999999
            min.UnidadesVendidas = 999999;
            //Percorrer a lista de albuns e guardar o album com menos unidades vendidas
            for (int i = 0; i < DL.Albuns.lstAlbuns.Count; i++)
            {
                if (DL.Albuns.lstAlbuns[i].UnidadesVendidas < min.UnidadesVendidas)
                {
                    min = DL.Albuns.lstAlbuns[i];
                }
            }
            //Mostra os dados do album menos vendido
            min.ToString();  
        }    
        
        /// <summary>
        /// Método que retorna o album mais vendido
        /// </summary>
        /// <returns></returns>
        public static void MaisVendido()
        {
            //Criar album auxiliar
            AlbumBO max = new AlbumBO();
            //Inicializar as unidades vendidas a 0
            max.UnidadesVendidas = 0;
            //Percorrer a lista de albuns e guardar o album com mais unidades vendidas
            for (int i = 0; i < DL.Albuns.lstAlbuns.Count; i++)
            {
                if (DL.Albuns.lstAlbuns[i].UnidadesVendidas > max.UnidadesVendidas)
                {
                    max = DL.Albuns.lstAlbuns[i];
                }
            }
            //Mostra os dados do album mais vendido
            max.ToString();
        }

        /// <summary>
        /// Mostra Albuns disponiveis
        /// </summary>
        public static void MostraAlbunsDisponiveis()
        {
            //Lista todos os albuns
            for (int i = 0; i < DL.Albuns.lstAlbuns.Count; i++)
                Console.WriteLine(DL.Albuns.lstAlbuns[i].ToString());
        }
        
        /// <summary>
        /// Lista todos os albuns ordenados por estilo
        /// </summary>
        /// <returns></returns>
        public static bool ListaAlbunsPorEstilo()
        {
            int contador = 0;
            //lista, caso existam, albuns pop
            for (int i = 0; i < DL.Albuns.lstAlbuns.Count; i++)
            {
                if (DL.Albuns.lstAlbuns[i].Estilo == "Pop")
                {
                    DL.Albuns.lstAlbuns[i].ToString();
                    contador++;
                }
            }

            //Lista, caso existam, albuns rock
            for (int i = 0; i < DL.Albuns.lstAlbuns.Count; i++)
            {
                if (DL.Albuns.lstAlbuns[i].Estilo == "Rock")
                {
                    DL.Albuns.lstAlbuns[i].ToString();
                    contador++;
                }
            }

            //Lista, caso existam, albuns indie
            for (int i = 0; i < DL.Albuns.lstAlbuns.Count; i++)
            {
                if (DL.Albuns.lstAlbuns[i].Estilo == "Indie")
                {
                    DL.Albuns.lstAlbuns[i].ToString();
                    contador++;
                }
            }

            //Lista, caso existam, albuns Punk
            for (int i = 0; i < DL.Albuns.lstAlbuns.Count; i++)
            {
                if (DL.Albuns.lstAlbuns[i].Estilo == "Punk")
                {
                    DL.Albuns.lstAlbuns[i].ToString();
                    contador++;
                }
            }

            if (contador == 0)
                return false;

            else
            return true;
        }

        /// <summary>
        /// Verificar se o album existe atraves do nome
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static int ExisteAlbum(string nome)
        {
            //Caso exista devolve a posição
            if (DL.Albuns.ObterAlbumIndex(nome) != -1)
                return DL.Albuns.ObterAlbumIndex(nome);
            //caso não exista devolve 0
            else
                return 0;
        }

        /// <summary>
        /// Edita os dados de determinado album
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="novoTitulo"></param>
        /// <param name="ano"></param>
        /// <param name="estilo"></param>
        /// <param name="unidadesVendidas"></param>
        /// <returns></returns>
        public static void EditarAlbumBO(int index, string novoTitulo, int ano, string estilo, int unidadesVendidas)
        {
            int codigo;
            //Guardar o código
            codigo = DL.Albuns.lstAlbuns[index].CodigoAlbum;
            //Remover o album antigo
            DL.Albuns.lstAlbuns.RemoveAt(index);
            //Adicionar um novo album com o mesmo código do antigo
            AdicionarAlbumBO(codigo, novoTitulo, ano, estilo, unidadesVendidas);
        }

    }
}
