
//Console.SetCursorPosition(10, 4);
//Console.Write ("+");

Console.Clear();

int xa=40, ya=1,
    xb=1, yb=20,
    xc=80, yc=20, x=0, y=0, n=0;
Console.SetCursorPosition(xa, ya);
Console.Write ("+");
Console.SetCursorPosition(xb, yb);
Console.Write ("+");
Console.SetCursorPosition(xc, yc);
Console.Write ("+");
while (n < 1000)
{ int num = new Random ().Next(1, 4);
if (num == 1)
{ x=(x+xa)/2;
  y=(y+ya)/2;
}
if (num == 2)
{ x=(x+xb)/2;
  y=(y+yb)/2;
}
if (num == 3)
{ x=(x+xc)/2;
  y=(y+yc)/2;
}
Console.SetCursorPosition(x, y);
Console.Write ("+");
n++;

}
Console.SetCursorPosition(xc, yc+2);