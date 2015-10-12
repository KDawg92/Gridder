using UnityEngine;
using System.Collections;

public class stickyFeet : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other)
	{
		other.transform.parent = transform;
	}
}
