namespace Enums_Mills_Justyce
{
    enum Months//global enum, called Months, starting from Jan to Dec
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int myBirthMonth = (int)Months.Jul;//Main method int called myBirthMonth and set to Months
            int myBirthDay = 16;//an int called myBirthDay and set to my day of birth
            int myBirthYear = 2005;//an int called myBirthYear and set to your birth year

            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";//a string called myBirthDate and set equal to "My birthday is on <myBirthMonth>/<myBirthDay>/<myBirthYear>"

            File.WriteAllText("myFile.txt", "clek\n");//Creates a file called "myFile.txt" and say clek
            Console.WriteLine(File.ReadAllText("myFile.txt"));//Read the file just created and print it to console

            File.AppendAllText("myFile.txt", "blek\n");//Append text to the file created and display all the text from the file to console
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            if (!File.Exists("newFile.txt"))
            {
                File.Copy("myFile.txt", "newFile.txt");//Copy "myFile.txt" to a new file called "newFile.txt", if the new file does not exist
            }
            else
            {
                File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");//If it does exist, replace the file with "myFile.txt"
            }

            File.AppendAllText("newFile.txt", myBirthDate);//Append the myBirthDate string to the new file and display all the text from the file to console
            Console.WriteLine(File.ReadAllText("newFile.txt"));
        }
    }
}