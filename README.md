# Fr�gor och Svar:
## Fr�ga 1: Hur fungerar stacken och heapen? F�rklara g�rna med exempel eller skiss p� dess grundl�ggande funktion 
## Svar: 
### Stacken och heapen �r tv� olika minnesomr�den som anv�nds av program f�r att hantera data.

Stacken fungerar som en "last in, first out" (LIFO) struktur d�r variabler lagras i ordning och tas bort i omv�nd ordning. Varje g�ng en funktion anropas, reserveras minne p� stacken f�r dess lokala variabler, och n�r funktionen �r klar frig�rs minnet. Stacken �r snabb men har begr�nsad storlek.

#### Exempel:
N�r du anropar en funktion som anv�nder en heltalsvariabel, lagras denna p� stacken. N�r funktionen avslutas frig�rs variabeln.

Heapen �r ett st�rre minnesomr�de d�r objekt lagras dynamiskt. Till skillnad fr�n stacken frig�rs minnet h�r f�rst n�r det inte l�ngre anv�nds (t.ex. genom "garbage collection"). Heapen �r mer flexibel men l�ngsammare eftersom minneshantering �r mer komplex.

#### Exempel:
N�r du skapar ett objekt via nyckelordet new i m�nga spr�k, allokeras minnet f�r objektet p� heapen och en referens till det sparas p� stacken.

## Fr�ga 2:  Vad �r Value Types respektive Reference Types och vad skiljer dem �t?
## Svar: 

### Value Types och Reference Types �r tv� kategorier av datatyper som skiljer sig �t i hur de lagras och �verf�rs.

Value Types lagrar v�rden direkt och finns p� stacken. N�r en value type tilldelas eller kopieras �verf�rs sj�lva v�rdet.

#### Exempel:
int, float, och bool �r value types. Om du tilldelar en int till en annan, kopieras sj�lva v�rdet.

Reference Types lagrar en referens till ett objekt p� heapen. N�r en reference type tilldelas eller kopieras, �verf�rs bara en referens, inte sj�lva objektet.

#### Exempel:
class, array, och string �r reference types. Om du kopierar ett objekt av dessa typer, pekar b�da referenserna p� samma objekt i heapen.


## Fr�ga 3:  F�ljande metoder (se bild nedan) genererar olika svar. Den f�rsta returnerar 3, den andra returnerar 4, varf�r?  
## Svar:
Den f�rsta metoden returnerar 3, tyder det p� att den arbetar med en Value Type. 
Den andra metoden returnerar 4, tyder det p� att den arbetar med en Reference Type.

## Fr�ga 4: Utg� ifr�n era nyvunna kunskaper om iteration, rekursion och minneshantering. Vilken av ovanst�ende funktioner �r mest minnesv�nlig och varf�r?  
## Svar:
Iteration �r mer effektiv n�r det g�ller minnesanv�ndning, eftersom den inte skapar nya stackanrop f�r varje iteration.


# �vningar P� papper

# �vning 2.1
## Steg f�r simulering av ICA k�n enlligt FIFO princip

Vi kommer att simulera en k� till en kassa p� f�ljande s�tt:

a. **ICA �ppnar och k�n till kassan �r tom:**
    - K�: `[]`
    - Ingen person i k�n.

b. **Kalle st�ller sig i k�n:**
    - K�: `[Kalle]`
    - Kalle �r f�rst i k�n.

c. **Greta st�ller sig i k�n:**
    - K�: `[Kalle, Greta]`
    - Kalle st�r f�rst, Greta st�r bakom.

d. **Kalle blir expedierad och l�mnar k�n:**
    - K�: `[Greta]`
    - Greta �r nu f�rst i k�n.

e. **Stina st�ller sig i k�n:**
    - K�: `[Greta, Stina]`
    - Greta st�r f�rst, Stina st�r bakom.

f. **Greta blir expedierad och l�mnar k�n:**
    - K�: `[Stina]`
    - Stina �r nu f�rst i k�n.

g. **Olle st�ller sig i k�n:**
    - K�: `[Stina, Olle]`
    - Stina st�r f�rst, Olle st�r bakom.

## Slutsats

Denna �vning demonstrerar hur en k� fungerar enligt FIFO-principen, d�r de som kommer f�rst blir expedierade f�rst. 
Jag simulerade stegvis vad som h�nder n�r personer st�ller sig i och l�mnar k�n. 
I verkligheten anv�nds k�er ofta i situationer d�r objekt m�ste hanteras i ordning, exempelvis i kassor eller vid n�tverkspaket.

---

