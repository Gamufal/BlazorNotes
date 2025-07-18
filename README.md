# BlazorNotes
Jest to lekka aplikacja webowa do tworzenia i zarządzania notatkami.

## Funkcjonalności:
- Przeglądanie listy notatek
- Dodawanie nowej notatki
- Edytowanie istniejącej notatki
- Usuwanie notatki
- Automatyczne śledzenie daty utworzenia i modyfikacji notatek
- Sortowanie notatek wg daty modyfikacji
- Zapis notatek w bazie danych
- Walidacja formularzy

## Technologie:
- [Blazor Server (.NET 9)](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)
- [Entity Framework Core (EF Core)](https://learn.microsoft.com/en-us/ef/core/)
- [SQLite](https://www.sqlite.org/index.html)

## Architektura:
- Model–widok–serwis
- Interfejsy dla serwisów
- Separacja logiki biznesowej od UI
- Wstrzykiwanie serwisów za pomocą wbudowanego kontenera DI .NET

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
## Jak uruchomić projekt?

1. Upewnij się, że masz zainstalowane [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download).
2. Sklonuj repozytorium:
```
git clone https://github.com/Gamufal/BlazorNotes.git
cd blazornotes
```
3. Uruchom aplikację:
```
dotnet run
```
4. Otwórz przeglądarkę i przejdź do adresu:
```
http://localhost:5000
```

## Autor
Kamil Kotorc - *Gamufal*
