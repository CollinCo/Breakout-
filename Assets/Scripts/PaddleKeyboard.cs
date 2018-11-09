using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleKeyboard : MonoBehaviour
{
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float screenWidthinUnits = 16f;

    private void Start()
    {

    }

    private void Update()
    {
        //Debug.Log(Input.mousePosition);
        float Pos = Paddle. / Screen.width * screenWidthinUnits;
        if (Input.GetKey("a"){
            
        }
        Vector2 paddlepos = new Vector2(mousePos, transform.position.y);
        transform.position = paddlepos;
    }

}
