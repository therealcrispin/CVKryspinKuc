using System;

namespace CV_Kryspin_Kuc
{
	class MojeCV
	{
		static void Main(string[] args)
		{
			Wstep_MojeCV();
			SekcjaWyboru();
		}

		static void Wstep_MojeCV()
		{
			Console.Clear();
			Console.WriteLine("===========================================");
			Console.WriteLine("               DZIEŃ DOBRY!                ");
			Console.WriteLine("===========================================\n");
			string intro = "Nazywam się Kryspin Kuć i z radością prezentuję swoje CV :)\n";
			string aboutMe = "Zanim jednak zaczniemy, to krótko o sobie.  Po 10 latach pełnych wyzwań w świecie reklamy, nadszedł czas na moją nową przygodę!\n"+
					 "Postanowiłem zmienić branżę i tym samym spróbować swoich sił w IT! Decyzja o zmianie kariery wynika z głębokiej refleksji wobec swojej przyszłości i rozwoju.\n"+
					 "Czuję, że osiągnąłem wiele w dotychczasowej branży i mimo, że ta oferuje nadal bardzo dużo, to ja sam, mam wrażenie, że moje życie wymaga czegoś bardziej stabilnego,\n"+
					 "dającego ciągły rozwój i perspektywy w kontekście przyszłości. Do tego dochodzi chęć poznawania i odkrywania nowości, zainteresowanie technologią,\n"+
					 "czy po prostu uwielbieniem do gier i tego jak to jest zrobione. Wszystko to sprawia, że wizja przebranżowienia, to w moim odczuciu, najlepsza z możliwych decyzji.\n";
			string closing = "Podsumowując, wierzę, że stabilność w branży IT pozwoli mi nie tylko na realizację ambicji,\n"+
				"ale także na wpływanie na nie tylko moją przyszłość. Zatem zapraszam do zapoznania się z moimi curriculum vitae!\n\n";

			Console.WriteLine(intro);
			Console.WriteLine(aboutMe);
			Console.WriteLine(closing);	
		}

        static void SekcjaWyboru()
        {
            string naglowek = "Jeśli jesteś zainteresowany moją osobą i chcesz poznać mnie lepiej, to wybierz jedną z opcji.\n";

            while (true)
            {
                Console.WriteLine(naglowek);
                Console.WriteLine("[1] Pełne CV");
                Console.WriteLine("[2] Wyświetlisz tylko moje dane osobowe oraz ukończoną uczelnie.");
                Console.WriteLine("[3] Zapoznasz się tylko z moim doświadczeniem oraz umiejętnościami");
                Console.WriteLine("[4] Możesz przeczytać o moich zainteresowaniach");
                Console.WriteLine("[5] Przeczytasz mój list motywacyjny");
                Console.WriteLine("[6] Zdjęcie");
		Console.WriteLine("[7] Zamkniesz program");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        naglowek = "Wybierz inną sekcję lub wyłącz program";
                        Sekcja1();
                        break;
                    case "2":
                        naglowek = "Wybierz inną sekcję lub wyłącz program";
                        Sekcja2();
                        break;
                    case "3":
                        naglowek = "Wybierz inną sekcję lub wyłącz program";
                        Sekcja3();
                        break;
                    case "4":
                        naglowek = "Wybierz inną sekcję lub wyłącz program";
                        Sekcja4();
                        break;
                    case "5":
                        naglowek = "Wybierz inną sekcję lub wyłącz program";
                        Sekcja5();
                        break;
                    case "6":
                        naglowek = "Wybierz inną sekcję lub wyłącz program";
                        Sekcja6();
                        break;
                    case "7":
			Console.Clear();
			return; // Koniec programu
                    default:
			Console.Clear();
                        Console.WriteLine("Błędny wybór. :( Spróbuj ponownie!");
                        break;
                }
            }
        }

