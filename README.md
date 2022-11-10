# c-sharp-test
 
A C# program that reads through a csv file to identify if a provided search key exists within the file.

I've used the 'StreamReader' class to read the data from the CSV file and create a readable stream.

## Getting Started

Clone the repo :
```bash
git clone https://github.com/Ruby6991/c-sharp-test.git
```

Running the program : Open Command Prompt and Change directory to the Program.cs file location and run the below command.

dotnet run {Path to the CSV file} {Column index} {Search key}

```bash
dotnet run ./file.csv 2 Alberto
```
This returns:
```bash
3, Verdi, Alberto,03/08/1987
```

