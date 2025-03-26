# 📚 Fundamentos C# - Aplicação de Cadastro de Clientes

Este projeto foi desenvolvido como parte do curso **Desenvolvedor IO - Fundamentos do C#**. Ele explora conceitos fundamentais da linguagem C# e culmina na criação de uma aplicação prática para **cadastro de clientes**. 🚀

---

## 🛠️ Funcionalidades

A aplicação oferece as seguintes funcionalidades:

1. **Cadastrar Cliente**: Permite adicionar novos clientes ao sistema, solicitando informações como nome, e-mail, telefone, data de nascimento e desconto.
2. **Listar Clientes**: Exibe todos os clientes cadastrados com seus respectivos detalhes.
3. **Atualizar Cliente**: Permite editar as informações de um cliente existente.
4. **Excluir Cliente**: Remove um cliente do sistema.
5. **Persistência de Dados**: Os dados dos clientes são armazenados em um arquivo `clientes.txt` para garantir que as informações sejam mantidas mesmo após o encerramento da aplicação.

---

## 🏗️ Estrutura do Projeto

O projeto está organizado da seguinte forma:

- **`Cliente.cs`**: Define a classe `Cliente`, que representa os dados de um cliente, como ID, nome, e-mail, telefone, data de cadastro, data de nascimento e desconto.
- **`ClienteRepositorio.cs`**: Contém a lógica para manipular os dados dos clientes, incluindo métodos para adicionar, listar, atualizar, excluir e persistir os dados no arquivo `clientes.txt`.
- **`Program.cs`**: O ponto de entrada da aplicação, responsável por exibir o menu principal e gerenciar a interação com o usuário.
- **`clientes.txt`**: Arquivo utilizado para armazenar os dados dos clientes em formato JSON.
- **`AppClientes.csproj`**: Arquivo de configuração do projeto, especificando o framework alvo (.NET 9.0) e outras propriedades.

---

## 🖥️ Como Executar

1. Certifique-se de ter o **.NET SDK 9.0** instalado em sua máquina.
2. Clone este repositório:
   ```bash
   git clone https://github.com/joaooliveira10/FundamentosCSharp.git
    ```

3. Navegue até a pasta do projeto:
   ```bash
    cd AppClientes
    ```

4. Compile e execute o projeto:
   ```bash
    dotnet run
    ```


## 📂 Fluxo da Aplicação

1. Menu Principal: O usuário é apresentado a um menu com as opções de cadastro, listagem, atualização, exclusão e saída.

2. Interação com o Usuário: A aplicação utiliza o console para coletar e exibir informações.
3. Persistência de Dados: Os dados são salvos automaticamente no arquivo clientes.txt ao sair da aplicação.


## 🧠 Conceitos Aplicados

- **Classes e Objetos**: Uso da classe `Cliente` para modelar os dados.
- **Coleções**: Manipulação de uma lista de clientes (``List<Cliente>``).
- **Serialização e Desserialização**: Uso do ``System.Text.Json`` para salvar e carregar os dados no formato JSON.
- **Tratamento de Arquivos**: Leitura e escrita de arquivos com a classe ``File``.
- **Estruturas de Controle**: Uso de ``switch``, ``if`` e laços para controlar o fluxo da aplicação.
- **Cultura e Localização**: Configuração da cultura para ``pt-BR`` para formatação de datas e números.

## 📝 Exemplo de Uso

**Cadastro de Cliente**

O sistema solicita as seguintes informações:

- Nome
- E-mail
- Telefone
- Data de Nascimento
- Desconto

 Após o cadastro, o cliente é exibido no console com todos os seus detalhes.

**Listagem de Clientes**

Todos os clientes cadastrados são exibidos com suas informações formatadas.

**Atualização de Cliente**

O sistema permite alterar os dados de um cliente existente, identificando-o pelo ID.

**Exclusão de Cliente**

O cliente é removido da lista e não será mais exibido nas listagens.

## 📦 Tecnologias Utilizadas

- **C#**: Linguagem de programação principal.
- **.NET 9.0**: Framework utilizado para desenvolvimento.
- **System.Text.Json**: Biblioteca para manipulação de JSON.

## 🚀 Melhorias Futuras

- Implementar validações mais robustas para os dados de entrada.
- Adicionar suporte a múltiplos arquivos de dados.
- Criar uma interface gráfica para melhorar a experiência do usuário.
- Implementar testes unitários para garantir a qualidade do código.

## 🎉 Conclusão
Este projeto é uma excelente introdução ao desenvolvimento em C# e ao uso de conceitos fundamentais da linguagem. Ele demonstra como criar uma aplicação funcional e prática, com persistência de dados e interação com o usuário.

## 💡 Divirta-se explorando e aprimorando este projeto!