Module Module1
    Dim nome As String
    Dim idade As String
    Dim saldo As Double

    Sub Main()
        Dim informacoesCompletas As Boolean = False
        Dim sucessoConversaoSaldo = False
        Dim respostaInformacoes As String
        Dim acao As String

        saldo = 0.0


        While informacoesCompletas = False
            Console.WriteLine("Seja bem vindo! Por favor, insira seu nome: ")
            nome = Console.ReadLine()

            Console.WriteLine("Ótimo! {0}, digite sua idade: ", nome)
            idade = Console.ReadLine()


            Do Until sucessoConversaoSaldo
                Console.WriteLine("Perfeito! Agora só falta digitar seu salário: ")
                If (Double.TryParse(Console.ReadLine(), saldo)) Then
                    Console.WriteLine("Salário armazenado com sucesso!")
                    sucessoConversaoSaldo = True
                Else
                    Console.WriteLine("Ops, parece que você digitou um valor inválido, por favor digite seu salário no padrao xxxx.xx")
                End If

            Loop


            Console.WriteLine("Apenas para revisar, confirme com s para sim ou n para nao se os seus dados estão corretos:
            Nome: {0}, Idade: {1}, Salário: {2}", nome, idade, saldo)
            respostaInformacoes = Console.ReadLine()

            If respostaInformacoes = "s" Then
                Console.WriteLine("Cadastro concluído com sucesso! Aguarde em quanto iniciamos o sistema bancário...")
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

            ElseIf acao = "sair" OrElse "deslogar" Then
                Console.WriteLine("Finalizando programa...")
                Environment.Exit(0)

            Else
                Console.WriteLine("Ação inválida! Por favor, digite alguma das opções fornecidas!")
            End If
        End While
        

    End Sub

    Sub depositar()
        Dim depositoConvertido As Boolean = False
        Dim valorDeposito As Double

        Do Until depositoConvertido
            Console.WriteLine("{0}, digite o valor que deseja depositar: ", nome)
            If Double.TryParse(Console.ReadLine(), valorDeposito) Then
                Console.WriteLine("Depósito recebido com sucesso!")
                saldo += valorDeposito
                depositoConvertido = True
            Else
                Console.WriteLine("Ops, parece que você digitou um valor errado! Por favor, digite um valor valido no padrão xxxx.xx")
            End If
        Loop





    End Sub

    Function verificarSaldo() As Double
        Return saldo
    End Function

    Sub sacar()
        Dim conversaoSaque As Boolean = False
        Dim valorSaque As Double

        Do Until conversaoSaque
            Console.WriteLine("Digite o valor que deseja sacar: ")
            If Double.TryParse(Console.ReadLine(), valorSaque) Then
                If saldo > valorSaque Then
                    saldo -= valorSaque
                    Console.WriteLine("Saque realizado com sucesso!")
                    conversaoSaque = True
                Else
                    Console.WriteLine("Saldo insuficiente! O valor que deseja sacar é maior do que você tem de saldo.")
                End If

            Else
                Console.WriteLine("Ops, parece que você digitou um valor inválido! Por favor, digite um valor no padrão xxxx.xx")
            End If
        Loop
    End Sub


End Module
