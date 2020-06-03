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
        public static bool RemoverAlbumBO(string titulo)
        {
            bool aux;
            //Remover o album específicado
            aux = DL.Albuns.RemoverAlbum(titulo);

            //Retorna false caso não tenha removido
            if (aux == false)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Atribuir musica a artista
        /// </summary>
        /// <param name="nomeAlbum"></param>
        /// <param name="nomeMusica"></param>
        public static bool AssociarMusicaBO(string nomeAlbum, string nomeMusica)
        {
            bool aux;
            //Atribuir uma musica a um artista
            aux = DL.Albuns.AtribuirMusica(nomeAlbum, nomeMusica, DL.Musicas.lstMusicas);

            //Retorna false se não conseguiu atribuir
            if (aux == false)
                return false;

            //Retorna true se conseguiu 
            else
                return true;
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
            Console.WriteLine("Título - {0}\nUnidades vendidas - {1}\n\n", min.Titulo, min.UnidadesVendidas);
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
            Console.WriteLine("Título - {0}\nUnidades vendidas - {1}\n\n", max.Titulo, max.UnidadesVendidas);
        }

        /// <summary>
        /// Mostra Albuns disponiveis
        /// </summary>
        public static bool MostraAlbunsDisponiveis()
        {
            if (DL.Albuns.lstAlbuns.Count != 0)
            {
                //Lista todos os albuns
                for (int i = 0; i < DL.Albuns.lstAlbuns.Count; i++)
                    Console.WriteLine(DL.Albuns.lstAlbuns[i].ToString());
                return true;
            }
            //Retorna false caso a lista esteja vazia
                return false;
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
                    Console.WriteLine(DL.Albuns.lstAlbuns[i].ToString());
                    contador++;
                }
            }

            //Lista, caso existam, albuns rock
            for (int i = 0; i < DL.Albuns.lstAlbuns.Count; i++)
            {
                if (DL.Albuns.lstAlbuns[i].Estilo == "Rock")
                {
                    Console.WriteLine(DL.Albuns.lstAlbuns[i].ToString());
                    contador++;
                }
            }

            //Lista, caso existam, albuns indie
            for (int i = 0; i < DL.Albuns.lstAlbuns.Count; i++)
            {
                if (DL.Albuns.lstAlbuns[i].Estilo == "Indie")
                {
                    Console.WriteLine(DL.Albuns.lstAlbuns[i].ToString());
                    contador++;
                }
            }

            //Lista, caso existam, albuns Punk
            for (int i = 0; i < DL.Albuns.lstAlbuns.Count; i++)
            {
                if (DL.Albuns.lstAlbuns[i].Estilo == "Punk")
                {
                    Console.WriteLine(DL.Albuns.lstAlbuns[i].ToString());
                    contador++;
                }
            }

            Console.ReadKey();
            Console.Clear();

            if (contador == 0)
                return false;

            else
            return true;
        }

        /// <summary>
        /// Lista albuns de um determinado artista
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool ListarAlbunsPorArtista(string nome)
        {
            int existe;
            existe = DL.Artistas.ObterArtistaIndex(nome);
            if (existe == -1)
                return false;
            else
            {

                for (int i = 0; i < DL.Artistas.lstArtistas[existe].A.Count; i++)
                {
                    Console.WriteLine(DL.Artistas.lstArtistas[existe].A[i].ToString());
                }

            }
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

        /// <summary>
        /// Devolve o tamanho da lista, para poder incrementar o código
        /// </summary>
        /// <returns></returns>
        public static int TamanhoListaAlbuns()
        {
           //Devolve o tamanho da lista
           return DL.Albuns.lstAlbuns.Count;
        }
    }
}
