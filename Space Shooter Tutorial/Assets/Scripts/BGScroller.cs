using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour {

    public float scrollSpeed;
    public float tileSizeZ;
    private Vector3 startPosition;

	// Use this for initialization
	void Start () {
        // this will maintain the -10 position in the Y axis
        startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        // this loops the value of t, used to repeat the position of the background
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        // the Vector3.forward is 0 X and 0 Y and adding only on the Z position
        transform.position = startPosition + Vector3.forward * newPosition;
	}
}
