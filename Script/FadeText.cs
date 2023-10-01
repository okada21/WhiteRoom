using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FadeText : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    bool aFlag;
    float a;
    // Start is called before the first frame update
    void Start()
    {
        aFlag = false;
        a = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        text.color = new Color(1.0f, 0.0f, 0.0f, a);
        Invoke("EscalateAlpha", 2.5f);

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
