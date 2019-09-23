### Adicionar projeto de apis
dotnet new webapi -n "restapi"

### Adicionar pacote
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

### Restoaurar pacotes
dotnet restore

### Limpar Soluçáo
dotnet clean

### Buildar Soluçáo
dotnet build

### Rodar Soluçáo
dotnet run

### Rodar Soluçáo com profiller de produçáo
dotnet run --launch-profile Prod

### Criar Migration
dotnet ef migrations add Initial

### Atualizar o banco
dotnet ef database update

### Criar controller por scaffold
dotnet aspnet-codegenerator controller -name FornecedorController -actions -api -m Fornecedor -dc ApiDbContext -outDir Controllers

### Live Reloading
dotnet watch run

### Informaçóes do dotnet
dotnet --info