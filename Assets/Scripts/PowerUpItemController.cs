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
            // ���g�����ł�����B
            Destroy(gameObject);
            // �Փ˂����I�u�W�F�N�g�̒e���Փ˂����Ƃ��̊֐����ĂԁB
            coll.gameObject.GetComponent < RocketController>().PowerUp();
        }
    }
}
