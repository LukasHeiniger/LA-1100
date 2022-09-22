# Projektdokumentation LA-1100

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

Lukas Heiniger

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|  1.09.2022     | Alpha 1.0  | Das Hauptprogramm mit allen muss Anforderungen ist fertig. |
|  8.09.2022     | Alpha 1.1 | Das Spiel mit allen muss und kann Anforderungen ist fertig. |                                                            |
|  8.09.2022     | Alpha 1.2  | Features wurden eingebaut (Hardcoremode) |
|  15.09.2022    | Alpha 1.3  | Das Spiel hat nun Farbe und Bugs wurden gefixt|
|  15.09.2022    | Beta 1.0  | Das Spiel ist Fertig und wird noch getestet |
|  22.09.2022    | Release   |  Das Spiel ist Fertig und wurde getestet. Es ist nun Fertig.|
## 1 Informieren

### 1.1 Ihr Projekt

Ich mache ein kleines Spiel in dem man eine Zahl von 1-100 raten muss.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | muss            | Funktionale Anforderung     | Als ein Spieler möchte ich dass der Computer eine Zufallszahl zwischen 1 und 100 generiert, damit man eine Zahl raten kann.                    |
| 2    | muss            | Funktionale Anforderung      | Als ein Spieler möchte ich dass ich eine Zahl raten kann, damit ich das Spiel gewinnen kann.                                   |
| 3    | muss            | Funktionale Anforderung     | Als ein Spieler möchte ich dass der Computer mir einen Hinweis gibt ob die Zahl grösser, kleiner oder richtig ist, damit das Spiel einfacher wird.   |
| 4    | kann            | Qualitatanforderung     | Als ein Spieler möchte ich dass der Computer mir, wenn ich das Spiel gewonnen habe eine Nachricht ausgibt wie viele versüche ich brauchte, damit ich mich mit anderen vergleichen kann.                 |
| 5    | kann            | Qualitatanforderung     | Als ein Spieler möchte ich dass der Computer nur Zahlen zwischen 1 und 100 als eingabe akzeptiert, damit man keine Fehlermeldung bekommt.             |
| 6    | kann            |  Randanforderungen    | ALs ein Spieler möchte ich das man andere Spielmodis spielen kann, damit das Spiel immer spannend bleibt.|
| 7   | kann            |  Randanforderungen    | ALs ein Spieler möchte ich das man Farbe im Spiel hat, damit das Spiel schöner aussieht.|
| 8 | kann            |  Randanforderungen    | ALs ein Spieler möchte ich einen Timer den ich selber festlegen kann, damit ich mir Challanges stellen kann.|


✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |Programm ist gestarten | Der Tester muss das Programm starten.        | Der Computer generiert eine Zahl und wird durch Breakpoints im debbuger sicht bar.   |         
| 2.1  | Das Spiel wurde gestarten | Der Tester muss eine Zahl eingeben        |  Der Computer merkt sich die Zahl und kann durch Breakpoints sicht bar gemacht werden.                |
| 3.1  | Eine Zahl wurde eingegeben     | Der Spieler gibt eine Zahl ein     | Die Zahl ist grösser als die Generierte Zahl.  / Die Zahl ist kleiner als die Generierte Zahl.                |
| 4.1  | Spiel wurde gewonnen          | Der Tester muss das Spiel spielen.        | Es wird angezeigt das der Tester zum Beispiel 4 versüche gebraucht hatte.                  |
| 5.1  | Der Spieler hat eine Falsche eingabe betätigt, | Der Tester soll eine falsche Eingabe betätigen.|  Das Programm soll eine Fehlermeldung abgeben und bitten eine richtige Eingabe zubetätigen.                |
| 6.1  | Das Spiel wurde 3 mal gewonnen | Der Tester kann entscheiden ob er einen schwierigeren Modus spielen möchte.|Wenn man Nein klickt soll man wieder spielen können. Und das man Ja schreibt soll man schwierigere Modisspielen können                 |
| 7.1  |  Spiel wurde gestartet            |  Spieler startet Spiel       |  Das Spiel wird mit blauer Farbe angezeigt.|
| 8.1 |  Spiel wurde gestartet            |  Timer festlegen.       | Nach abgelofener Zeit hat man verloren.                  |







### 1.4 Diagramme

