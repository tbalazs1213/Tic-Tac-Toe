#include <iostream>
using namespace std;

#define MERET 9

void ClearScreen()
{
  for(int i = 0; i < 10; i++)
  {
    cout << "\n\n\n\n\n\n\n\n\n";
  }
}

void Tablafeltoltes(char tabla[MERET][MERET])
{
  for(int i = 0; i < MERET; i++)
  {
    for(int j = 0; j < MERET; j++)
    {
      tabla[i][j] = '-';
    }
  }
}

void TablaKiiras(char tabla[MERET][MERET])
{
  cout << endl << "Tabla:" << endl << endl << ' ';
  for(int i = 1; i < MERET + 1; i++)
  {
    cout << ' ' << i;
  }
  cout << endl;
  for(int i = 0; i < MERET; i++)
  {
    cout << i + 1;
    for(int j = 0; j < MERET; j++)
    {
      cout << ' ' << tabla[i][j];
    }
    cout << endl;
  }
}

int SorBekeres()
{
  int sor;
  do
  {
    cout << "Sor:\t";
    cin >> sor;
  }while(sor < 0 || sor > MERET);
  return sor;
}

int OszlopBekeres()
{
 int oszlop;
 do
  {
    cout << "Oszlop:\t";
    cin >> oszlop;
  }while(oszlop < 0 || oszlop > MERET);
  return oszlop;
}

void Jatekos(bool c, int lepesszamlalo)
{
  cout << endl;
  if(c)
  {
    cout << "X Jatekos (" << lepesszamlalo + 1 << "):\t\tJatek mentese: [M]" << endl;
  }
  else
  {
    cout << "O jatekos (" << lepesszamlalo + 1 << "):\t\tJatek mentese: [M]" << endl;
  }
  cout << endl;
}

bool JatekVege(int sorbeker, int oszlopbeker, bool c, char tabla[MERET][MERET])
{
  if(c == true)
  {
    if(tabla[sorbeker - 1][oszlopbeker - 3] == 'X' && tabla[sorbeker - 1][oszlopbeker - 2] == 'X')
    {
      return true;
    }
    else if(tabla[sorbeker - 1][oszlopbeker] == 'X' && tabla[sorbeker - 1][oszlopbeker + 1] == 'X')
    {
      return true;
    }
    else if(tabla[sorbeker - 1][oszlopbeker - 2] == 'X' && tabla[sorbeker - 1][oszlopbeker] == 'X')
    {
      return true;
    }
    else if(tabla[sorbeker - 2][oszlopbeker - 1] == 'X' && tabla[sorbeker - 3][oszlopbeker - 1] == 'X')
    {
      return true;
    }
    else if(tabla[sorbeker][oszlopbeker - 1] == 'X' && tabla[sorbeker + 1][oszlopbeker - 1] == 'X')
    {
      return true;
    }
    else if(tabla[sorbeker - 2][oszlopbeker - 1] == 'X' && tabla[sorbeker][oszlopbeker - 1] == 'X')
    {
      return true;
    }
    else if(tabla[sorbeker - 2][oszlopbeker - 2] == 'X' && tabla[sorbeker - 3][oszlopbeker - 3] == 'X')
    {
      return true;
    }
    else if(tabla[sorbeker - 2][oszlopbeker - 2] == 'X' && tabla[sorbeker][oszlopbeker] == 'X')
    {
      return true;
    }
    else if(tabla[sorbeker][oszlopbeker] == 'X' && tabla[sorbeker + 1][oszlopbeker + 1] == 'X')
    {
      return true;
    }
    else if(tabla[sorbeker - 2][oszlopbeker] == 'X' && tabla[sorbeker - 3][oszlopbeker + 1] == 'X')
    {
      return true;
    }
    else if(tabla[sorbeker][oszlopbeker - 2] == 'X' && tabla[sorbeker + 1][oszlopbeker - 3] == 'X')
    {
      return true;
    }
    else if(tabla[sorbeker - 2][oszlopbeker] == 'X' && tabla[sorbeker][oszlopbeker - 2] == 'X')
    {
      return true;
    }
  }
  else
  {
    if(tabla[sorbeker - 1][oszlopbeker - 3] == 'O' && tabla[sorbeker - 1][oszlopbeker - 2] == 'O')
    {
      return true;
    }
    else if(tabla[sorbeker - 1][oszlopbeker] == 'O' && tabla[sorbeker - 1][oszlopbeker + 1] == 'O')
    {
      return true;
    }
    else if(tabla[sorbeker - 1][oszlopbeker - 2] == 'O' && tabla[sorbeker - 1][oszlopbeker] == 'O')
    {
      return true;
    }
    else if(tabla[sorbeker - 2][oszlopbeker - 1] == 'O' && tabla[sorbeker - 3][oszlopbeker - 1] == 'O')
    {
      return true;
    }
    else if(tabla[sorbeker][oszlopbeker - 1] == 'O' && tabla[sorbeker + 1][oszlopbeker - 1] == 'O')
    {
      return true;
    }
    else if(tabla[sorbeker - 2][oszlopbeker - 1] == 'O' && tabla[sorbeker][oszlopbeker - 1] == 'O')
    {
      return true;
    }
    else if(tabla[sorbeker - 2][oszlopbeker - 2] == 'O' && tabla[sorbeker - 3][oszlopbeker - 3] == 'O')
    {
      return true;
    }
    else if(tabla[sorbeker - 2][oszlopbeker - 2] == 'O' && tabla[sorbeker][oszlopbeker] == 'O')
    {
      return true;
    }
    else if(tabla[sorbeker][oszlopbeker] == 'O' && tabla[sorbeker + 1][oszlopbeker + 1] == 'O')
    {
      return true;
    }
    else if(tabla[sorbeker - 2][oszlopbeker] == 'O' && tabla[sorbeker - 3][oszlopbeker + 1] == 'O')
    {
      return true;
    }
    else if(tabla[sorbeker][oszlopbeker - 2] == 'O' && tabla[sorbeker + 1][oszlopbeker - 3] == 'O')
    {
      return true;
    }
    else if(tabla[sorbeker - 2][oszlopbeker] == 'O' && tabla[sorbeker][oszlopbeker - 2] == 'O')
    {
      return true;
    }
  }
  return false;
}

