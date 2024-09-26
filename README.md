# Frågor och Svar:
## Fråga 1: Hur fungerar stacken och heapen? Förklara gärna med exempel eller skiss på dess grundläggande funktion 
## Svar: 
### Stacken och heapen är två olika minnesområden som används av program för att hantera data.

Stacken fungerar som en "last in, first out" (LIFO) struktur där variabler lagras i ordning och tas bort i omvänd ordning. Varje gång en funktion anropas, reserveras minne på stacken för dess lokala variabler, och när funktionen är klar frigörs minnet. Stacken är snabb men har begränsad storlek.

#### Exempel:
När du anropar en funktion som använder en heltalsvariabel, lagras denna på stacken. När funktionen avslutas frigörs variabeln.

Heapen är ett större minnesområde där objekt lagras dynamiskt. Till skillnad från stacken frigörs minnet här först när det inte längre används (t.ex. genom "garbage collection"). Heapen är mer flexibel men långsammare eftersom minneshantering är mer komplex.

#### Exempel:
När du skapar ett objekt via nyckelordet new i många språk, allokeras minnet för objektet på heapen och en referens till det sparas på stacken.

## Fråga 2:  Vad är Value Types respektive Reference Types och vad skiljer dem åt?
## Svar: 

### Value Types och Reference Types är två kategorier av datatyper som skiljer sig åt i hur de lagras och överförs.

Value Types lagrar värden direkt och finns på stacken. När en value type tilldelas eller kopieras överförs själva värdet.

#### Exempel:
int, float, och bool är value types. Om du tilldelar en int till en annan, kopieras själva värdet.

Reference Types lagrar en referens till ett objekt på heapen. När en reference type tilldelas eller kopieras, överförs bara en referens, inte själva objektet.

#### Exempel:
class, array, och string är reference types. Om du kopierar ett objekt av dessa typer, pekar båda referenserna på samma objekt i heapen.


## Fråga 3:  Följande metoder (se bild nedan) genererar olika svar. Den första returnerar 3, den andra returnerar 4, varför?  
## Svar:
Den första metoden returnerar 3, tyder det på att den arbetar med en Value Type. 
Den andra metoden returnerar 4, tyder det på att den arbetar med en Reference Type.

## Fråga 4: Utgå ifrån era nyvunna kunskaper om iteration, rekursion och minneshantering. Vilken av ovanstående funktioner är mest minnesvänlig och varför?  
## Svar:
Iteration är mer effektiv när det gäller minnesanvändning, eftersom den inte skapar nya stackanrop för varje iteration.


# Övningar På papper

# Övning 2.1
## Steg för simulering av ICA kön enlligt FIFO princip

Vi kommer att simulera en kö till en kassa på följande sätt:

a. **ICA öppnar och kön till kassan är tom:**
    - Kö: `[]`
    - Ingen person i kön.

b. **Kalle ställer sig i kön:**
    - Kö: `[Kalle]`
    - Kalle är först i kön.

c. **Greta ställer sig i kön:**
    - Kö: `[Kalle, Greta]`
    - Kalle står först, Greta står bakom.

d. **Kalle blir expedierad och lämnar kön:**
    - Kö: `[Greta]`
    - Greta är nu först i kön.

e. **Stina ställer sig i kön:**
    - Kö: `[Greta, Stina]`
    - Greta står först, Stina står bakom.

f. **Greta blir expedierad och lämnar kön:**
    - Kö: `[Stina]`
    - Stina är nu först i kön.

g. **Olle ställer sig i kön:**
    - Kö: `[Stina, Olle]`
    - Stina står först, Olle står bakom.

## Slutsats

Denna övning demonstrerar hur en kö fungerar enligt FIFO-principen, där de som kommer först blir expedierade först. 
Jag simulerade stegvis vad som händer när personer ställer sig i och lämnar kön. 
I verkligheten används köer ofta i situationer där objekt måste hanteras i ordning, exempelvis i kassor eller vid nätverkspaket.

---

# Övning 3.1
## Simulera ICA-kön med en stack

I denna övning simulerar vi ICA-kön med en **stack** istället för en kö. Vi undersöker varför stacken inte är ett bra alternativ för detta scenario.

