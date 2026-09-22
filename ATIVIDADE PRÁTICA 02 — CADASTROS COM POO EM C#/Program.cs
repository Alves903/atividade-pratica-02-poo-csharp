using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Listas
        List<Produto> produtos = new List<Produto>();
        List<Livro> livros = new List<Livro>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        List<Veiculo> veiculos = new List<Veiculo>();
        List<Filme> filmes = new List<Filme>();
        List<Cliente> clientes = new List<Cliente>();
        List<Curso> cursos = new List<Curso>();
        List<Pedido> pedidos = new List<Pedido>();
        List<Equipamento> equipamentos = new List<Equipamento>();
        List<Jogo> jogos = new List<Jogo>();

        int opcao = 0;

        while (opcao != 11)
        {
            Console.Clear();

            Console.WriteLine("====================================");
            Console.WriteLine("       SISTEMA DE CADASTROS");
            Console.WriteLine("====================================");
            Console.WriteLine();

            Console.WriteLine("1 - Produtos");
            Console.WriteLine("2 - Livros");
            Console.WriteLine("3 - Funcionários");
            Console.WriteLine("4 - Veículos");
            Console.WriteLine("5 - Filmes");
            Console.WriteLine("6 - Clientes");
            Console.WriteLine("7 - Cursos");
            Console.WriteLine("8 - Pedidos");
            Console.WriteLine("9 - Equipamentos");
            Console.WriteLine("10 - Jogos");
            Console.WriteLine("11 - Sair");

            Console.WriteLine();
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                MenuProdutos(produtos);
            }
            else if (opcao == 2)
            {
                MenuLivros(livros);
            }
            else if (opcao == 3)
            {
                MenuFuncionarios(funcionarios);
            }
            else if (opcao == 4)
            {
                MenuVeiculos(veiculos);
            }
            else if (opcao == 5)
            {
                MenuFilmes(filmes);
            }
            else if (opcao == 6)
            {
                MenuClientes(clientes);
            }
            else if (opcao == 7)
            {
                MenuCursos(cursos);
            }
            else if (opcao == 8)
            {
                MenuPedidos(pedidos);
            }
            else if (opcao == 9)
            {
                MenuEquipamentos(equipamentos);
            }
            else if (opcao == 10)
            {
                MenuJogos(jogos);
            }
            else if (opcao == 11)
            {
                Console.WriteLine();
                Console.WriteLine("Encerrando o sistema...");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Opção inválida!");
                Pausar();
            }
        }
    }


    // =====================================================
    // MENU PADRÃO
    // =====================================================

    static int MostrarMenu(string titulo)
    {
        Console.Clear();

        Console.WriteLine("====================================");
        Console.WriteLine("            " + titulo);
        Console.WriteLine("====================================");
        Console.WriteLine();

        Console.WriteLine("1 - Cadastrar");
        Console.WriteLine("2 - Listar");
        Console.WriteLine("3 - Pesquisar");
        Console.WriteLine("4 - Alterar");
        Console.WriteLine("5 - Excluir");
        Console.WriteLine("6 - Relatório");
        Console.WriteLine("7 - Voltar");

        Console.WriteLine();
        Console.Write("Escolha uma opção: ");

        return int.Parse(Console.ReadLine());
    }


    // Pausa o programa

    static void Pausar()
    {
        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }


    // =====================================================
    // PRODUTOS
    // =====================================================

    static void MenuProdutos(List<Produto> produtos)
    {
        int opcao = 0;

        while (opcao != 7)
        {
            opcao = MostrarMenu("PRODUTOS");

            if (opcao == 1)
            {
                CadastrarProduto(produtos);
            }
            else if (opcao == 2)
            {
                ListarProdutos(produtos);
            }
            else if (opcao == 3)
            {
                PesquisarProduto(produtos);
            }
            else if (opcao == 4)
            {
                AlterarProduto(produtos);
            }
            else if (opcao == 5)
            {
                ExcluirProduto(produtos);
            }
            else if (opcao == 6)
            {
                RelatorioProdutos(produtos);
            }
            else if (opcao != 7)
            {
                Console.WriteLine("Opção inválida!");
                Pausar();
            }
        }
    }


    static void CadastrarProduto(List<Produto> produtos)
    {
        Console.Clear();

        Console.WriteLine("====================================");
        Console.WriteLine("         Cadastro de Produto");
        Console.WriteLine("====================================");
        Console.WriteLine();

        Produto produto = new Produto();

        Console.Write("Nome: ");
        produto.nome = Console.ReadLine();

        Console.Write("Categoria: ");
        produto.categoria = Console.ReadLine();

        Console.Write("Preço: ");
        produto.preco = double.Parse(Console.ReadLine());

        Console.Write("Quantidade: ");
        produto.quantidade = int.Parse(Console.ReadLine());

        produtos.Add(produto);

        Console.WriteLine();
        Console.WriteLine("Produto cadastrado com sucesso!");

        Pausar();
    }


    static void ListarProdutos(List<Produto> produtos)
    {
        Console.Clear();

        Console.WriteLine("====================================");
        Console.WriteLine("         Lista de Produtos");
        Console.WriteLine("====================================");
        Console.WriteLine();

        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
        }
        else
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Produto " + (i + 1));
                Console.WriteLine("------------------------------------");

                produtos[i].MostrarProduto();

                double total =
                    produtos[i].preco * produtos[i].quantidade;

                Console.WriteLine(
                    "Valor total em estoque: R$ " +
                    total.ToString("F2")
                );

                Console.WriteLine();
            }
        }

        Pausar();
    }


    static void PesquisarProduto(List<Produto> produtos)
    {
        Console.Clear();

        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0; i < produtos.Count; i++)
        {
            if (produtos[i].nome == nome)
            {
                Console.WriteLine();
                produtos[i].MostrarProduto();

                encontrado = true;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine();
            Console.WriteLine("Produto não encontrado.");
        }

        Pausar();
    }


    static void AlterarProduto(List<Produto> produtos)
    {
        Console.Clear();

        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0; i < produtos.Count; i++)
        {
            if (produtos[i].nome == nome)
            {
                Console.WriteLine();

                Console.Write("Novo nome: ");
                produtos[i].nome = Console.ReadLine();

                Console.Write("Nova categoria: ");
                produtos[i].categoria = Console.ReadLine();

                Console.Write("Novo preço: ");
                produtos[i].preco =
                    double.Parse(Console.ReadLine());

                Console.Write("Nova quantidade: ");
                produtos[i].quantidade =
                    int.Parse(Console.ReadLine());

                encontrado = true;

                Console.WriteLine();
                Console.WriteLine("Produto alterado com sucesso!");
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine();
            Console.WriteLine("Produto não encontrado.");
        }

        Pausar();
    }


    static void ExcluirProduto(List<Produto> produtos)
    {
        Console.Clear();

        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0; i < produtos.Count; i++)
        {
            if (produtos[i].nome == nome)
            {
                produtos.RemoveAt(i);

                encontrado = true;

                Console.WriteLine();
                Console.WriteLine("Produto excluído com sucesso!");

                break;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine();
            Console.WriteLine("Produto não encontrado.");
        }

        Pausar();
    }


    static void RelatorioProdutos(List<Produto> produtos)
    {
        Console.Clear();

        int quantidadeTotal = 0;
        double valorTotal = 0;

        for (int i = 0; i < produtos.Count; i++)
        {
            quantidadeTotal += produtos[i].quantidade;

            valorTotal +=
                produtos[i].preco *
                produtos[i].quantidade;
        }

        Console.WriteLine("====================================");
        Console.WriteLine("       Relatório de Produtos");
        Console.WriteLine("====================================");
        Console.WriteLine();

        Console.WriteLine(
            "Produtos cadastrados: " +
            produtos.Count
        );

        Console.WriteLine(
            "Quantidade em estoque: " +
            quantidadeTotal
        );

        Console.WriteLine(
            "Valor total do estoque: R$ " +
            valorTotal.ToString("F2")
        );

        Pausar();
    }


    // =====================================================
    // LIVROS
    // =====================================================

    static void MenuLivros(List<Livro> livros)
    {
        int opcao = 0;

        while (opcao != 7)
        {
            opcao = MostrarMenu("LIVROS");

            if (opcao == 1)
            {
                CadastrarLivro(livros);
            }
            else if (opcao == 2)
            {
                ListarLivros(livros);
            }
            else if (opcao == 3)
            {
                PesquisarLivro(livros);
            }
            else if (opcao == 4)
            {
                AlterarLivro(livros);
            }
            else if (opcao == 5)
            {
                ExcluirLivro(livros);
            }
            else if (opcao == 6)
            {
                RelatorioLivros(livros);
            }
            else if (opcao != 7)
            {
                Console.WriteLine("Opção inválida!");
                Pausar();
            }
        }
    }


    static void CadastrarLivro(List<Livro> livros)
    {
        Console.Clear();

        Livro livro = new Livro();

        Console.Write("Título: ");
        livro.titulo = Console.ReadLine();

        Console.Write("Autor: ");
        livro.autor = Console.ReadLine();

        Console.Write("Ano: ");
        livro.ano = int.Parse(Console.ReadLine());

        Console.Write("Categoria: ");
        livro.categoria = Console.ReadLine();

        Console.Write("Disponível (true/false): ");
        livro.disponivel =
            bool.Parse(Console.ReadLine());

        livros.Add(livro);

        Console.WriteLine();
        Console.WriteLine("Livro cadastrado com sucesso!");

        Pausar();
    }


    static void ListarLivros(List<Livro> livros)
    {
        Console.Clear();

        if (livros.Count == 0)
        {
            Console.WriteLine("Nenhum livro cadastrado.");
        }
        else
        {
            for (int i = 0; i < livros.Count; i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Livro " + (i + 1));
                Console.WriteLine("------------------------------------");

                livros[i].MostrarLivro();

                Console.WriteLine();
            }
        }

        Pausar();
    }


    static void PesquisarLivro(List<Livro> livros)
    {
        Console.Clear();

        Console.Write("Digite o título do livro: ");
        string titulo = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0; i < livros.Count; i++)
        {
            if (livros[i].titulo == titulo)
            {
                livros[i].MostrarLivro();
                encontrado = true;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine("Livro não encontrado.");
        }

        Pausar();
    }


    static void AlterarLivro(List<Livro> livros)
    {
        Console.Clear();

        Console.Write("Digite o título do livro: ");
        string titulo = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0; i < livros.Count; i++)
        {
            if (livros[i].titulo == titulo)
            {
                Console.Write("Novo título: ");
                livros[i].titulo = Console.ReadLine();

                Console.Write("Novo autor: ");
                livros[i].autor = Console.ReadLine();

                Console.Write("Novo ano: ");
                livros[i].ano =
                    int.Parse(Console.ReadLine());

                Console.Write("Nova categoria: ");
                livros[i].categoria = Console.ReadLine();

                Console.Write("Disponível (true/false): ");
                livros[i].disponivel =
                    bool.Parse(Console.ReadLine());

                encontrado = true;

                Console.WriteLine("Livro alterado!");
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine("Livro não encontrado.");
        }

        Pausar();
    }


    static void ExcluirLivro(List<Livro> livros)
    {
        Console.Clear();

        Console.Write("Digite o título do livro: ");
        string titulo = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0; i < livros.Count; i++)
        {
            if (livros[i].titulo == titulo)
            {
                livros.RemoveAt(i);

                encontrado = true;

                Console.WriteLine("Livro excluído!");

                break;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine("Livro não encontrado.");
        }

        Pausar();
    }


    static void RelatorioLivros(List<Livro> livros)
    {
        Console.Clear();

        int disponiveis = 0;
        int emprestados = 0;

        for (int i = 0; i < livros.Count; i++)
        {
            if (livros[i].disponivel == true)
            {
                disponiveis++;
            }
            else
            {
                emprestados++;
            }
        }

        Console.WriteLine("Total de livros: " + livros.Count);
        Console.WriteLine("Disponíveis: " + disponiveis);
        Console.WriteLine("Emprestados: " + emprestados);

        Pausar();
    }


    // =====================================================
    // FUNCIONÁRIOS
    // =====================================================

    static void MenuFuncionarios(List<Funcionario> funcionarios)
    {
        int opcao = 0;

        while (opcao != 7)
        {
            opcao = MostrarMenu("FUNCIONÁRIOS");

            if (opcao == 1)
                CadastrarFuncionario(funcionarios);

            else if (opcao == 2)
                ListarFuncionarios(funcionarios);

            else if (opcao == 3)
                PesquisarFuncionario(funcionarios);

            else if (opcao == 4)
                AlterarFuncionario(funcionarios);

            else if (opcao == 5)
                ExcluirFuncionario(funcionarios);

            else if (opcao == 6)
                RelatorioFuncionarios(funcionarios);

            else if (opcao != 7)
            {
                Console.WriteLine("Opção inválida!");
                Pausar();
            }
        }
    }


    static void CadastrarFuncionario(
        List<Funcionario> funcionarios)
    {
        Console.Clear();

        Funcionario funcionario =
            new Funcionario();

        Console.Write("Nome: ");
        funcionario.nome = Console.ReadLine();

        Console.Write("Idade: ");
        funcionario.idade =
            int.Parse(Console.ReadLine());

        Console.Write("Cargo: ");
        funcionario.cargo = Console.ReadLine();

        Console.Write("Salário: ");
        funcionario.salario =
            double.Parse(Console.ReadLine());

        Console.Write("Setor: ");
        funcionario.setor = Console.ReadLine();

        funcionarios.Add(funcionario);

        Console.WriteLine();
        Console.WriteLine(
            "Funcionário cadastrado com sucesso!"
        );

        Pausar();
    }


    static void ListarFuncionarios(
        List<Funcionario> funcionarios)
    {
        Console.Clear();

        if (funcionarios.Count == 0)
        {
            Console.WriteLine(
                "Nenhum funcionário cadastrado."
            );
        }
        else
        {
            for (int i = 0;
                 i < funcionarios.Count;
                 i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine(
                    "Funcionário " + (i + 1)
                );
                Console.WriteLine("------------------------------------");

                funcionarios[i].Apresentar();

                Console.WriteLine(
                    "Salário anual: R$ " +
                    funcionarios[i]
                    .CalcularSalarioAnual()
                    .ToString("F2")
                );

                Console.WriteLine();
            }
        }

        Pausar();
    }


    static void PesquisarFuncionario(
        List<Funcionario> funcionarios)
    {
        Console.Clear();

        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0;
             i < funcionarios.Count;
             i++)
        {
            if (funcionarios[i].nome == nome)
            {
                funcionarios[i].Apresentar();
                encontrado = true;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Funcionário não encontrado."
            );
        }

        Pausar();
    }


    static void AlterarFuncionario(
        List<Funcionario> funcionarios)
    {
        Console.Clear();

        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0;
             i < funcionarios.Count;
             i++)
        {
            if (funcionarios[i].nome == nome)
            {
                Console.Write("Novo nome: ");
                funcionarios[i].nome =
                    Console.ReadLine();

                Console.Write("Nova idade: ");
                funcionarios[i].idade =
                    int.Parse(Console.ReadLine());

                Console.Write("Novo cargo: ");
                funcionarios[i].cargo =
                    Console.ReadLine();

                Console.Write("Novo salário: ");
                funcionarios[i].salario =
                    double.Parse(Console.ReadLine());

                Console.Write("Novo setor: ");
                funcionarios[i].setor =
                    Console.ReadLine();

                encontrado = true;

                Console.WriteLine(
                    "Funcionário alterado!"
                );
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Funcionário não encontrado."
            );
        }

        Pausar();
    }


    static void ExcluirFuncionario(
        List<Funcionario> funcionarios)
    {
        Console.Clear();

        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0;
             i < funcionarios.Count;
             i++)
        {
            if (funcionarios[i].nome == nome)
            {
                funcionarios.RemoveAt(i);

                encontrado = true;

                Console.WriteLine(
                    "Funcionário excluído!"
                );

                break;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Funcionário não encontrado."
            );
        }

        Pausar();
    }


    static void RelatorioFuncionarios(
        List<Funcionario> funcionarios)
    {
        Console.Clear();

        double salarioMensal = 0;
        double salarioAnual = 0;

        for (int i = 0;
             i < funcionarios.Count;
             i++)
        {
            salarioMensal +=
                funcionarios[i].salario;

            salarioAnual +=
                funcionarios[i]
                .CalcularSalarioAnual();
        }

        Console.WriteLine(
            "Funcionários cadastrados: " +
            funcionarios.Count
        );

        Console.WriteLine(
            "Total de salários mensais: R$ " +
            salarioMensal.ToString("F2")
        );

        Console.WriteLine(
            "Total de salários anuais: R$ " +
            salarioAnual.ToString("F2")
        );

        Pausar();
    }


    // =====================================================
    // VEÍCULOS
    // =====================================================

    static void MenuVeiculos(List<Veiculo> veiculos)
    {
        int opcao = 0;

        while (opcao != 7)
        {
            opcao = MostrarMenu("VEÍCULOS");

            if (opcao == 1)
                CadastrarVeiculo(veiculos);

            else if (opcao == 2)
                ListarVeiculos(veiculos);

            else if (opcao == 3)
                PesquisarVeiculo(veiculos);

            else if (opcao == 4)
                AlterarVeiculo(veiculos);

            else if (opcao == 5)
                ExcluirVeiculo(veiculos);

            else if (opcao == 6)
                RelatorioVeiculos(veiculos);

            else if (opcao != 7)
            {
                Console.WriteLine("Opção inválida!");
                Pausar();
            }
        }
    }


    static void CadastrarVeiculo(List<Veiculo> veiculos)
    {
        Console.Clear();

        Veiculo veiculo = new Veiculo();

        Console.Write("Marca: ");
        veiculo.marca = Console.ReadLine();

        Console.Write("Modelo: ");
        veiculo.modelo = Console.ReadLine();

        Console.Write("Ano: ");
        veiculo.ano =
            int.Parse(Console.ReadLine());

        Console.Write("Cor: ");
        veiculo.cor = Console.ReadLine();

        Console.Write("Placa: ");
        veiculo.placa = Console.ReadLine();

        veiculos.Add(veiculo);

        Console.WriteLine();
        Console.WriteLine(
            "Veículo cadastrado com sucesso!"
        );

        Pausar();
    }


    static void ListarVeiculos(List<Veiculo> veiculos)
    {
        Console.Clear();

        if (veiculos.Count == 0)
        {
            Console.WriteLine(
                "Nenhum veículo cadastrado."
            );
        }
        else
        {
            for (int i = 0;
                 i < veiculos.Count;
                 i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine(
                    "Veículo " + (i + 1)
                );
                Console.WriteLine("------------------------------------");

                veiculos[i].MostrarVeiculo();

                Console.WriteLine();
            }
        }

        Pausar();
    }


    static void PesquisarVeiculo(
        List<Veiculo> veiculos)
    {
        Console.Clear();

        Console.Write(
            "Digite a marca ou modelo: "
        );

        string pesquisa = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0;
             i < veiculos.Count;
             i++)
        {
            if (veiculos[i].marca == pesquisa ||
                veiculos[i].modelo == pesquisa)
            {
                veiculos[i].MostrarVeiculo();

                Console.WriteLine();

                encontrado = true;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Veículo não encontrado."
            );
        }

        Pausar();
    }


    static void AlterarVeiculo(
        List<Veiculo> veiculos)
    {
        Console.Clear();

        Console.Write("Digite a placa: ");
        string placa = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0;
             i < veiculos.Count;
             i++)
        {
            if (veiculos[i].placa == placa)
            {
                Console.Write("Nova marca: ");
                veiculos[i].marca =
                    Console.ReadLine();

                Console.Write("Novo modelo: ");
                veiculos[i].modelo =
                    Console.ReadLine();

                Console.Write("Novo ano: ");
                veiculos[i].ano =
                    int.Parse(Console.ReadLine());

                Console.Write("Nova cor: ");
                veiculos[i].cor =
                    Console.ReadLine();

                Console.Write("Nova placa: ");
                veiculos[i].placa =
                    Console.ReadLine();

                encontrado = true;

                Console.WriteLine(
                    "Veículo alterado!"
                );
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Veículo não encontrado."
            );
        }

        Pausar();
    }


    static void ExcluirVeiculo(
        List<Veiculo> veiculos)
    {
        Console.Clear();

        Console.Write("Digite a placa: ");
        string placa = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0;
             i < veiculos.Count;
             i++)
        {
            if (veiculos[i].placa == placa)
            {
                veiculos.RemoveAt(i);

                encontrado = true;

                Console.WriteLine(
                    "Veículo excluído!"
                );

                break;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Veículo não encontrado."
            );
        }

        Pausar();
    }


    static void RelatorioVeiculos(
        List<Veiculo> veiculos)
    {
        Console.Clear();

        Console.WriteLine(
            "Total de veículos cadastrados: " +
            veiculos.Count
        );

        Pausar();
    }


    // =====================================================
    // FILMES
    // =====================================================

    static void MenuFilmes(List<Filme> filmes)
    {
        int opcao = 0;

        while (opcao != 7)
        {
            opcao = MostrarMenu("FILMES");

            if (opcao == 1)
                CadastrarFilme(filmes);

            else if (opcao == 2)
                ListarFilmes(filmes);

            else if (opcao == 3)
                PesquisarFilme(filmes);

            else if (opcao == 4)
                AlterarFilme(filmes);

            else if (opcao == 5)
                ExcluirFilme(filmes);

            else if (opcao == 6)
                RelatorioFilmes(filmes);

            else if (opcao != 7)
            {
                Console.WriteLine("Opção inválida!");
                Pausar();
            }
        }
    }


    static void CadastrarFilme(List<Filme> filmes)
    {
        Console.Clear();

        Filme filme = new Filme();

        Console.Write("Título: ");
        filme.titulo = Console.ReadLine();

        Console.Write("Gênero: ");
        filme.genero = Console.ReadLine();

        Console.Write("Ano: ");
        filme.ano =
            int.Parse(Console.ReadLine());

        Console.Write("Duração em minutos: ");
        filme.duracao =
            int.Parse(Console.ReadLine());

        Console.Write("Nota: ");
        filme.nota =
            double.Parse(Console.ReadLine());

        filmes.Add(filme);

        Console.WriteLine();
        Console.WriteLine(
            "Filme cadastrado com sucesso!"
        );

        Pausar();
    }


    static void ListarFilmes(List<Filme> filmes)
    {
        Console.Clear();

        if (filmes.Count == 0)
        {
            Console.WriteLine(
                "Nenhum filme cadastrado."
            );
        }
        else
        {
            for (int i = 0;
                 i < filmes.Count;
                 i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine(
                    "Filme " + (i + 1)
                );
                Console.WriteLine("------------------------------------");

                filmes[i].ExibirInformacoes();

                if (filmes[i].nota >= 8)
                {
                    Console.WriteLine(
                        "Filme com nota maior ou igual a 8!"
                    );
                }

                Console.WriteLine();
            }
        }

        Pausar();
    }


    static void PesquisarFilme(List<Filme> filmes)
    {
        Console.Clear();

        Console.Write("Digite o título: ");
        string titulo = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0;
             i < filmes.Count;
             i++)
        {
            if (filmes[i].titulo == titulo)
            {
                filmes[i].ExibirInformacoes();
                encontrado = true;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Filme não encontrado."
            );
        }

        Pausar();
    }


    static void AlterarFilme(List<Filme> filmes)
    {
        Console.Clear();

        Console.Write("Digite o título: ");
        string titulo = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0;
             i < filmes.Count;
             i++)
        {
            if (filmes[i].titulo == titulo)
            {
                Console.Write("Novo título: ");
                filmes[i].titulo =
                    Console.ReadLine();

                Console.Write("Novo gênero: ");
                filmes[i].genero =
                    Console.ReadLine();

                Console.Write("Novo ano: ");
                filmes[i].ano =
                    int.Parse(Console.ReadLine());

                Console.Write("Nova duração: ");
                filmes[i].duracao =
                    int.Parse(Console.ReadLine());

                Console.Write("Nova nota: ");
                filmes[i].nota =
                    double.Parse(Console.ReadLine());

                encontrado = true;

                Console.WriteLine(
                    "Filme alterado!"
                );
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Filme não encontrado."
            );
        }

        Pausar();
    }


    static void ExcluirFilme(List<Filme> filmes)
    {
        Console.Clear();

        Console.Write("Digite o título: ");
        string titulo = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0;
             i < filmes.Count;
             i++)
        {
            if (filmes[i].titulo == titulo)
            {
                filmes.RemoveAt(i);

                encontrado = true;

                Console.WriteLine(
                    "Filme excluído!"
                );

                break;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Filme não encontrado."
            );
        }

        Pausar();
    }


    static void RelatorioFilmes(List<Filme> filmes)
    {
        Console.Clear();

        int notaAlta = 0;

        for (int i = 0;
             i < filmes.Count;
             i++)
        {
            if (filmes[i].nota >= 8)
            {
                notaAlta++;
            }
        }

        Console.WriteLine(
            "Total de filmes: " +
            filmes.Count
        );

        Console.WriteLine(
            "Filmes com nota 8 ou maior: " +
            notaAlta
        );

        Pausar();
    }


    // =====================================================
    // CLIENTES
    // =====================================================

    static void MenuClientes(List<Cliente> clientes)
    {
        int opcao = 0;

        while (opcao != 7)
        {
            opcao = MostrarMenu("CLIENTES");

            if (opcao == 1)
                CadastrarCliente(clientes);

            else if (opcao == 2)
                ListarClientes(clientes);

            else if (opcao == 3)
                PesquisarCliente(clientes);

            else if (opcao == 4)
                AlterarCliente(clientes);

            else if (opcao == 5)
                ExcluirCliente(clientes);

            else if (opcao == 6)
                RelatorioClientes(clientes);

            else if (opcao != 7)
            {
                Console.WriteLine("Opção inválida!");
                Pausar();
            }
        }
    }


    static void CadastrarCliente(
        List<Cliente> clientes)
    {
        Console.Clear();

        Cliente cliente = new Cliente();

        Console.Write("Nome: ");
        cliente.nome = Console.ReadLine();

        Console.Write("Idade: ");
        cliente.idade =
            int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cliente.cidade = Console.ReadLine();

        Console.Write("Email: ");
        cliente.email = Console.ReadLine();

        Console.Write("Telefone: ");
        cliente.telefone = Console.ReadLine();

        clientes.Add(cliente);

        Console.WriteLine();
        Console.WriteLine(
            "Cliente cadastrado com sucesso!"
        );

        Pausar();
    }


    static void ListarClientes(
        List<Cliente> clientes)
    {
        Console.Clear();

        if (clientes.Count == 0)
        {
            Console.WriteLine(
                "Nenhum cliente cadastrado."
            );
        }
        else
        {
            for (int i = 0;
                 i < clientes.Count;
                 i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine(
                    "Cliente " + (i + 1)
                );
                Console.WriteLine("------------------------------------");

                clientes[i].ApresentarCliente();

                Console.WriteLine();
            }
        }

        Pausar();
    }


    static void PesquisarCliente(
        List<Cliente> clientes)
    {
        Console.Clear();

        Console.Write(
            "Digite o nome do cliente: "
        );

        string nome = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0;
             i < clientes.Count;
             i++)
        {
            if (clientes[i].nome == nome)
            {
                clientes[i].ApresentarCliente();
                encontrado = true;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Cliente não encontrado."
            );
        }

        Pausar();
    }


    static void AlterarCliente(
        List<Cliente> clientes)
    {
        Console.Clear();

        Console.Write(
            "Digite o nome do cliente: "
        );

        string nome = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0;
             i < clientes.Count;
             i++)
        {
            if (clientes[i].nome == nome)
            {
                Console.Write("Novo nome: ");
                clientes[i].nome =
                    Console.ReadLine();

                Console.Write("Nova idade: ");
                clientes[i].idade =
                    int.Parse(Console.ReadLine());

                Console.Write("Nova cidade: ");
                clientes[i].cidade =
                    Console.ReadLine();

                Console.Write("Novo email: ");
                clientes[i].email =
                    Console.ReadLine();

                Console.Write("Novo telefone: ");
                clientes[i].telefone =
                    Console.ReadLine();

                encontrado = true;

                Console.WriteLine(
                    "Cliente alterado!"
                );
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Cliente não encontrado."
            );
        }

        Pausar();
    }


    static void ExcluirCliente(
        List<Cliente> clientes)
    {
        Console.Clear();

        Console.Write(
            "Digite o nome do cliente: "
        );

        string nome = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0;
             i < clientes.Count;
             i++)
        {
            if (clientes[i].nome == nome)
            {
                clientes.RemoveAt(i);

                encontrado = true;

                Console.WriteLine(
                    "Cliente excluído!"
                );

                break;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Cliente não encontrado."
            );
        }

        Pausar();
    }


    static void RelatorioClientes(
        List<Cliente> clientes)
    {
        Console.Clear();

        Console.WriteLine(
            "Total de clientes cadastrados: " +
            clientes.Count
        );

        Pausar();
    }


    // =====================================================
    // CURSOS
    // =====================================================

    static void MenuCursos(List<Curso> cursos)
    {
        int opcao = 0;

        while (opcao != 7)
        {
            opcao = MostrarMenu("CURSOS");

            if (opcao == 1)
                CadastrarCurso(cursos);

            else if (opcao == 2)
                ListarCursos(cursos);

            else if (opcao == 3)
                PesquisarCurso(cursos);

            else if (opcao == 4)
                AlterarCurso(cursos);

            else if (opcao == 5)
                ExcluirCurso(cursos);

            else if (opcao == 6)
                RelatorioCursos(cursos);

            else if (opcao != 7)
            {
                Console.WriteLine("Opção inválida!");
                Pausar();
            }
        }
    }


    static void CadastrarCurso(List<Curso> cursos)
    {
        Console.Clear();

        Curso curso = new Curso();

        Console.Write("Nome: ");
        curso.nome = Console.ReadLine();

        Console.Write("Carga horária: ");
        curso.cargaHoraria =
            int.Parse(Console.ReadLine());

        Console.Write("Professor: ");
        curso.professor = Console.ReadLine();

        Console.Write("Modalidade: ");
        curso.modalidade = Console.ReadLine();

        Console.Write("Quantidade de vagas: ");
        curso.quantidadeVagas =
            int.Parse(Console.ReadLine());

        cursos.Add(curso);

        Console.WriteLine();
        Console.WriteLine(
            "Curso cadastrado com sucesso!"
        );

        Pausar();
    }


    static void ListarCursos(List<Curso> cursos)
    {
        Console.Clear();

        if (cursos.Count == 0)
        {
            Console.WriteLine(
                "Nenhum curso cadastrado."
            );
        }
        else
        {
            for (int i = 0;
                 i < cursos.Count;
                 i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine(
                    "Curso " + (i + 1)
                );
                Console.WriteLine("------------------------------------");

                cursos[i].MostrarCurso();

                Console.WriteLine();
            }
        }

        Pausar();
    }


    static void PesquisarCurso(
        List<Curso> cursos)
    {
        Console.Clear();

        Console.Write("Digite o nome do curso: ");
        string nome = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0;
             i < cursos.Count;
             i++)
        {
            if (cursos[i].nome == nome)
            {
                cursos[i].MostrarCurso();
                encontrado = true;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Curso não encontrado."
            );
        }

        Pausar();
    }


    static void AlterarCurso(List<Curso> cursos)
    {
        Console.Clear();

        Console.Write("Digite o nome do curso: ");
        string nome = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0;
             i < cursos.Count;
             i++)
        {
            if (cursos[i].nome == nome)
            {
                Console.Write("Novo nome: ");
                cursos[i].nome =
                    Console.ReadLine();

                Console.Write("Nova carga horária: ");
                cursos[i].cargaHoraria =
                    int.Parse(Console.ReadLine());

                Console.Write("Novo professor: ");
                cursos[i].professor =
                    Console.ReadLine();

                Console.Write("Nova modalidade: ");
                cursos[i].modalidade =
                    Console.ReadLine();

                Console.Write(
                    "Nova quantidade de vagas: "
                );

                cursos[i].quantidadeVagas =
                    int.Parse(Console.ReadLine());

                encontrado = true;

                Console.WriteLine(
                    "Curso alterado!"
                );
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Curso não encontrado."
            );
        }

        Pausar();
    }


    static void ExcluirCurso(List<Curso> cursos)
    {
        Console.Clear();

        Console.Write("Digite o nome do curso: ");
        string nome = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0;
             i < cursos.Count;
             i++)
        {
            if (cursos[i].nome == nome)
            {
                cursos.RemoveAt(i);

                encontrado = true;

                Console.WriteLine(
                    "Curso excluído!"
                );

                break;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Curso não encontrado."
            );
        }

        Pausar();
    }


    static void RelatorioCursos(List<Curso> cursos)
    {
        Console.Clear();

        Console.WriteLine(
            "Cursos com vagas disponíveis:"
        );

        Console.WriteLine();

        int disponiveis = 0;

        for (int i = 0;
             i < cursos.Count;
             i++)
        {
            if (cursos[i].quantidadeVagas > 0)
            {
                Console.WriteLine(
                    cursos[i].nome +
                    " - " +
                    cursos[i].quantidadeVagas +
                    " vagas"
                );

                disponiveis++;
            }
        }

        Console.WriteLine();

        Console.WriteLine(
            "Total de cursos: " +
            cursos.Count
        );

        Console.WriteLine(
            "Cursos disponíveis: " +
            disponiveis
        );

        Pausar();
    }


    // =====================================================
    // PEDIDOS
    // =====================================================

    static void MenuPedidos(List<Pedido> pedidos)
    {
        int opcao = 0;

        while (opcao != 7)
        {
            opcao = MostrarMenu("PEDIDOS");

            if (opcao == 1)
                CadastrarPedido(pedidos);

            else if (opcao == 2)
                ListarPedidos(pedidos);

            else if (opcao == 3)
                PesquisarPedido(pedidos);

            else if (opcao == 4)
                AlterarPedido(pedidos);

            else if (opcao == 5)
                ExcluirPedido(pedidos);

            else if (opcao == 6)
                RelatorioPedidos(pedidos);

            else if (opcao != 7)
            {
                Console.WriteLine("Opção inválida!");
                Pausar();
            }
        }
    }


    static void CadastrarPedido(
        List<Pedido> pedidos)
    {
        Console.Clear();

        Pedido pedido = new Pedido();

        Console.Write("Número do pedido: ");
        pedido.numero =
            int.Parse(Console.ReadLine());

        Console.Write("Cliente: ");
        pedido.cliente = Console.ReadLine();

        Console.Write("Produto: ");
        pedido.produto = Console.ReadLine();

        Console.Write("Quantidade: ");
        pedido.quantidade =
            int.Parse(Console.ReadLine());

        Console.Write("Valor unitário: ");
        pedido.valorUnitario =
            double.Parse(Console.ReadLine());

        pedidos.Add(pedido);

        Console.WriteLine();
        Console.WriteLine(
            "Pedido cadastrado com sucesso!"
        );

        Pausar();
    }


    static void ListarPedidos(
        List<Pedido> pedidos)
    {
        Console.Clear();

        if (pedidos.Count == 0)
        {
            Console.WriteLine(
                "Nenhum pedido cadastrado."
            );
        }
        else
        {
            for (int i = 0;
                 i < pedidos.Count;
                 i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine(
                    "Pedido " + (i + 1)
                );
                Console.WriteLine("------------------------------------");

                pedidos[i].MostrarPedido();

                Console.WriteLine(
                    "Total: R$ " +
                    pedidos[i]
                    .CalcularTotal()
                    .ToString("F2")
                );

                Console.WriteLine();
            }
        }

        Pausar();
    }


    static void PesquisarPedido(
        List<Pedido> pedidos)
    {
        Console.Clear();

        Console.Write("Digite o número do pedido: ");
        int numero =
            int.Parse(Console.ReadLine());

        bool encontrado = false;

        for (int i = 0;
             i < pedidos.Count;
             i++)
        {
            if (pedidos[i].numero == numero)
            {
                pedidos[i].MostrarPedido();

                Console.WriteLine(
                    "Total: R$ " +
                    pedidos[i]
                    .CalcularTotal()
                    .ToString("F2")
                );

                encontrado = true;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Pedido não encontrado."
            );
        }

        Pausar();
    }


    static void AlterarPedido(
        List<Pedido> pedidos)
    {
        Console.Clear();

        Console.Write("Digite o número do pedido: ");
        int numero =
            int.Parse(Console.ReadLine());

        bool encontrado = false;

        for (int i = 0;
             i < pedidos.Count;
             i++)
        {
            if (pedidos[i].numero == numero)
            {
                Console.Write("Novo número: ");
                pedidos[i].numero =
                    int.Parse(Console.ReadLine());

                Console.Write("Novo cliente: ");
                pedidos[i].cliente =
                    Console.ReadLine();

                Console.Write("Novo produto: ");
                pedidos[i].produto =
                    Console.ReadLine();

                Console.Write("Nova quantidade: ");
                pedidos[i].quantidade =
                    int.Parse(Console.ReadLine());

                Console.Write(
                    "Novo valor unitário: "
                );

                pedidos[i].valorUnitario =
                    double.Parse(Console.ReadLine());

                encontrado = true;

                Console.WriteLine(
                    "Pedido alterado!"
                );
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Pedido não encontrado."
            );
        }

        Pausar();
    }


    static void ExcluirPedido(
        List<Pedido> pedidos)
    {
        Console.Clear();

        Console.Write("Digite o número do pedido: ");
        int numero =
            int.Parse(Console.ReadLine());

        bool encontrado = false;

        for (int i = 0;
             i < pedidos.Count;
             i++)
        {
            if (pedidos[i].numero == numero)
            {
                pedidos.RemoveAt(i);

                encontrado = true;

                Console.WriteLine(
                    "Pedido excluído!"
                );

                break;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Pedido não encontrado."
            );
        }

        Pausar();
    }


    static void RelatorioPedidos(
        List<Pedido> pedidos)
    {
        Console.Clear();

        double valorTotal = 0;

        for (int i = 0;
             i < pedidos.Count;
             i++)
        {
            valorTotal +=
                pedidos[i].CalcularTotal();
        }

        Console.WriteLine(
            "Total de pedidos: " +
            pedidos.Count
        );

        Console.WriteLine(
            "Valor total: R$ " +
            valorTotal.ToString("F2")
        );

        Pausar();
    }


    // =====================================================
    // EQUIPAMENTOS
    // =====================================================

    static void MenuEquipamentos(
        List<Equipamento> equipamentos)
    {
        int opcao = 0;

        while (opcao != 7)
        {
            opcao =
                MostrarMenu("EQUIPAMENTOS");

            if (opcao == 1)
                CadastrarEquipamento(equipamentos);

            else if (opcao == 2)
                ListarEquipamentos(equipamentos);

            else if (opcao == 3)
                PesquisarEquipamento(equipamentos);

            else if (opcao == 4)
                AlterarEquipamento(equipamentos);

            else if (opcao == 5)
                ExcluirEquipamento(equipamentos);

            else if (opcao == 6)
                RelatorioEquipamentos(equipamentos);

            else if (opcao != 7)
            {
                Console.WriteLine(
                    "Opção inválida!"
                );

                Pausar();
            }
        }
    }


    static void CadastrarEquipamento(
        List<Equipamento> equipamentos)
    {
        Console.Clear();

        Equipamento equipamento =
            new Equipamento();

        Console.Write("Patrimônio: ");
        equipamento.patrimonio =
            Console.ReadLine();

        Console.Write("Tipo: ");
        equipamento.tipo =
            Console.ReadLine();

        Console.Write("Marca: ");
        equipamento.marca =
            Console.ReadLine();

        Console.Write("Modelo: ");
        equipamento.modelo =
            Console.ReadLine();

        Console.Write("Número de série: ");
        equipamento.numeroSerie =
            Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Status:");
        Console.WriteLine(
            "Disponível / Em uso / Manutenção"
        );

        Console.Write("Digite o status: ");
        equipamento.status =
            Console.ReadLine();

        equipamentos.Add(equipamento);

        Console.WriteLine();
        Console.WriteLine(
            "Equipamento cadastrado com sucesso!"
        );

        Pausar();
    }


    static void ListarEquipamentos(
        List<Equipamento> equipamentos)
    {
        Console.Clear();

        if (equipamentos.Count == 0)
        {
            Console.WriteLine(
                "Nenhum equipamento cadastrado."
            );
        }
        else
        {
            for (int i = 0;
                 i < equipamentos.Count;
                 i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine(
                    "Equipamento " + (i + 1)
                );
                Console.WriteLine("------------------------------------");

                equipamentos[i]
                    .MostrarEquipamento();

                Console.WriteLine();
            }
        }

        Pausar();
    }


    static void PesquisarEquipamento(
        List<Equipamento> equipamentos)
    {
        Console.Clear();

        Console.Write(
            "Digite o patrimônio: "
        );

        string patrimonio =
            Console.ReadLine();

        bool encontrado = false;

        for (int i = 0;
             i < equipamentos.Count;
             i++)
        {
            if (equipamentos[i].patrimonio ==
                patrimonio)
            {
                equipamentos[i]
                    .MostrarEquipamento();

                encontrado = true;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Equipamento não encontrado."
            );
        }

        Pausar();
    }


    static void AlterarEquipamento(
        List<Equipamento> equipamentos)
    {
        Console.Clear();

        Console.Write(
            "Digite o patrimônio: "
        );

        string patrimonio =
            Console.ReadLine();

        bool encontrado = false;

        for (int i = 0;
             i < equipamentos.Count;
             i++)
        {
            if (equipamentos[i].patrimonio ==
                patrimonio)
            {
                Console.Write(
                    "Novo patrimônio: "
                );

                equipamentos[i].patrimonio =
                    Console.ReadLine();

                Console.Write("Novo tipo: ");
                equipamentos[i].tipo =
                    Console.ReadLine();

                Console.Write("Nova marca: ");
                equipamentos[i].marca =
                    Console.ReadLine();

                Console.Write("Novo modelo: ");
                equipamentos[i].modelo =
                    Console.ReadLine();

                Console.Write(
                    "Novo número de série: "
                );

                equipamentos[i].numeroSerie =
                    Console.ReadLine();

                Console.Write("Novo status: ");
                equipamentos[i].status =
                    Console.ReadLine();

                encontrado = true;

                Console.WriteLine(
                    "Equipamento alterado!"
                );
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Equipamento não encontrado."
            );
        }

        Pausar();
    }


    static void ExcluirEquipamento(
        List<Equipamento> equipamentos)
    {
        Console.Clear();

        Console.Write(
            "Digite o patrimônio: "
        );

        string patrimonio =
            Console.ReadLine();

        bool encontrado = false;

        for (int i = 0;
             i < equipamentos.Count;
             i++)
        {
            if (equipamentos[i].patrimonio ==
                patrimonio)
            {
                equipamentos.RemoveAt(i);

                encontrado = true;

                Console.WriteLine(
                    "Equipamento excluído!"
                );

                break;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine(
                "Equipamento não encontrado."
            );
        }

        Pausar();
    }


    static void RelatorioEquipamentos(
        List<Equipamento> equipamentos)
    {
        Console.Clear();

        int manutencao = 0;

        Console.WriteLine(
            "Equipamentos em manutenção:"
        );

        Console.WriteLine();

        for (int i = 0;
             i < equipamentos.Count;
             i++)
        {
            if (equipamentos[i].status ==
                "Manutenção")
            {
                equipamentos[i]
                    .MostrarEquipamento();

                Console.WriteLine();

                manutencao++;
            }
        }

        Console.WriteLine(
            "Total de equipamentos: " +
            equipamentos.Count
        );

        Console.WriteLine(
            "Em manutenção: " +
            manutencao
        );

        Pausar();
    }

    // =====================================================
    // JOGOS - EXERCÍCIO 10
    // =====================================================

    static void MenuJogos(List<Jogo> jogos)
    {
        int opcao = 0;

        while (opcao != 7)
        {
            opcao = MostrarMenu("JOGOS");

            if (opcao == 1)
            {
                CadastrarJogo(jogos);
            }
            else if (opcao == 2)
            {
                ListarJogos(jogos);
            }
            else if (opcao == 3)
            {
                PesquisarJogo(jogos);
            }
            else if (opcao == 4)
            {
                AlterarJogo(jogos);
            }
            else if (opcao == 5)
            {
                ExcluirJogo(jogos);
            }
            else if (opcao == 6)
            {
                RelatorioJogos(jogos);
            }
            else if (opcao != 7)
            {
                Console.WriteLine("Opção inválida!");
                Pausar();
            }
        }
    }

    static void CadastrarJogo(List<Jogo> jogos)
    {
        Console.Clear();

        Console.WriteLine("====================================");
        Console.WriteLine("          Cadastro de Jogo");
        Console.WriteLine("====================================");
        Console.WriteLine();

        Jogo jogo = new Jogo();

        Console.Write("Nome: ");
        jogo.nome = Console.ReadLine();

        Console.Write("Gênero: ");
        jogo.genero = Console.ReadLine();

        Console.Write("Plataforma: ");
        jogo.plataforma = Console.ReadLine();

        Console.Write("Ano: ");
        jogo.ano = int.Parse(Console.ReadLine());

        Console.Write("Nota: ");
        jogo.nota = double.Parse(Console.ReadLine());

        jogos.Add(jogo);

        Console.WriteLine();
        Console.WriteLine("====================================");
        Console.WriteLine("     Jogo cadastrado com sucesso!");
        Console.WriteLine("====================================");

        Pausar();
    }

    static void ListarJogos(List<Jogo> jogos)
    {
        Console.Clear();

        Console.WriteLine("====================================");
        Console.WriteLine("           Lista de Jogos");
        Console.WriteLine("====================================");
        Console.WriteLine();

        if (jogos.Count == 0)
        {
            Console.WriteLine("Nenhum jogo cadastrado.");
        }
        else
        {
            for (int i = 0; i < jogos.Count; i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Jogo " + (i + 1));
                Console.WriteLine("------------------------------------");
                Console.WriteLine();

                jogos[i].MostrarJogo();

                Console.WriteLine();
            }
        }

        Pausar();
    }

    static void PesquisarJogo(List<Jogo> jogos)
    {
        Console.Clear();

        Console.WriteLine("====================================");
        Console.WriteLine("          Pesquisar Jogo");
        Console.WriteLine("====================================");
        Console.WriteLine();

        Console.Write("Digite o nome do jogo: ");
        string nome = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0; i < jogos.Count; i++)
        {
            if (jogos[i].nome == nome)
            {
                Console.WriteLine();
                jogos[i].MostrarJogo();

                encontrado = true;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine();
            Console.WriteLine("Jogo não encontrado.");
        }

        Pausar();
    }

    static void AlterarJogo(List<Jogo> jogos)
    {
        Console.Clear();

        Console.WriteLine("====================================");
        Console.WriteLine("           Alterar Jogo");
        Console.WriteLine("====================================");
        Console.WriteLine();

        Console.Write("Digite o nome do jogo: ");
        string nome = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0; i < jogos.Count; i++)
        {
            if (jogos[i].nome == nome)
            {
                Console.WriteLine();

                Console.Write("Novo nome: ");
                jogos[i].nome = Console.ReadLine();

                Console.Write("Novo gênero: ");
                jogos[i].genero = Console.ReadLine();

                Console.Write("Nova plataforma: ");
                jogos[i].plataforma = Console.ReadLine();

                Console.Write("Novo ano: ");
                jogos[i].ano = int.Parse(Console.ReadLine());

                Console.Write("Nova nota: ");
                jogos[i].nota = double.Parse(Console.ReadLine());

                encontrado = true;

                Console.WriteLine();
                Console.WriteLine("Jogo alterado com sucesso!");
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine();
            Console.WriteLine("Jogo não encontrado.");
        }

        Pausar();
    }

    static void ExcluirJogo(List<Jogo> jogos)
    {
        Console.Clear();

        Console.WriteLine("====================================");
        Console.WriteLine("           Excluir Jogo");
        Console.WriteLine("====================================");
        Console.WriteLine();

        Console.Write("Digite o nome do jogo: ");
        string nome = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0; i < jogos.Count; i++)
        {
            if (jogos[i].nome == nome)
            {
                jogos.RemoveAt(i);

                encontrado = true;

                Console.WriteLine();
                Console.WriteLine("Jogo excluído com sucesso!");

                break;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine();
            Console.WriteLine("Jogo não encontrado.");
        }

        Pausar();
    }

    static void RelatorioJogos(List<Jogo> jogos)
    {
        Console.Clear();

        Console.WriteLine("====================================");
        Console.WriteLine("          Relatório de Jogos");
        Console.WriteLine("====================================");
        Console.WriteLine();

        if (jogos.Count == 0)
        {
            Console.WriteLine("Nenhum jogo cadastrado.");
        }
        else
        {
            double somaNotas = 0;
            int jogosNotaAlta = 0;

            for (int i = 0; i < jogos.Count; i++)
            {
                somaNotas = somaNotas + jogos[i].nota;

                if (jogos[i].nota >= 8)
                {
                    jogosNotaAlta++;
                }
            }

            double media = somaNotas / jogos.Count;

            Console.WriteLine("Total de jogos: " + jogos.Count);
            Console.WriteLine("Média das notas: " + media.ToString("F1"));
            Console.WriteLine("Jogos com nota 8 ou maior: " + jogosNotaAlta);
        }

        Pausar();
    }
}