# 📚 Sistema de Empréstimo de Livros

Aplicação **ASP.NET Core MVC** desenvolvida com **Razor Pages**, **Entity Framework Core**, **Bootstrap** e **jQuery**, voltada para o gerenciamento de empréstimos de livros.  
Permite cadastrar, editar e excluir registros de empréstimos, além de visualizar o histórico completo de movimentações.

---

## 🗂️ Índice
- [Visão Geral](#visão-geral)
- [Tecnologias](#tecnologias)
- [Funcionalidades](#funcionalidades)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Como Executar](#como-executar)
- [Capturas de Tela](#capturas-de-tela)
- [Autor](#autor)

---

## 💡 Visão Geral

O **Sistema de Empréstimo de Livros** tem como objetivo auxiliar no controle de empréstimos de livros, tanto em pequenas bibliotecas quanto em acervos pessoais.  
O sistema foi desenvolvido com uma arquitetura **MVC (Model-View-Controller)**, utilizando **Razor** para renderização das views e o **Entity Framework Core** para o mapeamento e persistência de dados em **SQLite** ou **SQL Server**.

---

## 🛠️ Tecnologias

- **ASP.NET Core 8.0**
- **Razor Pages**
- **Entity Framework Core**
- **SQLite** e **SQL Server**
- **Bootstrap 5**
- **jQuery**
- **HTML5 / CSS3 / JavaScript**

---

## ⚙️ Funcionalidades

- Cadastro de empréstimos  
- Edição e exclusão de registros  
- Validação de dados com jQuery
- Interface responsiva com Bootstrap  
- Suporte a SQLite e SQL Server  
- Estrutura simples e extensível  

---

## 🧱 Estrutura do Projeto

```
EmprestimoLivros/
├── Controllers/
│   ├── EmprestimoController.cs
│   ├── HomeController.cs
│
├── Models/
│   ├── EmprestimoModel.cs
│   ├── ErrorViewModel.cs
│
├── Data/
│   ├── ApplicationDbContext.cs
│
├── Views/
│   ├── Emprestimo/
│   │   ├── Cadastrar.cshtml
│   │   ├── Editar.cshtml
│   │   ├── Excluir.cshtml
│   │   ├── Index.cshtml
│   ├── Home/
│   │   ├── Index.cshtml
│   │   ├── Privacy.cshtml
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   ├── _ValidationScriptsPartial.cshtml
│   │   ├── Error.cshtml
│   ├── _ViewImports.cshtml
│   ├── _ViewStart.cshtml
│
├── wwwroot/
│   ├── css/
│   │   ├── bootstrap_brite.css
│   │   ├── site.css
│   ├── js/
│   │   ├── site.js
│   ├── img/
│   │   ├── home.png
│   ├── lib/
│       ├── bootstrap/
│       ├── jquery/
│       ├── jquery-validation/
│       ├── jquery-validation-unobtrusive/
│
├── appsettings.json
├── emprestimos.db
├── Program.cs
├── EmprestimoLivros.csproj
```

---

## 🚀 Como Executar

### Pré-requisitos
- [.NET SDK 8.0+](https://dotnet.microsoft.com/download)
- SQLite (ou SQL Server, conforme configuração em `appsettings.json`)

### Passos

1. Clone o repositório:
   ```bash
   git clone https://github.com/seuusuario/EmprestimoLivros.git
   ```

2. Acesse o diretório do projeto:
   ```bash
   cd EmprestimoLivros/EmprestimoLivros
   ```

3. Restaure os pacotes NuGet:
   ```bash
   dotnet restore
   ```

4. (Caso configure para SqlServer) Crie o banco de dados:
   ```bash
   dotnet ef database update
   ```

5. Execute a aplicação:
   ```bash
   dotnet run
   ```

6. Acesse no navegador:
   ```
   http://localhost:7208
   ```
   ou  
   ```
   https://localhost:5110
   ```

---

## 🖼️ Capturas de Tela

[Tela inicial](docs/home.png)

[Tela Empréstimos](docs/emprestimos.png)

[Cadastro de empréstimo](docs/cadastro_emprestimos.png)

---

## 👨‍💻 Autor

Desenvolvido por **[Víctor Corrêa](https://github.com/victorcorreadasilva)**  
💼 Engenheiro de Software | C# | ASP.NET Core | SQL 

---

## 📝 Licença

Este projeto está sob a licença MIT. Consulte o arquivo [LICENSE](LICENSE) para mais detalhes.
