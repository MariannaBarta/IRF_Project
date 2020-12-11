Megvalósítandó projekt: a Mikulás zenei listája

Feldolgozott tételek:
- XML feldolgozás
- Unit Test megvalósítása (int, string, bool - min. 3 teszteset)
- Írás CSV fájlba
- Timer használata

Karácsonyi ajándékozást segítő lista készítéső program, amellyel könnyedén összeállíthatjuk, hogy melyik zeneszerető ismerősünknek milyen zenei albumot szeretnénk ajánédkozni karácsonyra.

A proram részei:
- a boltok polcain található zenei albumok adatait egy XML fájlból töltjük be egy DataGridView-ba
- a megajándékozandó személyekről külön listát készítünk egy másik DataGridView-ba
- a megajándékozandó személyek alapvető adatait listában tároljuk (nincs mógöttes adatbázis)
- a személyes adatainak helyességét ellenőrizzük (Regex) - és itt a megfelelő validációt Unit Testtel ellenőrizzük
- a személyek adatainak bevitelét követően a két DataGridView elemei egymáshoz rendelhetők
- az így elkészített ajándékozási lista külön gombbal .csv fájlba menthető
- az alkalmazásban van egy CD ajánló felület is, ahol bizonyos időközönként (timer) új, random zenei album alapadatai jelennek meg