using System;
using System.Collections;

namespace Roleplay
{
    public class Magos
    {
        private string nombre;
        public int vida;
        public ArrayList items;
        public ArrayList spellbook;

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
        public Magos (string nombre)
        {
            this.Nombre = nombre;
            this.vida = 20;
            this.vidaMaxima = 20;
            this.items = new ArrayList();
            this.spellbook = new ArrayList();
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
        /// Agrego el hechizo al spellbook si no estaba en él.
        /// </summary>
        /// <param name="hechizo"></param>
        public void AgregarHechizo(Hechizo hechizo)
        {
             if (!this.spellbook.Contains(hechizo))
            {
                this.spellbook.Add(hechizo);
                Console.WriteLine($"El hechizo {hechizo.Nombre} fue agregado al spellbook.");
            }
            else 
            {
                Console.WriteLine($"El hechizo {hechizo.Nombre} ya se encuentra en el spellbook.");
            }
        }

        /// <summary>
        /// Remueve el hechizo del spellbook si estaba en él.
        /// </summary>
        /// <param name="elemento"></param>
        public void EliminarHechizo(Hechizo hechizo)
        {
            if (this.spellbook.Contains(hechizo))
            {
                this.spellbook.Remove(hechizo);
                Console.WriteLine($"El hechizo {hechizo.Nombre} fue removido del spellbook.");
            }
            else
            {
                Console.WriteLine($"El hechizo {hechizo.Nombre} no se encuentra en el spellbook.");
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
        /// Muestra el nombre, vida acutal, vida máxima, items  y hechizos del personaje.
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
            Console.WriteLine("Hechizos: ");
            foreach (Hechizo hechizo in this.spellbook)
            {
                Console.WriteLine($"-> {hechizo.Nombre} (ataque: {hechizo.ValorAtaque})");
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
