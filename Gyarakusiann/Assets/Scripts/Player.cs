using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    //移動スピード
    public float speed = 5;
    //Player_Bulletプレハブ
    public GameObject bullet;
    // 弾丸発射点
    public Transform muzzle;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); //左右
        float y = Input.GetAxisRaw("Vertical"); //上下

        Vector2 direction = new Vector2(x, y).normalized;
        GetComponent<Rigidbody2D>().velocity = direction * speed;

        // z キーが押された時
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 弾丸の複製
            GameObject bullets = GameObject.Instantiate(bullet) as GameObject;
            // 弾丸の位置を調整
            bullets.transform.position = muzzle.position;
        }
    }
}
