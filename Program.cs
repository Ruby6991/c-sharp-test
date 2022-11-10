namespace CSharpProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Check if required arguments are present*/
			if (args.Length < 3)
			{
				Console.WriteLine("Please provide all the required arguments");
				Environment.Exit(0);
			}

			/*Capture command line arguments*/
			string csvPath = Path.Combine(Environment.CurrentDirectory, args[0]);
			int index = Int32.Parse(args[1]);
			string query = args[2];
			
			string result = "Match not Found";

			if (File.Exists(csvPath))
			{
				using (var reader = new StreamReader(csvPath))
				{
					while (!reader.EndOfStream)
					{
						try
						{
							string[] row = reader.ReadLine().Split(',');

							if (row.Length > index)
							{
								/*Compare the search key against the value in the specified index*/
								if (row[index] == query)
								{
									result = String.Join(",", row);
									break;
								}
							}
							else if (row.Length <= index)
							{
								result = "Specified index does not exist";
							}

						}
						catch (Exception ex)
						{
							Console.WriteLine(ex.Message);
							Environment.Exit(0);
						}

					}
					reader.Close();
				}
			}
			else
			{
				Console.WriteLine("The file does not exist");
				Environment.Exit(0);
			}

			Console.WriteLine(result);
			Environment.Exit(0);
		}
	}

}