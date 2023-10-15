using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopScript : MonoBehaviour
{
    [SerializeField] ChangeScene changeScene;
    public float stop_s;
    float current_s;
    // Start is called before the first frame update
    void Start()
    {
        //script‚ð–³Œø‚É‚·‚é
        changeScene.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Œ»Ý‚ÌŽžŠÔ‚ð‘‚â‚·
        current_s += Time.deltaTime;
        //Ž~‚ß‚Ä‚¨‚­ŽžŠÔ‚æ‚è‘½‚­‚È‚Á‚½‚ç
        if(current_s > stop_s)
        {
            //script‚ð—LŒø‚É‚·‚é
            changeScene.enabled = true;
        }
    }
}
