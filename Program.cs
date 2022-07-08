using NAudio.Wave;

// var url = "http://media.ch9.ms/ch9/2876/fd36ef30-cfd2-4558-8412-3cf7a0852876/AzureWebJobs103.mp3";

var url = "https://cdn.pixabay.com/download/audio/2022/02/18/audio_345393e347.mp3?filename=midnight-blues-21179.mp3";

using(var audioSource = new MediaFoundationReader(url))
using(var outputDevice = new WaveOutEvent())
{
    outputDevice.Init(audioSource);
    outputDevice.Play();
    while (outputDevice.PlaybackState == PlaybackState.Playing)
    {
        Thread.Sleep(3000);
        outputDevice.Stop();
    }
}
