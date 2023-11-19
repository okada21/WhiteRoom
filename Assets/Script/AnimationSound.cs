using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSound : MonoBehaviour
{
    public AudioClip SE;
    AudioSource source;
    void Start()
    {
        //Componentを取得
        source = GetComponent<AudioSource>();
    }

    void Sound()
    {
        //音鳴らす
        source.PlayOneShot(SE);
    }

}
