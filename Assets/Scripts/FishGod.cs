using UnityEngine;
using System.Collections;
using System.Collections.Generic; // you need this line to use lists

public class FishGod : MonoBehaviour {
	
	public FishayFishay fishBlueprint;
	public int fishCount = 100;
	public SailFishay sailfishBlueprint;
	
	public List<FishayFishay> fishList = new List<FishayFishay>();
	public List<SailFishay> sailfishList = new List<SailFishay>();
	
	// Use this for initialization
	void Start () {
		int currentFishCounter = 0;
		while(currentFishCounter < fishCount){
			//spawn a fish
			Vector3 fishPosition = Random.insideUnitSphere*1000f;
			float random = Random.Range (0f,10f);
			if(random > 5f){
				FishayFishay newFish = Instantiate(fishBlueprint, fishPosition, Quaternion.identity) as FishayFishay;
				fishList.Add (newFish);
				//increment our fishCounter
				currentFishCounter ++;
			}else{
				SailFishay newSailFish = Instantiate(sailfishBlueprint, fishPosition, Quaternion.identity) as SailFishay;
				sailfishList.Add (newSailFish);
				//increment our fishCounter
				currentFishCounter ++;
			}
			
		}
		//when currentFishCounter is 100 the while() loop will end and do whatever code is after it, like right here
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			foreach(FishayFishay currentFish in fishList){
				currentFish.destination = Vector3.zero;
			}foreach(SailFishay currentFish in sailfishList){
				currentFish.destination = Vector3.zero;
			}
		}
	}
}
