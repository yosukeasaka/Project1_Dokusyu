using System;

class Help
{
    public void HelpOn(char what)
    {
        switch (what)
        {
            case '1':
                Console.WriteLine("The if:\n");
                Console.WriteLine("if(condition) statement");
                Console.WriteLine("else statement");
                break;
            case '2':
                Console.WriteLine("The switch:\n");
                Console.WriteLine("switch(expression) {");
                Console.WriteLine("\tcase constant:");
                Console.WriteLine("\t\tstatement sequence");
                Console.WriteLine("\t\t\brek;");
                Console.WriteLine("\t//...");
                Console.WriteLine("} ");
                break;
            case '3':
                Console.WriteLine("The for:\n");
                Console.Write("for(init; condition; iteration)");
                Console.WriteLine(" statement");
                break;
            case '4':
                Console.WriteLine("The while:\n");
                Console.WriteLine("while(condition) statement;");
                break;
            case '5':
                Console.WriteLine("The do-while:\n");
                Console.WriteLine("do { ");
                Console.WriteLine("\tstatement;");
                Console.WriteLine("}\twhile (condition);");
                break;
            case '6':
                Console.WriteLine("The break:\n");
                Console.WriteLine("break; or break label;");
                break;
            case '7':
                Console.WriteLine("The continue:\n");
                Console.WriteLine("continue; or continue label;");
                break;
            case '8':
                Console.WriteLine("The goto:\n");
                Console.WriteLine("goto label;");
                break;
        }
        Console.WriteLine();
    }

    //メニューを表示
    public void ShowMenu()
    {
        Console.WriteLine("Help on:");
        Console.WriteLine("\t1. if");
        Console.WriteLine("\t2. switch");
        Console.WriteLine("\t3. for");
        Console.WriteLine("\t4. while");
        Console.WriteLine("\t5. do-while");
        Console.WriteLine("\t6. break");
        Console.WriteLine("\t7. continue");
        Console.WriteLine("\t8. goto\n");
        Console.WriteLine("Choose one(q to quit): ");
    }

    //有効な選択肢か検証する
    public bool IsValid(char ch)
    {
        if (ch < '1' | ch > '8' & ch != 'q') return false;
        else return true;
    }

    class HelpClassDemo
    {
        static void HelpMain()
        {
            char choice;
            Help hlpobj = new Help();
            for(; ; )
            {
                do
                {
                    hlpobj.ShowMenu();
                    do
                    {
                        choice = (char)Console.Read();
                    } while (choice == '\n' | choice == '\r');
                } while (!hlpobj.IsValid(choice));
                if (choice == 'q') break;
                Console.WriteLine("\n");
                hlpobj.HelpOn(choice);
            }
        }
    }
}