# �vning 3.1
## Simulera ICA-k�n med en stack

I denna �vning simulerar vi ICA-k�n med en **stack** ist�llet f�r en k�. Vi unders�ker varf�r stacken inte �r ett bra alternativ f�r detta scenario.

## Kort om stackar

En stack �r en datastruktur som fungerar enligt **LIFO**-principen (Last In, First Out), vilket inneb�r att det senaste elementet som l�ggs till �r det f�rsta som tas bort. En stack kan illustreras som en h�g av tallrikar d�r du alltid l�gger p� en ny tallrik �verst och tar bort den �versta f�rst.

## Simulering av ICA-k�n med en stack

Vi simulerar ICA-k�n steg f�r steg:

a. **ICA �ppnar och k�n (stacken) �r tom:**
    - Stack: `[]`
    - Ingen person i k�n.

b. **Kalle st�ller sig i k�n:**
    - Stack: `[Kalle]`
    - Kalle �r f�rst in, och den enda i k�n.

c. **Greta st�ller sig i k�n:**
    - Stack: `[Kalle, Greta]`
    - Greta l�ggs ovanp� Kalle i stacken.

d. **Kalle blir expedierad och l�mnar k�n (problemet b�rjar h�r):**
    - Eftersom stacken f�ljer LIFO, m�ste vi ta bort **Greta** f�rst innan vi kan n� Kalle. Detta bryter mot det naturliga k�-beteendet (FIFO).
    - Stack: `[Kalle]`
    
    **Resultat:** Greta, som kom in efter Kalle, m�ste tas bort f�rst, vilket inte st�mmer med hur en k� ska fungera.

d. **Stina st�ller sig i k�n:**
    - Stack: `[Kalle, Stina]`
    - Stina l�ggs ovanp� Kalle.

e. **Greta blir expedierad (fanns egentligen inte kvar), men vi forts�tter simuleringen �nd�:**
    - Nu skulle Stina tas bort innan Kalle, vilket inte �r korrekt enligt en k�-logik.

## Slutsats

### Varf�r �r det inte smart att anv�nda en stack i detta fall?

Att anv�nda en stack f�r att simulera en k�, som fungerar enligt **FIFO**-principen (First In, First Out), �r inte l�mpligt eftersom stackar f�ljer **LIFO**-principen (Last In, First Out). Detta inneb�r att den senaste personen som st�llde sig i k�n skulle bli expedierad f�rst, vilket inte �verensst�mmer med verklighetens k�-beteende. I en k� m�ste den f�rsta personen som st�ller sig in ocks� vara den f�rsta som l�mnar, vilket en stack inte kan garantera.

---


# �vning 4.1
### V�lformad str�ng: `"({[]})"`

1. L�gg till �ppningssymboler p� stacken:  
   Stack: `[ ( , { , [ ]`
2. Hitta st�ngningssymboler och kontrollera matchning:
   - `]` matchar `[`, stacken blir: `[ ( , { ]`
   - `}` matchar `{`, stacken blir: `[ ( ]`
   - `)` matchar `(`, stacken blir: `[]`
3. Stacken �r tom efter hela str�ngen. **Str�ngen �r v�lformad**.

### Ej v�lformad str�ng: `"( [ ) ]"`

1. L�gg till �ppningssymboler p� stacken:  
   Stack: `[ ( , [ ]`
2. Hitta st�ngningssymboler och kontrollera matchning:
   - `)` matchar inte `[`, vilket g�r str�ngen ej v�lformad.

---


# �vning 5.1
## Illustrera f�rloppen f�r RecursiveOdd

### F�rlopp f�r RecursiveOdd(1)

**Ing�ng:** \( n = 1 \)

### Stegvis rekursion:

1. **F�rsta anropet:**  
   - \( n = 1 \), l�gg till 1 (f�rsta udda talet) och anropa `RecursiveOdd(0)`.

2. **Andra anropet:**  
   - \( n = 0 \), basfallet n�s och funktionen returnerar 0.

### Sammanst�llning av resultaten:
- \( \text{RecursiveOdd}(1) = 1 + 0 = 1 \)

**Resultat:**  
`RecursiveOdd(1) = 1`

---

## F�rlopp f�r RecursiveOdd(3)

**Ing�ng:** \( n = 3 \)

### Stegvis rekursion:

1. **F�rsta anropet:**  
   - \( n = 3 \), l�gg till 5 (tredje udda talet) och anropa `RecursiveOdd(2)`.

2. **Andra anropet:**  
   - \( n = 2 \), l�gg till 3 (andra udda talet) och anropa `RecursiveOdd(1)`.

