﻿using Projeto_Console.Classes;

// métodos genéricos
PessoaFisica metodosPf = new PessoaFisica();
PessoaJuridica metodosPj = new PessoaJuridica();

// Cabeçalho do sistema
Console.WriteLine(@$"
=============================================
|    Bem vindo ao sistema de cadastro de    |
|        Pessoas Físicas e Jurídicas        |
=============================================
");



// loading
Utils.Loading("Iniciando o sistema", 300, 5);

Console.WriteLine();//pula uma linha



string? opcao;//fora do do while por conta do escopo

do
{

    // Menu do sistema
    Console.WriteLine(@$"
=============================================
|    Escolha uma das opções abaixo          |
| ------------------------------------------|
|           1 - Pessoa Física               |
|           2 - Pessoa Jurídica             |
|                                           |
|           0 - Sair                        |
=============================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            //pessoa física
            Console.Clear();
            // ****************************** PESSOA FÍSICA *****************************

            // CADASTRO
            // //Endereço PF
            Endereco endPf = new Endereco();
            endPf.Logradouro = "Rua Lá de Casa";
            endPf.Numero = 123;
            endPf.Comercial = false;
            //Cadastrando Pessoa Física
            PessoaFisica novaPf = new PessoaFisica();
            novaPf.Nome = "Eduardo Costa";
            novaPf.Cpf = "5826384796";
            novaPf.DataNascimento = "20/07/2006";
            novaPf.Rendimento = 1501;
            novaPf.Endereco = endPf;


            //EXIBIÇÃO
            Console.WriteLine($"***** Pessoa Física *****");

            Console.WriteLine(@$"
Nome: {novaPf.Nome}
Cpf: {novaPf.Cpf}
Data Nascimento: {novaPf.DataNascimento}
Maior de Idade: {metodosPf.ValidarDataNascimento(novaPf.DataNascimento)}
Rendimento Bruto: R${novaPf.Rendimento}
Rendimento Líquido: {metodosPf.PagarImposto(novaPf.Rendimento)}
Endereço: {novaPf.Endereco.Logradouro}
Número: {novaPf.Endereco.Numero}
Endereço Comercial: {novaPf.Endereco.Comercial}
");

            Utils.ParadaNoConsole("Tecle <Enter> para coninuar");
            Console.Clear();
            break;

        case "2":
            //pessoa jurídica
            Console.Clear();
            // ****************************** PESSOA JURÍDICA *****************************

            // CADASTRO
            // //Endereço PJ
            Endereco endPj = new Endereco();
            endPj.Logradouro = "Rua Niterói";
            endPj.Numero = 180;
            endPj.Comercial = true;

            //Cadastrando Pessoa Jurídica
            PessoaJuridica novaPj = new PessoaJuridica();
            novaPj.Nome = "Paulo Skaf";
            novaPj.RazaoSocial = "Serviço Nacional de Aprendizagem Industrial";
            novaPj.Cnpj = "73.482.002/0001-38";
            novaPj.Rendimento = 100000;
            novaPj.Endereco = endPj;

            // EXIBIÇÃO
            Console.WriteLine($"***** Pessoa Jurídica *****");
            Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}
CNPJ Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
Rendimento Bruto: R${novaPj.Rendimento}
Rendimento Líquido: R${metodosPj.PagarImposto(novaPj.Rendimento)}
Endereço: {novaPj.Endereco.Logradouro}
Número: {novaPj.Endereco.Numero}
Endereço Comercial: {novaPj.Endereco.Comercial}
");
            Utils.ParadaNoConsole("Tecle <Enter> para coninuar");
            Console.Clear();
            break;

        case "0":
            //sair
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar o sistema ");
            Utils.Loading("Finalizando", 500, 3, ConsoleColor.Yellow, ConsoleColor.White);
            Console.WriteLine();
            break;

        default:
            //opção inválida
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;//cor da fonte
            Console.WriteLine($"opção inválida");
            Console.ResetColor();
            
            Utils.ParadaNoConsole("Tecle <Enter> para coninuar");
            break;
    }
} while (opcao != "0");

















// ************** Atividade ER3- ValidarDataNascimento **************
// PessoaFisica novaPf = new PessoaFisica();

// // Console.WriteLine( novaPf.ValidarDataNascimento("1982,07,20") );
// Console.WriteLine( $"Maior de Idade? {novaPf.ValidarDataNascimento("20/07/2005")}");



// ************** Get && Set **************
// Pessoa edu = new Pessoa();
// edu.Nome = "Eduardo";
// edu.SetCorDeOlhos("red");


// Console.WriteLine($"Cor dos olhos: {edu.corDeOlhos}");
// edu.SetCorDaPele("Branca");//set

// Console.WriteLine($"Cor da Pele: {edu.GetCorDaPele()}");//get






// ************** Métodos e Construtores **************

// ************** Sobrescrita **************
// PessoaFisica edu = new PessoaFisica();
// edu.Nome = "Eduardo";
// edu.Idade = 40;

// Console.WriteLine($"Nome: {edu.Nome}");
// Console.WriteLine($"Idade: {edu.Idade}");

// edu.Envelhecer();

// Console.WriteLine($"Nova Idade: {edu.Idade}");



// ************** Sobrecarga **************

// //Endereço PF
// Endereco endPf = new Endereco();
// endPf.Logradouro = "Rua Lá de Casa";
// endPf.Numero = 123;
// endPf.Comercial = false;


// Pessoa eduardoCosta = new Pessoa();
// eduardoCosta.Nome = "Eduardo Mendes da Costa";
// eduardoCosta.Endereco = endPf;
// eduardoCosta.Rendimento = 100000;


// Pessoa roseCosta = new Pessoa("Rose Mendes da Costa Santos");
// roseCosta.Endereco = endPf;
// roseCosta.Rendimento = 200000;

// Pessoa thePeople = new Pessoa("The People", endPf, 1500);

// Console.WriteLine($"Nome: {eduardoCosta.Nome}");
// Console.WriteLine($"Nome: {roseCosta.Nome}");
// Console.WriteLine($"Nome: {thePeople.Nome}");


// //Endereço PJ
// Endereco endPj = new Endereco();
// endPj.Logradouro = "Rua Niterói";
// endPj.Numero = 180;
// endPj.Comercial = true;
// //Cadastrando Pessoa Jurídica
// PessoaJuridica novaPj = new PessoaJuridica();
// novaPj.Nome = "Paulo Skaf";
// novaPj.RazaoSocial = "Serviço Nacional de Aprendizagem Industrial";
// novaPj.Cnpj = "73.482.002/0001-38";
// novaPj.Rendimento = 100000;
// novaPj.Endereco = endPj;

// //Endereço PF
// Endereco endPf = new Endereco();
// endPf.Logradouro = "Rua Lá de Casa";
// endPf.Numero = 123;
// endPf.Comercial = false;
// //Cadastrando Pessoa Física
// PessoaFisica novaPf = new PessoaFisica();
// novaPf.Nome = "Eduardo Costa";
// novaPf.Cpf = "5826384796";
// novaPf.DataNascimento = "20/07/1982";
// novaPf.Rendimento = 12000;
// novaPf.Endereco = endPf;


// //Exibindo Pessoa Física
// Console.WriteLine($"***** Pessoa Física *****");
// Console.WriteLine(@$"
// Nome: {novaPf.Nome}
// Cpf: {novaPf.Cpf}
// Data Nascimento: {novaPf.DataNascimento}
// Rendimento: R${novaPf.Rendimento}
// Endereço: {novaPf.Endereco.Logradouro}
// Número: {novaPf.Endereco.Numero}
// Endereço Comercial: {novaPf.Endereco.Comercial}
// ");

// Console.WriteLine();

// Console.WriteLine($"***** Pessoa Jurídica *****");
// Console.WriteLine(@$"
// Nome: {novaPj.Nome}
// Razão Social: {novaPj.RazaoSocial}
// CNPJ: {novaPj.Cnpj}
// Rendimento: R${novaPf.Rendimento}
// Endereço: {novaPj.Endereco.Logradouro}
// Número: {novaPj.Endereco.Numero}
// Endereço Comercial: {novaPj.Endereco.Comercial}
// ");

