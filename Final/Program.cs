using System;

class Program
{

    static char[] supportwongrepArray = new char[]{'(',')'};

    static void Inputwongrep(Queue<char> conveyor)
   {
        char wongrep = char.Parse(Console.ReadLine());
        if(supportwongrepArray.Contains(wongrep))
        {
            conveyor.Push(wongrep);
            Inputwongrep(conveyor);
        }
    }

    static void ProcessConveyor(Queue<char> conveyor)
    {
    int x = 1;
    int y = 1;
    
    string V = "valid";
    string IV = "Invalid";
        char wongrep;
        while(conveyor.GetLength() > 0)
        {
            wongrep = conveyor.Pop();
            switch(wongrep)
            {
                case '(':
                    Console.Write("{0}",x);
                    break;
                case ')':
                    Console.Write("{0}",y);
                    break;
            }
            if(x%y==0)
            { 
                Console.WriteLine("{0}",V);
            }
		    else
            {
                Console.WriteLine("{0}",IV);
            }
    }
    }
    static void Main(string[] args)
    {
        Queue<char> conveyor = new Queue<char>();
        Inputwongrep(conveyor);
        ProcessConveyor(conveyor);
    }
}
    
