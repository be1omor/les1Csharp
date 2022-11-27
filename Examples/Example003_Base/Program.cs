Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int Xa = 1, Ya = 1, 
    Xb = 1, Yb = 30, 
    Xc = 60, Yc = 30;

Console.SetCursorPosition(Xa, Ya);
Console.WriteLine("+");

Console.SetCursorPosition(Xb, Yb);
Console.WriteLine("+");

Console.SetCursorPosition(Xc, Yc);
Console.WriteLine("+");

int X = Xa, Y = Xb;

int count = 0;

while(count<10000)
{
    int what = new Random().Next(0, 3);
    if(what == 0)
    {
        X = (X+Xa)/2;
        Y = (Y+Ya)/2;
    }

    if(what == 1)
    {
        X = (X+Xb)/2;
        Y = (Y+Yb)/2;
    }

    if(what == 2)
    {
        X = (X+Xc)/2;
        Y = (Y+Yc)/2;
    }

    Console.SetCursorPosition(X, Y);
    Console.WriteLine("+");
    count++;
}