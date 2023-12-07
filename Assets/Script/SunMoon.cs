using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMoon : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite sun;
    [SerializeField] Sprite moon;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.sprite = sun;
    }

    // Update is called once per frame
    void Update()
    {
        if (spriteRenderer.sprite == moon)
        {

        }
    }
    //�}�E�X�N���b�N�����Ƃ�
    public void ChangeSky()
    {
        spriteRenderer.sprite = spriteRenderer.sprite == sun ? moon : sun;
    }
}