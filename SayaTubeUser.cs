using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

public class SayaTubeUser 
{	private int id;
	public string Username;
	private List <SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        Contract.Requires(username != null && username.Length <= 100);

        this.id = new Random().Next(10000, 99999);
        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public int getTotalVideoPlayCount()
    {
        int total = 0;
        for (int i = 0; i < this.uploadedVideos.Count; i++)
        {
            total = total + uploadedVideos[i].getPlayCount();
        }
        return total;
    }

    public void addVideo( SayaTubeVideo video)
    {
        Debug.Assert(video != null);
        // Debug.Assert(video.getPlayCount() > 0 && video.getPlayCount() < int.MaxValue);
        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {Username}");
        for (int i = 0; i < 8; i++) 
        {
            Console.WriteLine($"Video {i+1}: {uploadedVideos[i].getTitle()} " + $"oleh {Username}");
        }
    }

}
