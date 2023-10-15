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
        //Componentを取得
        source = GetComponent<AudioSource>();
        //透明にする
        a = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<SpriteRenderer>().color = new Color(0.0f, 0.0f, 0.0f, a);
    }

    //マウスクリックしたとき
    public void GameOver()
    {
        //音鳴らす
        source.PlayOneShot(SE);
        //ゲームオーバーへ移行
        SceneManager.LoadScene("GameOver");

    }

    //スプレーが当たった時
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

