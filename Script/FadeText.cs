using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FadeText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    public float stop_s;
    public float r, g, b;
    //�����x
    float a;
    //�����ɂ���t���O
    bool aFlag;

    // Start is called before the first frame update
    void Start()
    {
        //�����x0
        a = 0.0f;
        aFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        //text�̃J���[�ݒ�
        text.color = new Color(r, g, b, a);
        //n�b��ϐF�J�n
        Invoke("EscalateAlpha", stop_s);

        if(aFlag)
        {
            if(a < 1.0f)
            {
                a += Time.deltaTime;
            }
            else
            {
                a = 1.0f;
                aFlag = false;
            }
        }
    }

    void EscalateAlpha()
    {
        aFlag = true;
    }
}
