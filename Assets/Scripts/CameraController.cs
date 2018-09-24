using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        // transform.positon references the position of the camera
        offset = transform.position - player.transform.position;
	}
	
	// Gauranteed to be called after update
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
