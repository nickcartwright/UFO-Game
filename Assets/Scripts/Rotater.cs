using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour {
	
	// Time.deltaTime....
    // Vector 3 as transform still exists in 3d volume.
	void Update () {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
	}
}
