using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject character;
	
	// Update is called once per frame
	void LateUpdate () {
		this.transform.position = new Vector3(character.transform.position.x, 0, -6.3f);
		print(character.transform.position);
	}
}
