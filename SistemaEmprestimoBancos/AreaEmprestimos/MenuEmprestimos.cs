using SistemaEmprestimoBancos.Bancos;
using SistemaEmprestimoBancos.Enums;

namespace SistemaEmprestimoBancos.AreaEmprestimos
{
    public class MenuEmprestimos
    {
        public static void MenuDeEmprestimo()
        {
            bool sair = false;
            while(sair == false)
            {
                Console.WriteLine();
                Console.WriteLine("Em qual Banco deseja fazer a Simulação de Empréstimo? ");
                Console.WriteLine();
                Console.WriteLine("1-Caixa Econômica Federal\n2-Itaú Unibanco\n3-Banco Santander\n4-Banco Bradesco\n5-Voltar");
                Console.WriteLine();
                Console.Write("Escolha a opção desejada: ");
                int.TryParse(Console.ReadLine(), out int opcaoBanco);
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine();
                EnumBancos op = (EnumBancos)opcaoBanco;
                switch (op)
                {
                    case EnumBancos.Caixa:
                        var caixa = new Banco();
                        caixa.Menu(opcaoBanco);
                        break;
                    case EnumBancos.Itau:
                        var itau = new Banco();
                        itau.Menu(opcaoBanco);
                        break;
                    case EnumBancos.Santander:
                        var santander = new Banco();
                        santander.Menu(opcaoBanco);
                        break;
                    case EnumBancos.Bradesco:
                        var bradesco = new Banco();
                        bradesco.Menu(opcaoBanco);
                        break;
                    case EnumBancos.Voltar:
                        sair = true;
                        break;
                    default:
                        sair = true;
                        break;
                }

            }
            
        }

    }
}
