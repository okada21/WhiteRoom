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
        //scriptを無効にする
        changeScene.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //現在の時間を増やす
        current_s += Time.deltaTime;
        //止めておく時間より多くなったら
        if(current_s > stop_s)
        {
            //scriptを有効にする
            changeScene.enabled = true;
        }
    }
}
