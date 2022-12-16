using System;

namespace DuplicateFileChecker
{
    class DuplicateFolder
    {
        public string[] fileNames;
        public int[] newFileIds;
        public string[] newFileNames;
        public int[] fileIds;

        public void arrayLen(int size)
        {
            fileNames = new string[size]; 
            fileIds = new int[size];
            newFileIds = new int[size];
            newFileNames = new string[size];
        }



        public string fileNameLetters;
        public string fileNameId;
        char ch;
        public void fileName_Split(string filename)
        {
            fileNameLetters = "";
            fileNameId = "";
            for (int i = 0; i < filename.Length; i++)
            {
                ch = filename[i];
                if (Char.IsLetter(ch))
                {
                    fileNameLetters += ch;
                }
                else if (Char.IsDigit(ch))
                {
                    fileNameId += ch;
                }
            }
        }

        public int fileId;
        public void store(int i)
        {
            fileNames[i] = fileNameLetters;
        
            //[i] = Convert.ToInt32(fileNameId);
            fileId = int.Parse(fileNameId);

            fileIds[i] = fileId;
        }

        public int existing_file;
     

        public void checkForDuplicate(int numberOfFiles)
        {
            for (int i = 0; i < numberOfFiles; i++)
            {
                for (int j = 0; j < numberOfFiles; j++)
                {
                    //public string str1 = newFileNames[j];
                    //public string str2 = fileNames[i];
                    // bool check = string.Compare(newFileNames[j], fileNames[i]);
                    if (String.Equals(newFileNames[j], fileNames[i]))
                    {
                        existing_file = j;
                        break;
                    }
                    else
                    {
                        existing_file = -1;
                    }

                }

                if (existing_file == -1)
                {
                    newFileNames[i] = String.Copy(fileNames[i]);
                    newFileIds[i] = fileIds[i];
                }
                else
                {
                    if (newFileIds[existing_file] <= fileIds[i])
                    {
                        newFileNames[i] = String.Copy(fileNames[i]);
                        newFileIds[i] = -1;
                    }
                    else
                    {
                        newFileNames[i] = String.Copy(fileNames[i]);
                        newFileIds[existing_file] = fileIds[i];
                        newFileIds[i] = -1;
                    }

                }

            }

            Array.Sort(newFileIds);
            foreach (int id in newFileIds)
            {
                if (id != -1)
                {
                    Console.Write("{0}\t", id);
                }
            }

            Console.WriteLine();

        }

    }

    class DuplicateCheckerRun
    {
        public static int testcases;
        public static  int number_of_files;
        public static  string file_input;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of testcases:\t\n");
            testcases = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < testcases; i++)
            {
                Console.WriteLine("Enter number of files:\t\n");
                number_of_files = int.Parse(Console.ReadLine());
                DuplicateFolder Folder = new DuplicateFolder();
                Folder.arrayLen(number_of_files);


                for (int k = 0; k < number_of_files; k++)
                {
                    Console.WriteLine("Enter file :\t\n");
                    file_input = Console.ReadLine();
                    Folder.fileName_Split(file_input);
                    Folder.store(k);
                    
                }

                Folder.checkForDuplicate(number_of_files);
            }
        }
    }
}













