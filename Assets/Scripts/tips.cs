using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tips : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cheer('lemao');
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /// <summary>
    /// Prints custom message to the console
    /// </summary>
    /// <param name="ayylmao">Ayylmao.</param>
    void Cheer(string ayylmao) {
        Debug.Log(ayylmao);
    }
}
