// zadanie1

// Console.Write("Rostyslav, ");
// Console.WriteLine("Informatyka");
// Console.WriteLine("Chce nauczyc sie instrukcji IO");

// zadanie2

// string imie = "Rostyslav";
// int wiek = 19;
// string gra = "CS2";

// Console.WriteLine("+--------------------------+");
// Console.WriteLine("|       WIZYTÓWKA          |");
// Console.WriteLine("+--------------------------+");
// Console.WriteLine($"| Imię: {imie}          |");
// Console.WriteLine("| Wiek: {0}                 |", wiek);
// Console.WriteLine("| Gra: " + gra + "                 |");
// Console.WriteLine("+--------------------------+");

// zadanie3

// Console.Write("Jak masz na imie? ");
// string imie = Console.ReadLine();
// Console.Write("Jaki jest twoj ulubiony kolor? ");
// string ulubionKolor = Console.ReadLine();

// Console.WriteLine($"Czesc {imie},Twoj ulubiony kolor to {ulubionKolor}.");

// zadanie4

// Console.Write("Ile masz lat? ");
// int wiek = int.Parse(Console.ReadLine());

// Console.WriteLine("Za rok bidziesz mial {0} lat",wiek +1 );

// zadanie5
// Console.Write("Ile km do celu? ");
// int km = int.Parse(Console.ReadLine());
// Console.Write("Ile bedziesz jechac km codziennie? ");
// int kmd = int.Parse(Console.ReadLine());
// int dni = km/kmd;
// Console.WriteLine("Ty pszyjedzisz za {0} dni",dni );


// zadanie6
// Console.Write("Ile masz miedzianych? ");
// int mied = int.Parse(Console.ReadLine());
// Console.Write("Ile masz srebnych? ");
// int sr = int.Parse(Console.ReadLine());
// Console.Write("Ile masz zlotych? ");
// int zlota = int.Parse(Console.ReadLine());

// int miedzianych = zlota *100 + sr*10 + mied;
// Console.WriteLine($"Masz {miedzianych} miedzianych");


// zadanie7
// Console.Write("Ile chcesz mikstur? ");
// int mikst = int.Parse(Console.ReadLine());
// int krysz = mikst * 3;
// int ziol = mikst *2;
// Console.WriteLine($"ziola - {ziol} ");
// Console.WriteLine($"krysztaly - {krysz} ");


// zadanie8
// Console.Write("Ile kosztuje nocleg? ");
// decimal cena = decimal.Parse(Console.ReadLine());
// Console.Write("Ile chcesz nocy? ");
// int ilnoc = int.Parse(Console.ReadLine());
// decimal koszt = cena * ilnoc;
// Console.WriteLine($"koszty - {koszt} ");


// zadanie9
// Console.Write("Ile sekund? ");
// int ilsek = int.Parse(Console.ReadLine());
// int min = ilsek / 60;
// int sekp = ilsek % 60;
// Console.WriteLine($"to jest - {min} minut i {sekp} sekund ");


// zadanie10
// Console.Write("Ile monet? ");
// int ilmon = int.Parse(Console.ReadLine());
// Console.Write("Ile bohaterow? ");
// int ilboh = int.Parse(Console.ReadLine());
// int mon = ilmon / ilboh;
// int resz = ilmon % ilboh;
// Console.WriteLine($"to jest na kazdego - {mon} monet i zostalo {resz} monet ");


// zadanie11
// Получите базовый урон оружия и бонус к силе. Рассчитайте урон от обычной атаки как сумму обоих значений, 
// урон от специальной атаки как удвоенный урон от обычной атаки, а также суммарный урон от трех обычных атак и одной специальной атаки. 
// Просмотрите все этапы расчета в удобном для чтения отчете.

// Console.Write("weapon damage? ");
// int wdamage = int.Parse(Console.ReadLine());
// Console.Write("damage bonus? ");
// int bonus = int.Parse(Console.ReadLine());
// int damage = wdamage + bonus;
// int bd = damage*2;
// int mbg = damage*3 + bd;
// Console.WriteLine($"damage = {damage} bonus damage = {bd} mega bonus damage = {mbg}");
// Console.WriteLine($"damage = {wdamage} + {bonus}");
// Console.WriteLine($"bonus damage = {damage} * 2");
// Console.WriteLine($"mega bonus damage = {damage} * 3 + {damage} * 2");


// zadanie12




// zadanie+++

// Console.Write("Imie ");
// string name = Console.ReadLine();
// int HP = 300;
// int damage = 50;
// decimal gold = 100;
// int crit = damage *3;



