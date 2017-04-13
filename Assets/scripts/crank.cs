using UnityEngine;
using System.Collections;

public class crank : MonoBehaviour {

	//created by Nick Parr
	//use: apply this to a "crank" this will allow the player to spin the crank and then "lock in" the coord so that they can aim the gun

	Vector3 mousePos;

	float speed = 5f;

	// Use this for initialization
	void Start () {

	}


	void Update () 
	{
		Vector3 mousePosition = Input.mousePosition;
		mousePosition.z = 50f;
		mousePos = Camera.main.ScreenToWorldPoint (mousePosition);//gives world coords of mouse
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Debug.Log (gameObject.transform.rotation.eulerAngles.z);
			//			RpcPrintText(gameObject.transform.rotation.eulerAngles.z);
		}

	}

	void OnMouseDrag()
	{

		Vector3 direction = mousePos - transform.position;
		float angle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg;
		Quaternion rotation = Quaternion.AngleAxis (angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);

	}

}
