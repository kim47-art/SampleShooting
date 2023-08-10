using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject explosionPrefab;   //�����G�t�F�N�g��Prefab

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 1.0f * Time.fixedDeltaTime , 0);
        //transform.Translate(0, 0.5f * Time.deltaTime , 0);

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
        �@�@// �Փ˂����Ƃ��ɃX�R�A���X�V����
        �@�@GameObject.Find("Canvas").GetComponent<UIController>().AddScore();
            // �����G�t�F�N�g�𐶐�����	
            GameObject effect = Instantiate(explosionPrefab, transform.position, Quaternion.identity) as GameObject;
            Destroy(effect, 1.0f);
            // �Փ˂����I�u�W�F�N�g�����ł�����B
            Destroy(coll.gameObject);
            // ���g�����ł�����B
            Destroy(gameObject);
        }
    }
}
