using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSquare : MonoBehaviour
{
    public Vector3 move;
    public float speed; 
    Vector3 movePos;
    public GameObject square;
    // Start is called before the first frame update
    void Start()
    {
        square.SetActive(true);
        movePos = this.gameObject.transform.position - move;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MouseClick()
    {
        
        transform.Translate(movePos * Time.deltaTime * speed);
        //square.SetActive(false);
    }
}
