using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject explosionPrefab;   //爆発エフェクトのPrefab

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.5f * Time.fixedDeltaTime, 0);

        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        // 衝突したときにスコアを更新する
        GameObject.Find("Canvas").GetComponent<UIController>().AddScore();


        //if (coll.gameObject.tag == "Rock")
        if(coll.gameObject.name == "RockPrefab(Clone)")//Instantiateで生成されるオブジェクト名を使った判定も可能
        {
            // 爆発エフェクトを生成する	
            GameObject effect = Instantiate(explosionPrefab, transform.position, Quaternion.identity) as GameObject;
            Destroy(effect, 1.0f);
            // 衝突したオブジェクトを消滅させる。
            Destroy(coll.gameObject);
            // 自身を消滅させる。
            Destroy(gameObject);
        }
    }
}
