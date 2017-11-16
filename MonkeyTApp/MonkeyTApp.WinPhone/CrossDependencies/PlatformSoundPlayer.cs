using System;
using Xamarin.Forms;
using MonkeyTApp.CrossDependencies;

[assembly: Dependency(typeof(MonkeyTApp.WinPhone.CrossDependencies.PlatformSoundPlayer))]

namespace MonkeyTApp.WinPhone.CrossDependencies
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
