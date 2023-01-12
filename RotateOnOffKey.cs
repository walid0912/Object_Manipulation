using UnityEngine;
using System.Collections;

public class RotateOnOffKey : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    [SerializeField]
    private KeyCode key = KeyCode.R;
    private bool onoff = false;

    void Update()
    {
        if (Input.GetKeyDown(key))
            onoff = !onoff;
        if (onoff)
            transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
