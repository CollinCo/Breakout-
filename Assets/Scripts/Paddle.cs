using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Paddle - bottom paddle object
/// relies on mouse input for control
/// </summary>
public class Paddle : MonoBehaviour {
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float screenWidthinUnits = 16f;

    private void Start() {

    }

    private void Update() {
        //Debug.Log(Input.mousePosition);
        float mousePos = Input.mousePosition.x / Screen.width * screenWidthinUnits;
        Vector2 paddlepos = new Vector2(mousePos, transform.position.y);
        transform.position = paddlepos;
    }

}
