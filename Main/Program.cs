///  <author> Rui Costa</author>
///  <author> Helder Sá</author>
///  <date> xx/xx/2020 </date>
///  <version> 1.0 </version>
///  <email> a17005@alunos.ipca.pt </email>
///  <email> a17023@alunos.ipca.pt </email>
///  Camada de interação


using System;
using System.Collections.Generic;
using BO;
using System.Web.Script.Serialization;
using System.IO;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Variaveis

            // Variavel bool, vai permitir que o menu se repita até que o utilizador pretenda sair
            bool voltar = true;

            // Char opcao que vai guardar a opção pretendida
            char opcao;

            //variaveis que armazenam dados temporariamente
            string nomeArtista, tipoArtista, nomeAlbum, nomeMusica, estilo;
            int duracao, unidadesVendidas, codigoArtista = 0, codigoAlbum = 0, codigoMusica = 0, ano;
            #endregion

            #region JSON
            //// Variaveis que vão guardar os dados
            //string artistaJSON, albumJSON, musicaJSON;
            //// Caminho para os ficheiros .json
            //string artistaPath = Path.GetFullPath(Path.Combine(@"../../Artistas.json"));
            //string albumPath = Path.GetFullPath(Path.Combine(@"../../Albuns.json"));
            //string musicaPath = Path.GetFullPath(Path.Combine(@"../../Musicas.json"));
            //// Instanciar JavaScriptSerializer para converter o objeto para JSON
            //var javaScriptSerializer = new JavaScriptSerializer();

            //// Se o caminho para o ficheiro JSON de Artistas, Albuns e Musicas existir...
            //if (File.Exists(artistaPath) && File.Exists(albumPath) && File.Exists(musicaPath))
            //{
            //    // Lê os dados do ficheiro .JSON
            //    artistaJSON = File.ReadAllText(artistaPath);
            //    albumJSON = File.ReadAllText(albumPath);
            //    musicaJSON = File.ReadAllText(musicaPath);

            //    // Importa os dados para o objecto
            //    artistas = javaScriptSerializer.Deserialize<List<Artista>>(artistaJSON);
            //    albuns = javaScriptSerializer.Deserialize<List<Album>>(albumJSON);
            //    musicas = javaScriptSerializer.Deserialize<List<Musica>>(musicaJSON);
            //}
            #endregion

            #region Menu
            while (voltar != false)
            {
                #region Gravar JSON
                //// Serializa o objeto para JSON e guarda-o numa string 
                //artistaJSON = javaScriptSerializer.Serialize(artistas);
                //albumJSON = javaScriptSerializer.Serialize(albuns);
                //musicaJSON = javaScriptSerializer.Serialize(musicas);
                //// Escreve o texto nas strings nos respetivos ficheiros *.json
                //File.WriteAllText(artistaPath, artistaJSON);
                //File.WriteAllText(albumPath, albumJSON);
                //File.WriteAllText(musicaPath, musicaJSON);

                #endregion

                #region Início
                Console.WriteLine("========= MENU PRINCIPAL =========");
                Console.WriteLine("[1] Artistas");
                Console.WriteLine("[2] Albuns");
                Console.WriteLine("[3] Músicas");
                Console.WriteLine("[0] Sair");
                opcao = char.Parse(Console.ReadLine());
                #endregion

                #region Artistas 
                if (opcao == '1') //Gestão dos artistas
                {
                    #region Menu
                    Console.Clear();
                    Console.WriteLine("========= GERIR ARTISTAS =========");
                    Console.WriteLine("[1] Adicionar Artista");
                    Console.WriteLine("[2] Eliminar Artista");
                    Console.WriteLine("[3] Listar Artistas");
                    Console.WriteLine("[4] Atribuir Album");
                    Console.WriteLine("[0] Voltar");
                    opcao = char.Parse(Console.ReadLine());
                    Console.Clear();
                    #endregion

                    #region Adicionar Artista
                    if (opcao == '1') // Adicionar Artista
                    {
                        //Incrementar o código do artista
                        codigoArtista++;

                        Console.WriteLine("--Adicionar Artista--\n");

                        // Pede o nome do artista
                        Console.Write("\nNome: "); nomeArtista = Console.ReadLine();

                        // Pede o tipo do artista
                        Console.Write("\nTipo:"); tipoArtista = Console.ReadLine();

                        //Pede a duração do contrato
                        Console.Write("\nDuração do contrato: "); duracao = int.Parse(Console.ReadLine());

                        // Limpa a Consola
                        Console.Clear();

                        // Criar um novo artista
                        Artistas novoArtista = new Artistas(tipoArtista, nomeArtista, codigoArtista, DateTime.Now, duracao);

                        // Regista o novo artista
                        Console.WriteLine(Artistas.RegistarArtista(novoArtista) ? "O artista {0} foi criado" : "O artista {0} não foi criado", nomeArtista);
                    }
                    #endregion

                    #region Remover Artista
                    else if (opcao == '2') // Remover artista
                    {
                        Console.WriteLine("--Remover Artista--\n\n");
                        Console.Write("\nNome: "); nomeArtista = Console.ReadLine();
                        Console.WriteLine(Artistas.RemoverArtista(artistas, nomeArtista) ? "{0} foi eliminado" : "Não foi possível eliminar {0}", nomeArtista);
                    }
                    #endregion

                    #region Listar Artistas
                    else if (opcao == '3') // Listar Artistas
                    {
                        Console.Clear();
                        Console.WriteLine("--Listagem de Artistas--\n\n");
                        for (int i = 0; i < artistas.Count; i++)
                            Console.WriteLine("[{0}] {1}", i, artistas[i].ToString());
                        Console.ReadKey();
                    }
                    #endregion

                    #region Atribuir um album a um artista
                    else if (opcao == '4') // Atribuir um album a um artista
                    {
                        Console.Clear();
                        Console.WriteLine("--Atribuir album a artista--\n\n");
                        Console.WriteLine("========= Albuns Disponíveis =========");
                        for (int i = 0; i < albuns.Count; i++)
                            Console.WriteLine(albuns[i].ToString());
                        Console.Write("\n\nNome do artista: "); nomeArtista = Console.ReadLine();
                        Console.Write("\nNome do album: "); nomeAlbum = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(Artistas.AtribuirAlbum(artistas, nomeArtista, albuns, nomeAlbum) ? "{0} atribuído a {1}" : "Não foi possível atribuir o album {0} ao artista {1}", nomeAlbum, nomeArtista);
                    }
                    #endregion
                }
                #endregion

                #region Albuns
                else if (opcao == '2') //Gestão dos albuns
                {
                    #region Menu
                    Console.Clear();
                    Console.WriteLine("========= GERIR ALBUNS =========");
                    Console.WriteLine("[1] Adicionar Album");
                    Console.WriteLine("[2] Eliminar Album");
                    Console.WriteLine("[3] Listar Albuns");
                    Console.WriteLine("[4] Atribuir Musica");
                    opcao = char.Parse(Console.ReadLine());
                    Console.Clear();
                    #endregion

                    #region Adicionar Album
                    if (opcao == '1') // Adicionar Album
                    {
                        //Incrementar o código do album
                        codigoAlbum++;

                        Console.WriteLine("--Adicionar Album--\n\n");

                        // Pede o titulo do album
                        Console.Write("\nTitulo: "); nomeAlbum = Console.ReadLine();

                        // Pede o estilo do album
                        Console.Write("\nEstilo musical:"); estilo = Console.ReadLine();

                        //Pede o ano de lançamento
                        Console.Write("\nAno de lançamento: "); ano = int.Parse(Console.ReadLine());

                        //Pede o número de unidades vendidas
                        Console.Write("\nNúmero de unidades vendidas: "); unidadesVendidas = int.Parse(Console.ReadLine());

                        // Limpa a Consola
                        Console.Clear();

                        // Criar um novo album
                        Albuns novoAlbum = new Albuns(codigoAlbum, nomeAlbum, ano, estilo, unidadesVendidas);

                        // Regista o novo album
                        Console.WriteLine(Albuns.RegistarAlbum(albuns, novoAlbum) ? "O album {0} foi criado" : "O album {0} não foi criado", nomeAlbum);
                    }
                    #endregion

                    #region Remover Album
                    if (opcao == '2') // Remover album
                    {
                        Console.WriteLine("\n--Remover Album--\n\n");
                        Console.Write("\nTitulo: "); nomeAlbum = Console.ReadLine();
                        Console.WriteLine(Albuns.RemoverAlbum(albuns, nomeAlbum) ? "{0} foi eliminado" : "Não foi possível eliminar {0}", nomeAlbum);
                    }
                    #endregion

                    #region Listar Albuns
                    if (opcao == '3') // Listar Albuns
                    {
                        Console.Clear();
                        Console.WriteLine("--Listagem de Albuns--\n\n");
                        for (int i = 0; i < albuns.Count; i++)
                            Console.WriteLine("[{0}] {1}", i, albuns[i].ToString());


                        Console.ReadKey();
                    }
                    #endregion

                    #region Atribuir uma musica a um album
                    if (opcao == '4') // Atribuir uma musica a um album
                    {
                        Console.Clear();
                        Console.WriteLine("--Atribuir musica a album--\n\n");
                        Console.WriteLine("========= Musicas Disponíveis =========");
                        for (int i = 0; i < musicas.Count; i++)
                            Console.WriteLine(musicas[i].ToString());
                        Console.Write("\n\nNome do Album: "); nomeAlbum = Console.ReadLine();
                        Console.Write("\nNome da Musica: "); nomeMusica = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(Albuns.AtribuirMusica(albuns, nomeAlbum, musicas, nomeMusica) ? "{0} atribuída a {1}" : "Não foi possível atribuir a musica {0} ao album {1}", nomeMusica, nomeAlbum);
                    }
                    #endregion
                }
                #endregion

                #region Musicas
                else if (opcao == '3') //Gestão das musicas
                {
                    #region Menu
                    Console.Clear();
                    Console.WriteLine("========= GERIR MUSICAS =========");
                    Console.WriteLine("[1] Adicionar Musica");
                    Console.WriteLine("[2] Eliminar Musica");
                    Console.WriteLine("[3] Listar Musicas");
                    opcao = char.Parse(Console.ReadLine());
                    Console.Clear();
                    #endregion

                    #region Adicionar Musica
                    if (opcao == '1') // Adicionar Musica
                    {
                        //Incrementar o código da musica

                        codigoMusica++;

                        Console.WriteLine("--Adicionar Musica--\n\n");

                        // Pede o titulo da musica
                        Console.Write("\nTitulo: "); nomeMusica = Console.ReadLine();

                        // Limpa a Consola
                        Console.Clear();

                        // Criar uma nova musica
                        Musicas novaMusica = new Musicas(nomeMusica, codigoMusica);

                        // Regista a nova musica
                        Console.WriteLine(Musicas.RegistarMusica(musicas, novaMusica) ? "A musica {0} foi criada" : "A musica {0} não foi criada", nomeMusica);
                    }
                    #endregion

                    #region Remover Musica
                    if (opcao == '2') // Remover musica
                    {
                        Console.WriteLine("\n--Remover Musica--\n\n");
                        Console.Write("\nTitulo: "); nomeMusica = Console.ReadLine();
                        Console.WriteLine(Musicas.RemoverMusica(musicas, nomeMusica) ? "{0} foi eliminada" : "Não foi possível eliminar {0}", nomeMusica
);
                    }
                    #endregion

                    #region Listar Musicas
                    if (opcao == '3') // Listar Musicas
                    {
                        Console.Clear();
                        Console.WriteLine("--Listagem de Musicas--\n\n");
                        for (int i = 0; i < musicas.Count; i++)
                            Console.WriteLine("[{0}] {1}", i, musicas[i].ToString());
                        Console.ReadKey();
                    }
                    #endregion
                }
                #endregion

                #region Default
                //Sair
                else if (opcao == '0')
                {
                    Environment.Exit(0);
                }

                //Opção Inválida
                else
                {
                    Console.Clear(); Console.WriteLine("Opção Inválida! ");
                }
                #endregion
            }
            #endregion
        }
    }
}
