using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSpray : MonoBehaviour
{
    [SerializeField] GameObject jetspray;
    //座標
    Vector3 mousePos, worldPos, originPos;
    public float angle;

    // Start is called before the first frame update
    void Start()
    {
        //噴射の非表示
        jetspray.SetActive(false);
        //オブジェクト座標の取得
        originPos = this.transform.position;
    }

    //スプレーをクリックしているとき
    public void HaveSpray()
    {
        //噴射の表示
        jetspray.SetActive(true);

        //マウス座標の取得
        mousePos = Input.mousePosition;
        //スクリーン座標からワールド座標に変換
        worldPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10f));
        worldPos.x -= 0.25f;
        //オブジェクト移動
        this.transform.position = worldPos;
        //回転
        this.transform.localEulerAngles = new Vector3(0.0f, 0.0f, angle);
    }

    //スプレーを離したとき
    public void LetgoSpray()
    {
        //噴射の非表示
        jetspray.SetActive(false);
        //オブジェクトをもとの位置に戻す
        this.transform.position = originPos;
        this.transform.localEulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
    }
}
