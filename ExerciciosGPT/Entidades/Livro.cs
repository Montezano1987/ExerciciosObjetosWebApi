using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGPT.Entidades
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public bool Emprestado { get; set; }

        public void Emprestar()
        {
            if (!Emprestado)
            {
                Emprestado = true;
                Console.WriteLine($"O livro '{Titulo}' foi emprestado.");
            }
            else
            {
                Console.WriteLine($"O livro '{Titulo}' já está emprestado");
            }
        }
        public void Devolver()
        {
            if (Emprestado)
            {
                Emprestado = false;
                Console.WriteLine($"O livro '{Titulo}' foi devolvido.");
            }

            else
            {
                Console.WriteLine($"O livro '{Titulo}' não está emprestado.");
            }
        }
    }


}
