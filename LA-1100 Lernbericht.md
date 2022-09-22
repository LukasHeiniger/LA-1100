# Lern-Bericht LA-1100
Name: Lukas Heiniger

## Einleitung

Ich habe ein Spiel mit C# programmiert in dem man eine Zahl zwischen 1 und 100 raten muss.

## Was habe ich gelernt?

Ich habe gelernt wie ich eine Zahl generieren kann auch, wenn Variablen vorhanden sind.

## Beschreibung

In meinem Projekt, dem Zahlenratespiel musste ich mich dem Problem Zahlen generieren stellen. Ich habe also gelernt, wie man eine Zahl generiert, dafür habe ich viele Informationen aus dem Internet gefunden, zudem musste ich mir auch überlegen, wie ich den Zahlengenerator einbauen möchte.

Hier ein PAP zur einfachen Generierung einer Zahl.

![image](https://user-images.githubusercontent.com/111046378/191698104-129d71ab-9901-4820-8617-80385218b6f0.png)

Da ich in meinem Projekt einen Hardcoremodi möchte, musste ich mir überlegen wie ich, ohne dass ich den Code ändern muss, sprich den Code einfach kopieren und unter dem 
bestehenden Code wieder einfüge. Dann habe ich mich dafür entschieden, dass ich die obere Grenze sprich 100 als Variable speichere. Das heisst es ist möglich im Spiel seine eigene Grenze festzulegen.
Hier ein Code Beispiel

```csharp
  
    int höhe = 100;
    
    Random Zahl = new Random();
    int randomzahl = Zahl.Next(0, höhe);

    Console.WriteLine("Sie können nun ihre eigene Zahl festlegen von 0 bis x ");
    int x = Convert.ToInt32(Console.ReadLine());
    höhe = x;

```



## Verifikation


Durch mein PAP kann man sehen, wie ich das Prinzip eines Zahlengenerators verstehe und weiss wie er funktioniert.
Durch den Text kann man herauslesen, wie ich das ganze Thema behandle und wie ich meine Probleme gelöst habe z.B , mit "höhe" als Variable für die Zahlen Generierung.
Durch den Code kann man sehen, wie ich das Problem mit der Variable gelöst habe und wie ich einen Zahlengenerator programmiert habe.



# Reflexion zum Arbeitsprozess

Das Zuhause arbeiten ist mir gut gelungen, da ich mich besser konzentrieren konnte als in der Schule.

Das recherchieren ist mir nicht gut gelungen, da ich nicht spezifisch für das Thema recherchiert habe z.B falsche Programmiersprache etc..

In den nächsten Projekte versuche ich spezifischer zu rechechieren z.B. nach C# oder anfänger Code.

Lernbericht von Lukas Heiniger

