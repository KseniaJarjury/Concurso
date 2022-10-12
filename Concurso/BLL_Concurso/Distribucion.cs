using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Concurso
{
    public class Distribucion : Concurso
    {
        //Los premios pueden repetirse, pero al finalizar todos deben estar asignados.
        //Cada participante recibe un solo premio.
        //Debe haber más participantes que premios.
        //El orden de asignación es aleatorio tanto para personas como para premios.
        public override DataTable Asignacion()
        {
            try
            {
                _cargarListas();
                crearDt();
                List<Premio> prems = _premios;
                List<Premio> premsaux = new List<Premio>();
                List<Participantes> parts = _parts;
                Random random = new Random();
                int index;
                int indexAux;
                DataTable dt = _dt;
                if (parts.Count < prems.Count)
                    throw new Exception("Se necesita registrar mas participantes");
                //genero duplicado de lista de premios
                foreach (Premio prem in prems)
                {
                    premsaux.Add(prem);
                }

                //Recorro los participantes
                foreach (Participantes part in parts)
                {
                    Premio premio = new Premio();
                    //Selecciono al azar el indice de uno de los premios y lo uso para elegir un ganador
                    index = random.Next(prems.Count);
                    //Selecciono premio y lo quito de la lista para que todos los premios sean asignados si o si
                    if (prems.Count > 0)
                    {
                        premio = prems[index];
                        prems.Remove(prems[index]);
                    }
                    else//si existen mas participantes que premios, uso una lista auxiliar con los mismos premios
                    {
                        indexAux = random.Next(premsaux.Count);
                        premio = premsaux[indexAux];
                    }
                    //Asigno premios a los ganadores y los agrego al datatable
                    dt.Rows.Add(part.Nombre, premio.Descripcion);
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