3. **Tredje anropet:**  
   - \( n = 1 \), l�gg till 1 (f�rsta udda talet) och anropa `RecursiveOdd(0)`.

4. **Fj�rde anropet:**  
   - \( n = 0 \), basfallet n�s och funktionen returnerar 0.

### Sammanst�llning av resultaten:
- \( \text{RecursiveOdd}(1) = 1 + 0 = 1 \)
- \( \text{RecursiveOdd}(2) = 3 + 1 = 4 \)
- \( \text{RecursiveOdd}(3) = 5 + 4 = 9 \)

**Resultat:**  
`RecursiveOdd(3) = 9`

---

## F�rlopp f�r RecursiveOdd(5)

**Ing�ng:** \( n = 5 \)

### Stegvis rekursion:

1. **F�rsta anropet:**  
   - \( n = 5 \), l�gg till 9 (femte udda talet) och anropa `RecursiveOdd(4)`.

2. **Andra anropet:**  
   - \( n = 4 \), l�gg till 7 (fj�rde udda talet) och anropa `RecursiveOdd(3)`.

3. **Tredje anropet:**  
   - \( n = 3 \), l�gg till 5 (tredje udda talet) och anropa `RecursiveOdd(2)`.

4. **Fj�rde anropet:**  
   - \( n = 2 \), l�gg till 3 (andra udda talet) och anropa `RecursiveOdd(1)`.

5. **Femte anropet:**  
   - \( n = 1 \), l�gg till 1 (f�rsta udda talet) och anropa `RecursiveOdd(0)`.

6. **Sj�tte anropet:**  
   - \( n = 0 \), basfallet n�s och funktionen returnerar 0.

### Sammanst�llning av resultaten:
- \( \text{RecursiveOdd}(1) = 1 + 0 = 1 \)
- \( \text{RecursiveOdd}(2) = 3 + 1 = 4 \)
- \( \text{RecursiveOdd}(3) = 5 + 4 = 9 \)
- \( \text{RecursiveOdd}(4) = 7 + 9 = 16 \)
- \( \text{RecursiveOdd}(5) = 9 + 16 = 25 \)

**Resultat:**  
`RecursiveOdd(5) = 25`

---
# �vning 6.1

## IterativeOdd(1)

**Ing�ng:** \( n = 1 \)

### Iteration:
1. **S�tt summan till 0**.
2. Iterera fr�n 1 till \( n \) (i detta fall endast 1):
   - L�gg till det udda talet \( 1 \) till summan.

### Ber�kning:
Summa = 0 + 1 = 1

**Resultat:**  
`IterativeOdd(1) = 1`

---

## IterativeOdd(3)

**Ing�ng:** \( n = 3 \)

### Iteration:
1. **S�tt summan till 0**.
2. Iterera fr�n 1 till \( n \) (1, 2, 3):
   - L�gg till det f�rsta udda talet \( 1 \).  
     Summa = 0 + 1 = 1
   - L�gg till det andra udda talet \( 3 \).  
     Summa = 1 + 3 = 4
   - L�gg till det tredje udda talet \( 5 \).  
     Summa = 4 + 5 = 9

### Ber�kning:
Summa = 1 + 3 + 5 = 9

**Resultat:**  
`IterativeOdd(3) = 9`

---

## IterativeOdd(5)

**Ing�ng:** \( n = 5 \)

### Iteration:
1. **S�tt summan till 0**.
2. Iterera fr�n 1 till \( n \) (1, 2, 3, 4, 5):
   - L�gg till det f�rsta udda talet \( 1 \).  
     Summa = 0 + 1 = 1
   - L�gg till det andra udda talet \( 3 \).  
     Summa = 1 + 3 = 4
   - L�gg till det tredje udda talet \( 5 \).  
     Summa = 4 + 5 = 9
   - L�gg till det fj�rde udda talet \( 7 \).  
     Summa = 9 + 7 = 16
   - L�gg till det femte udda talet \( 9 \).  
     Summa = 16 + 9 = 25

### Ber�kning:
Summa = 1 + 3 + 5 + 7 + 9 = 25

**Resultat:**  
`IterativeOdd(5) = 25`

---

## Sammanfattning

H�r �r resultaten f�r olika v�rden av \( n \):

- \( \text{IterativeOdd}(1) = 1 \)
- \( \text{IterativeOdd}(3) = 9 \)
- \( \text{IterativeOdd}(5) = 25 \)

Denna process illustrerar hur funktionen arbetar genom att iterera �ver de f�rsta \( n \) udda talen och successivt summera dem.

---

