// See https://aka.ms/new-console-template for more information
using UC9_PBE_10.Classes;

Console.WriteLine("Hello, World!");

PessoaFisica novaPessoaFisica = new PessoaFisica();

novaPessoaFisica.Nome = "Larissa";
novaPessoaFisica.Cpf = "06518733478";
novaPessoaFisica.DataNascimento = new DateTime(2001, 08, 03);
novaPessoaFisica.Rendimento = 13200.23f;

Console.WriteLine(@$"
Nome: {novaPessoaFisica.Nome}
Data de Nascimento : {novaPessoaFisica.DataNascimento}
Cpf: {novaPessoaFisica.Cpf}
Rendimento: US$ {novaPessoaFisica.Rendimento}
");

PessoaJuridica novaPessoaJuridica = new PessoaJuridica();

novaPessoaJuridica.Nome = "Program";
novaPessoaJuridica.RazaoSocial = "Instituto Especializado em Codificações";
novaPessoaJuridica.Cnpj = "98451973048806";
novaPessoaJuridica.Rendimento = 102880.50f;

Console.WriteLine(@$"
Nome Fantasia : {novaPessoaJuridica.Nome}
Cnpj : {novaPessoaJuridica.Cnpj}
Razão Social : {novaPessoaJuridica.RazaoSocial}
Rendimento Mensal : US$ {novaPessoaJuridica.Rendimento}
");