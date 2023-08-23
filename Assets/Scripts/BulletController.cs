using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0, 1.0f * Time.fixedDeltaTime , 0);
        transform.Translate(0, 4.0f * Time.deltaTime , 0);

        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {


        //if (coll.gameObject.tag == "Rock")
        if(coll.gameObject.name == "RockPrefab(Clone)")//Instantiate�Ő��������I�u�W�F�N�g�����g����������\
        {
            // ���g�����ł�����B
            Destroy(gameObject);
            // �Փ˂����I�u�W�F�N�g�̒e���Փ˂����Ƃ��̊֐����ĂԁB
            coll.gameObject.GetComponent<RockController>().HittedBullet();
        }
    }
}
