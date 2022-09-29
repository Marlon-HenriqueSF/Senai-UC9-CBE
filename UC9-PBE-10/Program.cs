// See https://aka.ms/new-console-template for more information
using System.Globalization;
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
Rendimento: RS$ {novaPessoaFisica.Rendimento}
");


PessoaJuridica novaPessoaJuridica = new PessoaJuridica();

Endereco novoEndereco = new Endereco();
novoEndereco.Logradouro = "Rua Jose Vasconcelos Marcos";
novoEndereco.Numero = 785;
novoEndereco.Complemento = "Casa";
novoEndereco.Comercial = false;


novaPessoaJuridica.Nome = "Program";
novaPessoaJuridica.RazaoSocial = "Instituto Especializado em Codificações";
novaPessoaJuridica.Cnpj = "98451973048806";
novaPessoaJuridica.Rendimento = 102880.50f;
novaPessoaJuridica.Endereco = novoEndereco;

PessoaJuridica metodosPj = new PessoaJuridica();


Console.WriteLine(@$"
Nome Fantasia : {novaPessoaJuridica.Nome}
Cnpj : {novaPessoaJuridica.Cnpj}
Razão Social : {novaPessoaJuridica.RazaoSocial}
Rendimento Mensal : RS$ {novaPessoaJuridica.Rendimento}
Endereco : {novaPessoaJuridica.Endereco.Logradouro}, {novaPessoaJuridica.Endereco.Numero}, {novaPessoaJuridica.Endereco.Complemento}, {novaPessoaJuridica.Endereco.Comercial}
Imposto à pagar : R$ {metodosPj.PagarImposto(novaPessoaJuridica.Rendimento).ToString("c", new CultureInfo("pt-BR"))}
");