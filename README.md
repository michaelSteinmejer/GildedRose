# GildedRose
 Test i C#

I denne opgave har jeg lagt stor vægt på refactorere koden, da det er et stort rod med nestede if statements.
Det er ikke nemt at håndtere nye typer, over tid ville det blive  meget uoverskueligt.

Jeg valgte at gøre følgende:

 1. først lavede jeg en mappe struktur med følgende navne: Model, Controller & Utility.
    1.2 I Model ligger Item, i Controller ligger ItemUpdatehandler, ItemAgedBrie, ItemBackstagePass, ItemConjured, ItemDefault & ItemSulfuras,
    i Utility ligger Utils.
 2. ItemsUpdateHandler er ansvarlig for at tildele item til den rigtig metode, alt efter switch casens udfald.
 3. De specifikke item klasser, sørger for at håndtere hvordan data skal behandles.
 4. Utils er lavet til at undgå duplicate method, da de samme tjeks går igen.
 5. Der er yderligere tilføjet Unit test til projektet(Kig eventuelt på Approval test delen, den er meget interessant).
 6. Der er yderligere tilføjet docstrings til metoderne, så man har en idé om hvad de gør.
 7. der er 100 % CodeCoverage på på alle klasser undtagen Item model class. 
 
Målet med det jeg har lavet, er at det skal være nemt at skabe sig et overblik, kode skal være vedligeholdelsesvenligt og let at læse, det har jeg valgt at gøre ved hjælp at en god struktur, og ved give information om hvad der sker i de enkelte klasser.
Grunden til at jeg valgte at lave unit test, er hvis der i fremtiden skulle tilføjes en ny type item, så kan man nemt teste om det eksisterende stadig virker. 
