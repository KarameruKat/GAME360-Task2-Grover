using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum SoundType
{
    SHOOT,
    COIN,
    DIE,
    LOSE,
    WIN
}

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] soundList;
    private static AudioManager instance;
    private AudioSource audioSource;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public static void PlaySound(SoundType sound, float volume = 3)
    {
        instance.audioSource.PlayOneShot(instance.soundList[(int)sound], volume);
    }
}