		static void Sekcja1()
{
    		Console.Clear();
    		string fullCV = "\nMoje CV:\n\n" +
            "====================\n\n" +
            "Imię i nazwisko: Kryspin Kuć\n\n" +
            "Adres: al. Józefa Piłsudskiego 5/13, 20-011 Lublin\n\n" +
            "Data urodzenia: 1 kwietnia 1991 roku\n\n" +
            "Numer telefonu: +48 724 825 757\n\n" +
            "Adres e-mail: kryspin.kuc@gmail.com\n\n" +
            "Wykształcenie: Dziennikarstwo i Komunikacja Społeczna na Uniwersytecie Jagiellońskim\n\n" +
            "====================\n\n"+
            "Doświadczenie:\n\n" +
            "....................\n\n"+
            "01.2024 - 04.2024\nSolinea\n\n"+
            "Specjalista ds. Social Media\n\n"+

            "Byłem odpowiedzialny za:\n"+
            "- Stworzenie linii kreatywnej dla profilu Zdrowe Rozwiązania\n"+
            "- Monitoring kampanii reklamowych na Facebook\n"+
            "- Wsparcie kreatywne\n"+
            "- Copywriting\n"+
            "- Tworzenie grafik\n"+
            "- Analizę konkurencji\n\n"+
            "....................\n\n"+
            "04.2023 - 09.2023\nAllianz\n\n"+
            "Agent Ubezpieczeniowy\n\n"+

            "Byłem odpowiedzialny za:\n"+
            "- Przygotowanie dedykowanych ofert dla klientów\n"+
            "- Aktywne pozyskiwanie Klientów\n"+
            "- Doradztwo ubezpieczeniowe\n\n"+
            "....................\n\n"+
            "01.2022 - 10.2022\nTVP - SwipeTo\n\n"+
            "Head of Social Media\n\n"+

            "Byłem odpowiedzialny za:\n"+
            "- Budowanie strategii social media dla serwisu swipeto.pl\n"+
            "- Analizę rynku i trendów\n"+
            "- Koncepcje kreatywne dla profilu na Instagramie i TikToku\n"+
            "- Współtworzenie koncepcji graficznej w social media\n"+
            "- Tworzenie treści na profile\n"+
            "- Koordynację badań rynkowych\n"+
            "- Budowanie zespołu\n\n"+
	    "....................\n\n"+

	    "04.2020-02.2023\nSigmaBis\n\n"+
	    "Content Moderator\n\n"+

	    "Byłem odpowiedzialny za:\n"+
	    "Moderacja profili w serwisie Facebook marek tj.:\n"+
	    "* PKN Orlen\n* Orlen Stop Cafe\n* Vitay\n"+
	    "- Wspierałem działania agencyjne w zakresie pracy kreatywnej oraz analizy konkurencji\n\n"+
            "....................\n\n" +
	    "01.2019 - 10.2019\nCodemedia\n\n"+
	    "Graphic Designer/Creative\nSocial Media & Content Specialist\n\n"+

	    "Byłem odpowiedzialny za:\n"+
	    "Jako Graphic Designer/Creative\n"+
	    "- Tworzenie kreacji do social media oraz kampanii Google\n"+
	    "- Tworzenie copy postów, key visuali, moodboardów oraz koncepcji kreatywnych\n"+
	    "- Nadzór kreatywny\n-Wsparcie Client Service\n\n"+
	    "Jako Social Media & Content Specialist\n"+
	    "- Obsługa klientów\n"+
	    "- Tworzenie wycen i ofert\n"+
	    "- Publikacja i moderacja treści\n"+
	    "- Nadzór realizacji kampanii dla Klientów\n\n"+
	    "....................\n\n" +
	    "06.2015 - 01.2018\n"+
	    "TVP - Biuro Reklamy\n\n"+
	    "Specjalista ds. Rozwoju Social Media/Project Manager\n\n"+

	    "Byłem odpowiedzialny za:\n"+
	    "- Tworzenie ofert niestandardowych np. autorskiego pomysłu - Euro komentowane przez Piotra 'Izaka' Skowyrskiego\n"+
	    "- Wsparcie sprzedaży\n"+
	    "- Wdrażanie oraz nadzór pojektów, zarówno po stronie prawnej jak i technicznej\n"+
	    "- Kontakt z Klientem\n"+
	    "- Wyceny projektów\n\n"+
	    "....................\n\n"+
	    "09.2014 - 03.2015\n"+
	    "Socialyse/Havas Media\n\n"+
	    "Social Ads Manager\n\n"+

	    "Byłem odpowiedzialny za:\n"+
	    "- Ustalanie grup docelowych do kampanii klienckich na Facebook\n"+
	    "- Zarządzanie reklamami\n"+
	    "- Zarządzanie budżetem kampanii\n"+
	    "- Analiza i raportowanie wyników\n\n"+
            "....................\n\n" +
	    "12.2013 - 07.2014\n"+
	    "Legallais\n\n"+
	    "Asystent Działu Zakupów i Marketingu\n\n"+

	    "Byłem odpowiedzialny za:\n"+
	    "- Wsparcie działań marketingowych\n"+
	    "- Wsparcie dyrektora ds. zakupów\n"+
	    "- Zarządzanie danymi katalogu sprzedażowego\n"+
	    "- Współtworzenie katalogu sprzedażowego\n"+
	    "- Kontrola spójności danych między katalogiem, sklepem, a magazynem.\n\n"+
	    "====================\n\n"+
	    "Moje atuty\n\n"+
	    "Jestem osobą samodzielną, przez lata pracowałem na projektach wymagających odpowiedzialności indywidualnej. Dodatkowo potrafię nieszablonowo podchodzić do wielu tematów, co pozwala mi widzieć rozwiązania, które często innym potrafią umykać.\n"+
	    "Uważam się również za osobę ambitną, potrafiącą stawiać czoła nowym wyzwaniom i nie bojąca się nieznanego. Przez lata pracy w reklanie również udało mi się wyksztalcić w sobie umiejętność pracy w stresie i odporności na niego. Zawsze staram się\n"+
	    "szukać rozwiązań i w razie problemów przedstawiać sposoby na zażegnanie jakiegoś kryzysu. Dodatkowo cechuje mnie bycie samoukiem. Całą karierę uczyłem się we własnym zakresie, co powoduje, że potrafie się z łatwością adaptować oraz samodzielnie myśleć\n\n"+
	    "====================\n\n"+
            "Moje umiejętności:\n\n"+
            "====================\n\n"+
             "- SQL\n"+
	     "- Podstawowa umiejętność testowania manualnego, czego dowodem może być członkostwo na platformach Testbirds oraz Ubertesters\n"+
	     "- Samodzielna nauka programowania - to CV jest na to dowodem :)\n"+
	     "- Zarządzanie projektami\n"+
	     "- Znajomość platform tj. Trello, Notion, Discord\n-Grafika rastrowa i wektorowa\n-Copywriting\n-Social Media Marketing\n-Łatwość w wyszukiwaniu rozwiązań problemu\n-Język angielski\n\n"+
	     "Programy z których potafię korzystać:\n\n"+
	     "- Microsoft Office\n"+
	     "- Adobe Photoshop\n"+
	     "- Adobe Illustrator\n"+
	     "- Audacity\n"+
	     "- Linux - początkujący\n"+
	     "- Postman - początkujący\n"+
	     "- Neovim - początkujący\n\n"+
	     "====================\n\n"+
	     "Zainteresowania:\n\n" +
	     "====================\n\n"+
	     "- Sport:\n"+
	     "* Football Amerykański\n"+
	     "* Koszykówka(NBA)\n"+
	     "* Baseball\n"+
	     "- Rekreacja:\n"+
	     "* Wycieczki w góry\n"+
	     "* Wędkarstwo\n"+
	     "* Zbieranie grzybów\n"+
	     "- Gry - szczególnie RPG i grand strategy\n"+
	     "- Seriale - aktualnie jestem na niemal 700 odcinku Plebanii\n"+
	     "- Historia - średniowiecze i okres I Wojny Światowej\n"+
	     "- Niespełniony fan planszówek\n\n"+
	     "====================\n\n"+
	     "Informacje dodatkowe:\n\n"+
	     "====================\n\n"+
            "Prowadzę wraz z przyjacielem mały serwis o NBA oraz NFL. Przez niemal 7 lat wyewoluował z medium pisanego w audio i do tej pory nagranych jest już 700 odcinków na tematy dookoła sportowe :)\n\n";
    
    Console.WriteLine(fullCV);
}
	static void Sekcja2()
		{
			Console.Clear();
	           	string daneteleadresowe = "\nDane Teleadresowe i wykształcenie:\n\n" +
				"====================\n\n" +		
				"Imię i nazwisko: Kryspin Kuć\n\n" +
				"Adres: al. Józefa Piłsudskiego 5/13, 20-011 Lublin\n\n" +
				"Data urodzenia: 1 kwietnia 1991 roku\n\n" +
				"Numer telefonu: +48 724 825 757\n\n"+
				"Adres e-mail: kryspin.kuc@gmail.com\n\n"+
				"Wykształcenie: Dziennikarstwo i Komunikacja Społeczna na Uniwerystecie Jagiellońskim\n\n"+
		            	"====================\n\n";
		    Console.WriteLine(daneteleadresowe);
		}

