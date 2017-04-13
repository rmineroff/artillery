using UnityEngine;
using System.Collections;

public class zoom : MonoBehaviour {

	float minFov = 15f;
	float maxFov = 90f;
	float sensitivity = 10f;


	// Use this for initialization
	void Start () {

	}

	void Update () {
		float fov = Camera.main.fieldOfView;
		fov += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
		fov = Mathf.Clamp(fov, minFov, maxFov);
		Camera.main.fieldOfView = fov;
	}
}