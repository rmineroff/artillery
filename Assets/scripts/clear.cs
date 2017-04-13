using UnityEngine;
using System.Collections;

public class clear : MonoBehaviour {

	//this will get the x and z position to set objects up with the array then if their value changes it deletes them

	public GameObject crater;

	int original;

	int xPos;
	int yPos;
	int arrayMax = 36;//update with max size of array

	bool shot = false;


	// Use this for initialization
	void Start () 
	{


		xPos = (int)gameObject.transform.position.x / 10;
		yPos = (int)gameObject.transform.position.z / 10;

		original = arrayMap.mapArray [xPos, yPos];

	}

	// Update is called once per frame
	void Update () 
	{
		//if(Input.GetKeyDown("space"))
			//shot = true;

		if (original != arrayMap.mapArray [xPos, yPos])
		{
			//quickly trigger explosion?

			Destroy (gameObject);

			arrayMap.mapArray [xPos, yPos] = 0;
			Instantiate (crater, new Vector3 (xPos * 10, 0, yPos * 10), Quaternion.identity);
		}
		/*if (shot) 
		{
			for (int i = 0; i < arrayMax; i++) {
				for (int y = 0; y < arrayMax; y++) {

					if (arrayMap.mapArray [i, y] == -1) {
						arrayMap.mapArray [i, y] = 0;
						Instantiate (crater, new Vector3 (i * 10, 0, y * 10), Quaternion.identity);

					}
				}
			}
			shot = false;
		}*/

	}

}