## Kort om stackar

En stack är en datastruktur som fungerar enligt **LIFO**-principen (Last In, First Out), vilket innebär att det senaste elementet som läggs till är det första som tas bort. En stack kan illustreras som en hög av tallrikar där du alltid lägger på en ny tallrik överst och tar bort den översta först.

## Simulering av ICA-kön med en stack

Vi simulerar ICA-kön steg för steg:

a. **ICA öppnar och kön (stacken) är tom:**
    - Stack: `[]`
    - Ingen person i kön.

b. **Kalle ställer sig i kön:**
    - Stack: `[Kalle]`
    - Kalle är först in, och den enda i kön.

c. **Greta ställer sig i kön:**
    - Stack: `[Kalle, Greta]`
    - Greta läggs ovanpå Kalle i stacken.

d. **Kalle blir expedierad och lämnar kön (problemet börjar här):**
    - Eftersom stacken följer LIFO, måste vi ta bort **Greta** först innan vi kan nå Kalle. Detta bryter mot det naturliga kö-beteendet (FIFO).
    - Stack: `[Kalle]`
    
    **Resultat:** Greta, som kom in efter Kalle, måste tas bort först, vilket inte stämmer med hur en kö ska fungera.

d. **Stina ställer sig i kön:**
    - Stack: `[Kalle, Stina]`
    - Stina läggs ovanpå Kalle.

e. **Greta blir expedierad (fanns egentligen inte kvar), men vi fortsätter simuleringen ändå:**
    - Nu skulle Stina tas bort innan Kalle, vilket inte är korrekt enligt en kö-logik.

## Slutsats

### Varför är det inte smart att använda en stack i detta fall?

Att använda en stack för att simulera en kö, som fungerar enligt **FIFO**-principen (First In, First Out), är inte lämpligt eftersom stackar följer **LIFO**-principen (Last In, First Out). Detta innebär att den senaste personen som ställde sig i kön skulle bli expedierad först, vilket inte överensstämmer med verklighetens kö-beteende. I en kö måste den första personen som ställer sig in också vara den första som lämnar, vilket en stack inte kan garantera.

---


# Övning 4.1
### Välformad sträng: `"({[]})"`

1. Lägg till öppningssymboler på stacken:  
   Stack: `[ ( , { , [ ]`
2. Hitta stängningssymboler och kontrollera matchning:
   - `]` matchar `[`, stacken blir: `[ ( , { ]`
   - `}` matchar `{`, stacken blir: `[ ( ]`
   - `)` matchar `(`, stacken blir: `[]`
3. Stacken är tom efter hela strängen. **Strängen är välformad**.

### Ej välformad sträng: `"( [ ) ]"`

1. Lägg till öppningssymboler på stacken:  
   Stack: `[ ( , [ ]`
2. Hitta stängningssymboler och kontrollera matchning:
   - `)` matchar inte `[`, vilket gör strängen ej välformad.

---


# Övning 5.1
## Illustrera förloppen för RecursiveOdd

### Förlopp för RecursiveOdd(1)

**Ingång:** \( n = 1 \)

### Stegvis rekursion:

1. **Första anropet:**  
   - \( n = 1 \), lägg till 1 (första udda talet) och anropa `RecursiveOdd(0)`.

2. **Andra anropet:**  
   - \( n = 0 \), basfallet nås och funktionen returnerar 0.

### Sammanställning av resultaten:
- \( \text{RecursiveOdd}(1) = 1 + 0 = 1 \)

**Resultat:**  
`RecursiveOdd(1) = 1`

---

## Förlopp för RecursiveOdd(3)

**Ingång:** \( n = 3 \)

### Stegvis rekursion:

1. **Första anropet:**  
   - \( n = 3 \), lägg till 5 (tredje udda talet) och anropa `RecursiveOdd(2)`.

2. **Andra anropet:**  
   - \( n = 2 \), lägg till 3 (andra udda talet) och anropa `RecursiveOdd(1)`.

3. **Tredje anropet:**  
   - \( n = 1 \), lägg till 1 (första udda talet) och anropa `RecursiveOdd(0)`.

4. **Fjärde anropet:**  
   - \( n = 0 \), basfallet nås och funktionen returnerar 0.

