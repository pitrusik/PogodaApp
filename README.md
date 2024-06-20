Nazwa projektu: Aplikacja Pogodowa
Opis projektu: Aplikacja Pogodowa to aplikacja desktopowa stworzona w technologii Windows Forms w języku C#, która umożliwia użytkownikom sprawdzanie aktualnych danych pogodowych dla wybranych miast. Używa publicznego API OpenWeatherMap do pobierania danych takich jak temperatura, prędkość wiatru i wilgotność.

Koncepcja projektu jest prosta, ale skuteczna: tworzymy aplikację desktopową, która pozwala użytkownikowi szybko sprawdzić aktualne dane pogodowe. Oto kluczowe elementy projektu:

Form1 (Interfejs użytkownika):
Główny interfejs aplikacji zawiera pola tekstowe do wprowadzenia nazwy miasta oraz wyświetlania wyników (takich jak temperatura, wiatr, wilgotność). Dodatkowo znajduje się przycisk do rozpoczęcia zapytania o pogodę.

WeatherService:
Ten serwis odpowiada za komunikację z zewnętrznym API pogodowym (OpenWeatherMap). Wykorzystuje bibliotekę RestSharp do wysyłania zapytań HTTP i odbierania odpowiedzi. Dane z API są deserializowane z formatu JSON do odpowiednich modeli danych za pomocą biblioteki Newtonsoft.Json.

WeatherModels:
Zbiór klas modeli danych, które odpowiadają strukturze odpowiedzi z API pogodowego. Przykładowe klasy to WeatherInfo, Main, Wind oraz Weather, przechowujące informacje o temperaturze, ciśnieniu, wilgotności, prędkości wiatru i opisie pogody.

Program.cs:
Punkt wejścia aplikacji, który inicjalizuje i uruchamia główny formularz aplikacji.

Projekt ten ma na celu demonstrację integracji zewnętrznego API (OpenWeatherMap) z aplikacją Windows Forms. Chcemy pokazać, jak można efektywnie organizować kod i struktury danych w większych projektach, aby aplikacja była zarówno funkcjonalna, jak i łatwa w utrzymaniu.

![image](https://github.com/pitrusik/PogodaApp/assets/91748205/cd4c0cc1-bc0a-409a-930e-48349f5a93df)
