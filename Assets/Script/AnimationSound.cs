using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSound : MonoBehaviour
{
    public AudioClip SE;
    AudioSource source;
    void Start()
    {
        //Component���擾
        source = GetComponent<AudioSource>();
    }

    void Sound()
    {
        //���炷
        source.PlayOneShot(SE);
    }

}
