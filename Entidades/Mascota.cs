using System;

namespace Entidades
{
    public class Mascota
    {
        public bool Dormido { get; set; }
        public bool Lleno { get; set; }

        private void ComprobarDormido()
        {
            if (Dormido)
                throw new Exception("No hago nada, durmiendo zzzzzzzzz");
        }

        public string Comer()
        {
            ComprobarDormido();
            if (Lleno)
                throw new Exception("Mascota llena");
            return "Comiendo";
        }
        public void IrAlBanho()
        {
            ComprobarDormido();
        }
        public void Jugar()
        {
            ComprobarDormido();
        }
        public void Dormir()
        {
            if (Dormido)
                throw new Exception("Mascota ya esta durmiendo");
        }
        public void Despertarse()
        {
            if (!Dormido)
                throw new Exception("Mascota ya esta despierta");
        }
    }
}
