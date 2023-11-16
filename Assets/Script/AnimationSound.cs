using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSound : MonoBehaviour
{
    public AudioClip SE;
    AudioSource source;
    void Start()
    {
        //Component‚ðŽæ“¾
        source = GetComponent<AudioSource>();
    }

    void Sound()
    {
        //‰¹–Â‚ç‚·
        source.PlayOneShot(SE);
    }

}
