using ExerciciosGPT.Entidades;
using ExerciciosGPT.ConsumindoApis;


namespace ExerciciosGPT;

public class Program
{

    public static async Task Main()
    {


        Carro carro1 = new Carro { Marca = "Toyota", Modelo = "Corolla", Ano = 2020 };
        Carro carro2 = new Carro { Marca = "Honda", Modelo = "Civic", Ano = 2019 };
        Carro carro3 = new Carro { Marca = "Ford", Modelo = "Focus", Ano = 2018 };

        carro1.ExibirInformacoes();
        carro2.ExibirInformacoes();
        carro3.ExibirInformacoes();

        Console.WriteLine("----------------------------------------------------------");

        Cachorro cachorro = new Cachorro { Nome = "Rex", Idade = 5 };
        Gato gato = new Gato { Nome = "Gambazinho", Idade = 8 };
        cachorro.FazerSom();
        gato.FazerSom();

        Console.WriteLine("----------------------------------------------------------");

        ICalculadora calculadora = new CalculadoraBasica();
        Console.WriteLine($"5 + 3 = {calculadora.Somar(5, 3)}");
        Console.WriteLine($"5 - 3 = {calculadora.Subtrair(5, 3)}");

        Console.WriteLine("----------------------------------------------------------");

        try
        {
            Console.WriteLine("Digite o nome para consultar a idade:");
            string name = Console.ReadLine();

            RespostaApiDTO dados = await RespostaApiService.GetAgeByNameAsync(name);

            Console.WriteLine($"Nome: {dados.Name}, Idade: {dados.Age}, Contagem: {dados.Count}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao consultar a API: {ex.Message}");
        }

        Console.WriteLine("----------------------------------------------------------");


        List<Livro> livros = new List<Livro>
        {
            new Livro { Titulo = "Livro A", Autor = "Autor A", AnoPublicacao = 2001 },
            new Livro { Titulo = "Livro B", Autor = "Autor B", AnoPublicacao = 2002 },
            new Livro { Titulo = "Livro C", Autor = "Autor C", AnoPublicacao = 2003 }
        };

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Listar todos os livros");
            Console.WriteLine("2. Emprestar um livro");
            Console.WriteLine("3. Devolver um livro");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    ListarLivros(livros);
                    break;
                case 2:
                    EmprestarLivro(livros);
                    break;
                case 3:
                    DevolverLivro(livros);
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    public static void ListarLivros(List<Livro> livros)
    {
        foreach (var livro in livros)
        {
            Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.AnoPublicacao}, Emprestado: {livro.Emprestado}");
        }
    }

    public static void EmprestarLivro(List<Livro> livros)
    {
        Console.Write("Digite o título do livro para emprestar: ");
        string titulo = Console.ReadLine();
        Livro livro = livros.Find(l => l.Titulo == titulo);
        if (livro != null)
        {
            livro.Emprestar();
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }

    public static void DevolverLivro(List<Livro> livros)
    {
        Console.Write("Digite o título do livro para devolver: ");
        string titulo = Console.ReadLine();
        Livro livro = livros.Find(l => l.Titulo == titulo);
        if (livro != null)
        {
            livro.Devolver();
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }
}

