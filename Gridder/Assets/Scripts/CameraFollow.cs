using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform player;
	public Transform player2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float dis = Vector3.Distance (player.position, player2.position);
		if(dis < 10)
			dis = 10;
		if(dis > 78)
			dis = 78;
		Vector3 camPos = new Vector3 ((player.position.x + player2.position.x)/2, ((player.position.y + 1.5f) + (player2.position.y + 1.5f))/2, -10);
		GetComponent<Camera> ().orthographicSize = dis/ 1.5f;
		transform.position = Vector3.Lerp (transform.position, camPos , 0.1f);
	
	}
}
