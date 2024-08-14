**docker**
```
docker compose up -d
```
**Initial Create Migrations**
```
dotnet ef migrations add "InitialCreate" -o Data/Migrations
```

**update database**
```
dotnet ef database update
```

**seed data**
```
Data was seeded using Dbinitializer
```

**drop db**
```
dotnet ef database drop
```

**activity to pupolate DB**
```
dotnet watch
```

**Shaping the Data to return**