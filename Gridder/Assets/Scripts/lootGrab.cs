using UnityEngine;
using System.Collections;

public class lootGrab : MonoBehaviour {

	public GameObject ItemSpawner;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Physics2D.OverlapCircle
	
	}



	void OnTriggerEnter2D(Collider2D other)
	{
//		print ("Yo!");
		if (other.tag == "Loot") {
			Destroy (other.transform.parent.gameObject);
			ItemSpawner.GetComponent<ItemSpawner> ().ObjectInventory [Random.Range (0, ItemSpawner.GetComponent<ItemSpawner> ().ObjectInventory.Length - 1)]++;
		}
		else if(other.tag == "Platform")
		{
			transform.parent = other.transform;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if(other.tag == "Platform")
		{
			transform.parent = null;
		}
	}

}
