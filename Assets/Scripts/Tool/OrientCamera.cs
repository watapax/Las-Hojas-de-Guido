using UnityEngine;
using System.Collections;

public class OrientCamera : MonoBehaviour {

	Transform cameraTransform;

	void Awake()
	{
		cameraTransform = Camera.main.transform;
	}

	void FixedUpdate()
	{
		transform.LookAt(cameraTransform.position);
		transform.localEulerAngles = new Vector3(0 , transform.localEulerAngles.y, 0);
	}

}
