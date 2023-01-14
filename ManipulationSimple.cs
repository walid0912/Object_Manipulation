using UnityEngine;
using System.Collections;

public class ManipulationSimple : MonoBehaviour
{
    private bool onoff = false;
    public float speed;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onoff = true;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            onoff = false;
        }

        if (onoff)
        {
            transform.Translate(speed * Input.GetAxisRaw("Mouse X"), 0, speed * Input.GetAxisRaw("Mouse Y"), Space.World);
        }
    }
}
