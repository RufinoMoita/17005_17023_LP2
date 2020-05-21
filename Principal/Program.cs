///  <author> Rui Costa</author>
///  <author> Helder Sá</author>
///  <date> xx/xx/2020 </date>
///  <version> 1.0 </version>
///  <email> a17005@alunos.ipca.pt </email>
///  <email> a17023@alunos.ipca.pt </email>
///  Camada de interação


using System;
using System.Collections.Generic;
using BL;
using System.Web.Script.Serialization;
using System.IO;

namespace Main
{
    class Program
    {
        static void Main()
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
            //    albuns = javaScriptSerializer.Deserialize<List<AlbumBO>>(albumJSON);
            //    musicas = javaScriptSerializer.Deserialize<List<Musica>>(musicaJSON);
            //}
            #endregion

            #region Menu
            while (voltar != false)
            {
                #region Gravar JSON
                /// Serializa o objeto para JSON e guarda-o numa string 
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
                    Console.WriteLine("[4] Atribuir AlbumBO");
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
                        BL.Artistas.AdicionarArtista(tipoArtista, nomeArtista, codigoArtista, DateTime.Now, duracao);
                    }
                    #endregion

                    #region Remover Artista
                    else if (opcao == '2') // Remover artista
                    {
                        Console.WriteLine("--Remover Artista--\n\n");
                        Console.Write("\nNome: "); nomeArtista = Console.ReadLine();
                        BL.Artistas.RemoverArtista(nomeArtista);
                    }
                    #endregion

                    #region Listar Artistas
                    else if (opcao == '3') // Listar Artistas
                    {
                        BL.Artistas.ListarArtistas();
                    }
                    #endregion

