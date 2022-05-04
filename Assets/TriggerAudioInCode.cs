using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAudioInCode : MonoBehaviour
{
    // make section in inspector to drag in audio clip
    // - always place before any functions (at top of script class) 

    [Header("Audio")]
    public AudioClip AudioClipName;

    // create instance of an audio source to refer to in code
    AudioSource AudioInstance;

    private void Awake()
    {
        // set created audio instance to refer to audio source added in inspector
        AudioInstance = GetComponent<AudioSource>();
    }

    void Start()
    {
        // trigger audio to play
        // - place wherever in your script you want to trigger your sound
        AudioInstance.PlayOneShot(AudioClipName);
    }

}