### Sammanställning av resultaten:
- \( \text{RecursiveOdd}(1) = 1 + 0 = 1 \)
- \( \text{RecursiveOdd}(2) = 3 + 1 = 4 \)
- \( \text{RecursiveOdd}(3) = 5 + 4 = 9 \)

**Resultat:**  
`RecursiveOdd(3) = 9`

---

## Förlopp för RecursiveOdd(5)

**Ingång:** \( n = 5 \)

### Stegvis rekursion:

1. **Första anropet:**  
   - \( n = 5 \), lägg till 9 (femte udda talet) och anropa `RecursiveOdd(4)`.

2. **Andra anropet:**  
   - \( n = 4 \), lägg till 7 (fjärde udda talet) och anropa `RecursiveOdd(3)`.

3. **Tredje anropet:**  
   - \( n = 3 \), lägg till 5 (tredje udda talet) och anropa `RecursiveOdd(2)`.

4. **Fjärde anropet:**  
   - \( n = 2 \), lägg till 3 (andra udda talet) och anropa `RecursiveOdd(1)`.

5. **Femte anropet:**  
   - \( n = 1 \), lägg till 1 (första udda talet) och anropa `RecursiveOdd(0)`.

6. **Sjätte anropet:**  
   - \( n = 0 \), basfallet nås och funktionen returnerar 0.

### Sammanställning av resultaten:
- \( \text{RecursiveOdd}(1) = 1 + 0 = 1 \)
- \( \text{RecursiveOdd}(2) = 3 + 1 = 4 \)
- \( \text{RecursiveOdd}(3) = 5 + 4 = 9 \)
- \( \text{RecursiveOdd}(4) = 7 + 9 = 16 \)
- \( \text{RecursiveOdd}(5) = 9 + 16 = 25 \)

**Resultat:**  
`RecursiveOdd(5) = 25`

---
# Övning 6.1

## IterativeOdd(1)

**Ingång:** \( n = 1 \)

### Iteration:
1. **Sätt summan till 0**.
2. Iterera från 1 till \( n \) (i detta fall endast 1):
   - Lägg till det udda talet \( 1 \) till summan.

### Beräkning:
Summa = 0 + 1 = 1

**Resultat:**  
`IterativeOdd(1) = 1`

---

## IterativeOdd(3)

**Ingång:** \( n = 3 \)

### Iteration:
1. **Sätt summan till 0**.
2. Iterera från 1 till \( n \) (1, 2, 3):
   - Lägg till det första udda talet \( 1 \).  
     Summa = 0 + 1 = 1
   - Lägg till det andra udda talet \( 3 \).  
     Summa = 1 + 3 = 4
   - Lägg till det tredje udda talet \( 5 \).  
     Summa = 4 + 5 = 9

### Beräkning:
Summa = 1 + 3 + 5 = 9

**Resultat:**  
`IterativeOdd(3) = 9`

---

## IterativeOdd(5)

**Ingång:** \( n = 5 \)

### Iteration:
1. **Sätt summan till 0**.
2. Iterera från 1 till \( n \) (1, 2, 3, 4, 5):
   - Lägg till det första udda talet \( 1 \).  
     Summa = 0 + 1 = 1
   - Lägg till det andra udda talet \( 3 \).  
     Summa = 1 + 3 = 4
   - Lägg till det tredje udda talet \( 5 \).  
     Summa = 4 + 5 = 9
   - Lägg till det fjärde udda talet \( 7 \).  
     Summa = 9 + 7 = 16
   - Lägg till det femte udda talet \( 9 \).  
     Summa = 16 + 9 = 25

### Beräkning:
Summa = 1 + 3 + 5 + 7 + 9 = 25

**Resultat:**  
`IterativeOdd(5) = 25`

---

## Sammanfattning

Här är resultaten för olika värden av \( n \):

- \( \text{IterativeOdd}(1) = 1 \)
- \( \text{IterativeOdd}(3) = 9 \)
- \( \text{IterativeOdd}(5) = 25 \)

Denna process illustrerar hur funktionen arbetar genom att iterera över de första \( n \) udda talen och successivt summera dem.

---

