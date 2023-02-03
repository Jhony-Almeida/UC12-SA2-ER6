// See https://aka.ms/new-console-template for more information

//Console.Clear();
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Turma13");

using ProgBackEnd.Classes;


Console.Clear();

Utils.BarraCarregamento("iniciando", 3, "#");

string? opcao;

do
{   
    Console.Clear();
    Console.WriteLine(@$"
    
    ==================================================
    |         Bem-Vindo ao Sistema de Cadastro       |
    |           de Pessoa Física ou Juridica         |
    ==================================================
    |        Digite o número da opção desejada       |
    ==================================================
    |                                                |
    |               1-Pessoa Física                  |
    |               2-Pessoa Juridica                |
    |                                                |
    |               0-Sair                           |
    ==================================================
");


opcao = Console.ReadLine();
Thread.Sleep(1000);

        switch (opcao)
        {
            case "1":
                    PessoaFisica novaPf = new PessoaFisica();
                    Endereco novaEndPF = new Endereco();

        
                    novaPf.nome = "Jhony Almeida da Silva";
                    novaPf.cpf = "1547846565";
                    novaPf.rendimento = 7000.5f;
                    novaPf.dataNasc = new DateTime(1979,01,01);


                    Console.WriteLine($"Pessoa Fisica ========================");
                    float resultado = novaPf.CalcularImposto(novaPf.rendimento);
                    Console.WriteLine(resultado);
                    Console.WriteLine($"Validação de Datas ========================");
                    DateTime temp = new DateTime(2000,01,01);
                    Console.WriteLine(novaPf.ValidarDataNasc(temp));
                    Console.WriteLine(novaPf.ValidarDataNasc("01/01/2000"));

                    novaEndPF.logradouro = "Rua Niteroi";
                    novaEndPF.numero = 100;
                    novaEndPF.complemento = "Predio";
                    novaEndPF.endComercial = true;

                    novaPf.endereco = novaEndPF;

                    Console.WriteLine(@$"
                    Nome: {novaPf.nome}
                    Nome da Rua: {novaPf.endereco.logradouro}, Num: {novaPf.endereco.numero}
                    Maior de Idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
                    ");

                    Console.WriteLine($"Para continuar, aperte a tecla ENTER");
                    Console.ReadLine();
                    
                    // Console.WriteLine(novaPf.nome);
                    // Console.WriteLine(novaPf.cpf);
                    // Console.WriteLine($"---------------------------");


                    // Console.WriteLine($"Bem-vindo {novaPf.nome} seu cpf é:{novaPf.cpf}"); 

                break;

            case "2":

                    PessoaJuridica novaPj = new PessoaJuridica();
                    Console.WriteLine(novaPj.ValidarCnpj("21.137.998/0001-40"));
                    Endereco novaEndPj = new Endereco();
                    
                    novaPj.cnpj = "21.137.998/0001-40";

                    Console.WriteLine(@$"
                    CNPJ: {novaPj.cnpj}
                    Valido: {novaPj.ValidarCnpj(novaPj.cnpj)}

                    ");

                    Console.WriteLine($"Pessoa Juridica ========================");
                    novaEndPj.logradouro = "Rua Niteroi";
                    novaEndPj.numero = 100;
                    novaEndPj.complemento = "Predio";
                    novaEndPj.endComercial = true;
                    novaPj.endereco = novaEndPj;

                    float impostoPagar = novaPj.CalcularImposto(12000.5f);
                    Console.WriteLine($"R$ {impostoPagar:0.00}");
                    Console.WriteLine($"{impostoPagar.ToString("C")}");

                    Console.WriteLine($"Para continuar, aperte a tecla ENTER");
                    Console.ReadLine();

                break;

            case "0":

                Console.WriteLine($"Obrigado por utilizar nosso sistema");
                
                break;

            default:

            Console.WriteLine("Opção invalida, digite um valor disponivel");
            Console.WriteLine($"Para continuar, aperte a tecla ENTER");
            Console.ReadLine();
            
                break;
        }

} while (opcao != "0");

Utils.BarraCarregamento("Finalizando", 9, "@");