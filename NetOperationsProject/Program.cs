bool expression = true;

// if else
/*
 * 
if(expression)
{}
else
{}

if(expression)
{}
else if
{}
else if
{}
else
{}


(expression) ? true_block : false_block
*/

// while, do while
/*
while(expression)
{

}

do
{

} while (expression);
*/

// for, foreach
/*
for(int i = 0; i < 10; i++)
{}

foreach(int i in Enumerable.Range(0, 10))
{ }
*/

int key = 1;
switch(key)
{
    case 0:
        Console.WriteLine("Zero");
        break;
    case 1:
        Console.WriteLine("One");
        break;
}

Console.WriteLine(Calc(20, 30, '+'));

int Calc(int a, int b, char sign)
{
    //switch (sign)
    //{
    //    case '+': return a + b;
    //    case '-': return a - b;
    //    case '*': return a * b;
    //    case '/': return a / b;
    //    default: return 0;
    //}
    int result = sign switch
    { 
        '+' => a + b,
        '-' => a - b,
        '*' => a * b,
        '/' => a / b,
        _ => 0
    };

    return result;
}

void OperationExample()
    {
        int n = 20;
        int m = 30;

        /* 

         +, -, *, /, %
        ++, --

        &, |, <<, >>, ^, ~

        >, <, >=, <=, ==, !=


        &/&&, |/||, !

        +=, -=, *=, /=, %=
        &=, |=, ^=, <<=, >>=
        a <<= b   <=>   a = a << b

        (type) - explicit
        implcit

        */

        byte b = (byte)n;

        if (n > 0 || ++m > 0)
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
        Console.WriteLine(m);

        float x = 123.5F;
        n = (int)x;
    }


