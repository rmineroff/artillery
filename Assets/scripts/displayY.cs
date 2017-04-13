using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class displayY : MonoBehaviour {

	public Text yCoord;

	float Y;

	int newY;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		Y = gameObject.transform.rotation.eulerAngles.z;

		newY = (int)(Y / 10) / 2;

		//yCoord.text = "" + newY;

	}
}
