using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Concurso
{
    public class Premio
    {
        private string _descripcion;
        private int _idPremio;
        private int _ordenPremio;

        public string Descripcion
        {
            get => _descripcion;
            set => _descripcion = value;
        }

        public int IdPremio
        {
            get => _idPremio;
            set => _idPremio = value;
        }
        public int OrdenPremio
        {
            get => _ordenPremio;
            set => _ordenPremio = value;
        }

        public Premio(int id, string desc, int orden)
        {
            this.IdPremio = id;
            this.Descripcion = desc;
            this.OrdenPremio = orden;
        }

        public Premio()
        {
        }
    }
}
