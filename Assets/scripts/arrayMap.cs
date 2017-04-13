using UnityEngine;
using System.Collections;

public class arrayMap : MonoBehaviour {

	//for loop that randomly assigns values to a 6 by 6 array by rolling random nums to asign the values it keeps track of how many of certain values have been rolled so that there cannot be to many of one value

	static int arraySize = 36;//this will need to be updated in setUpCoord and clear

	public static int[,] mapArray = new int[arraySize,arraySize];


	public static int targetX;
	public static int targetY;

	//put objects into array
	public GameObject [] piece;

	int pick;

	int maxCount = ((arraySize*arraySize)/5) + 1;

	//put these in an array
	int [] counter = new int[5];

	bool skip = false;//use to skip when the overide is set

	// Use this for initialization
	void Start () 
	{

		targetX = Random.Range (22, 27);
		targetY = Random.Range (3, 7);
		// we can worry about the ratios later
		for(int i = 0; i< arraySize;i++)
		{
			for (int y = 0; y < arraySize; y++) //if array size is increased then max count must be increased to compensate
			{

				pick = 1;

				//OVERIDE
				//setting an override so there is a blank area in the center of the map dont forget target thing at bottom

				if(i >= 22 && i <= 27 && y >= 3 && y <= 7)
				{
					if (i == targetX && y == targetY) 
					{
						mapArray [i, y] = 5;
						Instantiate (piece [5], new Vector3 (i * 10, 0, y * 10), Quaternion.identity);
					} else 
					{
						pick = Random.Range (2, 5);
						skip = true;
						mapArray [i, y] = pick;
						Instantiate (piece [pick], new Vector3 (i * 10, 0, y * 10), Quaternion.identity);
					}
				}

				if(i >= 3 && i <= 7 && y >= 3 && y <= 7)
				{
					pick = Random.Range (2, 5);
					skip = true;
					mapArray [i, y] = pick;
					Instantiate (piece[pick], new Vector3 (i*10, 0, y*10), Quaternion.identity);
				}

				if(i >= 12 && i <= 18 && y >= 5 && y <= 9)
				{
					pick = Random.Range (2, 5);
					skip = true;
					mapArray [i, y] = pick;
					Instantiate (piece[pick], new Vector3 (i*10, 0, y*10), Quaternion.identity);
				}

				if(i >= 15 && i <= 20 && y >= 26 && y <= 31)
				{
					pick = Random.Range (2, 5);
					skip = true;
					mapArray [i, y] = pick;
					Instantiate (piece[pick], new Vector3 (i*10, 0, y*10), Quaternion.identity);
				}

				if(i >= 2 && i <= 6 && y >= 28 && y <= 33)
				{
					pick = Random.Range (2, 5);
					skip = true;
					mapArray [i, y] = pick;
					Instantiate (piece[pick], new Vector3 (i*10, 0, y*10), Quaternion.identity);
				}

				if(i >= 28 && i <= 33 && y >= 28 && y <= 33)
				{
					pick = Random.Range (2, 5);
					skip = true;
					mapArray [i, y] = pick;
					Instantiate (piece[pick], new Vector3 (i*10, 0, y*10), Quaternion.identity);
				}

				if(i >= 28 && i <= 33 && y >= 20 && y <= 26)
				{
					pick = Random.Range (2, 5);
					skip = true;
					mapArray [i, y] = pick;
					Instantiate (piece[pick], new Vector3 (i*10, 0, y*10), Quaternion.identity);
				}

				if(i >= 29 && i <= 35 && y >= 7 && y <= 14)
				{
					pick = Random.Range (2, 5);
					skip = true;
					mapArray [i, y] = pick;
					Instantiate (piece[pick], new Vector3 (i*10, 0, y*10), Quaternion.identity);
				}

				if(i >= 3 && i <= 9 && y >= 17 && y <= 24)
				{
					pick = Random.Range (2, 5);
					skip = true;
					mapArray [i, y] = pick;
					Instantiate (piece[pick], new Vector3 (i*10, 0, y*10), Quaternion.identity);
				}
				//OVERIDE END!!!!!!!!!!!!!

				if (skip == false) 
				{
					Instantiate (piece [pick], new Vector3 (i * 10, 0, y * 10), Quaternion.identity);
					//counter [pick] = counter [pick]++;
					mapArray [i, y] = pick;
				} 
				/*else if (counter [pick] >= maxCount)
				{
					// Loop until i find a building with room in maxcount
					// 
					// while (still havent found building) then look for building
					while (counter[pick] >= maxCount)
					{

						if (pick >= 5) //!!!!!!!!!!!!!!!UPDATE WITH SIZE OF MAX COUNT ARRAY !!!!!!!!!!!!!!!!!!!!!!!!!!!1
						{
							pick = 1;
						} else 
						{
							pick++;
						}

						if (counter [pick] < maxCount) 
						{
							Instantiate (piece [pick], new Vector3 (i * 10, 0, y * 10), Quaternion.identity);
							counter [pick] = counter [pick]++;
							mapArray [i, y] = pick;
						} 

					}
				}*/

				skip = false;

				//reset:;
				/*
				pick = Random.Range (0, 100);//pick random int 0 to 100

				if (skip == false && pick <= 20 && count0 < maxCount) //roughly no more than 33% should be blank
				{
					mapArray [i, y] = 0;
					Instantiate (plain, new Vector3 (i*10, 0, y*10), Quaternion.identity);
					count0++;
				}else if (count0 >= maxCount)
				{
					pick = Random.Range (21, 100);//generates a new number so it does not skip
				}

				if (skip == false && pick >=21 && pick <= 40 && count1 < maxCount)
				{
					mapArray [i, y] = 1;
					Instantiate (tall, new Vector3 (i*10, 0, y*10), Quaternion.identity);
					count1++;
				}else if (count1 >= maxCount)
				{

					pick = Random.Range (0, 100);
					//goto reset;
				} 

				if (skip == false && pick >= 41 && pick <= 50 && count2 < maxCount)
				{
					mapArray [i, y] = 2;
					Instantiate (small, new Vector3 (i*10, 0, y*10), Quaternion.identity);
					count2++;
				}else if (count2 >= maxCount)
				{
					pick = Random.Range (0, 100);
					//goto reset;
				} 

				if (skip == false && pick >=51 && pick <= 60 && count3 < maxCount)
				{
					mapArray [i, y] = 3;
					Instantiate (regular, new Vector3 (i*10, 0, y*10), Quaternion.identity);
					count3++;
				}else if (count3 >= maxCount)
				{

					pick = Random.Range (61, 100);

					pick = Random.Range (0, 100);
					//goto reset;

				} 

				if (skip == false && pick >=61 && pick <= 75 && count4 < maxCount)
				{
					mapArray [i, y] = 4;
					Instantiate (regular, new Vector3 (i*10, 0, y*10), Quaternion.identity);
					count4++;
				}else if (count4 >= maxCount)
				{

					pick = Random.Range (76, 100);
				} 

				if (skip == false && pick >= 76 && pick <= 100 && count5 < arraySize * arraySize) {//just put something there
					mapArray [i, y] = 5;
					Instantiate (regular, new Vector3 (i*10, 0, y*10), Quaternion.identity);
					count5++;
				} else if (count5 >= maxCount) 
				{

					pick = Random.Range (0, 100);
					//goto reset;


				}

				Debug.Log (i + " " + y + " " + mapArray[i,y]);
				//Debug.Log (i + " " + y + " count1 " + count1);
				//Debug.Log (i + " " + y + " count2 " + count2);
				//Debug.Log (i + " " + y + " count3 " + count3);
				//Debug.Log (i + " " + y + " count4 " + count4);
				//Debug.Log (i + " " + y + " count5 " + count5);
*/

			}

		}

		//set a target position for later use

	}

	// Update is called once per frame
	void Update () {

	}
}