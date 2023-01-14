using System.Collections;
using UnityEngine;

/// <summary>
/// Script for Orbital Movement
/// Permet de tourner autour d'une <paramref name="targetCenter"/> à l'aide des axes <paramref name="panAxis"/> et <paramref name="tiltAxis"/>, et de zoomer sur le centre à l'aide de <paramref name="zoomInKey"/> et  <paramref name="zoomOutKey"/>
/// </summary>
public class OrbitalCamera : NavigationCamera {

    [SerializeField]
    private float
            zoomSpeed = 0.5f;

    [SerializeField]
    private float
            rotationSpeed = 50;

    [Tooltip("If NULL : Empty GameObjet at origin")]
    [SerializeField]
    private GameObject
            targetCenter;

    [SerializeField]
    private string
            panAxis = "Horizontal";

    [SerializeField]
    private string
            tiltAxis = "Vertical";

    [SerializeField]
    private KeyCode
            zoomInKey = KeyCode.KeypadPlus;

    [SerializeField]
    private KeyCode
            zoomOutKey = KeyCode.KeypadMinus;

    protected override void Start() {
        base.Start();
        if (targetCenter == null) {
            Debug.LogWarning(this.gameObject + ".OrbitalCamera : targetCenter is null, creating target object... ");
            targetCenter = new GameObject();
            targetCenter.transform.position = Vector3.zero;
            targetCenter.name = "OrbitalCameraCenter";
            Debug.LogWarning("... target object is " + targetCenter);
        }
        if (Mathf.Abs(speedVariationOnZoom) < 0.1f)
            speedVariationOnZoom = 1;
    }

    protected override void UpdateCamera() {
        navigationCamera.fieldOfView += Input.GetAxis("Zoom") * zoomSpeed;
       
        var x = -Input.GetAxis(panAxis) * Time.deltaTime * rotationSpeed;
        var z = Input.GetAxis(tiltAxis) * Time.deltaTime * rotationSpeed;

        //public void RotateAround(Vector3 point, Vector3 axis, float angle);
        //Rotates the transform about axis passing through point in world coordinates by angle degrees.
        navigationCamera.transform.RotateAround(targetCenter.transform.position, targetCenter.transform.up, x); //up is Y (green) of the target
        navigationCamera.transform.RotateAround(targetCenter.transform.position, navigationCamera.transform.right, z); //right is x (red) of the camera

       }
}