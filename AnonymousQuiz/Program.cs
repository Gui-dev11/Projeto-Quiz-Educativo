namespace AnonymousQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ========================================================================
            // ======================   DIVISÃO DO PROJETO POR INTEGRANTE   ======================
            // ========================================================================
            // Cada integrante possui abaixo a explicação detalhada DAS SUAS CLASSES

            // ========================================================================
            // ========================== 1. LUÍS GUSTAVO ==============================
            // ========================================================================

            /*
            ------------------------------------------------------------------------
            Pasta - Model

            Cliente

            idCliente (int): Identificador único do cliente.
            Nome (string): Nome do cliente.
            Email (string): Email utilizado para acesso.
            Senha (string): Senha do cliente.
            DiasAtivo (int): Quantidade de dias consecutivos em que o cliente acessou o sistema.

            Construtores:
            Construtor vazio: Inicializa o objeto sem valores.
            Construtor cheio: Recebe idCliente, nome, email, senha, diasAtivo.

            Métodos Lógicos:
            FazerLogin(email, senha): Valida login.
            FazerCadastro(nome, email, senha): Registra um novo cliente.
            RecuperarSenha(novaSenha): Altera a senha.
            ConfigurarQuiz(quiz, titulo): Ajusta o título de um quiz.
            ResponderQuiz(quiz): Representa ação de resposta.
            VisualizarRanking(ranking): Exibe ranking.
            GerenciarAcessibilidade(opcao): Altera acessibilidade.
            ManterSequenciaDeDiasAtivo(): Incrementa dias ativos.
            ToString(): Dados formatados.
            ------------------------------------------------------------------------

            Feedback

            IdFeedback (int): Código único.
            Resultado (float): Pontuação obtida.
            Mensagem (string): Texto enviado ao usuário.

            Métodos:
            ExibirFeedback(): Mostra conteúdo.
            VoltarAoInicio(): Retorna ao início.
            ToString(): Formatação do feedback.
            ------------------------------------------------------------------------

            Questao

            IdQuestao (int): Identificador da questão.
            Enunciado (string): Pergunta.
            Alternativas (List): Lista de opções.
            RespostaCorreta (int): Id da alternativa correta.

            Construtores:
            Vazio e cheio.

            Métodos:
            AtualizarQuestoesDiariamente(): Lógica interna.
            VerificarResposta(idAlternativa): Retorna acerto/erro.
            ToString(): Formatação textual.
            ------------------------------------------------------------------------

            Pasta - Services

            CsvServiceCliente
            CsvServiceFeedback
            CsvServiceQuestao

            Responsabilidade:
            – Gravar e ler dados do CSV referente às classes acima
            – Validar arquivos
            – Criar estrutura de armazenamento
            – Atualizar registros
            – Buscar registros

            ------------------------------------------------------------------------
            */


            // ========================================================================
            // ============================== 2. HEITOR ===============================
            // ========================================================================

            /*
            ------------------------------------------------------------------------
            Pasta - Model

            Alternativa

            IdAlternativa (int): Identificador da alternativa.
            Descricao (string): Texto da alternativa.
            Correta (bool): Verdadeira ou falsa.

            Construtores:
            - Vazio: Inicializa padrão.
            - Cheio: Inicializa com valores.

            Métodos Lógicos:
            Marcar(): Indica seleção do usuário.
            ToString(): Dados formatados.
            ------------------------------------------------------------------------

            Pasta - Service

            CsvServiceQuiz

            Funções:
            SalvarQuiz(quiz): Salva quiz no CSV.
            LerQuiz(): Retorna quizzes do arquivo.
            AtualizarQuiz(quiz): Edita registro.
            ExcluirQuiz(id): Remove quiz do arquivo.
            ------------------------------------------------------------------------
            */


            // ========================================================================
            // ============================= 3. ABRAÃO ================================
            // ========================================================================

            /*
            ------------------------------------------------------------------------
            Pasta - View

            GenericView

            Responsável por:
            – Exibir menus
            – Mostrar mensagens ao usuário
            – Exibir listas de objetos
            – Renderizar tabelas

            Métodos Principais:
            MostrarMensagem(texto)
            MostrarErro(texto)
            Listar(objetos)

            ------------------------------------------------------------------------

            MenuView

            Responsável por:
            – Montar telas de menu
            – Definir navegação
            – Exibir opções numéricas
            – Chamar controladores conforme escolha

            Métodos:
            MostrarMenuPrincipal()
            MostrarMenuCliente()
            MostrarMenuQuiz()
            ------------------------------------------------------------------------
            */


            // ========================================================================
            // ============================= 4. GUILHERME =============================
            // ========================================================================

            /*
            ------------------------------------------------------------------------
            Pasta - Controller

            ClienteController

            Responsável por:
            – Controlar fluxo de operações relacionadas ao cliente.
            – Integrar View → Service → Model.

            Métodos Lógicos:
            CadastrarCliente()
            LoginCliente()
            AtualizarDadosCliente()
            ExcluirCliente()
            ListarClientes()
            ------------------------------------------------------------------------

            CsvServiceBase

            Responsabilidade:
            – Classe base para todos serviços CSV.
            – Possui métodos utilitários comuns.

            Métodos Importantes:
            LerArquivo(caminho)
            EscreverArquivo(caminho, dados)
            CriarArquivoSeNaoExistir()
            ------------------------------------------------------------------------
            */


            // ========================================================================
            // ========================== 5. SAMUEL BUTZKE ============================
            // ========================================================================

            /*
            ------------------------------------------------------------------------
            Pasta - Model

            Quiz

            IdQuiz (int): Identificador.
            Titulo (string): Título do quiz.
            Questoes (List): Lista de questões.

            Construtores:
            – Vazio
            – Cheio

            Métodos Lógicos:
            AdicionarQuestao(questao)
            RemoverQuestao(idQuestao)
            CalcularPontuacao(respostas)
            ToString()
            ------------------------------------------------------------------------

            Pasta - Services

            CsvServiceAcessibilidade

            Responsabilidade:
            – Gerenciar configurações de acessibilidade salvas em CSV.
            – Tema escuro, fonte, contraste etc.

            Métodos:
            SalvarAcessibilidade(config)
            CarregarAcessibilidade()
            AtualizarAcessibilidade()
            ------------------------------------------------------------------------
            */


            // ========================================================================
            // =========================== 6. IGOR GABRIEL ============================
            // ========================================================================

            /*
            ------------------------------------------------------------------------
            Pasta - Model

            Ranking

            IdRanking (int): Identificador.
            ListaPontuacoes (List): Pontuações de usuários.

            Métodos Lógicos:
            AdicionarPontuacao(pontos)
            OrdenarRanking()
            ExibirRanking()
            ToString()

            ------------------------------------------------------------------------

            Pasta - Services

            CsvServiceRanking

            Responsabilidade:
            – Ler e salvar ranking no CSV.
            – Atualizar pontos.
            – Retornar top jogadores.

            Métodos:
            SalvarRanking()
            CarregarRanking()
            AtualizarRanking()
            ------------------------------------------------------------------------
            */


            // ========================================================================
            // =========================== 7. GUSTAVO ASSIS ===========================
            // ========================================================================

            /*
            ------------------------------------------------------------------------
            Pasta - Controller

            QuizController

            Responsabilidade:
            – Controlar fluxo de funcionamento do quiz.
            – Iniciar, processar e finalizar o quiz.

            Métodos:
            IniciarQuiz()
            MostrarQuestaoAtual()
            RegistrarResposta()
            FinalizarQuiz()
            ------------------------------------------------------------------------

            Pasta - Repository

            GenericRepository

            Responsável por:
            – Padrão repository.
            – Operações genéricas de dados.

            Métodos:
            Adicionar(item)
            Atualizar(item)
            Excluir(id)
            Buscar(id)
            ListarTodos()
            ------------------------------------------------------------------------
            */


            // ========================================================================
            // =========================== 8. EMANUEL RUFINO ==========================
            // ========================================================================

            /*
            ------------------------------------------------------------------------
            Pasta - Model

            Acessibilidade

            TemaEscuro (bool): Ativa tema escuro.
            TamanhoFonte (int): Tamanho da fonte.
            Contraste (bool): Contraste elevado.

            Métodos:
            AplicarConfiguracoes()
            AlterarFonte()
            AtivarTemaEscuro()
            ToString()
            ------------------------------------------------------------------------

            Arquivo Main - Program.cs

            Program

            Responsável por:
            – Ponto de entrada do sistema.
            – Inicializa menus, configurações e controladores.
            – Chama MenuView para iniciar a navegação.

            Método:
            Main(string[] args)
            ------------------------------------------------------------------------
            */

            // ========================================================================
            // ============================== FIM ======================================
            // ========================================================================

        }
    }
}
