using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class Musicas
    {
        /// <summary>
        /// Função que devolve o número total de artistas
        /// </summary>
        /// <returns></returns>
        public static int TotalMusicas()
        {
            return DL.Musicas.lst_musicas.Count;
        }
    }
}
