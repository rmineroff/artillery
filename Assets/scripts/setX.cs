using UnityEngine;
using System.Collections;

public class setX : MonoBehaviour {

	public static float lockX = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown("left"))
		{
			lockX = gameObject.transform.eulerAngles.z;
			lockX = (lockX / 10) / 2;
			Debug.Log (lockX);
		}

	}
}
