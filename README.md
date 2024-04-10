# Aplicação C\# de Arquitetura em 3 Camadas

## Descrição
<p> Esta é uma aplicação em C# que segue a arquitetura em três camadas, incluindo a     camada de apresentação (UI) usando Windows Forms, a camada de lógica de negócios (Services) e a camada de acesso a dados (Data), com MySQL como base de dados local.</p>

## Projeto: Cadastro de Produtos e Fornecedores

O projeto visa desenvolver um sistema de cadastro de produtos e fornecedores, permitindo sua associação para uma gestão eficiente. As funcionalidades principais abrangem:

### Cadastro de Produtos: 
Esta funcionalidade permite a adição, visualização, atualização e exclusão de informações sobre produtos. Os dados manipulados incluem nome, descrição, preço e outras características essenciais. Através dessa interface, os usuários podem manter um catálogo atualizado dos produtos oferecidos.

### Cadastro de Fornecedores: 
Nesta seção, os usuários podem adicionar, visualizar, atualizar e excluir informações sobre fornecedores. Os dados incluem nome, contato e CNPJ. Isso proporciona um registro organizado dos parceiros comerciais.

### Associação entre Produtos e Fornecedores: 
Um recurso crucial é a associação entre produtos e seus respectivos fornecedores. Isso simplifica a gestão, fornecendo uma filtragem mais direta e eficiente. No entanto, é importante ressaltar que não é possível excluir um fornecedor caso esteja associado a um produto. Essa restrição garante a integridade dos dados e evita inconsistências no sistema.

O projeto, ao aplicar os princípios da arquitetura em três camadas, busca oferecer um sistema robusto, modular e de fácil manutenção, atendendo às necessidades de gestão de produtos e fornecedores de forma eficaz e confiável.

## Importância da Arquitetura em 3 Camadas

A arquitetura em três camadas é um padrão amplamente adotado para o desenvolvimento de software devido aos seguintes benefícios:

- Separação de Responsabilidades: A divisão da aplicação em camadas distintas permite separar as responsabilidades de apresentação, lógica de negócios e acesso a dados, facilitando a manutenção e evolução do código.
  
- Facilidade de Manutenção: Com a separação clara das camadas, as alterações em uma camada podem ser feitas sem afetar diretamente as outras camadas. Isso torna mais fácil manter e modificar o código ao longo do tempo.
  
- Reutilização de Código: A modularização do código em diferentes camadas promove a reutilização de componentes, uma vez que as funcionalidades de lógica de negócios podem ser compartilhadas por diferentes partes da aplicação.
  
- Testabilidade: A separação das camadas facilita a escrita de testes unitários e de integração, permitindo testar cada camada de forma isolada para garantir a qualidade e a robustez do software.
  
- Escalabilidade: A arquitetura em três camadas fornece uma base sólida para escalar a aplicação horizontalmente, adicionando novos servidores ou instâncias conforme necessários para lidar com um aumento na carga de trabalho.

## Estrutura de Diretórios

bash

├── UI                  # Camada de Apresentação (Interface do Usuário) com Windows Forms

│   ├── Forms           # Formulários da Interface do Usuário

│   └── ...

├── Services                 # Camada de Lógica de Negócios

│   ├── Services        # Serviços de Lógica de Negócios

│   └── ...

├── Data                 # Camada de Acesso a Dados

│   ├── Repositories    # Repositórios de Acesso a Dados

│   └── ...

├── Domain              # Camada de Domínio

│   ├── Entities        # Entidades de Domínio

│   └── ...

└── ...

O projeto é composto pela estrutura acima, sendo que:

-   UI: Esta camada contém os formulários da interface do usuário desenvolvidos com Windows Forms. Aqui, são criadas as telas e elementos de interação com o usuário, como botões, campos de texto, listas, entre outros. A UI é responsável por apresentar os dados e permitir a interação do usuário com o sistema.

- Domain: Esta camada contém as entidades de domínio responsáveis por representar os conceitos fundamentais de negócios da aplicação. As entidades de domínio são utilizadas para representar e manipular os dados em diferentes camadas da aplicação, garantindo a coesão e a consistência do modelo de domínio.

- Services: Aqui estão localizados os serviços de lógica de negócios. Estes serviços são responsáveis por implementar as regras de negócio da aplicação. É onde ocorre o processamento dos dados, validações e tomada de decisões de acordo com as necessidades específicas do projeto. Os serviços encapsulam a lógica de negócios para manter a coesão e a modularidade do sistema.

- Data: Esta camada contém os repositórios de acesso a dados. Os repositórios são responsáveis por interagir diretamente com o banco de dados para realizar operações de persistência, como inserção, consulta, atualização e exclusão de dados. Eles abstraem a complexidade do acesso ao banco de dados e fornecem uma interface simplificada para as camadas superiores do sistema.

## Projeto: Funcionamento

A interface da aplicação foi projetada para oferecer uma experiência intuitiva e eficiente aos usuários. Ao iniciar, os usuários são recebidos com uma janela central contendo duas tabs distintas: uma para produtos e outra para fornecedores. Cada qual apresenta uma lista dos registros correspondentes disponíveis no sistema.

