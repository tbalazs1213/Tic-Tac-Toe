using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    int sorok;
    int oszlopok;
    int lepes_sor;
    int lepes_oszlop;
    int tablaszam;
    bool A = false;
    bool B = false;
    bool szin = false;
    bool jatekos = false;
    Console.Clear();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.SetCursorPosition(30, 0);
    Console.WriteLine("--AMŐBA--");
    Console.WriteLine();
    //Bekérés:
    Console.WriteLine("Add meg a tábla méreteit!");
    Console.ForegroundColor = ConsoleColor.White;
    do
    {
      Console.Write("Sorok: ");
      sorok = Convert.ToInt32(Console.ReadLine());
      if (sorok < 3 || sorok >= 10)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Az értéknek 3 és 9 közé kell esnie!");
        Console.ForegroundColor = ConsoleColor.White;
      }
    } while(sorok < 3 || sorok >= 10);
    do
    {
      Console.Write("Oszlopok: ");
      oszlopok = Convert.ToInt32(Console.ReadLine());
      if (oszlopok < 3 || oszlopok >= 10)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Az értéknek 3 és 9 közé kell esnie!");
        Console.ForegroundColor = ConsoleColor.White;
      }
    } while (oszlopok < 3 || oszlopok >= 10);
    //
    //Tábla létrehozása:
    int[,] tabla = new int[sorok,oszlopok];
    tablaszam = sorok * oszlopok;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.SetCursorPosition(30, 0);
    Console.WriteLine("--AMŐBA--");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
    //Lépések ismétlése:
    do
    {
      //Tábla kiírása:
      Console.Write("   ");
      for (int i = 0; i < oszlopok; i++)
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("  {0}  ", i + 1);
        Console.ForegroundColor = ConsoleColor.White;
      }
      Console.WriteLine();
      Console.WriteLine();
      for (int i = 0; i < sorok; i++)
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("{0}  ", i + 1);
        Console.ForegroundColor = ConsoleColor.White;
        for (int j = 0; j < oszlopok; j++)
        {
          if (tabla[i,j] == '0')
          {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("  X  ");
            Console.ForegroundColor = ConsoleColor.White;

          }
          else if (tabla[i,j] == '1')
          {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  O  ");
            Console.ForegroundColor = ConsoleColor.White;
          }
          else
          {
            Console.Write("  -  ");
          } 
        }
        Console.WriteLine();
        Console.WriteLine();
      }
      //Tábla kiírásának vége
      //Következő lépés bekérése:
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write("Következő játékos: ");
      if (!jatekos)
      {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("X");
        Console.ForegroundColor = ConsoleColor.Green;
        jatekos = true;
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("O");
        Console.ForegroundColor = ConsoleColor.Green;
        jatekos = false;
      }
      Console.WriteLine("Következő lépés:");
      Console.ForegroundColor = ConsoleColor.White;
      do
      {
        do
        {
          Console.Write("Sor: ");
         lepes_sor = Convert.ToInt32(Console.ReadLine());
          if (lepes_sor < 0 || lepes_sor > sorok)
          {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Érvénytelen! Add meg újra!");
            Console.ForegroundColor = ConsoleColor.White;
         }
        } while(lepes_sor < 0 || lepes_sor > sorok);
        do
        {
        Console.Write("Oszlop: ");
          lepes_oszlop = Convert.ToInt32(Console.ReadLine());
          if (lepes_oszlop < 0 || lepes_oszlop > oszlopok)
          {
            Console.ForegroundColor = ConsoleColor.Red;
           Console.WriteLine("Érvénytelen! Add meg újra!");
           Console.ForegroundColor = ConsoleColor.White;
          }
        } while(lepes_oszlop < 0 || lepes_oszlop > oszlopok);
        if (tabla[lepes_sor - 1, lepes_oszlop - 1] == '1' || 
              tabla[lepes_sor - 1, lepes_oszlop - 1] == '0')
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Ez a hely már foglalt!");
          Console.ForegroundColor = ConsoleColor.White;
        }
        Console.Beep();
      } while(tabla[lepes_sor - 1, lepes_oszlop - 1] == '1' || 
              tabla[lepes_sor - 1, lepes_oszlop - 1] == '0');
      //Győzelem ellenőrzése:
      //X X _:
      if (lepes_oszlop >= 3 &&
          jatekos == true &&
          tabla[lepes_sor - 1, lepes_oszlop - 2] == '0' &&
          tabla[lepes_sor - 1, lepes_oszlop - 3] == '0')
      {
       B = true;
      }
      //O O _:
      if (lepes_oszlop >= 3 &&
          jatekos == false &&
          tabla[lepes_sor - 1, lepes_oszlop - 2] == '1' &&
          tabla[lepes_sor - 1, lepes_oszlop - 3] == '1')
      {
       A = true;
      }
      //_ X X:
      if (lepes_oszlop <= oszlopok - 2 &&
          jatekos == true &&
          tabla[lepes_sor - 1, lepes_oszlop] == '0' &&
          tabla[lepes_sor - 1, lepes_oszlop + 1] == '0')
      {
        B = true;
      }
      //_ O O:
      if (lepes_oszlop <= oszlopok - 2 &&
          jatekos == false &&
          tabla[lepes_sor - 1, lepes_oszlop] == '1' &&
          tabla[lepes_sor - 1, lepes_oszlop + 1] == '1')
      {
        A = true;
      }
      //X _ X:
      if (lepes_oszlop >= 2 && lepes_oszlop <= oszlopok - 1 &&
          jatekos == true &&
          tabla[lepes_sor - 1, lepes_oszlop - 2] == '0' &&
          tabla[lepes_sor - 1, lepes_oszlop] == '0')
      {
        B = true;
      }
      //O _ O:
      if (lepes_oszlop >= 2 && lepes_oszlop <= oszlopok - 1 &&
          jatekos == false &&
          tabla[lepes_sor - 1, lepes_oszlop - 2] == '1' &&
          tabla[lepes_sor - 1, lepes_oszlop] == '1')
      {
        A = true;
      }
      //X X _ f:
      if (lepes_sor >= 3 &&
          jatekos == true &&
          tabla[lepes_sor - 2, lepes_oszlop - 1] == '0' &&
          tabla[lepes_sor - 3, lepes_oszlop - 1] == '0')
      {
       B = true;
      }
      //O O _ f:
      if (lepes_sor >= 3 &&
          jatekos == false &&
          tabla[lepes_sor - 2, lepes_oszlop - 1] == '1' &&
          tabla[lepes_sor - 3, lepes_oszlop - 1] == '1')
      {
       A = true;
      }
      //_ X X f:
      if (lepes_sor <= sorok - 2 &&
          jatekos == true &&
          tabla[lepes_sor - 0, lepes_oszlop - 1] == '0' &&
          tabla[lepes_sor + 1, lepes_oszlop - 1] == '0')
      {
       B = true;
      }
      //_ O O f:
      if (lepes_sor <= sorok - 2 &&
          jatekos == false &&
          tabla[lepes_sor - 0, lepes_oszlop - 1] == '1' &&
          tabla[lepes_sor + 1, lepes_oszlop - 1] == '1')
      {
       A = true;
      }
      //X _ X f:
      if (lepes_sor >= 2 && lepes_sor <= sorok - 1 &&
          jatekos == true &&
          tabla[lepes_sor - 2, lepes_oszlop - 1] == '0' &&
          tabla[lepes_sor, lepes_oszlop - 1] == '0')
      {
        B = true;
      }
      //O _ O f:
      if (lepes_sor >= 2 && lepes_sor <= sorok - 1 &&
          jatekos == false &&
          tabla[lepes_sor - 2, lepes_oszlop - 1] == '1' &&
          tabla[lepes_sor, lepes_oszlop - 1] == '1')
      {
        A = true;
      }
      //_ X X a:
      if (lepes_sor <= sorok - 2 && lepes_oszlop <= oszlopok - 2 &&
          jatekos == true &&
          tabla[lepes_sor, lepes_oszlop] == '0' &&
          tabla[lepes_sor + 1, lepes_oszlop + 1] == '0')
      {
        B = true;
      }
      //_ O O a:
      if (lepes_sor <= sorok - 2 && lepes_oszlop <= oszlopok - 2 &&
          jatekos == false &&
          tabla[lepes_sor, lepes_oszlop] == '1' &&
          tabla[lepes_sor + 1, lepes_oszlop + 1] == '1')
      {
        A = true;
      }
      //X _ X a:
      if (lepes_sor <= sorok - 1 && lepes_oszlop <= oszlopok - 1 &&
          lepes_sor <= sorok + 1 && lepes_oszlop <= oszlopok + 1 &&
          tabla[lepes_sor, lepes_oszlop] == '0' &&
          jatekos == true &&
          tabla[lepes_sor - 2, lepes_oszlop - 2] == '0')
      {
        B = true;
      }
      //O _ O a:
      if (lepes_sor <= sorok - 1 && lepes_oszlop <= oszlopok - 1 &&
          jatekos == false &&
          lepes_sor <= sorok + 1 && lepes_oszlop <= oszlopok + 1 &&
          tabla[lepes_sor, lepes_oszlop] == '1' &&
          tabla[lepes_sor - 2, lepes_oszlop - 2] == '1')
      {
        A = true;
      }
      //X X _ a:
      if (lepes_sor >= 3 && lepes_oszlop >= 3 &&
          jatekos == true &&
          tabla[lepes_sor - 2, lepes_oszlop - 2] == '0' &&
          tabla[lepes_sor - 3, lepes_oszlop - 3] == '0')
      {
        B = true;
      }
      //O O _ a:
      if (lepes_sor >= 3 && lepes_oszlop >= 3 &&
          jatekos == false &&
          tabla[lepes_sor - 2, lepes_oszlop - 2] == '1' &&
          tabla[lepes_sor - 3, lepes_oszlop - 3] == '1')
      {
        A = true;
      }
      // _ X X ma:
      if (lepes_sor >= 3 && lepes_oszlop <= oszlopok - 2 &&
          jatekos == true && 
          tabla[lepes_sor - 2, lepes_oszlop] == '0' &&
          tabla[lepes_sor - 3, lepes_oszlop + 1] == '0')
      {
        B = true;
      }
      // _ O O ma:
      if (lepes_sor >= 3 && lepes_oszlop <= oszlopok - 2 &&
          jatekos == false && 
          tabla[lepes_sor - 2, lepes_oszlop] == '1' &&
          tabla[lepes_sor - 3, lepes_oszlop + 1] == '1')
      {
        A = true;
      }
      // X _ X ma:
      if (lepes_sor >= 2 && lepes_oszlop <= oszlopok - 1 &&
          jatekos == true &&
          tabla[lepes_sor - 2, lepes_oszlop] == '0' &&
          tabla[lepes_sor, lepes_oszlop - 2] == '0')
      {
        B = true;
      }
      //O _ O ma:
      if (lepes_sor >= 2 && lepes_oszlop <= oszlopok - 1 &&
          jatekos == false &&
          tabla[lepes_sor - 2, lepes_oszlop] == '1' &&
          tabla[lepes_sor, lepes_oszlop - 2] == '1')
      {
        A = true;
      }
      //Következő lépés bekérésének vége
      //Lépés elmentése:
      if (szin == false)
      {
        tabla[lepes_sor - 1, lepes_oszlop - 1] = '0';
        tablaszam--;
        szin = true;
      }
      else
      {
        tabla[lepes_sor - 1, lepes_oszlop - 1] = '1';
        tablaszam--;
        szin = false;
      }
      //
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Green;
    Console.SetCursorPosition(30, 0);
    Console.WriteLine("--AMŐBA--");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
  } while(!A && !B && tablaszam != 0);
  //Lépések ismétlésének vége
  //Tábla újbóli kiírása:
  Console.Write("   ");
  for (int i = 0; i < oszlopok; i++)
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("  {0}  ", i + 1);
        Console.ForegroundColor = ConsoleColor.White;
      }
      Console.WriteLine();
      Console.WriteLine();
  for (int i = 0; i < sorok; i++)
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("{0}  ", i + 1);
        Console.ForegroundColor = ConsoleColor.White;
        for (int j = 0; j < oszlopok; j++)
        {
          if (tabla[i,j] == '0')
          {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("  X  ");
            Console.ForegroundColor = ConsoleColor.White;

          }
          else if (tabla[i,j] == '1')
          {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  O  ");
            Console.ForegroundColor = ConsoleColor.White;
          }
          else
          {
            Console.Write("  -  ");
          } 
        }
        Console.WriteLine();
        Console.WriteLine();
      }
  //Tábla újbóli kiírásának vége
  //Nyertes kiírása:
  Console.WriteLine();
  Console.WriteLine("A játéknak vége!");
  if (A)
  {
    Console.Write("A győztes: ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("O");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(" játékos!");
  }
  else if (B)
  {
    Console.Write("A győztes: ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("X");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(" játékos!");
  }
  //
  }
}