// Console.WriteLine("+==========================+");
// Console.WriteLine("|       MMO PRG 2          |");
// Console.WriteLine("+--------------------------+");
// Console.WriteLine($"| Imię: {name}          |");
// Console.WriteLine("+--------------------------+");
// Console.WriteLine($"| HP: {HP}                  |");
// Console.WriteLine($"| Damage: {damage}               |");
// Console.WriteLine($"| Gold: {gold}                |");
// Console.WriteLine("+--------------------------+");
// Console.WriteLine($"| Critical damage: {crit}     |");
// Console.WriteLine("+==========================+");

// LAB 2
//zad 1

// Console.Write("Imie ");
// string name = Console.ReadLine();
// Console.Write("Symbol na mapie  ");
// char symb = char.Parse(Console.ReadLine());
// Console.Write("Poziom doswiadczenia ");
// int dos = int.Parse(Console.ReadLine());
// Console.Write("Ile monet? ");
// int gold = int.Parse(Console.ReadLine());
// Console.Write("Waga plecaka ");
// double waga = double.Parse(Console.ReadLine());
// Console.Write("Czy ma mape? t/f ");
// bool map = bool.Parse(Console.ReadLine());

// Console.WriteLine("=== EKWIPUNEK ===");
// Console.WriteLine($"Imię (string): {name}");
// Console.WriteLine($"Symbol (char): {symb}");
// Console.WriteLine($"Poziom (int): {dos}");
// Console.WriteLine($"Złoto (int): {gold}");
// Console.WriteLine($"Waga (double): {waga}");
// Console.WriteLine($"Ma mapę (bool): {map}");

//zad 2

// int dos = 40;
// int gold = 15;
// int tren = 0;
// dos += 25;
// dos *=2;
// gold -=8;
// gold +=15;
// tren ++;
// Console.WriteLine($"Złoto: {gold}");
// Console.WriteLine($"Dos: {dos}");
// Console.WriteLine($"Tren: {tren}");

//zad3

// Console.Write("liczbę racji żywnościowych ");
// double rac = double.Parse(Console.ReadLine());
// Console.Write("liczbę członków drużyny ");
// double cz = double.Parse(Console.ReadLine());
// Console.Write("liczbę dni wyprawy ");
// int dni = int.Parse(Console.ReadLine());
// int rac1 = (int)(rac / cz);
// Console.WriteLine($"1: {rac1}");
// int rac2 = (int)(rac % cz);
// Console.WriteLine($"2: {rac2}");
// double rac3 = rac / dni;
// Console.WriteLine($"3: {rac3}");
// double rac4 = rac3 / cz;
// Console.WriteLine($"4: {rac4}");

//zad4

// Console.Write("HP ");
// int hp = int.Parse(Console.ReadLine());
// Console.Write("liczbę mikstur ");
// int mik = int.Parse(Console.ReadLine());
// Console.Write("Czy ma Klucz? t/f ");
// bool key = bool.Parse(Console.ReadLine());
// Console.Write("Czy ma mape? t/f ");
// bool map = bool.Parse(Console.ReadLine());

// bool zyje = hp > 0;
// bool mp = hp > 99;
// bool wl = !mp;
// bool mz = mik > 0;
// bool mpn = key || map;
// bool got = zyje && mz && mpn;
// Console.WriteLine($"Żyje: {zyje}");
// Console.WriteLine($"Ma pełne zdrowie: {mp}");
// Console.WriteLine($"Wymaga leczenia: {wl}");
// Console.WriteLine($"Ma zaopatrzenie: {mz}");
// Console.WriteLine($"Ma klucz lub mapę: {mpn}");
// Console.WriteLine($"Gotowy do wyprawy: {got}");

//zad5

// Console.Write("Imie ");
// string name = Console.ReadLine();
// Console.Write("maksymalne punkty życia ");
// int maxhp = int.Parse(Console.ReadLine());
// Console.Write("aktualne punkty życia przed walką ");
// int hp = int.Parse(Console.ReadLine());
// Console.Write("podstawowe obrażenia broni ");
// int damage = int.Parse(Console.ReadLine());
// Console.Write("premię do siły ");
// int bdamage = int.Parse(Console.ReadLine());
// Console.Write("mnożnik ataku specjalnego ");
// double xcrit = double.Parse(Console.ReadLine());
// Console.Write("liczbę wykonanych zwykłych ataków ");
// int xatack = int.Parse(Console.ReadLine());

