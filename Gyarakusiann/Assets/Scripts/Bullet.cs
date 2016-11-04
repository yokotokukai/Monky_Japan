﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    public float speed = 10;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
        Destroy(gameObject, 1);
    }
    
	
	// Update is called once per frame
	void Update () {
	
	}
}