Para facilitar a navegação e acesso aos diferentes recursos, um menu localizado à esquerda da janela oferece opções para alternar entre as tabs. Isso permite que os usuários possam rapidamente acessar a funcionalidade desejada sem dificuldades.

Na tab de produto, os usuários têm a opção de adicionar novos produtos clicando no botão "ADD". Uma janela será aberta para permitir que o usuário insira os dados do novo produto e durante o processo de inserção, existem validações para garantir que os formatos de dados inseridos estejam corretos e atendam aos requisitos do sistema.

Para atualizar as informações de um produto existente, os usuários podem clicar no botão "UPDATE". Ao selecionar essa opção, uma janela será aberta para que o usuário possa atualizar as informações do produto selecionado na lista. Novamente, durante o processo de atualização, as validações são aplicadas para garantir a consistência dos dados.

Para garantir a integridade do sistema e evitar exclusões acidentais, ao clicar em "DELETE", uma janela de confirmação será aberta para perguntar se o usuário realmente deseja excluir o registro selecionado. Essa medida de segurança adicional ajuda a prevenir exclusões indesejadas.

O mesmo conjunto de funcionalidades está disponível na tab de fornecedor. Os usuários podem adicionar, atualizar e excluir registros de forma simples e direta, seguindo o mesmo padrão de interação presente na tab anterior.

Essa abordagem de interface foi projetada para fornecer uma experiência coesa e eficaz, garantindo que os usuários possam gerenciar facilmente os dados de produtos e fornecedores de maneira intuitiva e eficiente dentro do sistema.

## Instalação e Configuração

    1. Clone o repositório para sua máquina local.

    2. Abra o projeto em sua IDE preferida, como o Visual Studio.
    
    3. Certifique-se de que os pacotes NuGet necessários estejam restaurados.

    4. Antes de prosseguir, é necessário ter o MySQL Server instalado localmente. Se ainda não o fez, faça o download e instale a versão compatível com seu sistema operacional.

    5. Uma vez instalado, configure a conexão com o banco de dados MySQL localmente nos arquivos de configuração correspondentes(Data/Script/DataBaseCreation.sql)

    6. Abra um terminal ou prompt de comando.

    7. Conecte-se ao MySQL Server digitando o seguinte comando e inserindo sua senha quando solicitado:

        - mysql -u seu_nome_de_usuario -p

    8. Após ter entrado no MySQL, você pode selecionar o banco de dados padrão (se necessário) com o comando USE, conforme abaixo:

        - USE product_supplier;

    9. Em seguida, copie e cole o script SQL fornecido para criar o banco de dados e as tabelas.
    
    10. Pressione Enter para executar o script.

    11. Assim que o script for executado com sucesso, o banco de dados product_supplier e as tabelas supplier e product serão criados com as definições especificadas. Certifique-se de que não houve erros durante a execução do script e que você tenha as permissões necessárias para criar bancos de dados e tabelas.

    12. Certifique-se de fornecer as credenciais corretas e ajustar as configurações conforme necessário para garantir uma conexão bem-sucedida.

    13. Após configurar a conexão com o banco de dados, é necessário adicionar um arquivo App.Config na camada principal(UI).
    
    14. Em seguida, adicionar o código abaixo para poder configurar a string de conexão:

	    <appSettings>
    
            <add key="MySqlConnection" value="server=localhost;uid=seu_nome_de_usuario;pwd=; database=product_supplier"/>
    
        </appSettings>
    
    15. Por fim, compile o projeto e execute-o para começar a usar o sistema.

## Tecnologias Utilizadas

Neste projeto, foram utilizadas as seguintes tecnologias principais:

    - C# (.NET Framework ou .NET Core): A linguagem de programação principal para o desenvolvimento do projeto, oferecendo uma ampla gama de recursos e suporte para o desenvolvimento de aplicativos robustos.

    - Windows Forms (para a Interface do Usuário): Windows Forms foi escolhido para desenvolver a interface do usuário (UI) devido à sua simplicidade e familiaridade para criar interfaces de desktop no ambiente Windows, que é o sistema operacional mais utilizado dentro das corporações atualmente.

    - MySQL (banco de dados local): MySQL foi selecionado como o banco de dados local para armazenar e gerenciar os dados do sistema de cadastro de produtos e fornecedores devido à sua confiabilidade, desempenho e ampla adoção na comunidade de desenvolvimento.

    - Consultas SQL manuais (em vez do Entity Framework): Em vez de utilizar um ORM (Object-Relational Mapping) como o Entity Framework, optamos por escrever consultas SQL manuais para interagir com o banco de dados. Isso nos proporcionou maior controle sobre as consultas e melhor desempenho em algumas situações específicas do projeto.

## Como Contribuir

Se desejar contribuir para este projeto, siga estas etapas:

    1. Faça um fork do projeto.

    2. Crie uma nova branch (git checkout -b feature/nova-funcionalidade).

    3. Faça commit de suas alterações (git commit -am 'Adicione uma nova funcionalidade').

    4. Faça push para a branch (git push origin feature/nova-funcionalidade).

    5. Crie um novo Pull Request.

## Licença

Este projeto está licenciado sob a Licença MIT.
