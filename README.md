# Projeto CRUD de Produtos com MVC

Este projeto é um exemplo de aplicação CRUD (Create, Read, Update, Delete) usando o padrão **MVC (Model-View-Controller)** com ASP.NET Core.

## Estrutura do Projeto

O projeto é dividido em três camadas principais:

- **Model (Modelo):** Define a classe `Produto` e representa a lógica de negócios.
- **View (Visão):** Contém as páginas que o usuário verá para realizar as operações CRUD.
- **Controller (Controlador):** Gerencia as requisições do usuário e a interação entre as camadas de Model e View.

### Classe `Produto`

A classe `Produto` contém os seguintes atributos:

- `Id`: Identificador único do produto.
- `Nome`: Nome do produto.
- `Preco`: Preço do produto.
- `Categoria`: Categoria à qual o produto pertence.
- `Estoque`: Quantidade em estoque do produto.

### Operações CRUD

1. **Create (Criar):** Permite adicionar novos produtos ao sistema.
2. **Read (Ler):** Lista os produtos e exibe detalhes de um produto específico.
3. **Update (Atualizar):** Permite editar as informações de um produto existente.
4. **Delete (Excluir):** Remove um produto do sistema.
### Tecnologias Usadas

- **ASP.NET Core**
- **MVC (Model-View-Controller)**
- **Razor Pages**

## Como Executar

1. Clone este repositório: `git clone https://github.com/seu-usuario/projeto-mvc-produtos.git`
2. Navegue até o diretório do projeto.
3. Execute o comando `dotnet restore` para instalar as dependências.
4. Execute o comando `dotnet run` para iniciar a aplicação.
5. Acesse a aplicação no navegador em `https://localhost:5001`.

## Autor

Desenvolvido por [Seu Nome].
