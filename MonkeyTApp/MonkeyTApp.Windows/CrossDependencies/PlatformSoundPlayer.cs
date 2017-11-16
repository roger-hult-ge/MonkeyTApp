using System;
using Xamarin.Forms;
using MonkeyTApp.CrossDependencies;

[assembly: Dependency(typeof(MonkeyTApp.Windows.CrossDependencies.PlatformSoundPlayer))]

namespace MonkeyTApp.Windows.CrossDependencies
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
