### Criar Migration
dotnet ef migrations add Initial

### Atualizar o banco
dotnet ef database update

###Criar controller por scaffold
dotnet aspnet-codegenerator controller -name FornecedorController -actions -api -m Fornecedor -dc ApiDbContext -outDir Controllers

###Live Reloading
dotnet watch run