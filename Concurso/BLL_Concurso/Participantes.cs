using System;

namespace BLL_Concurso
{
    public class Participantes
    {
        private string _nombre;
        private int _edad;
        private int _idParticipante;
        private int _ordenRegistro;
        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public int Edad
        {
            get => _edad;
            set => _edad = value;
        }

        public int IdParticipante
        {
            get => _idParticipante;
            set => _idParticipante = value;
        }
        public int OrdenRegistro
        {
            get => _ordenRegistro;
            set => _ordenRegistro = value;
        }

        public Participantes(string nombre, int edad, int idParticipante, int orden)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.IdParticipante = idParticipante;
            this.OrdenRegistro = orden;
        }

        public Participantes()
        {
        }
    }
}
