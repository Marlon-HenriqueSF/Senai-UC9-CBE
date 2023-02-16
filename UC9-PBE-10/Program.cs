using System.Globalization;
using Cadastro_Pessoas_PBE10.Classes;

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(@$"
===========================================
|   Bem vindo ao sistema de cadastro de   |
|      Pessoas Físicas e Jurídicas        |
===========================================
");
Console.ResetColor();

Utils.BarraCarregamento("Iniciando", 300, 10);

List<PessoaFisica> listaPf = new List<PessoaFisica>();

string? opcao;

do
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(@$"
===========================================
|      Escolha uma das opções abaixo      |
|-----------------------------------------|
|             1 - Pessoa Física           |
|             2 - Pessoa Jurídica         |
|                                         |
|             0 - Sair                    |
===========================================
");
    Console.ResetColor();
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            string? opcaoPf;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@$"
===========================================
|      Escolha uma das opções abaixo      |
|-----------------------------------------|
|      1 - Cadastrar Pessoa Física        |
|      2 - Listar Pessoas Física          |
|                                         |
|      0 - voltar ao menu anterior        |
===========================================
");
                Console.ResetColor();
                opcaoPf = Console.ReadLine();
                PessoaFisica metodosPf = new PessoaFisica();

                switch (opcaoPf)
                {
                    case "1":
                        PessoaFisica novaPessoaFisica = new PessoaFisica();
                        Endereco novoEnderecoPf = new Endereco();

                        Console.WriteLine(@$"Digite o nome que deseja cadastrar");
                        novaPessoaFisica.Nome = Console.ReadLine();

                        Console.WriteLine($"Digite o número do cpf");
                        novaPessoaFisica.Cpf = Console.ReadLine();


                        bool dataValida; 

                        do 
                        {
                            Console.WriteLine(@$"Digite a data de nascimento ex: DD/MM/AAAA");
                            string? dataNascimento = Console.ReadLine();

                            dataValida = metodosPf.ValidarDataNascimento(dataNascimento);

                            if (dataValida)
                            {
                                DateTime dataConvertida;

                                DateTime.TryParse(dataNascimento, out dataConvertida);

                                novaPessoaFisica.DataNascimento = dataConvertida;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data inválida, favor digitar uma data válida!");
                                Console.ResetColor();
                            }
                        } while (dataValida == false);

                        Console.WriteLine($"Digite o rendimento mensal - (apenas números): ");
                        novaPessoaFisica.Rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro: ");
                        novoEnderecoPf.Logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número");
                        novoEnderecoPf.Numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Informe o complemento: ");
                        novoEnderecoPf.Complemento = Console.ReadLine();

                        Console.WriteLine($"Endereço é comercial ? S para sim ou N para não: ");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEnderecoPf.Comercial = true;
                        }
                        else
                        {
                            novoEnderecoPf.Comercial = false;
                        }

                        novaPessoaFisica.Endereco = novoEnderecoPf;

                        listaPf.Add(novaPessoaFisica);

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro Realizado com Sucesso!!!");
                        Thread.Sleep(3000);
                        Console.ResetColor();
                        break;

                    case "2":

                        if (listaPf.Count > 0) //se o conteudo da lista for maior que 0
                        {
                            foreach (PessoaFisica pf in listaPf) 
                            {
                                Console.WriteLine(@$"
                                Nome: {pf.Nome}
                                Endereço: {pf.Endereco.Logradouro}, {pf.Endereco.Numero}, {pf.Endereco.Complemento}, {pf.Endereco.Comercial}
                                Data de nascimento: {pf.DataNascimento}
                                Rendimento: {pf.Rendimento}
                                Imposto á pagar: {metodosPf.PagarImposto(pf.Rendimento)}
                                ");
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Aperte 'Enter' para continuar...");
                            Console.ResetColor();
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"Lista Vazia!!!");
                            Console.ResetColor();
                            Thread.Sleep(3000);
                        }
                        break;
                    case "0":
                        break;
                    default:

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção Inválida, por favor digite outra opção!");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        break;
                }
            } while (opcaoPf != "0");

            break;

        case "2":
            PessoaJuridica novaPessoaJuridica = new PessoaJuridica();

            Endereco novoEndereco = new Endereco();
            novoEndereco.Logradouro = "Rua Niterói";
            novoEndereco.Numero = 180;
            novoEndereco.Complemento = "São Caetano do Sul - SP";
            novoEndereco.Comercial = true;


            novaPessoaJuridica.Nome = "Senai";
            novaPessoaJuridica.RazaoSocial = "Escola Senai de Informática Ltda";
            novaPessoaJuridica.Cnpj = "58352125000149";
            novaPessoaJuridica.Rendimento = 100000.99f;
            novaPessoaJuridica.Endereco = novoEndereco;

            PessoaJuridica metodosPj = new PessoaJuridica();


            Console.WriteLine(@$"
Nome Fantasia : {novaPessoaJuridica.Nome}
Razão Social : {novaPessoaJuridica.RazaoSocial}
Cnpj : {novaPessoaJuridica.Cnpj}
Cnpj válido : {(metodosPj.ValidarCnpj(novaPessoaJuridica.Cnpj) ? "Cnpj no formato válido!" : "Cnpj fora do padrão esperado!")}
Rendimento Mensal : $ {novaPessoaJuridica.Rendimento}
Endereço : {novaPessoaJuridica.Endereco.Logradouro}, {novaPessoaJuridica.Endereco.Numero}, {novaPessoaJuridica.Endereco.Complemento}, {novaPessoaJuridica.Endereco.Comercial}
Imposto á pagar : {metodosPj.PagarImposto(novaPessoaJuridica.Rendimento).ToString("C", new CultureInfo("en-US"))} 
");
            Console.WriteLine("Aperte ENTER para continuar");
            Console.ReadLine();
            break;

        case "0":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Obrigado por utilizar nosso sistema !");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opção inválida, escolha outra opção !");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }
} while (opcao != "0");

Utils.BarraCarregamento("Finalizando", 300, 10);
