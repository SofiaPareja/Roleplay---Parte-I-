using System;
using System.Collections;

namespace Roleplay
{
    /// <summary>
    /// La clase Interacciones contiene todas las acciones que los personajes pueden hacer. Se utiliza
    /// una sobrecarga para poder interactuar con cualquier personaje, independiente de la clase que sea.
    /// </summary>
    public class Interacciones
    {
         /// <summary>
        /// El personaje recibe una cantidad de daño y se le sustrae de la vida.
        /// </summary>
        /// <param name="daño"></param>
        public static void RecibirDaño(Enanos enano, int daño)
        {
            if (daño > enano.Defensa())
            {
                enano.vida = enano.vida - daño;
                Console.WriteLine($"{enano.Nombre} ha recibido {daño} de daño.");
            }
            if (enano.vida <= 0)
            {
                Console.WriteLine($"{enano.Nombre} se ha desvanecido.");
            }
        }
         public static void RecibirDaño(Elfos elfo, int daño)
        {
            if (daño > elfo.Defensa())
            {
                elfo.vida = elfo.vida - daño;
                Console.WriteLine($"{elfo.Nombre} ha recibido {daño} de daño.");
            }
            if (elfo.vida <= 0)
            {
                Console.WriteLine($"{elfo.Nombre} se ha desvanecido.");
            }
        }

         public static void RecibirDaño(Magos mago, int daño)
        {
            if (daño > mago.Defensa())
            {
                mago.vida = mago.vida - daño;
                Console.WriteLine($"{mago.Nombre} ha recibido {daño} de daño.");
            }
            if (mago.vida <= 0)
            {
                Console.WriteLine($"{mago.Nombre} se ha desvanecido.");
            }
        }

         /// <summary>
        /// El personaje se cura una cantidad de vida que no puede exceder la vida máxima.
        /// </summary>
        /// <param name="cura"></param>
        public static void Curar(Enanos enano, int cura)
        {
            if (enano.vida + cura <= enano.VidaMaxima)
            {
               enano.vida = enano.vida + cura;
            }
            else
            {
                enano.vida = enano.VidaMaxima;
            }
        }

        public static void Curar(Elfos elfo, int cura)
        {
            if (elfo.vida + cura <= elfo.VidaMaxima)
            {
               elfo.vida = elfo.vida + cura;
            }
            else
            {
                elfo.vida = elfo.VidaMaxima;
            }
        }

         public static void Curar(Magos mago, int cura)
        {
            if (mago.vida + cura <= mago.VidaMaxima)
            {
               mago.vida = mago.vida + cura;
            }
            else
            {
                mago.vida = mago.VidaMaxima;
            }
        }
    }
    
}