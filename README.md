## Sobre este projeto

Implementação do "Desafio .NET".

A aplicação consiste em duas APIs implementadas utilizando o conceito de microsserviços. Os endpoints serão consumidos através de um Gateway.

## Executando a aplicação SEM Docker:

1. Abra o diretório da solução no prompt de comando

2. Restaure as dependências do projeto:

    `dotnet restore`

3. Crie uma variável de ambiente definindo o ambiente de desenvolvimento:

    `$Env:ASPNETCORE_ENVIRONMENT='Development'`

    Isso é necessário para carregar alguns arquivos de configuração específicos.

4. Em **um novo terminal**, execute o microserviço de taxa de juros:

    `dotnet run --project .\Microservices\TaxaJuros\TaxaJuros.csproj`

5. Em **um novo terminal**, execute o microserviço de cálculo de juros:

    `dotnet run --project .\Microservices\CalcularJuros\CalcularJuros.csproj`

6. Em **um novo terminal**, execute o gateway da aplicação:

    `dotnet run --project .\Gateway\Gateway.csproj`

7. Importe a collection *Desafio.postman_collection.json* no Postman e, neste ponto, todas as requisições da pasta **Sem Docker** devem estar funcionando

## Excutando a aplicação COM Docker & DockerCompose:

1. Abra o diretório da solução no prompt de comando

2. Crie as imagens e rode os containers:

    `docker-compose up -d`

3. Aguarde o término do processo de deploy

4. Importe a collection *Desafio.postman_collection.json* no Postman e, neste ponto, todas as requisições da pasta **Com Docker** devem estar funcionando