// int damage1 = damage + bdamage;
// int crit = (int)(damage1 * xcrit);
// int alld = damage1 * xatack + crit;
// double hp1 = hp;
// bool zyje = hp > 0;
// bool mp = hp > 99;


// Console.WriteLine("========== RAPORT Z WALKI ==========");
// Console.WriteLine($"Bohater: {name}");
// Console.WriteLine($"Zdrowie: {hp1}%");
// Console.WriteLine($"Zwykły atak: {damage1}");
// Console.WriteLine($"Atak specjalny: {crit}");
// Console.WriteLine($"Łączne zadane obrażenia: {alld}");
// Console.WriteLine($"Żyje: {zyje}");
// Console.WriteLine($"Pełne zdrowie: {mp}");
// Console.WriteLine("====================================");


//zad6

// Console.Write("Imie ");
// string name = Console.ReadLine();
// Console.Write("maksymalne punkty życia ");
// int maxhp = int.Parse(Console.ReadLine());
// Console.Write("aktualne punkty życia przed walką ");
// int hp = int.Parse(Console.ReadLine());
// Console.Write("podstawowe obrażenia broni ");
// int damage = int.Parse(Console.ReadLine());
// Console.Write("premię do siły ");
// int bdamage = int.Parse(Console.ReadLine());
// Console.Write("mnożnik ataku specjalnego ");
// double xcrit = double.Parse(Console.ReadLine());
// Console.Write("liczbę wykonanych zwykłych ataków ");
// int xatack = int.Parse(Console.ReadLine());
// Console.Write("Ile monet? ");
// int gold = int.Parse(Console.ReadLine());
// Console.Write("Miejscje zajete w plecaku ");
// int waga = int.Parse(Console.ReadLine());
// Console.Write("Czy ma mape? t/f ");
// bool map = bool.Parse(Console.ReadLine());


// int bp = 10;
// int wolne = bp - waga;
// int damage1 = damage + bdamage;
// int crit = (int)(damage1 * xcrit);
// int alld = damage1 * xatack + crit;
// double hp1 = hp/100*100;
// bool zyje = hp > 0;
// bool mp = hp > 99;
// bool wl = !mp;

// Console.WriteLine("+==========================+");
// Console.WriteLine("|       MMO PRG 2          |");
// Console.WriteLine("+--------------------------+");
// Console.WriteLine($"|Bohater: {name}        |");
// Console.WriteLine($"|Zdrowie: {hp1}%             |");
// Console.WriteLine($"|Zwykły atak: {damage1}           |");
// Console.WriteLine($"|Atak specjalny: {crit}        |");
// Console.WriteLine($"|Łączne  obrażenia: {alld}    |");
// Console.WriteLine("+--------------------------+");
// Console.WriteLine($"|Złoto: {gold}                 |");
// Console.WriteLine($"|plecak: {waga}/{bp}              |");
// Console.WriteLine($"|Wolne miejsca: {wolne}          |");
// Console.WriteLine("+--------------------------+");
// Console.WriteLine($"|Żyje: {zyje}                |");
// Console.WriteLine($"|Pełne zdrowie: {mp}       |");
// Console.WriteLine($"|Ma klucz lub mapę: {map}   |");
// Console.WriteLine($"|Wymaga leczenia: {wl}    |");
// Console.WriteLine("+==========================+");


// LAB 3
// zad1

// Console.Write("Podaj liczbę: ");
// int liczba = int.Parse(Console.ReadLine());

// if (liczba % 2 == 0)
//     Console.Write("Liczba jest parzysta ");
// else
//     Console.Write("Liczba nie jest parzysta ");


//zad2

// Console.Write("Podaj kierunek: ");
// string strona = Console.ReadLine();
// switch (strona?.ToLower())
//         {
//             case "polnoc":
//                 Console.WriteLine("Idziesz na północ.");
//                 break;
//             case "poludnie":
//                 Console.WriteLine("Idziesz na południe.");
//                 break;
//             case "wschod":
//                 Console.WriteLine("Idziesz na wschód.");
//                 break;
//             case "zachod":
//                 Console.WriteLine("Idziesz na zachód.");
//                 break;
//             default:
//                 Console.WriteLine("Nieznany kierunek!");
//                 break;
//         }


//zad3

// Console.Write("Podaj wiek: ");
// int liczba = int.Parse(Console.ReadLine());
// if (liczba <= 0)
//     Console.Write("liczba nie poprawna ");
// else if (liczba < 12)
//     Console.Write("dziecko ");
// else if (liczba < 17)
//     Console.Write("nastolatek ");
// else if (liczba < 64)
//     Console.Write("osoba dorosła ");
// else
//     Console.Write("senior ");

