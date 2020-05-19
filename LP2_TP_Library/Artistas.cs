using BO;
using DL;

namespace BL
{
    class Artistas
    {
        /// <summary>
        /// Função que devolve o número total de artistas
        /// </summary>
        /// <returns></returns>
        public static int TotalArtistas()
        {
            return DL.Artistas.lst_artistas.Count;
        }

    }
}
