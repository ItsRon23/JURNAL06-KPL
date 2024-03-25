using System;

class Program
{
    static void Main()
    {
        SayaTubeVideo video = null;
        SayaTubeUser user = null;

        user = new SayaTubeUser("Aaron Joseph");
        video = new SayaTubeVideo("Review of Tintin");
        user.addVideo(video);
        video = new SayaTubeVideo("Review Film Gundala");
        user.addVideo(video);
        video = new SayaTubeVideo("Review Film Pacific Rim");
        user.addVideo(video);
        video = new SayaTubeVideo("Review Film Avengers");
        user.addVideo(video);
        video = new SayaTubeVideo("Review Film Transformers");
        user.addVideo(video);
        video = new SayaTubeVideo("Review Film Transformers 2");
        user.addVideo(video);
        video = new SayaTubeVideo("Review Film Fast & Furious");
        user.addVideo(video);
        video = new SayaTubeVideo("Review Film Fast X");
        user.addVideo(video);

        for (int i = 0; i < 25000000; i++)
        {
            video.IncreasePlayCount(1);
        }

        video.PrintVideoDetails();
        user.PrintAllVideoPlaycount();

        /* try
        {
            user = new SayaTubeUser("Aaron Joseph");
            video = new SayaTubeVideo("Review of Tintin");
            user.addVideo(video);
            video = new SayaTubeVideo("Review Film Gundala");
            user.addVideo(video);
            video = new SayaTubeVideo("Review Film Pacific Rim");
            user.addVideo(video);
            video = new SayaTubeVideo("Review Film Avengers");
            user.addVideo(video);
            video = new SayaTubeVideo("Review Film Transformers");
            user.addVideo(video);
            video = new SayaTubeVideo("Review Film Transformers 2");
            user.addVideo(video);
            video = new SayaTubeVideo("Review Film Fast & Furious");
            user.addVideo(video);
            video = new SayaTubeVideo("Review Film Fast X");
            user.addVideo(video);

            for (int i = 0; i < 25000000; i++)
            {
                video.IncreasePlayCount(1);
            }
        }
        catch (Exception tes)
        {
            Console.WriteLine("Error: " + tes.Message);
        }
        finally
        {
            if (video != null)
            {
                video.PrintVideoDetails();
                user.PrintAllVideoPlaycount();                
            }
        }*/
    }
}