                    #region Atribuir um album a um artista
                    else if (opcao == '4') // Atribuir um album a um artista
                    {
                        Console.Clear();
                        Console.WriteLine("--Atribuir album a artista--\n\n");
                        Console.WriteLine("========= Albuns Disponíveis =========");
                        BL.Albuns.MostraAlbunsDisponiveis();
                        Console.Write("\n\nNome do artista: "); nomeArtista = Console.ReadLine();
                        Console.Write("\nNome do album: "); nomeAlbum = Console.ReadLine();
                        Console.Clear();
                        BL.Artistas.AtribuirAlbum(nomeArtista, nomeAlbum);
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
                    Console.WriteLine("[1] Adicionar AlbumBO");
                    Console.WriteLine("[2] Eliminar AlbumBO");
                    Console.WriteLine("[3] Editar AlbumBO");
                    Console.WriteLine("[4] Listar Albuns");
                    Console.WriteLine("[5] Listar Albuns por Estilo");
                    Console.WriteLine("[6] Atribuir Musica");
                    Console.WriteLine("[0] Voltar");
                    opcao = char.Parse(Console.ReadLine());
                    Console.Clear();
                    #endregion

                    #region Adicionar Album
                    if (opcao == '1') // Adicionar AlbumBO
                    {
                        //Incrementar o código do album
                        codigoAlbum++;

                        Console.WriteLine("--Adicionar AlbumBO--\n\n");

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

                        // Regista o novo album
                        BL.Albuns.AdicionarAlbumBO(codigoAlbum, nomeAlbum, ano, estilo, unidadesVendidas);
                    }
                    #endregion

                    #region Remover Album
                    if (opcao == '2') // Remover album
                    {
                        Console.WriteLine("\n--Remover AlbumBO--\n\n");
                        Console.Write("\nTitulo: "); nomeAlbum = Console.ReadLine();
                        BL.Albuns.RemoverAlbumBO(nomeAlbum);
                    }
                    #endregion

                    #region Editar Album
                    if (opcao == '3')
                    {
                        // Pede o titulo do album
                        int index;
                        Console.Write("\nTitulo do Album: "); nomeAlbum = Console.ReadLine();
                        Console.Clear();
                        index = BL.Albuns.ExisteAlbum(nomeAlbum);
                        if (index == 0)
                            Console.WriteLine("Não existe nenhum album com o nome {0}", nomeAlbum);
                        else
                        {
                            // Pede o titulo do album
                            Console.Write("\nTitulo Novo: "); nomeAlbum = Console.ReadLine();

                            // Pede o estilo do album
                            Console.Write("\nEstilo musical:"); estilo = Console.ReadLine();

                            //Pede o ano de lançamento
                            Console.Write("\nAno de lançamento: "); ano = int.Parse(Console.ReadLine());

                            //Pede o número de unidades vendidas
                            Console.Write("\nNúmero de unidades vendidas: "); unidadesVendidas = int.Parse(Console.ReadLine());

                            // Limpa a Consola
                            Console.Clear();

                            // Edita o novo album
                            BL.Albuns.EditarAlbumBO(index, nomeAlbum, ano, estilo, unidadesVendidas);

                            //Mostrar mensagem ao utilizador
                            Console.WriteLine("Album editado com sucesso!!");
                            Console.ReadKey();
                        }
                    }
                    #endregion

                    #region Listar Albuns
                    if (opcao == '4') // Listar Albuns
                    {
                        BL.Albuns.MostraAlbunsDisponiveis();
                    }
                    #endregion

                    #region Listar por Estilo
                    if (opcao == '5')
                    {
                        bool albuns;
                        //Listar albuns por estilo
                        albuns = BL.Albuns.ListaAlbunsPorEstilo();
                        if (albuns == false)
                        {
                            Console.WriteLine("Não existem albuns para listar!!");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    #endregion

                    #region Atribuir uma musica a um album
                    if (opcao == '6') // Atribuir uma musica a um album
                    {
                        Console.Clear();
                        Console.WriteLine("--Atribuir musica a album--\n\n");
                        Console.WriteLine("========= Musicas Disponíveis =========");
                        BL.Musicas.MostraMusicasDisponiveis();
                        Console.Write("\n\nNome do AlbumBO: "); nomeAlbum = Console.ReadLine();
                        Console.Write("\nNome da Musica: "); nomeMusica = Console.ReadLine();
                        Console.Clear();
                        BL.Albuns.AssociarMusicaBO(nomeAlbum, nomeMusica);
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
                    Console.WriteLine("[3] Editar Musica");
                    Console.WriteLine("[4] Listar Musicas");
                    Console.WriteLine("[5] Listar Musicas por Album");
                    Console.WriteLine("[0] Voltar");
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

                        // Regista a nova musica
                        BL.Musicas.AdicionarMusica(nomeMusica, codigoMusica);
                    }
                    #endregion

                    #region Remover Musica
                    if (opcao == '2') // Remover musica
                    {
                        Console.WriteLine("\n--Remover Musica--\n\n");
                        Console.Write("\nTitulo: "); nomeMusica = Console.ReadLine();
                        BL.Musicas.RemoverMusica(nomeMusica);
                    }
                    #endregion

                    #region Editar Musica
                    if (opcao == '3')
                    {
                        int index;

                        // Pede o titulo da musica
                        Console.Write("\nTitulo: "); nomeMusica = Console.ReadLine();
                        Console.Clear();
                        index = BL.Musicas.ExisteMusica(nomeMusica);
                        if (index == 0)
                            Console.WriteLine("Não existe nenhuma musica com o nome {0}", nomeMusica);
                        else
                        {
                            // Pede o titulo da musica
                            Console.Write("\nTitulo novo: "); nomeMusica = Console.ReadLine();

                            // Limpa a Consola
                            Console.Clear();

                            // Edita a musica nova
                            BL.Musicas.EditarMusicaBO(index, nomeMusica);

                            //Mostrar mensagem ao utilizador
                            Console.WriteLine("Musica editada com sucesso!!");
                            Console.ReadKey();
                        }
                    }
                    #endregion

                    #region Listar Musicas
                    if (opcao == '4') // Listar Musicas
                    {
                        Console.Clear();
                        Console.WriteLine("--Listagem de Musicas--\n\n");
                        BL.Musicas.MostraMusicasDisponiveis();
                        Console.ReadKey();
                    }
                    #endregion

                    #region Listar Musicas por Album
                    if (opcao == '5')
                    {
                        bool musicas;

                        // Pede o titulo do album
                        Console.Write("\nTitulo do album: "); nomeAlbum = Console.ReadLine();

                        //Verificar se existem musicas nesse album
                        musicas = BL.Musicas.ListarMusicasPorAlbum(nomeAlbum);

                        //Caso o album não exista ou não tenha musicas mostrar mensagem
                        if (musicas == false)
                        {
                            Console.WriteLine("Não existem musicas para listar!!");
                            Console.ReadKey();
                            Console.Clear();
                        }
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
             #endregion
            }
        }
    }
}
