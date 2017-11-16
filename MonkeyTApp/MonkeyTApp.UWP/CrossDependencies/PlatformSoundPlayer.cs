using System;
using Xamarin.Forms;
using MonkeyTApp.CrossDependencies;

[assembly: Dependency(typeof(MonkeyTApp.UWP.CrossDependencies.PlatformSoundPlayer))]

namespace MonkeyTApp.UWP.CrossDependencies
{
    public class PlatformSoundPlayer : IPlatformSoundPlayer
    {

        WinSoundPlayer winSoundPlayer;

        public void PlaySound(int samplingRate, byte[] pcmData)
        {
            if (winSoundPlayer == null)
            {
                winSoundPlayer = new WinSoundPlayer();
            }

            winSoundPlayer.PlaySound(samplingRate, pcmData);
        }
    }
}
