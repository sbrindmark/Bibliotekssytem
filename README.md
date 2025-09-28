# Bibliotekssystem

Detta �r ett konsolbaserat bibliotekssystem skrivet i C# (.NET 8) d�r anv�ndaren kan agera som bibliotekarie eller l�ntagare. Programmet hanterar b�cker, s�kning, utl�ning och �terl�mning via en enkel meny.

## Funktioner

- **Bibliotekarie**
  - L�gg till bok (med validering av tomma f�lt och ISBN)
  - Ta bort bok
  - S�k efter bok (titel/f�rfattare)
  - Visa alla b�cker

- **L�ntagare**
  - S�k efter bok
  - Visa alla b�cker
  - L�na bok (med kontroll om boken �r tillg�nglig)
  - L�mna tillbaka bok (med kontroll av anv�ndar-ID)

## F�rdelar

- **Enkel och tydlig menystruktur** f�r b�de bibliotekarie och l�ntagare.
- **Validering av inmatning** (t.ex. tomma f�lt och ISBN som endast siffror).
- **Objektorienterad design** med arv och interface (ISearchable).
- **Konsistent hantering av b�cker** via gemensam lista.
- **L�tt att bygga ut** med fler funktioner tack vare tydlig klassstruktur.

## Nackdelar

- **Ingen best�ndig lagring** � b�cker sparas endast i minnet under programmets k�rning.
- **Ingen autentisering** � anv�ndar-ID anges manuellt, ingen kontroll av anv�ndare.
- **Begr�nsad felhantering** � t.ex. hanteras inte alla m�jliga fel vid inmatning.
- **Ingen hantering av flera l�ntagare** � alla l�ntagare delar samma boklista.
- **Konsolgr�nssnitt** � ingen grafisk anv�ndarupplevelse.

## Kom ig�ng

1. Klona projektet:
2. �ppna i Visual Studio 2022.
3. Bygg och k�r projektet.

## Licens

MIT