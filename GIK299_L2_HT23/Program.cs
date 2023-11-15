namespace GIK299_L2_HT23
{
    //Denna kod är ett stöd för att se exempel på hur man kan utföra
    //vissa operationer som ni kommer ha nytta av under labb 2 i GIK299.
    //OBS! Ni ska inte koda i detta projekt utan skapa ert eget som ni laddar upp enligt labbinstruktion 
    //All kod som behövs för att lösa labb 2 finns inte i detta exempel så tänk på att
    //du kan komma att behöva hitta lösningar på andra sätt. Förslagsvis i boken, föreläsningsmaterial eller 
    //i dokumentationen för C#.

    //Observera att den här koden innehåller VÄLDIGT många kommentarer, det är för att vägleda dig och förklara begrepp
    // i anslutning till att nya koncept och begrepp introduceras. 

    //Inspireras av koden och använd den som ett stöd för att lösa labb 2. Notera att vissa delar i denna labb 
    //är på en mer avancerad nivå än vad som krävs för att klara labb 2. Ni behöver t.ex. inte använda er av varken
    //Stränginterpolation eller Random-klassen för labb 2. 

    using System;

    internal class Program
    {
        static void Main(string[] args)
        {

            //Hej och välkommen! Här visar jag hur man skapar en enkel applikation
            //med en meny som användaren kan välja att utföra olika handlingar ifrån.


            //för att skapa en meny har jag valt att använda mig av en while-loop. Den kommer att köras så länge som villkoret eller uttrycket inom parentesen utvärderas till true.

            //För att hålla koll på vad användaren väljer i menyn så börjar jag med att deklarera en variabel som håller värdet av det val som användaren kommer göra i menyn. 
            //Jag initierar den här variabeln till 0 eftersom den måste ha ett tilldelat värde för att kunna utvärderas.

            //Jag börjar med att deklarera en variabel som ska hålla värdet för vad användaren gör för val i menyn som jag ska skapa upp.

            int menuSelector = 0;

            //Så jag skapar upp en while-loop med nyckelordet while och inom parentes skriver jag villkoret för att loopen ska fortsätta köras.
            //Jag vill att användaren ska kunna välja att slumpa fram en lottorad samt kunna välja att avsluta, det är ju två alternativ
            //och jag bestämmer mig faktiskt redan nu för att det sista alterantivet, alternativ 2 ska vara att avsluta programmet.
            // så därför skriver jag villkoret såhär att jag vill att while-loopen ska köras så länge som inte menuSelector är likamed 2.
            //Sen skriver jag ut själva menyn till användaren så att hen kan veta hur jag vill att den här applikationen ska användas.


            while (menuSelector != 3) //en whileloop där variabeln menuSelector är villkoret som avgör om loopen ska fortsätta eller ej
            {
                Console.WriteLine(
                    "\n------------------------------------------------" +
                    "Välj ett av alternativen: " +
                    "\n1.) Lägg till husdjur och sortera dem i bokstavsordning" +
                    "\n2.) Slumpa fram en lottorad" +
                    "\n3. ) Avsluta" +
                    "------------------------------------------------"
                    );

                menuSelector = Int32.Parse(Console.ReadLine()); //läser in input från användaren. Eftersom vi får en sträng konverteras den till en int för att passa den datatyp som vi bestämt att menuSelector är.

                //För att avgöra vad användaren väljer så använder jag en switch-case.
                //Switch-uttrycket utvärderas en gång. Värdet av uttrycket jämförs med värdet av varje case.
                //Om det finns en match så körs den kod som finns i det case som matchar.
                //När C# når ett break-nyckelord så bryter den ut ur switch-blocket.
                //Detta stoppar exekveringen av koden och case-testning inuti blocket.
                //När en match hittas och jobbet är gjort så är det dags för en break (bokstavligt talat).
                //Det finns inget behov av mer testning då vi redan hittat matchningen.
                //Default-nyckelordet är valfritt och specifierar kod som ska köras om det inte finns någon matchning, t.ex. informera användaren om att
                //vi inte hittat någon match. Best practice är att placera default-nyckelordet sist i switch-blocket som i exemplet nedan.

                switch (menuSelector)
                {
                    case 1:
                        string[] pets = new string[5]; //anger att vi ska ska upp en ny array av typen sträng, i hakparenteserna skickar vi med
                                                       //antalet platser som vi vill att arrayen ska ha.

                        Console.WriteLine("Ange namnen på fem husdjur?"); //ber användaren att ange namnet på fem husdjur

                        //här använder jag en for-loop för att gå igenom arrayen och lägga till djuren som användaren skriver in
                        //en for-loop består av en räknare, ett villkor och en räknare som ökar eller minskar räknaren.
                        for (int i = 0; i < pets.Length; i++)
                        {

                            //Stanna här! Vad är det egentligen jag skriver som argument i WriteLinemetoden nedanför här?
                            //Det är ett dollartecken FÖRE strängen och måsvingar INUTI strängen! "OJ, OJ" kanske du tänker nu. Men det här
                            //är faktiskt inte särskilt svårt. Det kallas för stränginterpolation.
                            //Med $-tecknet så säger vi till kompilatorn att vi vill komma åt värdet av variabler inuti strängen. 
                            //Det är bra för oss människor då det gör att koden blir lättare att läsa och förstå.
                            //Istället för att jag behöver konkatenera strängen så kan jag här skriva in variabeln i strängen och kompilatorn
                            //kommer att hämta värdet som finns i de variabler som jag skriver inom måsvingarna.
                            //Här nedan kommer jag att fråga användaren vad djuren heter och sedan lägga till dem i arrayen. Eftersom jag är
                            // i en for-loop och har en räknare (i) så vill jag använda detta värde för att kunna lägga till djuren på rätt plats
                            //i arrayen. "Varför står det +1 efter i?" kanske du undrar. Det är för att vi börjar räkna från 0 i en array. Så om
                            //i är 0 så kommer vi att lägga till djuret på plats 1 i arrayen. Om i är 1 så kommer vi att lägga till djuret på plats 2.
                            //Så räknar en dator, men inte vi männsikor, så för att det ska bli mer lättförståeligt för användaren så lägger vi till +1 här.

                            Console.WriteLine($"vad heter djur nummer {i + 1}?"); //jag frågar användaren vad djuren heter 
                            pets[i] = Console.ReadLine(); //här tar jag emot användarens svar och spar på indexposition i i arrayen.
                                                          //så om i är 0 så kommer användarens svar att sparas på indexposition 0 i arrayen.

                        }

                        //För att sortera arrayen med husdjur så använder jag mig av Array-klassens Sort-metod och skickar med arrayen som
                        //argument till Sort-metodens parameterlista.

                        Array.Sort(pets); //Man kan även använda sort på en array som innehåller siffror men det går förstås att skriva denna funktionalitet själv om man vill få en bättre förståelse för den

                        Console.WriteLine("-----------------------------------------\nDina djur i bokstavsordning:\n-----------------------------------------------\n");
                        foreach (string pet in pets)
                        {
                            Console.WriteLine(pet);
                        }
                        break; //break betyder att vi ska ta oss ur det case i switch-loopen som vi befinner oss i här. 


                    // Vi ska skapa upp en lottorad och för det ska vi använda en grundläggande klass från namespacet System som kallas för Random.
                    //Genom att instansiera ett objekt av Randomklassen kommer vi åt Random-klassens metoder och det är ofta så man går tillväga när man vill använda metoder i en klass
                    //Ett exempel när vi dock INTE gör det är när vi använder Console-klassen, det beror på att Console-klassen är en så kallad statisk klass vilket innebär att vi inte 
                    //kan instansiera den utan vi får helt enkelt skriva klassnamnet följt av punkt för att komma åt metoderna som finns där.
                    //För Randomklassen så fungerar det lite annorlunda. Då skapar vi upp ett objekt av klassen Random. Och det gör vi genom att skriva på det här sättet.
                    //Det finns lite olika sätt man kan skriva på numer men det här är en ganska ursprunglig och grundläggande variant att instansiera ett objekt. 
                    //Sen ska vi skapa upp en array av typen int. Eftersom vi ska skapa en lottorad så bestämmer vi i förväg att den ska ha 7 index.
                    case 2:
                        Random random = new Random(); //Skapar upp en instans av klassen Random som vi kan använda för att slumpa fram tal
                                                      //jag döper den till random (notera litet r)

                        int[] lotteryRow = new int[7]; //skapar en array med 7 index där vi ska spara lottonumren
                        string lotteryRowStr = ""; //skapar en tom sträng.

                        //Använder en for-loop för att slumpa tal som jag lägger på olika index i arrayen lotteryRow
                        for (int i = 0; i < lotteryRow.Length; i++)
                        {
                            lotteryRow[i] = random.Next(1, 100); //använder Random-klassens Next-metod på
                                                                 //objektet random för att slumpa fram ett tal mellan 1 och 99


                            //för att inte numren ska skrivas ut utan mellanslag så skapar jag här upp en sträng så att jag 
                            //kan lägga in blanksteg mellan varje enskilt nummer i arrayen.
                            //Jag använder en if-sats för att kolla om vi är på sista indexet i arrayen.

                            //Om vi inte är det, det vill säga om vi är på ett index som inte är det sista så vill jag lägga till ett blanksteg
                            if (i != lotteryRow.Length - 1)
                            {
                                lotteryRowStr += lotteryRow[i] + " ";
                            }
                            else //...MEN om vi inte är på det sista indexet så vill jag lägga till blanksteg mellan numren 
                            {
                                lotteryRowStr += lotteryRow[i];
                            }


                        }

                        Console.WriteLine($"Din slumpade lottorad är: {lotteryRowStr}");
                        break;
                    case 3:
                        break;
                    default: //här ser ni default-case i switch-satsen som är det case som körs ifall inget annat case körs.
                        Console.WriteLine("Felaktig indata, du behöver ange ett nummer mellan 1 - 3\n");
                        break;
                } //här slutar switch-satsen

            } //här slutar while-loopen
        } // här slutar main-metoden
    } //här slutar klassen
}