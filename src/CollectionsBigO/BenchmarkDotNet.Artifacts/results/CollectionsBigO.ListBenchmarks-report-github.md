``` ini

BenchmarkDotNet=v0.13.3, OS=macOS Monterey 12.5.1 (21G83) [Darwin 21.6.0]
Intel Core i7-4770HQ CPU 2.20GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.101
  [Host]     : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  Job-CKTJND : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

```
| Method |   Size |         Mean |      Error |     StdDev |       Median |
|------- |------- |-------------:|-----------:|-----------:|-------------:|
|    **Add** |   **1000** |     **3.542 μs** |  **0.1623 μs** |  **0.4444 μs** |     **3.404 μs** |
|    **Add** |   **5000** |     **6.897 μs** |  **0.3206 μs** |  **0.9042 μs** |     **6.513 μs** |
|    **Add** |  **25000** |    **20.061 μs** |  **0.7617 μs** |  **2.1107 μs** |    **19.785 μs** |
|    **Add** | **125000** |   **246.384 μs** |  **6.4825 μs** | **18.8069 μs** |   **240.279 μs** |
|    **Add** | **625000** | **1,234.279 μs** | **25.3181 μs** | **73.4523 μs** | **1,222.396 μs** |
