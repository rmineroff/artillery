using UnityEngine;
using System.Collections;

public class setY : MonoBehaviour {

	public static float lockY = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown("right"))
		{
			lockY = gameObject.transform.eulerAngles.z;
			lockY = (lockY / 10) / 2;
			Debug.Log (lockY);
		}

	}
}