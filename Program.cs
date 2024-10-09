﻿using DesafioPOO.Models;




internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("SmartFone Iphone:");
        Smartphone iphone = new Iphone("88888888", "Iphone 1", "22222222", 128);
        iphone.Ligar();
        iphone.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\n");

        Console.WriteLine("SmartFone Nokia:");
        Smartphone nokia = new Nokia("88888888", "Nokia 1", "22222222", 64);
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Telegram");
    }
}