		static void Sekcja3()
		{
			Console.Clear();
			string expskill = "\nMoje Doświadczenie, umiejętności i atuty :)\n\n" +
				"====================\n\n"+ 
				"Doświadczenie:\n\n01,2024-04.2024\nSolinea\n\nSpecjalista ds. Social Media\n\nByłem odpowiedzialny za:\n"+
				"-Stworzenie linii kreatywnej dla profilu Zdrowe Rozwiązania\n-Monitoring kampanii reklamowych na Facebook\n-Wsparcie kreatywne\n-Copywriting\n-Tworzenie grafik\n-Analize konkurencji\n\n"+
				"04.2023 - 09.2023\nAllianz\n\nAgent Ubezpieczeniowy\n\nByłem odpowiedziany za:\n"+
				"-Przygotowanie dedykowanych ofert dla klientów\n-Aktywne pozyskiwanie Klientów\n-Doradztwo ubezpieczeniowe\n\n"+
				"01.2022 - 10.2022\nTVP - SwipeTo\n\nHead of Social Media\n\nByłem odpowiedzialny za:\n:"+
				"-Budowanie strategii social media dla serwisu swipeto.pl\n-analizę rynku i trendów\n-Koncepty kreatywne dla profilu na Instagramie i TikToku\n-Współtworzenie koncepcji graficznej w social media\n-Tworzenie treści na profile\n-Koordynacja badań rynkowych\n-Budowanie zespołu\n\n"+
				"04.2020-02.2023\nSigmaBis\n\nContent Moderator\n\nByłem odpowiedzialny za:\n"+
				"Moderacja profili w serwisie Facebook marek tj.:\n*PKN Orlen\n*Orlen Stop Cafe\n*Vitay\n-Wspierałem działania agencyjne w zakresie pracy kreatywnej oraz analizy konkurencji\n\n"+
				"01.2019 - 10.2019\nCodemedia\n\nGraphic Designer/Creative\nSocial Media & Content Specialist\n\nByłem odpowiedzialny za\n:"+
				"Jako Graphic Designer/Creative\n-Tworzenie kreacji do social media oraz kampanii Google\n-Tworzenie copy postów, key visuali, moodboardów oraz koncepcji kreatywnych\n-Nadzór kreatywny\n-Wsparcie Client Service\n\n"+
				"Jako Social Media & Content Specialist\n-Obsługa klientów\n-Tworzenie wycen i ofert\nPublikacja i moderacja treści\n-Nadzór realizacji kampanii dla Klientów\n\n"+
				"06.2015 - 01.2018\nTVP - Biuro Reklamy\n\nSpecjalista ds. Rozwoju Social Media/Project Manager\n\nByłem odpowiedzialny za:\n"+
				"-Tworzenie ofert niestandardowych np. autorskiego pomysłu - Euro komentowane przez Piotra 'Izaka' Skowyrskiego\n-Wsparcie sprzedaży\n-Wdrażanie oraz nadzór pojektów, zarówno po stronie prawnej jak i technicznej\n-Kontakt z Klientem\n-Wyceny projektów\n\n"+
				"09.2014 - 03.2015\nSocialyse/Havas Media\n\nSocial Ads Manager\n\nByłem odpowiedzialny za:\n"+
				"-Ustalanie grup docelowych do kampanii klienckich na Facebook\n-Zarządzanie reklamami\n-Zarządzanie budżetem kampanii\n-Analiza i raportowanie wyników\n\n"+
				"12.2013 - 07.2014\nLegallais\n\nAsystent Działu Zakupów i Marketingu\n\nByłem odpowiedzialny za:\n"+
				"-Wsparcie działań marketingowych\n-Wsparcie dyrektora ds. zakupów\n-Zarządzanie danymi katalogu sprzedażowego\n-Współtworzenie katalogu sprzedażowego\n-Kontrola spójności danych między katalogiem, sklepem, a magazynem.\n\n"+
				"Moje atuty\n\n"+
				"====================\n\n"+
				"Jestem osobą samodzielną, przez lata pracowałem na projektach wymagających odpowiedzialności indywidualnej. Dodatkowo potrafię nieszablonowo podchodzić do wielu tematów, co pozwala mi widzieć rozwiązania, które często innym potrafią umykać.\n"+
				"Uważam się również za osobę ambitną, potrafiącą stawiać czoła nowym wyzwaniom i nie bojąca się nieznanego. Przez lata pracy w reklanie również udało mi się wyksztalcić w sobie umiejętność pracy w stresie i odporności na niego. Zawsze staram się\n"+
				"szukać rozwiązań i w razie problemów przedstawiać sposoby na zażegnanie jakiegoś kryzysu. Dodatkowo cechuje mnie bycie samoukiem. Całą karierę uczyłem się we własnym zakresie, co powoduje, że potrafie się z łatwością adaptować oraz samodzielnie myśleć\n\n"+
				"Moje umiejętności:\n\n-SQL\n-Podstawowa umiejętność testowania manualnego - czego dowodem może być członkostwo na platformach Testbirds oraz Ubertesters\n-Samodzielna nauka programowania - to CV jest na to dowodem :)\n-Zarządzanie projektami\n"+
				"-Znajomość platform tj. Trello, Notion, Discord\n-Grafika rastrowa i wektorowa\n-Copywriting\n-Social Media Marketing\n-Łatwość w wyszukiwaniu rozwiązań problemu\n-Język angielski\n\n"+
				"Programy z których potafię korzystać:\n\n-Microsoft Office\n-Adobe Photoshop\n-Adobe Illustrator\n-Audacity\n-Linux - początkujący\n-Postman - początkujący\n-Neovim - początkujący\n\n"+
				"====================\n\n"; 
			Console.WriteLine(expskill);
		}

		
		static void Sekcja4()
		{
			Console.Clear();
			string zainteresowania = "\nMoje zainteresowania:\n\n" +
				"====================\n\n"+
				"-Sport:\n*Football Amerykański\n*Koszykówka(NBA)\n*Baseball\n-Rekreacja:\n*Wycieczki w góry\n*Wędkarstwo\n*Zbieranie grzybów\n-Gry - szczególnie RPG i grand strategy\n-Seriale - aktualnie jestem na niemal 700 odcinku Plebanii\n"+
				"-Historia - średniowiecze i okres I Wojny Światowej\n-Niespełniony fan planszówek\n\n"+
				"Informacje dodatakowe:\n\nProwadzę wraz z przyjacielem mały serwis o NBA oraz NFL. Przez niemal 7 lat wyewoulował z medium pisanego w audio i do tej pory nagranych jest już 700 odcinków na tematy dookoło sportowe :)\n\n"+
				"====================\n\n";
			Console.WriteLine(zainteresowania);



		}

