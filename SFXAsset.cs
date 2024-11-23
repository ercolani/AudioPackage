using System;
using System.Linq;
using CardboardCore.DI;
using UnityEngine;
using UnityEngine.Audio;
using Random = UnityEngine.Random;

[CreateAssetMenu(fileName = "NewSFXAsset", menuName = "ScriptableObject/SFXAsset")]
public class SFXAsset : ScriptableObject
{
    //[Inject] private AudioManager audioManager;

    //public bool InLoop = false;
    //[Range(0, 1)] public float Volume = 0.75f;
    //[Range(0, 1)] public float Pitch = 1; 
    //[Range(0, 1)] public float PitchDeviation = 0.15f;
    //public AudioMixerGroup AudioMixerGroup;
    //public AudioClip[] _audioClips;

    //private int lastIndex = 0;

    //public void Play(string channel = "")
    //{
    //    if (audioManager == null)
    //    {
    //        Injector.Inject(this);
    //    }

    //    audioManager.SfxManager.PlayClip(this, channel);
    //}

    //public AudioChannel PlayAndGetChannel(string channel = "")
    //{
    //    return audioManager.SfxManager.PlayClip(this, channel);
    //}

    //public float GetRandomPitch()
    //{
    //    return Random.Range(Pitch - PitchDeviation, Pitch + PitchDeviation);
    //}

    //public AudioClip GetRandomAudioClip()
    //{
    //    if(_audioClips.Count() == 0)
    //    {
    //        return null;
    //    }
    //    int newIndex = (lastIndex + Random.Range(1, _audioClips.Length - 1)) % _audioClips.Length;
    //    lastIndex = newIndex;
    //    return _audioClips[newIndex];
    //}
}
