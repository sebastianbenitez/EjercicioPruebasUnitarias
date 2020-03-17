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
            Lleno = true;
            return "Comiendo";
        }
        public string IrAlBanio()
        {
            ComprobarDormido();
            if (!Lleno)
                throw new Exception("Mascota no comio");
            Lleno = false;
            return "Yendo al baño";
        }
        public string Jugar()
        {
            ComprobarDormido();
            if (!Lleno)
                throw new Exception("Mascota no comio");
            return "Jugando";
        }
        public string Dormir()
        {
            if (Dormido)
                throw new Exception("Mascota ya esta durmiendo");
            Dormido = true;
            return "Durmiendo";
        }
        public string Despertarse()
        {
            if (!Dormido)
                throw new Exception("Mascota ya esta despierta");
            Dormido = false;
            return "Despertando";
        }
    }
}
