using UnityEngine;
using VContainer;
using VContainer.Unity;

public interface IAudioPlayer
{
    void PlaySound();
}

public class NormalAudioPlayer : IAudioPlayer
{
    public void PlaySound()
    {
        Debug.Log("Plays a normal sound");
    }
}


public class AudioService
{
    private readonly IAudioPlayer _audioPlayer;

    [Inject]
    public AudioService(IAudioPlayer audioPlayer)
    {
        _audioPlayer = audioPlayer;
    }

    public void PlaySound()
    {
        _audioPlayer.PlaySound();
    }

}

public class AudioPresenter : ITickable
{
    private readonly AudioService _audioService;

    [Inject]
    public AudioPresenter(AudioService audioService)
    {
        _audioService = audioService;
    }

    private KeyCode playSoundKey = KeyCode.Space;

    public void Tick()
    {
        if (Input.GetKeyDown(playSoundKey))
        {
            _audioService.PlaySound();
        }
    }
}