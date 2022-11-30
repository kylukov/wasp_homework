using System;

namespace wasp_3;

internal class Program
{
    static void Main(string[] args)
    {
        Audio lsp_audio = new Audio("Crazy_song", "POP", "LSP", "MSK", 1);
        Audio pharaoh = new Audio("Crazyness", "POP", "pharaoh", "MSK", 3);

        DVD dvd_filb = new DVD("Pirats of Caribean", "Traveling", "HZ", "IDK", 140);
        DVD dvd_film = new DVD("Red Notice", "Dramma", "HZ", "IDK", 153);

        Console.WriteLine(lsp_audio.ToString());
        Console.WriteLine(dvd_filb.ToString());
        Console.WriteLine();

        Store store1 = new Store("GeekAudios+DVDs", "MSK");
        store1.AddAudio(lsp_audio);
        store1.AddAudio(pharaoh);

        store1.AddDvd(dvd_filb);
        store1.AddDvd(dvd_film);

        Console.WriteLine(store1.ToString());
        Console.ReadKey();
    }
}