using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpItemController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -1.0f * Time.deltaTime, 0, Space.World);

        if (transform.position.y < -5.5f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        print(coll.gameObject.tag);
        if (coll.gameObject.tag == "Player")
        {
            // 自身を消滅させる。
            Destroy(gameObject);
            // 衝突したオブジェクトの弾が衝突したときの関数を呼ぶ。
            coll.gameObject.GetComponent < RocketController>().PowerUp();
        }
    }
}
