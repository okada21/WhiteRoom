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
        //script�𖳌��ɂ���
        changeScene.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //���݂̎��Ԃ𑝂₷
        current_s += Time.deltaTime;
        //�~�߂Ă������Ԃ�葽���Ȃ�����
        if(current_s > stop_s)
        {
            //script��L���ɂ���
            changeScene.enabled = true;
        }
    }
}
