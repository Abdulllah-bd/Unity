using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGen : MonoBehaviour {
	public GameObject platformPreFab;
	public int numberOfPlat=500;
	public float levelWidth = .3f;
	public float minY = .2f;
	public float maxY = 1.5f;
	// Use this for initialization
	void Start () {
		Vector3 spawnPosition=new Vector3();
		for (int i = 0; i < numberOfPlat; i++) {
			spawnPosition.y += Random.Range (minY,maxY);
			spawnPosition.x = Random.Range (-levelWidth,levelWidth);
			Instantiate (platformPreFab, spawnPosition, Quaternion.identity);
		
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
