# CompositeDemo (C# / .NET 8)

This solution demonstrates the **Composite Pattern** in a simple graphics domain.

## Projects
- **Graphics.Core** — Interfaces and implementations (`IGraphic`, `Circle`, `Rectangle`, `Group`).
- **Graphics.Demo** — Console app that builds a tree and demonstrates `Draw`, `Move`, and `GetArea`.
- **Graphics.Tests** — xUnit tests.

## Build & Run
```bash
dotnet build
dotnet test
dotnet run --project Graphics.Demo
```
