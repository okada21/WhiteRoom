using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockKey : MonoBehaviour
{
    public AudioClip SE;
    AudioSource source;
    float a;
    // Start is called before the first frame update
    void Start()
    {
        //Component���擾
        source = GetComponent<AudioSource>();
        //�����ɂ���
        a = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, a);
    }

    public void clickKey()
    {
        //���炷
        source.PlayOneShot(SE);
    }
}
