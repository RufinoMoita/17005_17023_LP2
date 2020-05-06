///  <author> Rui Costa</author>
///  <author> Helder Sá</author>
///  <date> xx/xx/2020 </date>
///  <version> 1.0 </version>
///  <email> a17005@alunos.ipca.pt </email>
///  <email> a17023@alunos.ipca.pt </email>
///  <desc></desc>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2_TP_Library
{
    public class Editora
    {
        #region Estado

        List<Artistas> artistas = new List<Artistas>();

        #endregion

        #region Propriedades
    
        /// <summary>
        /// Obtem e define a lista de artistas
        /// </summary>
        public List<Artistas> Ar
        {
            get { return artistas; }
            set { artistas = value; }
        }
        #endregion

        #region Métodos


        #endregion

        #region Overrides
        #endregion
    }
}
