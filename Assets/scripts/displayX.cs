using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class displayX : MonoBehaviour {

	public Text xCoord;

	float X;

	int newX;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		X = gameObject.transform.rotation.eulerAngles.z;

		newX = (int)(X / 10) / 2;

		xCoord.text = "" + newX;

	}
}
