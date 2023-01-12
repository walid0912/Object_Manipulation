using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
		[SerializeField]
		private float
				speed = 5.0f;
		
		void Update ()
		{
				transform.Rotate (0, speed * Time.deltaTime, 0);
		}
}
