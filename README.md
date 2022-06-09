# calculator-kata-dotnet
Calculator Kata (.NET)

## Prerequisites

.NET 6

Ensure that you have installed stryker:

```
dotnet tool install -g dotnet-stryker
```


## Instructions

Run Build

```
dotnet build
```

Run Tests:

```
dotnet test
```

Run Mutation Testing:

```
cd .\test\Optivem.Kata.Calculator.Test
dotnet stryker
```

# Reports

Stryker reports are generated in test/Optivem.Kata.Calculator.Test/StrykerOutput