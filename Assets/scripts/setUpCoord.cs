using UnityEngine;
using System.Collections;

public class setUpCoord : MonoBehaviour {

	//updates the array for when the artillery strikes

	//gets 3 by 3 grid when their is a hit and changes them to destroyed
	//xy x-1y x+1y ...

	public GameObject crater;

	public bool shot = false;

	public int shotX;
	public int shotY;

	static int arrayMax = 36;//update with max size of array

	static int landX;
	static int landY;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		/*shotX = (int)setX.lockX;
		shotY = (int)setY.lockY;

		if (Input.GetKeyDown("space"))
			shoot(10,10);


		if (Input.GetKeyDown ("up"))
			Debug.Log (landX + " " + landY);*/


	}

	//this fires when the shooter presses key
	public static void shoot(float shotX, float shotY)
	{
		Debug.Log (shotX);
		Debug.Log (shotY);
		landX = (int)shotX;// !!!!!!!!may need to update publick shot !!!!!!!!!!!!
		landY = (int)shotY;

		// if try to access array out of bounds will crash
		//sets to negative one so tha the clear script will clean out in case of overlapping shots

		arrayMap.mapArray [landX, landY] = -1;

		if (landX + 1 <= arrayMax)
			arrayMap.mapArray [landX + 1, landY] = -1;

		if (landX - 1 >= 0)
			arrayMap.mapArray [landX - 1, landY] = -1;

		if (landX + 1 <= arrayMax && landY + 1 <= arrayMax)
			arrayMap.mapArray [landX + 1, landY + 1] = -1;

		if (landX + 1 <= arrayMax && landY - 1 >= 0)
			arrayMap.mapArray [landX + 1, landY - 1] = -1;

		if (landX - 1 >= 0 && landY - 1 >= 0)
			arrayMap.mapArray [landX - 1, landY - 1] = -1;

		if (landX - 1 >= 0 && landY + 1 <= arrayMax)
			arrayMap.mapArray [landX - 1, landY + 1] = -1;

		if (landY + 1 <= arrayMax)
			arrayMap.mapArray [landX, landY + 1] = -1;

		if (landY - 1 >= 0)
			arrayMap.mapArray [landX, landY - 1] = -1;


	



	}

}
