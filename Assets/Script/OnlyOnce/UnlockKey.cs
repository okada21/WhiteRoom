using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockKey : MonoBehaviour
{
    public AudioClip waitSE;
    public AudioClip enableSE; 
    Animator anim;
    AudioSource source;
    Color color;
    public int clicknum_limit;
    int clicknum;
    bool enable;
    // Start is called before the first frame update
    void Start()
    {
        //Component���擾
        anim = gameObject.GetComponent<Animator>();
        source = GetComponent<AudioSource>();
        //�����ɂ���
        color = this.GetComponent<SpriteRenderer>().color;
        color.a = 0.0f;
        this.GetComponent<SpriteRenderer>().color = color;
        //�N���b�N��
        clicknum = 0;
        //��������
        enable = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void clickKey()
    {
        if (!enable)
        {
            clicknum++;
            if (clicknum != clicknum_limit)
            {
                //���炷
                source.PlayOneShot(waitSE);
            }
            else
            {
                color.a = 1.0f;
                this.GetComponent<SpriteRenderer>().color = color;
                enable = true;
                //���炷
                source.PlayOneShot(enableSE);
            }
        }
        else
        {
            //
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("None"))
            {
                anim.SetTrigger("Unlock");
            }
        }

    }
}
