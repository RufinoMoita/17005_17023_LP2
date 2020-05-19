///  <author> Rui Costa</author>
///  <author> Helder Sá</author>
///  <date> xx/xx/2020 </date>
///  <version> 1.0 </version>
///  <email> a17005@alunos.ipca.pt </email>
///  <email> a17023@alunos.ipca.pt </email>
///  Funções da classe albuns
using BO;

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
