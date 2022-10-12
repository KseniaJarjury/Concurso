using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Concurso
{
    public abstract class Concurso
    {
        Premio premio1 = new Premio(1,"Auto",3);
        Premio premio2 = new Premio(2, "Televisor", 1);
        Premio premio3 = new Premio(3, "Lavarropas", 2);
        Premio premio4 = new Premio(4, "Celular", 4);
        Participantes part1 = new Participantes("Juan",21,1,3);
        Participantes part2 = new Participantes("Pedro",33,2,4);
        Participantes part3 = new Participantes("Leonardo",25,3,1);
        Participantes part4 = new Participantes("Matias",44,4,5);
        Participantes part5 = new Participantes("Roman",52,5,2);
        Participantes part6 = new Participantes("Susy", 50, 6, 6);

        public List<Participantes> _parts = new List<Participantes>();
        public List<Premio> _premios = new List<Premio>();
        public DataTable _dt = new DataTable();
        

        public abstract DataTable Asignacion();
        public void crearDt()
        {
            _dt.Clear();
            _dt.Columns.Add("Participante");
            _dt.Columns.Add("Premio");
        }

        public void _cargarListas()
        {
            _parts.Add(part1);
            _parts.Add(part2);
            _parts.Add(part3);
            _parts.Add(part4);
            _parts.Add(part5);
            _parts.Add(part6);

            _premios.Add(premio1);
            _premios.Add(premio2);
            _premios.Add(premio3);
            _premios.Add(premio4);
        }

    }
}
