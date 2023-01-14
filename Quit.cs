using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {

	protected void Update () {
        if (Input.GetButtonDown("Cancel"))
            Application.Quit();
	}
}
