using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Concurso
{
    public class Sorteo:Concurso
    {
        //Cada premio se debe asignar a un único participante.
        //Cada participante recibe un solo premio.
        //Debe haber más participantes que premios.
        //La asignación se hace por premio, iniciando por el último y terminando con el
        //primero.

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
                if (parts.Count < prems.Count)
                    throw new Exception("Se necesita registrar mas participantes");
                //Ordeno la lista de premios en orden descente
                prems.OrderByDescending(prems => prems.OrdenPremio);

                //Recorro los premios
                foreach (Premio premio in prems)
                {
                    Participantes Ganador = new Participantes();
                    //Selecciono al azar el indice de uno de los participantes y lo uso para elegir un ganador
                    index = random.Next(parts.Count);
                    Ganador = parts[index];
                    //Quito al ganador de la lista para que no vuelva a salir sorteado
                    parts.Remove(Ganador);
                    //Asigno premios a los ganadores y los agrego al datatable
                    dt.Rows.Add(Ganador.Nombre, premio.Descripcion);
                }

                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
