# Bibliotekssystem

Detta är ett konsolbaserat bibliotekssystem skrivet i C# (.NET 8) där användaren kan agera som bibliotekarie eller låntagare. Programmet hanterar böcker, sökning, utlåning och återlämning via en enkel meny.

## Funktioner

- **Bibliotekarie**
  - Lägg till bok (med validering av tomma fält och ISBN)
  - Ta bort bok
  - Sök efter bok (titel/författare)
  - Visa alla böcker

- **Låntagare**
  - Sök efter bok
  - Visa alla böcker
  - Låna bok (med kontroll om boken är tillgänglig)
  - Lämna tillbaka bok (med kontroll av användar-ID)

## Fördelar

- **Enkel och tydlig menystruktur** för både bibliotekarie och låntagare.
- **Validering av inmatning** (t.ex. tomma fält och ISBN som endast siffror).
- **Objektorienterad design** med arv och interface (ISearchable).
- **Konsistent hantering av böcker** via gemensam lista.
- **Lätt att bygga ut** med fler funktioner tack vare tydlig klassstruktur.

## Nackdelar

- **Ingen beständig lagring** – böcker sparas endast i minnet under programmets körning.
- **Ingen autentisering** – användar-ID anges manuellt, ingen kontroll av användare.
- **Begränsad felhantering** – t.ex. hanteras inte alla möjliga fel vid inmatning.
- **Ingen hantering av flera låntagare** – alla låntagare delar samma boklista.
- **Konsolgränssnitt** – ingen grafisk användarupplevelse.

## Kom igång

1. Klona projektet:
2. Öppna i Visual Studio 2022.
3. Bygg och kör projektet.

## Licens

MIT