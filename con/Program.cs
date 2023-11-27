namespace con;

class Program
{
    static void Main(string[] args)
    {
        string pathU = "../../../input/in.txt";
        string pathS = "../../../save/test.csv";

        string dream;
        StreamReader scan = new StreamReader(pathU);
        StreamWriter print = new StreamWriter(pathS);

        dream = scan.ReadLine();
        while (dream != null)
        {

            print.WriteLine(dream);



            dream = scan.ReadLine();
        }

        scan.Close();
        print.Close();

            }
}

