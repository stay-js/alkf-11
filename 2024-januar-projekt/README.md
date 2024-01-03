# Asztali Projekt

## Adatok generálása

```bash
cd rust && cargo run --bin generate_data && cd ..
```

## Adatok másolása a C# projektbe

```bash
cp rust/adatok.csv csharp/AsztaliProjekt/adatok.csv
```

## Leírás

Az `adatok.csv` állomány 250 tanuló nevét és jegyeit tartalmazza. A tanulók nevei és jegyei véletlenszerűen generáltak. Az állományban található adatok pontosvesszővel vannak elválasztva. A sorok első oszlopa a tanulók neveit, a többi oszlop pedig a tanulók jegyeit tartalmazza az alábbi sorrendben: magyar, matematika, történelem, angol, informatika.

## Feladatok

### 1. feladat

Olvassa be az `adatok.csv` állományt és tárolja a megfelelő adatszerkezetben.

### 2. feladat

Irassa ki, hogy hány tanuló adatait tartalmazza az állomány.

### 3. feladat

Irassa ki a tanulók nevét és átlagát (két tizedesjegyre kerekítve).

### 4. feladat

Irassa ki a legalacsonyabb átlaggal rendelkező tanuló nevét.

### 5. feladat

Irassa ki a legmagasabb átlaggal rendelkező tanuló nevét.

### 6. feladat

Irassa ki a tantárgyánkénti átlagot (két tizedesjegyre kerekítve).

### 7. feladat

Irassa ki, hogy hány jeles érdemjegyet szereztek a tanulók.

### 8. feladat

Irassa ki, hogy tantárgyanként hány átlag feletti érdemjegyet szereztek a tanulók.

### 9. feladat

Irassa ki, hogy hány olyan tanuló van, aki jobb érdemjegyet szerzett matematikából, mint az előtte álló.

### 10. feladat

Irassa ki azon tanulók nevét, akik rendelkeznek a felhasználó által megadott érdemjeggyel.

### 11. feladat

Irassa ki azon tanulók nevét, jegyeit és átlagát, akik megbuktak legalább egy tantárgyból.

<br>
<br>

Készítette: **Nagy Zétény 11.a (SZTF1)**
