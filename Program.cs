using System;

namespace ExceptionsCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var Array = new int[3];

            try
            {
                // for (int i = 0; i < 10; i++)
                // {
                //     Console.WriteLine(Array[i]);
                // }
                Cadastrar("");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o índice na lista.");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Falha ao cadastrar o texto.");
            }
            catch (MinhaException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Caiu na minha exception.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado!");
            }
            finally
            {
                Console.WriteLine("Chegou ao fim!");
            }
        }

        static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new MinhaException("Problemas personalizados!");
            }
        }

        public class MinhaException : Exception
        {
            public MinhaException(string situacao)
            {
                OQueAconteceu = situacao;
            }
            public string OQueAconteceu { get; set; }
        }
    }
}
