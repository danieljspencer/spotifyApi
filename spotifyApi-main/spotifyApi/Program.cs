using System;
using System.Threading.Tasks;
using SpotifyAPI.Web;

class Program
{
    static async Task Main()
    {
      var spotify = new SpotifyClient("BQD1F0qnRBtMhO52xRXGemkCIkCIu94I19Ts3V6vrf19MOkUc_IApORAzDr2oi2Sg5H5rCrO1t3EDVAm5pK_hQW3ppxBn8jKb7kDD31VBOhD3koi6NC7");

      var track = await spotify.Tracks.Get("1s6ux0lNiTziSrd7iUAADH");
      Console.WriteLine(track.Name);
    }
}