//zad4

// Console.Write("HP ");
// int hp = int.Parse(Console.ReadLine());
// Console.Write("Czy ma klucz? t/f ");
// bool key = bool.Parse(Console.ReadLine());
// Console.Write("Czy zna haslo? t/f ");
// bool passw = bool.Parse(Console.ReadLine());

// if (hp <= 0)
//     Console.Write("nie zyje ");
// else if (hp >= 0 && key || passw)
//     Console.Write("moze ");
// else 
//     Console.Write("nie moze ponieważ nie ma sposobu otwarcia drzwi.");


//zad6

Console.Write("Imie ");
string name = Console.ReadLine();
Console.Write("maksymalne punkty życia ");
int maxhp = int.Parse(Console.ReadLine());
Console.Write("aktualne punkty życia przed walką ");
int hp = int.Parse(Console.ReadLine());
Console.Write("podstawowe obrażenia broni ");
int damage = int.Parse(Console.ReadLine());
Console.Write("premię do siły ");
int bdamage = int.Parse(Console.ReadLine());
Console.Write("mnożnik ataku specjalnego ");
double xcrit = double.Parse(Console.ReadLine());
Console.Write("liczbę wykonanych zwykłych ataków ");
int xatack = int.Parse(Console.ReadLine());
Console.Write("Ile monet? ");
int gold = int.Parse(Console.ReadLine());
Console.Write("Miejscje zajete w plecaku ");
int waga = int.Parse(Console.ReadLine());
Console.Write("Liczba miksturek ");
int heal = int.Parse(Console.ReadLine());
Console.Write("Czy ma mape? t/f ");
bool map = bool.Parse(Console.ReadLine());


int bp = 10;
int wolne = bp - waga;
int damage1 = damage + bdamage;
int crit = (int)(damage1 * xcrit);
int alld = damage1 * xatack + crit;
double hp1 = hp/100*100;
bool zyje = hp > 0;
bool mp = hp > 99;
bool wl = !mp;






Console.WriteLine("+==========================+");
Console.WriteLine("|       MMO PRG 2          |");
Console.WriteLine("+--------------------------+");
Console.WriteLine($"|Bohater: {name}        |");
Console.WriteLine($"|Zdrowie: {hp1}%/{maxhp}%             |");
Console.WriteLine($"|Zwykły atak: {damage1}           |");
Console.WriteLine($"|Atak specjalny: {crit}        |");
Console.WriteLine($"|Łączne  obrażenia: {alld}    |");
Console.WriteLine("+--------------------------+");
Console.WriteLine($"|Złoto: {gold}                 |");
Console.WriteLine($"|plecak: {waga}/{bp}              |");
Console.WriteLine($"|Wolne miejsca: {wolne}          |");
Console.WriteLine("+--------------------------+");
Console.WriteLine($"|Żyje: {zyje}                |");
Console.WriteLine($"|Pełne zdrowie: {mp}       |");
Console.WriteLine($"|Ma klucz lub mapę: {map}   |");
Console.WriteLine($"|Wymaga leczenia: {wl}    |");
Console.WriteLine("+--------------------------+");
Console.Write("|1.status hp  | \n|2.wyprawa    | \n|3.heal me    | \n|4.exit     |\n");
Console.Write("|wybieraj:    ");
int menu = int.Parse(Console.ReadLine());
Console.WriteLine("+==========================+");


switch (menu) 
{
  case 1:
        if (hp<30 && hp >0)
            Console.Write("prawie nie zyje ");
        else if (hp<70)
            Console.Write("heal me ");
        else 
            Console.Write("full hp ");
    break;
  case 2:
        string result = (hp >25 && map) ? "moze." : "ie moze.";
        Console.WriteLine(result); 
    break;
  case 3:
            Console.Write("1.heal me \n 2.exit\n");
            Console.Write("wybieraj:  ");
            int menu_heal = int.Parse(Console.ReadLine());
        switch (menu_heal) 
        {
            case 1:
                if (heal>0){
                    heal-=1;
                    hp+=20;
                    Console.WriteLine($"Zdrowie: {hp}%");
                    Console.WriteLine($"Liczba miskut: {heal}");
                    }
                else
                    Console.Write("nie masz mistur");
            break;
            case 2:
                Console.Write("exit");
            break;
        }
    break;
  case 4:
        Console.Write("exit");
    break;
}