# BlazorNotes

Jest to lekka aplikacja do tworzenia i zarządzania notatkami.

---

## Funkcjonalności:

- Przeglądanie listy notatek
- Dodawanie nowej notatki
- Edytowanie istniejącej notatki
- Usuwanie notatki
- Automatyczne śledzenie daty utworzenia i modyfikacji notatek
- Sortowanie notatek wg daty modyfikacji

---

## Technologie:

- [Blazor Server (.NET 9)](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)
- [Entity Framework Core (EF Core)](https://learn.microsoft.com/en-us/ef/core/)
- [SQLite](https://www.sqlite.org/index.html)

---

## Struktura projektu

```
BlazorNotes/
│
├── DataModels/         # Klasy modeli danych
├── Services/           # Warstwa logiki biznesowej 
├── Pages/              # Komponenty UI i routing 
├── Migrations/         # Migracje EF Core
├── wwwroot/            # Zasoby statyczne
├── Notes.db            # Baza danych SQLite
├── Program.cs          # Główna konfiguracja aplikacji
└── BlazorNotes.sln     # Plik rozwiązania
```
---

## Autor
Kamil Kotorc - *Gamufal*
