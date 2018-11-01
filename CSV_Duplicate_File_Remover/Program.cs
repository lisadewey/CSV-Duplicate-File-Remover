using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Duplicate_File_Remover
{
	class CSV_Duplicate_File_Remover
	{
		public static void Main()
		{
			HashSet<string> hs = new HashSet<string>();
			using (StreamReader reader = new StreamReader(@"C:\MW_Test_Files\remove-duplicate-files-from-csv.csv"))
			{
				while (!reader.EndOfStream)
				{
					string fileLine = reader.ReadLine();

					if (string.IsNullOrWhiteSpace(fileLine))
					{
						continue;
					}

					hs.Add(fileLine);
				}
			}

			using (StreamWriter file = new StreamWriter(@"C:\MW_Test_Files\remove-duplicate-files-from-csv-output.csv"))
			{
				foreach (string line in hs)
				{
					file.WriteLine(line);
				}
			}

		}
	}
}

