using UnityEngine;
using System.Collections;

public class CreateOnMouse : MonoBehaviour
{

		[SerializeField]
		private Transform
				originalObject;
		private Transform copyObject;

		void Update ()
		{
				if (Input.GetButtonDown ("Fire2")) {
						copyObject = (Transform)Instantiate (originalObject, transform.position, transform.rotation);
						copyObject.Translate (0, 0, 6);
				}
		}
}