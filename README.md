Nazwa projektu: Aplikacja Pogodowa
Opis projektu: Aplikacja Pogodowa to aplikacja desktopowa stworzona w technologii Windows Forms w języku C#, która umożliwia użytkownikom sprawdzanie aktualnych danych pogodowych dla wybranych miast. Używa publicznego API OpenWeatherMap do pobierania danych takich jak temperatura, prędkość wiatru i wilgotność. Dane te są następnie prezentowane w prostym i intuicyjnym interfejsie użytkownika.
Omówienie koncepcji projektu: Projekt składa się z kilku kluczowych komponentów:
1.	Form1 (Interfejs użytkownika): Główny formularz aplikacji zawierający elementy interfejsu użytkownika takie jak pola tekstowe dla wprowadzania nazwy miasta i wyświetlania wyników (temperatura, wiatr, wilgotność), oraz przycisk do inicjowania zapytania o pogodę.
2.	WeatherService: Serwis odpowiedzialny za komunikację z zewnętrznym API pogodowym (OpenWeatherMap). Używa biblioteki RestSharp do wysyłania zapytań HTTP i odbierania odpowiedzi. Dane z odpowiedzi są deserializowane z formatu JSON do modeli danych za pomocą biblioteki Newtonsoft.Json.
3.	WeatherModels: Zbiór klas modeli danych, które reprezentują strukturę odpowiedzi otrzymanej z API pogodowego. Obejmuje klasy takie jak WeatherInfo, Main, Wind, i Weather, które przechowują informacje o temperaturze, ciśnieniu, wilgotności, prędkości wiatru i opisie pogody.
4.	Program.cs: Punkt wejścia aplikacji, który inicjalizuje i uruchamia główny formularz aplikacji.
Koncepcja projektu opiera się na stworzeniu prostej, ale funkcjonalnej aplikacji desktopowej, która dostarcza użytkownikom szybkiego dostępu do aktualnych danych pogodowych. Aplikacja ma na celu pokazanie, jak można wykorzystać zewnętrzne API i integrować je z aplikacjami Windows Forms, a także jak organizować kod i struktury danych w większym projekcie.

![image](https://github.com/pitrusik/PogodaApp/assets/91748205/cd4c0cc1-bc0a-409a-930e-48349f5a93df)
