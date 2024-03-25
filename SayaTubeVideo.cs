using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;


    private int GenerateRandomId()
    {
        Random num = new Random();
        return num.Next(10000, 99999);
    }

    public SayaTubeVideo(string title)
    {
        Contract.Requires(title != null && title.Length <= 200, "Judul video harus memiliki panjang max 200 karakter dan tidak boleh null.");

        this.id = GenerateRandomId();
        this.title = title;
        this.playCount = 0;
    }
    public void IncreasePlayCount(int count)
    {
        Contract.Requires(count > 0 && count <= 25000000, "Input penambahan play count max 25.000.000.");
        Contract.Ensures(playCount <= int.MaxValue - count, "Penambahan play count melebihi max.");

        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Penambahan play count melebihi batas maksimal.");
        }
    }


    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }

    public int getPlayCount()
    {
        return playCount;
    }

    public string getTitle() 
    {
        return title;
    }
}

