using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollower : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		Vector3 pz = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		pz.z = 0;
		gameObject.transform.position = pz;
	}
}
