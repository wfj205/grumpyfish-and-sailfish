using UnityEngine;
using System.Collections;

public class FishayFishay : MonoBehaviour {
	
	public Vector3 destination = new Vector3(100f,100f,0f);
	//unity will initialize this at (0f,0f,0f) but you can manually initialize this at whatever you want
	public float fishSpeed = Random.Range(1f,3f);
	
	// Use this for initialization
	void Start () {
		InvokeRepeating("SetNewDestination", 0f, 3f);  //time refers to the initial delay //repeat rate is how often you want it to happen
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.LookRotation (rigidbody.velocity);
	}
	
	void FixedUpdate(){
		Vector3 direction = Vector3.Normalize (destination - transform.position);
		rigidbody.AddForce (direction * fishSpeed, ForceMode.VelocityChange);
	}
	
	void SetNewDestination(){
		// set a random destination
		destination = Random.insideUnitSphere*400f; //this unit sphere is normalized with a radius of 1. we can multiply it by stuff to make the sphere bigger
	}
}