![image](https://user-images.githubusercontent.com/111046378/186597793-93fb985a-a3d6-43bb-bcfa-cafbeae72c4c.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  1 Woche 1.Sep    | Lukas        | Herausfinden wie man eine Zufallzahl generieren lässt.   |   45min            |
| 2.A  |  1 Woche     | Lukas          | Zufallzahlgenerator ins Programm einbauen   |   45min            |
| 3.A  |  1 Woche     | Lukas          | Herausfinden wie man eine Zahl vergleichen kann und wie man sie eingeben kann     |   45min            |
| 4.A  |  1 Woche     | Lukas          | Einbauen das eine Eingebene Zahl mit der generierten Zahl verglichen wird.              |   45min            |
| 5.A  |  2 Woche 8.Sep   | Lukas          | Herausfinden wie man grösser kleiner oder gleich benutz beim coden.             |   45min            |
| 6.A  |  2 Woche     | Lukas          | Einbauen das angezeigt wird ob die Zahl grösser, kleiner oder richtig ist.             |   45min            |
| 7.A  |  2 Woche     | Lukas          | Herausfinden wie ich Anzahl versüche speichern kann und sie am Ende anzeigen kann.      |   45min            |
| 8.A  |  2 Woche     | Lukas          | Highscore ein bauen.             |   45min            |
| 9.A  |  3 Woche 15. Sep    | Lukas          | Herausfinden wie ich dem Programm sagen kann dass diese Eingabe falsch ist und eine Fehlermeldung angezeigt werden soll.             |   45min            |
| 10.A |  3 Woche     | Lukas          | Einbauen der Fehlermeldung wenn keine Zahl zwischen 1-100 eingegeben wird.              |   45min            |
| 11.A |  3 Woche      | Lukas         | Der Spieler soll entscheiden, ob er nochmal spielen möchte.             | 45min|
| 12.A |  3 Woche     | Lukas          | Highscore (Plus Name)           |   45min            |
| 13.A |  3 Woche     | Lukas           | Hardcore mode           |   45min            |
| 14.A  | 4 Woche      |  Lukas        |  Herausfinden wie ich Farbe in mein Spiel bringen kann.            |     45          | 
| 15.A | 4 Woche      |   Lukas        |  Farbe einfügen      |    45            |
| 16.A | 4 Woche      |   Lukas        |  Herausfinden wie ich einen Highscoore einbauen kann damit die Namen gespeichert werden    |    45  |
| 17.A | 4 Woche      |   Lukas        |  Highscooretabelle einfügen    |    45  |
| 18.A | 4 Woche      |   Lukas        |  Bugs beheben und allgemein den Code aufräumen    |    45  |
Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

Ich habe mich dazu entschieden wenn ich genügen Zeit habe einige Features einzubauen wie z.B das man das Spiel direkt nochmal Spielen kann oder auch das es verschiedene Schwierigkeitsgrade geben soll. Ich habe mich dafür entschieden das ich Farbe im Spiel haben möchte. Ich habe mich dazu entschieden noch Bugs zufixen z.B Try and catch das funktioniert noch nicht ganz.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |   1.09.2022    |   Lukas     |    45min           |   20min                |
|2.A  | 1.09.2022      |  Lukas        |  45min            |    20min               |
| 3.A  | 1.09.2022       |   Lukas        |   45min            |       20min            |
| 4.A | 1.09.2022      |   Lukas        |  45min             |   20min                |
| 5.A  |  1.09.2022     |   Lukas        |   45min            |  20min                 |
| 6.A  | 1.09.2022       |   Lukas        |    45min          |    35min               |
| 7.A  | 1.09.2022       |   Lukas        |     45min          |    25min               |
| 9.A  |  8.09.2022     |   Lukas        |   45min            |       30min            |
| 10.A  |  8.09.2022     |   Lukas        |     45min          |    40 min             |
| 11.A  | 8.09.2022      |   Lukas        |   45min            |    50min               |
| 12.A  |  8.09.2022    |   Lukas        |  45min             |    45min               |
| 13.A  |  8.09.2022     |   Lukas        |  45min             |   60min            |
| 14.A  |  15.09.2022    |   Lukas        |  45min             |   35min          |
| 15.A  |  15.09.2022       |   Lukas        |  45min             |   20min           |
| 16.A  |  15.09.2022      |   Lukas        |  45min             |   60min            |
| 17.A  |  15.09.2022      |   Lukas        |  45min             |                    |
| 18.A  |  15.09.2022      |   Lukas        |  45min             |   60min            |
✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 22.09.2022     |  funktioniert        | Lukas Heiniger        |
| 2.1  | 22.09.2022     |  funktioniert        | Lukas Heiniger        |
| 3.1  | 22.09.2022     |  funktioniert        | Lukas Heiniger        |
| 4.1  | 22.09.2022     |  funktioniert        | Lukas Heiniger        |
| 5.1  | 22.09.2022     |  funktioniert         | Lukas Heiniger        |
| 6.1  | 22.09.2022     |  funktioniert         | Lukas Heiniger        |
| 7.1  | 22.09.2022     |  funktioniert         | Lukas Heiniger        |
| 8.1  | 22.09.2022     |  nicht vorhanden        | Lukas Heiniger        |


Ich bin zufrieden mit allen Testergebnisse ausserd vielleicht mit dem letzten, da ich den Timer nicht einbauen konnte. Das Spiel funktioniert aber trozdem
und ist auf den Timer nicht angewiesen.


## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
