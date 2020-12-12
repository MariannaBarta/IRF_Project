Készítő: Barta Marianna
Neptun-kód: DCWC5L
Megvalósítandó projekt: a Mikulás zenei listája

Feldolgozott tételek:
- XML feldolgozás
- Unit Test megvalósítása (int, string, bool - min. 3 teszteset)
- Írás CSV fájlba
- Timer használata

Részletes leírás:
Karácsonyi ajándékozást segítő lista készítéső program, amellyel könnyedén összeállíthatjuk, hogy melyik zeneszerető ismerősünknek milyen zenei albumot szeretnénk ajánédkozni karácsonyra.

A programra betöltendő XML fájl:
A Solution mappájában ott van a betöltendő XML fájl: cd_catalog.xml

A program részei:
- a boltok polcain található zenei albumok adatait egy XML fájlból töltjük be egy DataGridView-ba a Tallózás gombot megnyomva külön ablakban (OpenFileDialogue)
- a megajándékozandó személyekről külön listát készítünk a megfelelő adatmezők feltöltésével egy másik DataGridView-ba
- a megajándékozandó személyek alapvető adatait listában (BindingList) tároljuk (nem használunk mögöttes adatbázis)
- a bevitt személyes adatok helyességét ellenőrizzük (Regex) - Unit Testtel ellenőrizzük, hogy biztos megfelelő legyen a validációs és regisztrációs metódus (összesen 4 teszt)
- a személyek adatainak bevitelét követően a két DataGridView elemei egymáshoz rendelhetők az erre szolgáló gomb megnyomásával (ennek az összerendelésnek az alapját egy másik BindingList képezi)
- az így elkészített ajándékozási lista külön gombbal .csv fájlba menthető
- az alkalmazásban van egy CD ajánló felület is, ahol a zenei lista betöltését követően 5 másodpercenként (timer) új, random zenei album alapadatai jelennek meg

Regex infók az adatbevitelhez:
a) Teljes név:
- angol ABC betűi
- egy vezetéknév + egy keresztnév (min. 3-3 karakter), közöttük szóköz
- a szavak kezdődjenek nagybetűvel
b) Becenév:
- csak az angol ABC beűit tartalmazza
- kezdődhet kis és nagy betűvel is
- legalább 3 karakter
c) E-mail:
- szokásos e-mail validációs szabályok (pl. nincs ékezetes karakter, de van @ jel és .)

Program részletes felépítése:

IRF_Project_DCWC5L-en belül

A)
Abstractions mappa
a)
IAccountManager:
- interfész
- ez alatt Account-hoz BindingList + CreateAccount metódus (még nincs kifejtve)

B) Entities mappa (az interfész és a Form1 kivételével minden osztály ebben van)
a)
AccountManager:
- az őse az IAccountManager interfész
- interfészhez illeszkedve Accounts lista + CreatAccount függvény kifejtve
- azonos iTunes fiókkal csak 1 megajándékozandó személy regisztrálható
b)
AccountController:
- tárolja az AccountManager egy példányát
- itt van a megajándékozott személyek regisztrációját kezelő Register függvény (3 validációnak kell megfelelni a sikeres regisztrációhoz)
- itt van kifejtve a 3 validációs metódus is (Regex részletek fentebb)
c)
Account:
- a megajándékozott személyeket reprezentáló osztály
d)
CDInfo:
- a zenei albumokat reprezentáló osztály
e)
PresentList:
- az egymáshoz rendelt (személy + ajándék) párokat reprezentáló osztály

C) Form1:
- BindingList-ek és AccountController példányosítása
- a Form1 inicializálását követően betöltődnek a képek és a DataGridView-k tartalmai
- XML megnyitás: Tallózás = buttonOpenFile_Click meghívja a betoltes() metódust
- betöltés metódus külön ablakban (OpenFileDialogue) teszi lehetővé az XML fájl megnyitását, az így megkapott elérési utat használva hívja meg az XmlDocument Load metódusát, és egy foreach cilkusban valamennyi XmlElement-et beolvassa a BindingListbe, végül elindítja a Timert
- Hozzáadás... gomb= ButtonAddList_Click metódusa elvégzi a bevitt, megajándékozott személyre vonatkozó adatok regisztrációját, ha a regisztráció sikeres, ha beviteli mezőket törli, ha nem, a validációs metódusoknak megfelelően hibaüzenetet ad vissza
- Timer => timerRandomCD_Tick esemény: random ajándék ajánló funkció, amely 5 másodpercenként új zenei albumra hívja fel a felhasználó figyelmét, a timer akkor indul, mikor betöltjük a zenei albumok adatait tartalmazó listát (korábban nem lenne megjeleníthető adat), az adatokat egy RichTextBoxban, középre igazítva jeleníti meg
- Lista mentés = buttonSaveList_Click : a gomb megnyomásával az elkészített ajándéklistát .csv fájlként menti el fejléccel együtt (SaveFileDialogue using StreamWriter)
- Ajándék és személy egymáshoz rendelése = buttonAddPresent_Click: a 2 DataGridView (album + személy) kiválasztott sorait egy közös BindingListhez adja, amely egy 3. DataGridView-ban jelenik meg (így azonnal ellenőrizhető, hogy sikeres volt-e az összerendelés)

D) Images mappa:
- program logója és zenei album ikon van itt tárolva, ezeket a Properties Settings beállításain keresztül kötöttem a Form1-hez

UnitTestAccountProjecten belül

a)
AccountControllerTestFixture:
- az AccountControllerhez megírt Unit Testeket tartalmazza
- telepített tesztcsomagok: NUnit, NUnit3TestAdapter, Moq (és függőségei)
- a 3 validációs metódusra + a Register függvényre készítettem teszteket
- futtatásnál minden teszt a tesztesetekben megadott, várt eredményt adta, tehát megfelelően működik a regisztrálás és a validáció


