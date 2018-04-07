using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    Vector3 startingposition;
    float movementFactor;
    [SerializeField] [Range(0, 1)] float movementSpeed;

    // Use this for initialization
    void Start () {
        startingposition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow))
        {
            movementFactor += movementSpeed;
            Vector3 offset = Vector3.up * movementFactor;
            gameObject.transform.position = new Vector3(transform.position.x, Mathf.Clamp(offset.y + startingposition.y, -startingposition.y, 2f), transform.position.z);
            
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            movementFactor += -movementSpeed;
            Vector3 offset = Vector3.up * movementFactor;
            gameObject.transform.position = offset + startingposition;
        }
	}
}
