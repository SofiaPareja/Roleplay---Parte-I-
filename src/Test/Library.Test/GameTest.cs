using NUnit.Framework;
using Roleplay;
using System.Collections;

namespace Test.Library
{

    [TestFixture]
    public class ExampleTest
    {

        [Test]
        public void ItemsInEnanosTest()
        {
            Enanos enano = new Enanos ("enano");
            Item item = new Item(1,1,"item");
            enano.AgregarItem(item);
            Assert.IsNotNull(enano.items);
        }

        [Test]
        public void ItemsInMagosTest()
        {
            Magos mago = new Magos("mago");
            Item item = new Item(1,1,"item");
            mago.AgregarItem(item);
            Assert.IsNotNull(mago.items);
        }

        [Test]
        public void ItemsInElfosTest()
        {
            Elfos elfo = new Elfos("elfo");
            Item item = new Item(1,1,"item");
            elfo.AgregarItem(item);
            Assert.IsNotNull(elfo.items);
        }

        [Test]
        public void SpellBookNotEmptyTest()
        {
            Magos mago = new Magos("mago");
            Hechizo spell = new Hechizo(1,"spell");
            mago.AgregarHechizo(spell);
            Assert.IsNotNull(mago.spellbook);
        }

        [Test]
        public void EliminarItemEnanosTest()
        {
            Enanos enano = new Enanos("enano");
            Item item = new Item(1,1,"item");
            enano.AgregarItem(item);
            enano.EliminarItem(item);
            Assert.IsEmpty(enano.items);

        }
        
        [Test]
        public void EliminarItemElfosTest()
        {
            Elfos elfo = new Elfos("elfo");
            Item item = new Item(1,1,"item");
            elfo.AgregarItem(item);
            elfo.EliminarItem(item);
            Assert.IsEmpty(elfo.items);

        }
        
        [Test]
        public void EliminarItemMagoTest()
        {
            Magos mago = new Magos("enano");
            Item item = new Item(1,1,"item");
            mago.AgregarItem(item);
            mago.EliminarItem(item);
            Assert.IsEmpty(mago.items);

        }

        [Test]
        public void EliminarSpellTest()
        {
            Magos mago = new Magos("mago");
            Hechizo spell = new Hechizo(1,"spell");
            mago.AgregarHechizo(spell);
            mago.EliminarHechizo(spell);
            Assert.IsEmpty(mago.spellbook);
        }

        [Test]
        public void AtacarEnanoAMagoTest()
        {
            Enanos enano = new Enanos("enano");
            Item item1 = new Item(4,1,"items");
            enano.AgregarItem(item1);
            Magos mago = new Magos("mago");
            enano.Atacar(mago);
            Assert.Less(mago.vida, 20);
        }

        [Test]
        public void CurarEnanoTest()
        {
            Enanos enano = new Enanos("enano");
            Interacciones.Curar(enano,2);
            const int expected = 20;
            Assert.AreEqual(expected, enano.vida);

        }
    }


}