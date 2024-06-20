using UnityEngine;

public class AudioMute : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;

    public void MuteOnOff()
    {
        _audio.mute = !_audio.mute;
    }
}
