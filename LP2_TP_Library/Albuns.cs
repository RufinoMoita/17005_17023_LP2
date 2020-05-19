using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DL;

namespace BL
{
    class Albuns
    {
        /// <summary>
        /// Método que retorna o album menos vendido
        /// </summary>
        /// <returns></returns>
        public static Album MenosVendido()
        {
            Album min = new Album();
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
        public static Album MaisVendido()
        {
            Album max = new Album();
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
    }
}
