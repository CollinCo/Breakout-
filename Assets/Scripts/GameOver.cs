﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision) {
        SceneManager.LoadScene("Game Over");
        Debug.Log("Touched bottom");
    }
}
