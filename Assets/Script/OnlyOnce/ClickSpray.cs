using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSpray : MonoBehaviour
{
    [SerializeField] GameObject jetspray;
    //���W
    Vector3 mousePos, worldPos, originPos;
    public float angle;

    // Start is called before the first frame update
    void Start()
    {
        //���˂̔�\��
        jetspray.SetActive(false);
        //�I�u�W�F�N�g���W�̎擾
        originPos = this.transform.position;
    }

    //�X�v���[���N���b�N���Ă���Ƃ�
    public void HaveSpray()
    {
        //���˂̕\��
        jetspray.SetActive(true);

        //�}�E�X���W�̎擾
        mousePos = Input.mousePosition;
        //�X�N���[�����W���烏�[���h���W�ɕϊ�
        worldPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10f));
        worldPos.x -= 0.25f;
        //�I�u�W�F�N�g�ړ�
        this.transform.position = worldPos;
        //��]
        this.transform.localEulerAngles = new Vector3(0.0f, 0.0f, angle);
    }

    //�X�v���[�𗣂����Ƃ�
    public void LetgoSpray()
    {
        //���˂̔�\��
        jetspray.SetActive(false);
        //�I�u�W�F�N�g�����Ƃ̈ʒu�ɖ߂�
        this.transform.position = originPos;
        this.transform.localEulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
    }
}
