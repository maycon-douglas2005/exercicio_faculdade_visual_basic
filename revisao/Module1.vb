Module Module1
    Dim nome As String
    Dim idade As String 'Como não vou realizar cálculos com essa váriavel, então vou deixa-la como String
    Dim saldo As Double

    Sub Main()
        Dim informacoesCompletas As Boolean
        Dim respostaInformacoes As String
        Dim acao As String
        informacoesCompletas = False
        saldo = 0.0


        While informacoesCompletas = False
            Console.WriteLine("Seja bem vindo! Por favor, insira seu nome: ")
            nome = Console.ReadLine()

            Console.WriteLine("Ótimo! {0}, digite sua idade: ", nome)
            idade = Console.ReadLine()

            Console.WriteLine("Perfeito! Agora só falta digitar seu salário: ")
            saldo = CDbl(Console.ReadLine())

            Console.WriteLine("Apenas para revisar, confirme com s para sim ou n para nao se os seus dados estão corretos:
            Nome: {0}, Idade: {1}, Salário: {2}", nome, idade, saldo)
            respostaInformacoes = Console.ReadLine()

            If respostaInformacoes = "s" Then
                Console.WriteLine("Cadastro concluído com sucesso! Aguarde em quanto iniciamos o sistema bancário...")
                'Colocar chamado de método para iniciar sistema bancário aq.
                informacoesCompletas = True
            End If
        End While

        While True
            Console.WriteLine("Então, {0}, o que deseja fazer agora? Você pode digitar 'depositar', 'sacar', 'verificar_saldo' e 'sair' ou 'deslogar': ", nome)
            acao = Console.ReadLine()

            If acao = "depositar" Then
                depositar()

            ElseIf acao = "sacar" Then
                sacar()
            ElseIf acao = "verificar_saldo" Then
                Dim verificacaoDeSaldo = verificarSaldo()
                Console.WriteLine("Seu saldo é {0}", verificacaoDeSaldo)
                Console.WriteLine("Verificação de saldo concluida!")

            ElseIf acao = "sair" Then
                Console.WriteLine("Finalizando programa...")
                Environment.Exit(0)

            Else
                Console.WriteLine("Ação inválida! Por favor, digite alguma das opções fornecidas!")
            End If
        End While
        

    End Sub

    Sub depositar()
        Dim valorDeposito As Double
        Console.WriteLine("{0}, digite o valor que deseja depositar: ", nome)
        valorDeposito = CDbl(Console.ReadLine())

        saldo += valorDeposito
        Console.WriteLine("Depósito realizado com sucesso!")
    End Sub

    Function verificarSaldo() As Double
        Return saldo
    End Function

    Sub sacar()
        Dim valorSaque As Double
        Console.WriteLine("{0}, digite o valor que deseja sacar: ", nome)
        valorSaque = CDbl(Console.ReadLine())

        saldo -= valorSaque
        Console.WriteLine("O saque de {0} foi realizado com sucesso!", valorSaque)

    End Sub
End Module
