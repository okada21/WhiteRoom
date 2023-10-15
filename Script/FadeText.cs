using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FadeText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    public float stop_s;
    public float r, g, b;
    //透明度
    float a;
    //透明にするフラグ
    bool aFlag;

    // Start is called before the first frame update
    void Start()
    {
        //透明度0
        a = 0.0f;
        aFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        //textのカラー設定
        text.color = new Color(r, g, b, a);
        //n秒後変色開始
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
