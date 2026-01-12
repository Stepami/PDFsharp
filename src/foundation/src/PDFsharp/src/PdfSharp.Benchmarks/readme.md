# before

| Method        | Iterations |        Mean |      Error |     StdDev |
|---------------|------------|------------:|-----------:|-----------:|
| CreateAndSave | 1          |    56.78 us |   1.677 us |   4.945 us |
| CreateAndSave | 10         |   529.62 us |  10.451 us |  20.872 us |
| CreateAndSave | 100        | 5,377.21 us | 103.454 us | 186.549 us |

# after

| Method        | Iterations |        Mean |      Error |     StdDev |
|---------------|------------|------------:|-----------:|-----------:|
| CreateAndSave | 1          |    51.83 us |   0.802 us |   0.891 us |
| CreateAndSave | 10         |   518.13 us |  10.099 us |  12.022 us |
| CreateAndSave | 100        | 5,102.81 us | 105.648 us | 201.006 us |