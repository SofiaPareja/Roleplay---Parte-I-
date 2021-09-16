using System;
using System.Collections;

namespace Roleplay
{
    public class Enanos
    {
        private string nombre;
        public int vida;
        public ArrayList items;

        private int vidaMaxima;

        public string Nombre
        {
            get ; set ;
        }

        public int VidaMaxima
        {
            get {return this.vidaMaxima;}
            set {this.VidaMaxima = 20;}
        }
        public Enanos (string nombre)
        {
            this.Nombre = nombre;
            this.vida = 20;
            this.vidaMaxima = 20;
            this.items = new ArrayList();
        }

        /// <summary>
        /// Agrega un item al personajel, si el personaje no lo tiene.
        /// </summary>
        /// <param name="elemento"></param>
        public void AgregarItem(Item elemento)
        {
            if (!this.items.Contains(elemento))
            {
                this.items.Add(elemento);
                Console.WriteLine($"El elemento {elemento.Nombre} fue agregado a los items.");
            }
            else 
            {
                Console.WriteLine($"El item {elemento.Nombre} ya se encuentra en los items.");
            }
        }

        /// <summary>
        /// Remueve el item del personaje, si el personaje lo tenía.
        /// </summary>
        /// <param name="elemento"></param>
        public void EliminarItem(Item elemento)
        {
            if (this.items.Contains(elemento))
            {
                this.items.Remove(elemento);
                Console.WriteLine($"El elemento {elemento.Nombre} fue removido de los items.");
            }
            else
            {
                Console.WriteLine($"El item {elemento.Nombre} no se encuentra en los items.");
            }
        }

        /// <summary>
        /// Calcula el ataque total del personaje en base a los items que tiene.  El personaje es el experto, 
        /// ya que tiene toda la información acerca de los items.
        /// </summary>
        /// <returns></returns>
        public int Ataque()
        {
            int resultado = 0;
            foreach (Item elemento in this.items)
            {
                resultado = resultado + elemento.ValorAtaque;
            }
            return resultado;
        }

        /// <summary>
        /// Calcula la defensa total del personaje en base a los items que tiene. El personaje es el experto, 
        /// ya que tiene toda la información acerca de los items.
        /// </summary>
        /// <returns></returns>
        public int Defensa()
        {
            int resultado = 0;
            foreach (Item elemento in this.items)
            {
                resultado = resultado + elemento.ValorDefensa;
            }
            return resultado;
        }

        /// <summary>
        /// Muestra el nombre, vida acutal, vida máxima y los items del personaje.
        /// </summary>
        public void Datos()
        {
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Vida: {this.vida}/{this.VidaMaxima}");
            Console.WriteLine("Items: ");
            foreach (Item item in this.items)
            {
                Console.WriteLine($"-> {item.Nombre} (ataque: {item.ValorAtaque}, defensa: {item.ValorDefensa})");
            }
        }

        /// <summary>
        /// Método para atacar a otro personaje.
        /// </summary>
        /// <param name="enano"></param>
        public void Atacar(Enanos enano)
        {
            Console.WriteLine($"{this.Nombre} ha atacado a {enano.Nombre}");
            Interacciones.RecibirDaño(enano, this.Ataque());
        }

         public void Atacar(Elfos elfo)
        {
            Console.WriteLine($"{this.Nombre} ha atacado a {elfo.Nombre}");
            Interacciones.RecibirDaño(elfo, this.Ataque());
        }

         public void Atacar(Magos mago)
        {
            Console.WriteLine($"{this.Nombre} ha atacado a {mago.Nombre}");
            Interacciones.RecibirDaño(mago, this.Ataque());
        }
        
    }
}