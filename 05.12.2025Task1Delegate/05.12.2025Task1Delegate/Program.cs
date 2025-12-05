using System;
public delegate void SendNotification(string msg);

class Program
{
    public static void SendEmail(string mesaj)
    {
        Console.WriteLine($"Email göndərildi: {mesaj}");
    }

    public static void ShowAlert(string mesaj)
    {
        Console.WriteLine($"Ekranda bildiriş çıxdı: {mesaj}");
    }


    static void Main(string[] args)
    {
        SendNotification notification;
        notification = SendEmail;

        notification+= ShowAlert;

        notification("Yeni mesajınız var!");

    }
    
}