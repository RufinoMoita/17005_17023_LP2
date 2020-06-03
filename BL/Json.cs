///  <author> Rui Costa</author>
///  <author> Helder Sá</author>
///  <date> xx/xx/2020 </date>
///  <version> 1.0 </version>
///  <email> a17005@alunos.ipca.pt </email>
///  <email> a17023@alunos.ipca.pt </email>
///  Json Files

using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
namespace BL
{
    public class Json
    {
        #region Estado
        //// Variaveis que vão guardar os dados
        static string artistaJSON, albumJSON, musicaJSON;
        // Caminho para os ficheiros .json
        static string artistaPath = Path.GetFullPath(Path.Combine(@"../../Artistas.json"));
        static string albumPath = Path.GetFullPath(Path.Combine(@"../../Albuns.json"));
        static string musicaPath = Path.GetFullPath(Path.Combine(@"../../Musicas.json"));
        // Instanciar JavaScriptSerializer para converter o objeto para JSON
        static JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
        #endregion

        #region Métodos
        /// <summary>
        /// Inicializar os ficheiros .json
        /// </summary>
        public static void InicializaJson()
        {
            // Se o caminho para o ficheiro JSON de Artistas, Albuns e Musicas existir...
            if (File.Exists(artistaPath) && File.Exists(albumPath) && File.Exists(musicaPath))
            {
                // Lê os dados do ficheiro .JSON
                artistaJSON = File.ReadAllText(artistaPath);
                albumJSON = File.ReadAllText(albumPath);
                musicaJSON = File.ReadAllText(musicaPath);

                // Importa os dados para o objecto
                DL.Artistas.lstArtistas = javaScriptSerializer.Deserialize<List<BO.ArtistaBO>>(artistaJSON);
                DL.Albuns.lstAlbuns = javaScriptSerializer.Deserialize<List<BO.AlbumBO>>(albumJSON);
                DL.Musicas.lstMusicas = javaScriptSerializer.Deserialize<List<BO.MusicaBO>>(musicaJSON);
            }
        }

        /// <summary>
        /// Gravar e ler os dados nos e dos ficheiros .json
        /// </summary>
        public static void GravaJson()
        {
            ///Serializa o objeto para JSON e guarda-o numa string 
            artistaJSON = javaScriptSerializer.Serialize(DL.Artistas.lstArtistas);
            albumJSON = javaScriptSerializer.Serialize(DL.Albuns.lstAlbuns);
            musicaJSON = javaScriptSerializer.Serialize(DL.Musicas.lstMusicas);
            // Escreve o texto nas strings nos respetivos ficheiros *.json
            File.WriteAllText(artistaPath, artistaJSON);
            File.WriteAllText(albumPath, albumJSON);
            File.WriteAllText(musicaPath, musicaJSON);
        }

        #endregion
    }
}
