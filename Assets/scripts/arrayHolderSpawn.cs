using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class arrayHolderSpawn : NetworkBehaviour {
	[SyncVar]
	public float angleX, angleY;

	float originalX = -1;
	float originalY = -1;
	float sendX, sendY;
	public GameObject array, crankx, cranky, canvas, crankOne, crankTwo;
	// Use this for initialization
	void Start () {
		angleX = originalX;
		angleY = originalY;
		if (this.isLocalPlayer == true) {
			if (this.isServer == true)
				Instantiate (array, new Vector3 (0, 0, 0), Quaternion.identity);
			if (this.isServer == false) {
				crankOne = (GameObject) Instantiate (crankx, new Vector3 (215, 47, 235), Quaternion.identity);
				crankTwo = (GameObject) Instantiate (cranky, new Vector3 (185, 47, 235), Quaternion.identity);
				Instantiate (canvas, new Vector3 (198.1f, 60.8f, 263f), Quaternion.identity);

			}
		}
	}

	// Update is called once per frame
	void Update () {
		//References the shooter while playing as the shooter
		if (this.isLocalPlayer == true) {
			if (this.isServer == false) {
				angleX = crankOne.transform.rotation.eulerAngles.z/10;
				angleY = crankTwo.transform.rotation.eulerAngles.z/10;
				if (Input.GetKeyDown (KeyCode.Space) == true)
					CmdGetAngle (angleX, angleY);
			}

		}

		//References the shooter while playing as the spotter

			if (this.isServer == false) {
				if (angleX > -1 || angleY >-1 ) {
					sendX = angleX;
					sendY = angleY;
					angleX = -1;
					angleY = -1;
					setUpCoord.shoot (sendX, sendY);
				}

				
		}

	}

	[Command]
	public void CmdGetAngle (float angle1, float angle2){
		angleX = angle1;
		angleY = angle2;
		RpcSetAngle (angle1, angle2);
	}

	[ClientRpc]
	public void RpcSetAngle (float angle1, float angle2){
		angleX = angle1;
		angleY = angle2;
		setUpCoord.shoot (angleX, angleY);
	
	}
}
