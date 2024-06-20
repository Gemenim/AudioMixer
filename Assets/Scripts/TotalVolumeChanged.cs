using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TotalVolumeChanged : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;

    public void Change(float value)
    {
        _audioMixer.SetFloat("MainMixer", Mathf.Log10(value) * 20);
    }
}