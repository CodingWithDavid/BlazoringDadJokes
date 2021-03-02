
namespace BlazorDadJokes.Client.Services
{
    public class ImageService
    {
        public int GetBackgroundImage()
        {
            System.Random rnd = new System.Random();

            int result = rnd.Next(1, 5);
            if (result > 5)
            {
                result = 1;
            }
            return result;
        }
    }
}
