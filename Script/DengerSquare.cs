using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DengerSquare : MonoBehaviour
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
        this.GetComponent<SpriteRenderer>().color = new Color(0.0f, 0.0f, 0.0f, a);
    }

    //�}�E�X�N���b�N�����Ƃ�
    public void GameOver()
    {
        //���炷
        source.PlayOneShot(SE);
        //�Q�[���I�[�o�[�ֈڍs
        SceneManager.LoadScene("GameOver");

    }

    //�X�v���[������������
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "spray")
        {
            a += Time.deltaTime;
            if (a > 1.0f)
            {
                a = 1.0f;
            }
        }
    }
}

