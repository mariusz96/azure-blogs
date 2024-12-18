# Azure Blogs
A web API in C# and Azure:
```JavaScript
POST /api/blogs
{
    "url": "https://devblogs.microsoft.com/dotnet/category/azure/"
}
```
```JavaScript
201 Created
1
```
```JavaScript
POST /api/posts
{
    "title": "Hello World",
    "content": "I wrote an app using Azure!",
    "blogId": 1
}
```
```JavaScript
201 Created
1
```
```JavaScript
DELETE /api/blogs/1
```
```JavaScript
204 No Content
```

## Prerequisites:
- .NET 9.0
- Visual Studio 2022
- Azure development workload

## Test:
- `Test Explorer` > `Run All Tests`

## Deploy:
- Create a new SQL Database and migrate it
- Create a new Key Vault, add a secret with `ConnectionStrings--AzureBlogsContext` name and SQL Database connection string value, and configure `KeyVaultName` property in `appsettings.json` file
- Publish `AzureBlogs.Api` web app to App Service
- Add permisions to web app to access other created resources
- Delete all created resources to prevent ongoing charges

## Azure services used:
- App Service
- SQL Database
- Key Vault
