using SimuladorEmprestimos;
using SistemaEmprestimoBancos.Conexao;
using SistemaEmprestimoBancos.Enums;
using SistemaEmprestimoBancos.MetodosCRUD;
using System.ComponentModel.Design;

namespace SistemaEmprestimoBancos.Bancos
{
    public class Banco
    {
        public int Id { get; set; }
        public string Nome { get; set; } = String.Empty;
        public double TjPessoal { get; set; }
        public double TjVeicular { get; set; }



        public static void MostrarBancos()
        {
            Console.WriteLine();
            Console.WriteLine("Taxas de juros dos Bancos Disponíveis:");
            Console.WriteLine();

            using (var repo = new BancoEntity())
            {
                IList<Banco> bancos = repo.Bancos();
                foreach (var item in bancos)
                {
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Precione Enter para voltar.");
            Console.ReadLine();
            Console.Clear();
        }


        public void Menu(int banco)
        {
            Console.WriteLine("Escolha a modalidade de emprestimo desejada:");
            Console.WriteLine();
            Console.WriteLine("1-Emprestimo Pessoal\n2-Emprestimo Veicular");
            Console.WriteLine();
            Console.Write("Escolha a opção desejada: ");
            int.TryParse(Console.ReadLine(), out int opcao);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
           //Console.Clear();

            EscolhaModalidade op = (EscolhaModalidade)opcao;
            Console.Write("Qual o valor que deseja Simular?    ");
            double.TryParse(Console.ReadLine(), out double valorEmprestimo);
            Console.Write("Em quantos anos deseja parcelar?    ");
            int.TryParse(Console.ReadLine(), out int anos);

            switch (op)
            {

                case EscolhaModalidade.EmprestimoPessoal:

                    using (var repositorio = new BancoContext())
                    {
                        IList<Banco> bancos = repositorio.bancos.ToList();

                        foreach (var item in bancos)
                        {
                            if (item.Id == banco)
                            {
                                double a = 1 + (item.TjPessoal / 100);
                                double b = Math.Pow(a, anos);
                                double valorTotalPago = b * valorEmprestimo;
                                double valorParcela = valorTotalPago / (anos * 12);
                                double valorJuros = valorTotalPago - valorEmprestimo;

                                Console.WriteLine();
                                Console.WriteLine($"Para financiar {valorEmprestimo.ToString("C2")}");
                                Console.WriteLine($"O valor da parcela será de: {valorParcela.ToString("C2")}");
                                Console.WriteLine($"O valor total pago ao final será de: {valorTotalPago.ToString("C2")}");
                                Console.WriteLine($"O valor total pago em juros será de: {valorJuros.ToString("C2")}");
                                Console.WriteLine();
                                Console.WriteLine("----------------------------------------------------");

                            }

                        }
                    }

                break;

                case EscolhaModalidade.EmprestimoVeicular:

                    using (var repositorio = new BancoContext())
                    {
                        IList<Banco> bancos = repositorio.bancos.ToList();

                        foreach (var item in bancos)
                        {
                            if (item.Id == banco)
                            {
                                double a = 1 + (item.TjVeicular / 100);
                                double b = Math.Pow(a, anos);
                                double valorTotalPago = b * valorEmprestimo;
                                double valorParcela = valorTotalPago / (anos * 12);
                                double valorJuros = valorTotalPago - valorEmprestimo;

                                Console.WriteLine();
                                Console.WriteLine($"Para financiar {valorEmprestimo.ToString("C2")}");
                                Console.WriteLine($"O valor da parcela será de: {valorParcela.ToString("C2")}");
                                Console.WriteLine($"O valor total pago ao final será de: {valorTotalPago.ToString("C2")}");
                                Console.WriteLine($"O valor total pago em juros será de: {valorJuros.ToString("C2")}");
                                Console.WriteLine();
                                Console.WriteLine("----------------------------------------------------");

                            }
                        }

                    }

                break;
            }

            Console.WriteLine();
            Console.WriteLine("Pressione Enter para voltar.");
            Console.ReadLine();
            Console.Clear();
            BancoMTM.MenuBanco();
        }


        public override string ToString()
        {
            return $"Banco: {Nome}\nTaxa de Juros Pessoal: {TjPessoal.ToString("F2")}% a.a.\nTaxa de Juros Veicular: {TjVeicular.ToString("F2")}% a.a.";
        }

    }

}




















