using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Concurso
{
    public class Ruleta:Concurso
    {
        //Los premios pueden repetirse cada vez que se asignan.
        //Puede haber más premios que participantes y quedar premios sin asignar.
        //Cada participante tiene una chance de participar.
        //La asignación se hace por participante, tomando cada uno por su orden de registro.

        public override DataTable Asignacion()
        {
            try
            {
                _cargarListas();
                crearDt();
                List<Premio> prems = _premios;
                List<Participantes> parts = _parts;
                Random random = new Random();
                int index;
                DataTable dt = _dt;
                //Ordeno la lista de participantes segun orden de registro
                 parts.OrderBy(parts => parts.OrdenRegistro);

                //Recorro los participantes
                foreach (Participantes part in parts)
                {
                    Premio premio = new Premio();
                    //Selecciono al azar el indice de uno de los premios y lo uso para elegir un ganador
                    index = random.Next(prems.Count);
                    premio = prems[index];
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
