Nazwa projektu: Aplikacja Pogodowa

Opis projektu: Aplikacja Pogodowa to aplikacja desktopowa stworzona w technologii Windows Forms w języku C#, która umożliwia użytkownikom sprawdzanie aktualnych danych pogodowych dla wybranych miast. Używa publicznego API OpenWeatherMap do pobierania danych takich jak temperatura, prędkość wiatru i wilgotność.

Kluczowe elementy:

1. Form1 (Interfejs użytkownika): Główny interfejs z polami do wprowadzania nazwy miasta i wyświetlania wyników (temperatura, wiatr, wilgotność) oraz przyciskiem do zapytania o pogodę.

2. WeatherService: Serwis obsługujący komunikację z zewnętrznym API pogodowym (OpenWeatherMap) za pomocą RestSharp do wysyłania zapytań HTTP i deserializacji danych JSON do modeli danych (WeatherModels).

3. WeatherModels: Zbiór klas modeli odpowiadających strukturze danych z API pogodowego, takich jak WeatherInfo, Main, Wind, przechowujących informacje o temperaturze, ciśnieniu, wilgotności, prędkości wiatru i opisie pogody.

4. Program.cs: Punkt wejścia aplikacji, inicjalizujący i uruchamiający główny formularz.

![image](https://github.com/pitrusik/PogodaApp/assets/91748205/cd4c0cc1-bc0a-409a-930e-48349f5a93df)
