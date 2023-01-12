using System.Collections;
using UnityEngine;

public class RotateDuringKeyPressed : MonoBehaviour
{
    [SerializeField] private float
        speed = 5.0f;

    [SerializeField] private KeyCode
        key = KeyCode.R;
    
    private void Start()
    {
    }
    
    private void Update()
    {
        if (Input.GetKey(key))
            transform.Rotate(0, speed * Time.deltaTime, 0, Space.Self);
    }
}