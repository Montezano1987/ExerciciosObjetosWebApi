
namespace ObjetosWebApi.Entidades
{
    public class Animal

    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void FazerSom()
        {
            Console.WriteLine("Som generico de animal");
        }
    }

    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine("Latido");
        }
    }

    public class Gato : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine("Miado");
        }
    }
}