		static void Sekcja5()
		{
			Console.Clear();
			string listmotywacyjny = "\nSzanowni Państwo,\n\n"+
				"Z zainteresowaniem zapoznałem się z ofertą pracy na stanowisko Junior Low-Code Developer i pragnę zgłosić swoją kandydaturę. Moje doświadczenie w pracy z danymi,\n"+
				"SQL oraz zarządzaniu projektami pozwala mi szybko przyswajać nowe narzędzia, co uważam za kluczową umiejętność na tym stanowisku.\n\n"+
				"Mimo że jestem na początku swojej kariery w IT, moje dotychczasowe doświadczenie w branży reklamowej nauczyło mnie analitycznego myślenia, rozwiązywania problemów i efektywnej pracy zespołowej,\n"+
				"które są równie ważne w pracy z systemami low-code. Dodatkowo, intensywnie rozwijam swoje umiejętności programowania w C#, co pozwala mi lepiej rozumieć zaplecze techniczne projektów,\n"+
				"a także pracuję nad nauką notacji BPMN i UML, aby skuteczniej modelować procesy biznesowe.\n\n"+
				"Jestem osobą zmotywowaną, która zawsze stara się dostarczać jak najlepsze rezultaty. Wierzę, że moja elastyczność, umiejętność pracy zespołowej oraz chęć nauki nowych technologii będą wartościowym atutem w Państwa firmie.\n\n"+
				"Chętnie przedstawię więcej szczegółów podczas rozmowy kwalifikacyjnej.\n\n"+
				"Z poważaniem,\nKryspinKuć\n+ 48 724 825 757\nkryspin.kuc@gmail.com\n";
			Console.WriteLine(listmotywacyjny);


		}

