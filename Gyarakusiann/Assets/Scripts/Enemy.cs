using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public float speed = 0;
    public GameObject expPrefab; //爆発アニメーション用プレハブ
    // Use this for initialization
    void Start () {
        Vector2 direction = transform.up * -1;
        GetComponent<Rigidbody2D>().velocity = direction * speed;
	}
    void OnTriggerEnter2D(Collider2D c){
        Instantiate(expPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(c.gameObject);
    }
}
