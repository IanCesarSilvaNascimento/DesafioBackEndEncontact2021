# DesafioBackEndEncontact2021 


## Descrição do desafio

O projeto consiste em uma API simples para cadastro e consulta de contatos em uma agenda.

Neste teste você poderá mostrar suas habilidades em c# e dotnet, Orientação a objetos, lógica de programação, SQL, refatoração e também suas habilidades de debug para encontrar os problemas.

O foco deste teste é a garantia dos requisitos abaixo estejam funcionais na API:

- [x] Criar, editar, excluir e listar agendas.
- [x] Criar, editar, excluir e listar empresas.
- [x] Importar contatos a partir de um arquivo .csv
  - Fique a vontade para definir o leiaute do arquivo .csv
  - Caso dê erro na importação de um registro, não deve impactar a importação dos demais.
  - É obrigatório ter uma agenda vinculada ao contato.
  - No arquivo, se for informada uma empresa ao contato, ela deve existir previamente no sistema. Caso não seja informado, o contato é registrado sem vinculo com a empresa.
- [x] Pesquisar contatos
  - Deve pesquisar em qualquer campo do contato (incluído o nome da empresa).
  - A pesquisa deve ser paginada (Fique a vontade para utilizar qualquer estratégia).
- [x] Pesquisa de contatos da empresa
  - Poder consultar os contatos de uma agenda e que estejam em uma determinada empresa.



## Solução proposta 

estruturar e organizar uma solução de API;

implementação CQRS;

implementação Design By Contracts;

Modelagem em contextos e domínios ricos;

Implementação Domain Notifications;

Implementação Repository Pattern;

Aplicação Fail-Fast Validations;

Aplicação testes de unidade para Handlers, Entities, Commands, fakes repositories;

Implementação de migrações em SQLite;
