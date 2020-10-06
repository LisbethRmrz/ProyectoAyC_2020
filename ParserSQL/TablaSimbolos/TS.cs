using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Errores;

namespace TablaSimbolos
{
    public class TS
    {
        public List<TabladeSimbolos> TSimbolos = new List<TabladeSimbolos>();
        TE tablaerroes = new TE();


        public TS()
        {

        }
        public List<TabladeSimbolos> TablaSimbolos
        {
            get { return TSimbolos; }
            set { TSimbolos = value; }
        }

        public void reinicialista()
        {
            TSimbolos.Clear();
        }

        #region Tabla de Simbolos, 3
        public void inicialista()
        {
            //string simb,string val,int nunlin,int tam,int ambit,int id_,string tip,string descrip
            TabladeSimbolos ts = new TabladeSimbolos("create", "", -0, -0, -0, 0, "Palabra Reservada", "Palabra reservada, usada como inicio de sentencia para crear base de datos", "");
            TSimbolos.Add(ts);
            TabladeSimbolos ts1 = new TabladeSimbolos("database", "", -0, -0, -0, 1, "Palabra Reservada", "Palabra reservada, usada para hacer referencia a una base de datos", "");
            TSimbolos.Add(ts);
            TabladeSimbolos ts2 = new TabladeSimbolos(";", "", -0, -0, -0, 2, "Punto y Coma", "Indica el final de una sentencia", "");
            TSimbolos.Add(ts);
        }

        #endregion

        public List<TabladeSimbolos> llamatabla()
        {
            return TSimbolos;
        }

        public void añadir_obj(TabladeSimbolos Ts)
        {
            TSimbolos.Add(Ts);
        }

        public bool compararAL(string argsplit)
        {
            bool bandera = false;
            foreach (var palabra in TSimbolos)
            {

                if (palabra.simbolo == argsplit)
                {
                    bandera = true;
                    break;
                }
                else
                {
                    bandera = false;
                }

            }
            return bandera;
        }
        //----------------------------------------------------------------
        public bool revisar_duplicados()
        {
            bool flag = false;
            //int cont = 0;
            foreach (var sent1 in TSimbolos)
            {
                foreach (var sent2 in TSimbolos)
                {
                    if (sent1.ID == sent2.ID)//&& sent1.TipoVar == sent2.TipoVar
                    {

                        flag = true;


                        //cont += 1;
                    }
                }
            }
            return flag;
        }
        //----------------------------------------------------------------
        public void compararALsemantic()
        {

            foreach (var palabra in TSimbolos)
            {
                foreach (var palabra2 in TSimbolos)
                {
                    if (palabra.Simbolo == palabra2.Simbolo)
                    {
                        palabra2.TipoVar = palabra.TipoVar;
                        //break;
                    }
                }
            }

        }

        //----------------------------------------------------------------

        public int compararALRef(string argsplit)
        {
            int id = 0;
            foreach (var palabra in TSimbolos)
            {

                if (palabra.simbolo == argsplit)
                {
                    id = palabra.id;
                    break;
                }
                else
                {
                    id = 0;
                }

            }
            return id;
        }

        //--------------------------------------------------------------
        public int contlineas()
        {
            int numid = 0;
            foreach (var nlinea in TSimbolos)
            {
                numid = numid + 1;
            }
            return numid - 1;
        }

    }
}
