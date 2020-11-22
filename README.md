# README Localization
- [Português](README_pt.md)

# Goals
This repository is a working example of a .net 5 console application that reads a file, protobuf serialized, generated by the java project: [protobuf-example-java](https://github.com/danielpadua/protobuf-example-java), used to demonstrate protobuf in my medium article: [Understanding Protobuf]()

# Prerequisites
- .NET 5 SDK
- Ensure you have compiled and successfully run the java project: [protobuf-example-java](https://github.com/danielpadua/protobuf-example-java) which is responsible to generate in a path chosen by you, a protobuf serialized file using as contract the [Customer](src/DanielPadua.ProtobufExampleCsharp/Protos/customer.proto) defined in the `.proto` file.

# How to run
1. Clone this project using: `git clone https://github.com/danielpadua/protobuf-example-csharp`
2. Navigate to the root of the repository: `cd protobuf-example-csharp`
3. Run the command:
```
dotnet run --project src/DanielPadua.ProtobufExampleCsharp/DanielPadua.ProtobufExampleCsharp.csproj -i #{path}`
```
or
```
dotnet run --project src/DanielPadua.ProtobufExampleCsharp/DanielPadua.ProtobufExampleCsharp.csproj --inputPath ${path}`
```
where: `${path}` stands for the path of the directory you chose for the java project to generate the file. **Do not** include the file name itself, only the full path to the directory.