using UnityEngine;

public class ChangeColorOnMouse : MonoBehaviour
{
    private Material mat;

    [SerializeField] private Material
        newMat;
        
    private void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material = newMat;
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material = mat;
    }
}