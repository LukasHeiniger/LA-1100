# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

Lukas Heiniger

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

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

✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Der Computer soll am anfang des Spieles eine Zahl generieren und anzeigen             | Der Tester muss das Programm starten.        | Der Computer generiert eine Zahl und zeigt sie an     |         
| 2.1  | Es soll möglich sein ein Zahl einzugeben             | Der Tester muss eine Zahl eingeben        |  Der Computer merkt sich die Zahl.                 |
| 3.1  | Es soll möglich sein das Spiel zu gewinnen mit hilfe von >/</= ist die generierte Zahl.            | Der Tester soll mit Hilfe von </>/= das Spiel gewinnen können        | Der Spieler kann das Spiel gewinnen.                  |
| 4.1  | Am ende des Spiel sollen die Anzahl versuche dargestellt werden.            | Der Tester muss das Spiel spielen.        | Es wird angezeigt das der Tester zum Beispiel 4 versüche bracuhte.                  |
| 5.1  | Es sollen nur Zahlen zwischen 1 und 100 akzeptiert werrden.             | Der Tester soll eine Zahl die kleiner als 0 ist oder grösser als 100 eingeben        |  Das Programm soll eine Fehlermeldung abgeben und bitten eine richtige Eingabe zubetätigen.                |
| 6.1  | Es soll möglich sein eingebaute Features zu testen z.B den nochmal Spiele Button oder die Verschieden Schwierigkeitmoduse           | Der Tester soll auf den Button nochmal Spielen klicken können oder ander Moduse zustarten         |  Wenn man den Button klickt soll man wieder spielen können. Und das man schwierigere Moduse spielen kann.                 |
| ...  |              |         |                   |
| ...  |              |         |                   |
| ...  |              |         |                   |
| ...  |              |         |                   |




✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

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
| 12.A |  3 Woche     | Lukas          | Herausfinden wie ich Features einbauen kann.             |   45min            |
| 13.A |  3 Woche     | Lukas           | Features einbauen             |   45min            |
| 1.A  |       |           |              |               |
| ...  |       |           |              |               |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

Ich habe mich dazu entschieden wenn ich genügen Zeit habe einige Features einzubauen wie z.B das man das Spiel direkt nochmal Spielen kann oder auch das es verschiedene Schwierigkeitsgrade geben soll.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |   1.09.2022    |   Lukas     |    45min           |   20min                |
|2.A  | 1.09.2022      |  Lukas        |  45min            |    15min               |
| 3.A  | 1.09.2022       |   Lukas        |   45min            |       20min            |
| 4.A | 1.09.2022      |   Lukas        |  45min             |   10min                |
| 5.A  |  1.09.2022     |   Lukas        |   45min            |  5min                 |
| 6.A  | 1.09.2022       |   Lukas        |    45min          |    35min               |
| 7.A  | 1.09.2022       |   Lukas        |     45min          |    20min               |
| 9.A  |  8.09.2022     |   Lukas        |   45            |       8min            |
| 3.A  |       |   Lukas        |               |                   |
| ...  |       |   Lukas        |               |                   |
| 1.A  |       |   Lukas        |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
