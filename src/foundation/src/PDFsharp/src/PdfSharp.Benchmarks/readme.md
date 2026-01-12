# before

| Method        | Iterations |        Mean |       Error |      StdDev |      Median |
|---------------|------------|------------:|------------:|------------:|------------:|
| CreateAndSave | 1          |    878.8 us |    18.28 us |    53.62 us |    869.4 us |
| CreateAndSave | 10         |  8,357.5 us |   153.39 us |   143.49 us |  8,361.5 us |
| CreateAndSave | 100        | 83,972.1 us | 1,764.56 us | 5,175.14 us | 82,510.5 us |

# after

| Method        | Iterations |        Mean |       Error |      StdDev |      Median |
|---------------|------------|------------:|------------:|------------:|------------:|
| CreateAndSave | 1          |    784.6 us |    17.22 us |    46.86 us |    869.4 us |
| CreateAndSave | 10         |  7,692.0 us |   138.45 us |   175.10 us |  7,723.0 us |
| CreateAndSave | 100        | 78,402.7 us | 1,636.04 us | 4,772.40 us | 77,814.7 us |
