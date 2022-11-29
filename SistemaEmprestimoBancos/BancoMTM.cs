using SistemaEmprestimoBancos.AreaEmprestimos;
using SistemaEmprestimoBancos.Bancos;
using SistemaEmprestimoBancos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorEmprestimos
{
    public class BancoMTM
    {
        public static void MenuBanco()
        {
            bool sair = false;
            while (sair == false)
            {

                Console.WriteLine("----- Bem Vindo ao Simulador de Empréstimo MTM -----");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("1-Ver Taxas de Juros\n2-Fazer uma simulação de Empréstimo\n3-Sair");
                Console.WriteLine();
                Console.Write("Escolha a opção desejada: ");
                int.TryParse(Console.ReadLine(), out int opcao);
                Console.WriteLine("----------------------------------------------------");

                EscolhaMenuPrincipal op = (EscolhaMenuPrincipal)opcao;
                switch (op)
                {
                    case EscolhaMenuPrincipal.VerTaxaJuro:
                        Banco.MostrarBancos();
                        break;
                    case EscolhaMenuPrincipal.SimulacaoEmprestimo:
                        MenuEmprestimos.MenuDeEmprestimo();
                        break;
                    case EscolhaMenuPrincipal.Sair:
                        sair = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Opçao Inválida! Tente novamente.");
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------");
                        MenuBanco();
                        break;
                }
                
                Console.Clear();

            }

        }
    }
}
