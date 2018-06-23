# A NetAcademia "Bevezetés az objektumorientált világba: a SNAKE projekt" tanfolyamának ismétlése

## A Snake játék programozása

### 0. Feladat Előkészületek
- [ ] Bejelentkezni a GitHub-ra
- [ ] Létrehozni egy új Repót
- [ ] Klónozni a gápre rögtön kinyitva VS2017-ben
  - [ ] Pontosítani a local Repó helyét a gépen 
  - [ ] Létrehozni egy áj Solutiont a  Snake201806 néven
  - [ ] Bezárni a VS-t
- [ ] Újra megnyitni magát a Solutiont
- [ ] Belinkelni a ReadMe fájlt a Solution-be (Add Existing ... Add As a link)

### A játék szabályai

- egy kígyót irányítunk úgy, hogy a fejének az irányát szabjuk, a kígyó követi a fejét.
- a játékterületen megjelennek ételek, ezeket a kígyónak meg kell ennie.
- a játék célja az, hogy minél több ételt megegyünk.
- a játék vége akkor következik be, ha
  - nekimegyünk a falnak
  - beleütközünk a saját fakunkba
- minél több ételt eszünk meg, a kígyó
  - annál hosszabb
  - annál gyorsabb

### A játék képernyői
 
``` 
+-------------------------------------------+
|                                           |
|   A játékszabályokat megjelenítjük az     |
|   indulásig                               |
|                                           |
|                                           |
|                                           |
|                                           |
|                                           |
|                                           |
|                                           |
|                    ++                     |
|                    ++                     |
|                                           |
|                                           |
|                                           |
|                                           |
|                                           |
|                                           |
|                                           |
|                                           |
|                                           |
|                                           |
|                                           |
+-------------------------------------------+
```
Játék közben
```
           +-------------------------------------------+
           |                                           |
           |                                           |
Étel       |             +--------------------+        |  A háttérben a játékinformációk
           |             |                    |        |  áttetsző betűkkel, nem zavaró
     +------->  ++       |                    |  <--------módon------+
           |    ++       |                    |        |  A megjelenítéskor animálhatjuk is
           |             |                    |        |
           |             +--------------------+        |
           |                                           |
           |                                           |
           |                    ^^                     |
           |                    ||                     |
           |                    ||                     |    Kígyó
           |                    ||                     |
           |                    ||  <---------------------------+
           |                    ||                     |
           |                    ||                     |
           |                    ++                     |
           |                                           |
           |                                           |
           |                                           |
           |                                           |
           |                                           |
           +-------------------------------------------+
``` 

Záróképernyő

```
+-----------------------------------+
|                                   |
|                                   |
|                                   |
|                                   |
|                                   |
|     A játékinformációk            |
|     megjelenítése                 |
|     - játék időtartama            |
|     | kígyó hossza                |
|     - megevett ételek             |
|     . top 5 eredménylista         |
|                                   |
|                                   |
|                                   |
|                                   |
|                                   |
|                                   |
|                                   |
|                                   |
|                                   |
+-----------------------------------+
```

##Vázlat az alkalmazás felépítéséhez

Az alkalmazásunk felépítése a következő 

```
  Képernyő (View)                                 Alkalmazás logika (Model)
+---------------------------------------+       +-----------------------------------+
|                                       |       |                                   |
|  A megjelenítést végzi, illetve       |       |   A feladata a játékmenethez      |
|  a felhasználó vezérlését fogadja.    |       |   szükséges tudás birtoklása      |
|                                       | +---> |   Fontos, hogy célunk szerint     |
|                                       |       |   nem tudja, hogy a megjelenítés  |
|                                       | <---+ |   pontosan mi.                    |
|                                       |       |   (Ezt nem tudjuk maradéktalanul  |
|                                       |       |   megoldani a jelenlegi           |
|                                       |       |   tudásunkkal, de egy nagy        |
|                                       |       |   lépést teszünk ebbe az irányba  |
|                                       |       |                                   |
|                                       |       |                                   |
|                                       |       |                                   |
|                                       |       |                                   |
|                                       |       |                                   |
|                                       |       |                                   |
|                                       |       |                                   |
|                                       |       |                                   |
+---------------------------------------+       +-----------------------------------+
```
### 1. Feladat
- [ ] elkészíteni a képernyőt (View: MainWindows.xaml)
  - [ ] tudnia kell megjeleníteni a kígyó fejét
    - [ ] ehhez kell a játéktábla
      - [ ] meg kell tudni jeleníteni a megevett ételek számát
      - [ ] Opcionálisan
        - [ ] meg kell tudni jeleníteni az eltelt időt (Házi feladat)
        - [ ] meg kell tudni jeleníteni a kígyó hosszát (Házi feladat)
  - [ ] tudnia kell megjeleníteni a játékszabályokat
  - [ ] tudnia kell elkapni a felhasználó vezérlőparancsait (billentyűleütések), és továbbítni a Model felé.
- [ ] elkészíteni az alkalmazáslogikát (Model)
  - [ ] tudnia kell átvenni a billentyűparancsokat
  - [ ] tudnia kell elindítani a játékmenetet 
    - [ ] el kell tudnia tüntetni a játékszabályokat
- [ ] ezt a két réteget összekötni


### 2. Feladat
Játékmenet programozása
- [ ] a kígyó megy amerre irányítjuk
- [ ] ha ütközik a fallal vége a játéknak
- [ ] ha ütközik magával vége a játéknak



### 1. Házi feladat 
- meg kell tudni jeleníteni az eltelt időt
- meg kell tudni jeleníteni a kígyó hosszát
- elgondolkodni az ütközések programozásáról
- csatlakozás a DotNet cápákhoz a [facebookon](https://www.facebook.com/groups/dotnetcapak/)
