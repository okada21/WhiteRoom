using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //���N���b�N���V�[���ړ�
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene(scene);
        }
    }
}
