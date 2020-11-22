# README Localization
- [English](README.md)

# Objetivo
Este repositório é o exemplo funcional de uma aplicação console .net 5 que lê um arquivo serializado com protobuf gerado pelo projeto java: [protobuf-example-java](https://github.com/danielpadua/protobuf-example-java), usado para demonstrar o protobuf no meu artigo no medium: [Entendendo Protobuf]().

# Pré-Requisitos
- .NET 5 SDK
- Certifique-se de ter compilado e executado com sucesso o projeto java: [protobuf-example-java](https://github.com/danielpadua/protobuf-example-java) que é responsável por gerar um arquivo serializado com protobuf em um diretório especificado por você, utilizando contrato [Customer](src/DanielPadua.ProtobufExampleCsharp/Protos/customer.proto) definido no arquivo `.proto`.

# Como executar
1. Clonar este projeto utilizando: `git clone https://github.com/danielpadua/protobuf-example-csharp`
2. Navegar até o diretório raíz: `cd protobuf-example-csharp`
3. Executar o comando:
```
dotnet run --project src/DanielPadua.ProtobufExampleCsharp/DanielPadua.ProtobufExampleCsharp.csproj -i #{path}`
```
ou
```
dotnet run --project src/DanielPadua.ProtobufExampleCsharp/DanielPadua.ProtobufExampleCsharp.csproj --inputPath ${path}`
```
onde: `${path}` representa o caminho do diretório onde você definiu que o projeto java gerasse o arquivo. **Não** incluir o nome do arquivo, apenas o caminho completo até o diretório.
