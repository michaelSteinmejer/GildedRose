# GildedRose
 Test i C#

I denne opgave har jeg lagt stor vægt på test driven development og refactoring. Udfordringen ligger i at der er noget eksisterende kode, som allerede virker, koden er dog dårligt struktureret og svær at tyde. Den bedste approach er skrive testen først og efterfølgende refactorere koden. Det ville her være smart at gøre brug af approval tests, da man efterfølgende kan gøre brug af resultatet af denne approval test når koden er refactoreret.

Jeg valgte at gøre følgende:

 1. Approval test for at sikre det rigtige resultat.
 2. Jeg lavede en mappe struktur med følgende navne: Model, Controller & Utility.
    1.2 I Model ligger Item, i Controller ligger ItemUpdatehandler, ItemAgedBrie, ItemBackstagePass, ItemConjured, ItemDefault & ItemSulfuras,
    i Utility ligger Utils.
 3. ItemsUpdateHandler er ansvarlig for at tildele item til den rigtig metode, alt efter switch casens udfald.
 4. De specifikke item klasser, sørger for at håndtere hvordan data skal behandles.
 5. Utils er lavet til at undgå duplicate method, da de samme tjeks går igen.
 6. Der er yderligere tilføjet seperate unit tests.
 7. Der er yderligere tilføjet docstrings til metoderne, så man har en idé om hvad de gør.
 8. der er 100 % CodeCoverage på på alle klasser. 
 
Målet med det jeg har refactoreret, er at koden skal være vedligeholdelsesvenlig og let at læse, det har jeg valgt at gøre med en god struktur, og ved give information om hvad der sker i de enkelte klasser.
Grunden til at jeg valgte at lave unit test, er hvis der i fremtiden skulle tilføjes en ny type item, ville det være nemt at teste den enkelte klasse.

OBS! Jeg forsøgte at klone og builde projektet som forskrevet, men desværre var der build issues, det er som om at build filen ikke registrerede pakkerne korrekt. Jeg førsøgte at opdatere til nyere versioner i package.json, det virkede heller ikke, så jeg valgte derfor at lave et helt nyt projekt.

![alt text](https://github.com/michaelSteinmejer/GildedRose/blob/master/error.PNG)
