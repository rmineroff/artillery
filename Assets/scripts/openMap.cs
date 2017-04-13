using UnityEngine;
using System.Collections;

public class openMap : MonoBehaviour {

	int down = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{

		if (down == 1) 
		{

			//transform.localPosition = Vector3.Lerp (new Vector3 (0, 0, 10*5), new Vector3 (20*5, -20*5, 40*5), 10 * Time.deltaTime);
			transform.localPosition = new Vector3 (0, 0, 10);
				
			Debug.Log ("click");
		}

		if (down == -1)
		{

			//transform.localPosition = Vector3.Lerp (new Vector3 (20*5, -20*5, 40*5), new Vector3 (0, 0, 10), 10 * Time.deltaTime);
			transform.localPosition = new Vector3 (20, -20, 40);

		}

		down = down * -1;

	}
		
}