int Kezdolap()
{
  int parancs;
  cout << "Kezdolap:" << endl << endl;
  cout << "• Uj jatek (1)" << endl << endl;
  cout << "• Betoltes (2)" << endl << endl;
  do
  {
    cout << "Parancs: ";
    cin >> parancs;
    cout << endl;
    if(parancs < 1 || parancs > 2)
    {
      cout << "Ismeretlen parancs!" << endl << endl;
    }
  }while(parancs < 1 || parancs > 2);
  return parancs;
}

void UjJatek()
{
  bool c = true;
  int lepesszamlalo = 0;
  int sorbeker, oszlopbeker;
  char tabla[MERET][MERET];
  bool jv = false;
  Tablafeltoltes(tabla);
  do
  {
    ClearScreen();
    TablaKiiras(tabla);
    Jatekos(c, lepesszamlalo);
    do
    {
      sorbeker = SorBekeres();
      oszlopbeker = OszlopBekeres();
      if(tabla[sorbeker - 1][oszlopbeker - 1] != '-')
      {
        cout <<endl << "Foglalt hely!" << endl << endl;
      }
    }while(tabla[sorbeker - 1][oszlopbeker - 1] != '-');
    if(c)
    {
      tabla[sorbeker - 1][oszlopbeker - 1] = 'X';
    }
    else
    {
      tabla[sorbeker - 1][oszlopbeker - 1] = 'O';
    }
    jv = JatekVege(sorbeker, oszlopbeker, c, tabla);
    ClearScreen();
    TablaKiiras(tabla);
    if(c)
    {
      c = false;
    }
    else
    {
      c = true;
    }
    lepesszamlalo++;
  }while(lepesszamlalo < MERET * MERET && jv == false);
  cout << endl << "A Jateknak vege!" << endl;
  if(c)
  {
    cout << "A gyoztes a O jatekos!" << endl;
  }
  else
  {
    cout << "A gyoztes az X jatekos!" << endl;
  }
  cout << endl;
};

int main()
{
  bool a = true;
  ClearScreen();
  do
  {
    int kezdolap = Kezdolap();
    if(kezdolap == 1)
    {
      UjJatek();
    }
    else if(kezdolap == 2)
    {
      ClearScreen();
      cout << "Nem elerheto!" << endl << endl;
    }
  }while(a == true);
  return 0;
}