		static void Sekcja6()
		{
			Console.Clear();
			string zdjecie = 
@"
???7777777777777777777777777777777777!!7777!7777!7!!77777777777777!!777777777777777777?7??7??77777777777777777777!77!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!77
?77777777777777777777777777!77!7!7777!!7!7!!7!77!7777!777777777777!777777777777777777777777?777777777777777777777!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!7!
777777777777777777777777!!77!!!7!77!7!!!777!7!77!7777777777!777777!7777777!!7777777777777777777777777777777777777!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!77
77777777777777!!!!!!!!!!!!7!777777!!7!!7!7777777!7777!77777777777777?77777?JJ?777???????J??????777777777777777777!!!!!!!!!!!!!!!!!!!!!!~~~~~!!!!!!!!77
77777777777777!!!!!!!!!!!!!!!777777!7777!7777777777777??JYYY55555555Y?JJ?JJ!7J?J55YPPP55PPP5555YJ??777777777777!7!!!!!!!!!!!!!!~!!~~~^^^^~~~~~!!!!!!77
7777777777777!!!~!~~^^^~~!!!!!!7!!7!77777777777777?JYY5555YYYJJJJ??J5JYYY55JYP5Y555YJJ????JJJY55555YJ?77777777777!!!!!!!!!!!!~!!^.       .:~~~!!!!!!77
7777777777777!!!~:        :~!!!!!!7!77777777777?JYY5YYJ?77777!7!!7!7777~?BG55GG?!777777777777777?JY55YJ?777777777!!!!!!!!!!!~!~:            ~!~!!!!!77
???7777777777!!^            :!!!!!!!777777777?JYYYJ77!7777777!77!7!!7!7!!?J77JJ7!777777777777777777??Y5Y??7777777!!7!!!!!!!77!:             .!!!!!!!77
?????77777777!!.             ^!!!!!!7777!77?7JYJ77!!7777777!7!7!!7!!7!!!!^?!~J!!777!777777777777777777?Y5J7777777!7!!!!!!!!??~.             :7!!!!7777
???7??77777777!.             :!!!!!!!!!77?77JJ777777777777777777!7!!7!!!!~?JJ?!!!!!777777777777777777777?YJ7?7!77!7!!!!!!!!!!~:            .!7!!!!7777
???7??777777777!.            ^~~!!!!!7!7?!??77777777777777777777!7!77!7!!!????777!777777777777777777777777JJ!?7!7!7!!!!!!!!!!~~^.        .^!7!!!!77777
????????77777777!^.        .^~~!!!!!7!!7~?J777777777777777777777!!!!!7?JJJ?!7?JJJJ777!777777777777777777777YJ~?!7777!!!!!!!!!!~~^^::::^^~777!!!7777777
????????77777777777!~^:::::^~~!!!!!!!~!:7?7777777777777777!7777!!7JY5PGGGGGPPGGGGGPP5Y?77777777777777777777757^7^!77!7!!!!!!!!!!~~~~~!!!!!!!7777777777
??????????777777777!!!!!~~~~~!!!!!7!^~ :?77777777777777777!777~7PGGBBBBBBBBBBBBBBBBBBBBGJ!777777777777777777?Y:~~~77!7!!!!!!!!!!!!!!!!!!!7777777777777
??????????7777777777!!!!!!!!!!!!777!7^.?777777777777777777!77!YBBBBGGBBBBBBBBBBBBBBBBBBBBP777777777777777777!Y?^J!7777!77!7!!!!!!!!!!77777777777777777
???????????7?7777777777777!77777777??:?J7777777777777777777777JGB###BBBBBBBBBBBBBBBB###BGJ7777777777777777777?57JY777777777!77!77777777777777777777777
?????????????7777777777777777777777Y7!Y77777777777777777!7777777?Y5GGBB####BB###BBBGPPY?7777777777777777777777YJ?5?77777777777!777777777777777777777?7
???????????????77?7777777777777777?5!?J777777777!7!7777777777777!!!777JJJJYGG5?7~7?77777777777!777777777777777JJ!5?777777777777777777777777777777777?7
?J???????????????????7777777777777J5~JJ7777!777!!7777!7777!77!77!7!77!!!7^7BBY~:~!!~!7777777777!777!7777777777J5!5J7777777777777777777777777777?7?77??
?J???????????????????7?77?77777777J5~YJ77777777777!77!!!!7777!7!77!!!!!!!~?BBY^.:~~!!!77?7?7777777777777777777J57PY7777777777777777777777777?77???????
JJ?JJ??????????????????77?77777777J5~YJ77777777777777777777777777777!~77!!JGG57!~!!777!!77????7777777777777777?P?PY7777777777777777777777?????????????
JJJJJ?J?????????????????7?77?77777J5~YJ777777777777777777777777777777777?J5GG5YYJ!^~777!77?7??77?7777777777777JPJPY777777777777777777?7???????????????
JJJJJJJ??J???????????????????7?777JP~JY777777777777777777777777777??J??JYY5BG55YJJ7777?777??7??7?77?777777?777JPJPY777777777777777?7??????????????????
JJJJJJJJ?J??????????????????????7?JP!YY7??777777777?777777777???JJYYYYJJYY5BB555YJ?JJ?J?J???????777???77777777JPYPY7777777777?7????7??????????????????
JJJJJJJJJJJ????????????????????7??JP!YJ7777777?7????77777??JJYYYYYYYYYYJJY5GG55YY?!?J?JJJJJJJJ??!7777???777777JPYPY7777?77?7??7?7??7??????????????????
JJJJJJJJJJJJJ?????????????????????JP7YJ7777777?????77???JJJYYYYJJJ?JJJ????5YJ5YJ?????J?JJJJJJJJJ???77?7?777777JPJPY7?77??7?7??7?7??7??????????????????
JJJJJJJJJJJJ??????????????????????JP?YJ7?7777???????JJYYYYJJJJ?777???77???5YJ55Y7777?????????JJYJJ???777777777JPJ5Y7?777?7?7?77???????????????????????
JJJJJJJJJJJJJ?J???????????????????JP?YY7??7??????JJYYYYYJJ??7777???????7??YYJP5J7??777?????????JJJYJJ???777?77JP?5Y7?????7?7??????????????????????????
JJJJJJJJJJJJJJJ??J????????????????JG?JY7??????JJYYYYYJJ??7777?77?77?77777?Y5YPY7!!7~~~7??7??????JJJJJJJ??????7JP!YY7??7?????????????????????????????J?
JJJJJJJJJJJJJJJ?JJ?J??????????????JG7J5?????JYYYYYJJ??77?777777777??77777J55JP7!!!~^~!77???7???????????JJJJ???YP:J5?????????????????????????????????J?
JJJJJJJJJJJJJJJJJJ?JJ?J???????????JG7?5???JY5YYYYJ?????7????7??777???JJJYY55?P777!~????????????????????JJYYYJJYP~55?????????????????????????????????J?
JJJJJJJJJJJJJJJJJJJJJJJ???????????JG7?5?JY555YYJ????????????7????JJYYYYYY5557PYJ?JJYYYYJJ????????????7??JYYY5Y5P?P5????????????????????????????????JJ?
JYJJJJJJJJJJJJJJJJJJJJJ?JJ?J??????JG?7PY5555YJ?????????????????JYYYYYYYYY555!5YYJYJYYYYYYYJ??7????JJ?7???JJYY55PJP5?????????????????????????J????J??J?
YJJJJJJJJJJJJJJJJJJJJJJ?J???????J?JGJ?P5555Y????????????????7?YYYY55555Y5555~5YYYYJYYYYYYYY???77JJJJ???????JY55GYP5???????????????????????J?JJJJ?J?JJJ
YYJYJJJJJJJJJJJJJJJJJJJJJJ?J?JJ?JJJGJ?P55YJ??????????????7???JJY5PPPPPPPPP5P!5YYYYYYYYYYYYYJ?J?!?JJJ?7?7?????J5G5P5J?????????????????????JJ?J?JJJJJJJJ
YYJYJJYJJJJJJJJJJJJJJJJJJJJJ?JJ?JJYGYJG5YJ??????????????777?JYYPPPPGGBBGGGPP?P5YYYYYJYYJYYYJ??7!?JJJ7!7????7?J5G5PPYJ????????????????????J?JJ?JJJJJJJJ
YYYYYYYJYJJJJJJJJJJJJJJJJJJJ?JJJJY5G5YGYJ????????????????77??J5PPB##BGGGGGGP?P5YYYJJJYYYYJYJ??77?JJJ77????????5G5GPY5YJ?????????????J?JJJJJJJJJJJJJJJJ
YYYYYYYYYJJJJJJJJJJJJJJJJJJJJJJJ555G5YGYJ?J???????????????????5G##PYJ??JY5PP5P5YYYYYJYJJJJJ???77JJJJ7~7???JJ??5GYGP555YYJ????J?J????J?JJJJJJJJJJJJJJJJ
YYYYYYYYYJJJJJJJJJJJJJJJJ?JJJJJY555GP5GYJJJ???????????????????5BBP5PP5YYPPPPPGY?J???????!7???????JYJ?~!?JJJ7??5G5G5JY555YJJJJJ?J?JJJJJJJJJJJJJJJJJJJJJ
YYYYYYYYYJYJJJJJJJJJJJJJJJJJJY55555PG5GYJJJ?????J?????????????YBGGGP5PGPPYJJ?5Y7???????????J???77JYJ7!?J??????5GPGY?Y5Y5YYJ?JJ?J?JJJJJJJJJJJJJJJJJJJJJ
YYYYYYYYYYYYJYJYJJJJJJJJJJJJY55555YPG5GYJJJ??J?JJJJ??J????????Y#GP5YJY55555YJJ5J???????JJ??J?7??JJYJJ?JJ??JJJJ5GPG5JJY5555YJJJJJJJJJJJJJJJJJJJJJJJJJJJ
YYYYYYYYYYYYJYJJJJJJJJJJJJJY55555YJPG5GYJJJJJJ?JJ?JJJJJJJ???JJY#BGP5Y5PPYYJJJYYYJ????JJJ??JJJJ???YYJJJJJJJJJJJ5GPG5JJJY5555YJJJJJJJJJJJJJJJJJJJJJJJJJJ
YYYYYYYYYYYYYYYYYJJJJJJJJJY55555YJJ5GPG5JJJJJJJJJJJJJJJJJJJJJJJGGGGP55555Y55555YJJ?JJJJJ??JJJ??JJYYYJJJJ?JJJJJ5GPG5JJJJYY555YJJJJJJJJJJJJJJJJJJJJJJJJJ
YYYYYYYYYYYYYYYYYJJJJJJJJJ55555YJJJ5G5G5JJJJJJJJJJJJJJJJJJJJJJJYYPBBGGGBBBBBBBGJJJJJJJJJJJJJJJJJJYYYJ?JJJJJJJJ5BPG5JJJJYY5555YJJJJJJJJJJJJJJJJJJJJJJJJ
YYYYYYYYYYYYYYYYYYYJJJJJYY5555YJJJJ5G5G5JJJJJJJJJJJJJJJJJJJJJJJJYYGBBBBBGGGGGP5JJJJJJJJJJJJJJJJJJYYYJJJJJJJJJJ5BGG5JJJJJY55555JJJJJJJJJJJJJJJJJJJJJJYJ
YYYYYYYYYYYYYYYYYYYYYYJYY55555YJJJJ5GJGPJJJJJJJJJJJJJJJJJJJJJJJJJJJPPGGP555P5YYJJJY55YJJJJJJJJJJJYYYJJJJJJJJJJY5?P5JJJJJJY5555YJJJJJJJJJJJJJJJJJJJJJJJ
YYYYYYYYYYYYYYYYYYYYYYYY55555YJJJJYGG55GYJJJJJJJJJJJJJJJJJJJJJJJJJYPPY5PP55YJJY5PB&&&#PJJJJJJJJJYYYYYJJJJJJJJYPY7?PYJJJJJJ55555YJJJJJJJJJYJJJJJJJJJJYJ
YYYYYYYYYYYYYYYYYYYYYYYY55555YJJJYYGP?YGYJYJJJJJJJJJJJJJJJJYJYJ5GB#&#BP555Y55G#&@@@&&&&BPP5YYYJJYYYYYJJJJJJJJY5J!5PJJJJJJJY55555JJJJJJJJJYJJYJJJJYJJYJ
5YYYYYYYYYYYYYYYYYYYYYY555P55Y5PPPGBGJ5GGYYJJJJJJJJJJJJJJJJJYYY#@&&@@@@&#B#&@@@@&&&&&&&&&&&&##G5YYYYYJJJJJJJJ5PP?5GGPPP55YY55555YJJJYYJYJYJJYJYYYYYYYY
555Y55YYYYYYYYYYYYYYYYY55555YY5PGBB#BBB#BGGPPPPPPP55555555PGB##&&&&&&&&&&@&&&&&&&&&&&&&&&&&&&&@&G55P55PPPPPPPB#BGGBBBBGPPYJY55555YYJYYJYYYYYYYYYYYYYYY
555555Y5YYYYYYYYYYYYYYY55555YYYYJYYPBPBBY55YY5555555555G&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@#P5555555555YGBGBGYYYYYJJJY55555YYJYYYYYYYYYYYYYYYYYY
555555Y55YYYYYYYYYYYYY5P5555YYYYYYY5BPGGYYYYYJJJJJJJJY#&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@&@#5YYYYYYYYYYPBGBPJJJJYJYJY55555YYYYYYYYYYYYYYYYYYYYY
555555555YYYYYYYYYYYYY5P5P55YYYYYYYPBPBGYYYYYYYYYYYJP#&&&@&&&&&&&&&&&&&&&&&&@&&&&&&&&&&&&&&&&&&@@@@#5YYYYYYYYYPBGBGJYYYYYYYY555555YYYYYYYYYYYYYYYYYYYY
555555Y5555YYYYYYYYYYY5PPPP5YYYYYYYP#GBGYYYYYYYYYYYP&@&&@&&&@&&&&&&&&&&&&&&&##&&&&&&&&&&&&&@@@&@@@@@GYYYYYYYYYPBGBGYYYYYYYYY555P55YYYYYYYYYYYYYYYYYYYY
55555555555Y5YYYYYYYYY5PPPP5YYYYYYYPBGBBYYYYYYYYYY5&@&@@&&@@@@@@&&&&&@&&@&#P5#@@&@@@@&@@&&&&&@@@@@@@&5YYYYYYYYPBGBGYYYYYYYYY555P55YYYYYYYYYYYYYYYYYYYY
55555555555YYYYYYYYYYY5PPPPP5YYYYYYP#GBBYYYYYYYYYY#&&&&@@@@@@@@@@@@@@@@#P5YP#@@@@@@@@@@@@@@@&&@@@@@@@#55YYYY55P#BBGYYYYYYYYY5PPPP5YYYYYYYYYYYYYYYYYYYY
5555555555555YYYYYYYYY5PPPPP5YYYYYYP#BBBYYYYYYYYP#&&&@@@@@@@@@@@@@@@@&GYJYYY5PGGGGBBB##&@@@@@@&&@@@@@@BPPP5YYYP#BBBYYYYYYYYY5PPPP5YYYYYYYYYYYYYYYYYYYY
55555555555555YYYYYYYY5PPPPP5YYYY5YG#B#BYYYY555G&&@@@@@@@@@@@@&&&&&&&&5JYYYYY555PPPGGGG#&@@@@@@@@@@@@@&P55PP55P#BBGYY55YYYYY5PPPP5YYYYYYYYYYYYYYYYYYYY
5555555555555555Y5Y55Y5PPPPP5YYYY55G#BBBY5PPPG#&@&@@@@&&&&&&&&&&&&&&&&&P5555PPPPPGGGGGBBB&@@@@@@@@@@@@@#YY55PPG#BBBYYY55YYYYPPPPP5YYYYYYYYYYYYYYYYYYYY
555555555555555555YY5Y5PPPPP5YYYY55P#BBBPPP55&@@&&@@@&&&&&&&@@@@&&&&&@@&BGGPPGGGGGGGGBBB&@@@@@@@@@@@@@@&P55555P#BBBYYYY5YYYYPPPPP5YYYYYYYYYYYYYYYYYYYY
55555555555555555555555PPPPP55YYY55PBGB#GGPPB@@@@@@@@@@@@@@@@@@@@@@@@@@@&&#####BBBBB#&&&@@@@@@@@@@@@@@@@&GGGGGBB5PBGPP555YY5PPPPP5YYYYYYYYYYYYYYYYYYYY
55555555555555555555555PPPPP555Y5PGGG?5B#GGP#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&&@@@@@@@@@@@@@@@@@@@&5555P#GYJGBBGG5YYY5PPPPP5YYYYYYYYYYYYYYYYYY55
55555555555555555555555PPPPP555Y5PB#BPG##555#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@P555P##BGB#GPPP5YY5PPPPPPYY5YYYYYYYYYYYYYYYYY
55555555555555555555555PPPPP5555PPGB#BB#P555B@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&P555G#BBBP555PP555PPPPPPY55YYYY5YYYYYYY5YYYY
55555555555555555555555PPPPP555PPP5P#B#B555PPB&&&&&&&&&#B#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&P5555##BB55YY55PP5PPPPPP555555Y5YY5Y5YY5Y555
5P555555555555555555555PPPPPPPPP555G#BBB55PP55PPPPPPPPPPPB@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#5PP55##BB5555555PPPPPPPP555555Y5Y55Y55555555
PP55P55P55555555555555PPPPPPPPP5555G###B5PPP55PP55555PPPPG@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@G5PP55##BBP5555555PPPPPPP55555555Y5555555555Y
5P5PP5PP55555555555555PPPPPPPP55555G###B5PPPP5P5555PPPPPPG&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&P5555PB#BBP55555555PPPPPP55555555Y5555555555Y
5P5PP555555555555555555PPPPPP555555G##BB5PPP5555555PPPPPPG&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&P55555B#BBP55555555PPPPPP555555Y5Y55Y5555555Y
PPPPPPPPPPPPPPPPPP5PPPPPGGGGP555PPPG##B#PPPPPPPPPPGGGGBBB#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&GPPPPG##BBGGPPPPPPPGGGGGGPGGPGPPPPGPPGPPPPGPP
GBGBBGBGGGGBGGBGGBGGBGBBBBBBBGBGGBG###B&BBBBBBBGBBBBBBBBBG&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&BBBBGB##BGBGGGGPGGGBBBBBBGBBGBGGGGBGGGGGGGGGG";
Console.WriteLine(zdjecie);


			
		}


	}
}
