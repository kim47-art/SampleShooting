using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
	// Start is called before the first frame update
	public GameObject explosionPrefab;   //�����G�t�F�N�g��Prefab

	float fallSpeed;
	float rotSpeed;
	float durability;

	void Start()
	{
		this.fallSpeed = 0.01f + 0.8f * Random.value;
		this.rotSpeed = 2.5f + 3.0f * Random.value ;
		this.durability = 3.0f;
	}

	void Update()
	{
		transform.Translate(0, -fallSpeed * Time.deltaTime, 0, Space.World);
		transform.Rotate(0, 0, rotSpeed  * Time.deltaTime );

		if (transform.position.y < -5.5f)
		{
			GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
			Destroy(gameObject);
		}
	}

    public void HittedBullet()
    {
		this.durability -= 1;
		print(this.durability);
		if (this.durability <= 0)//�ϋv�l��0�ȉ��ɂȂ�������ł�����B
		{          // �Փ˂����Ƃ��ɃX�R�A���X�V����
			GameObject.Find("Canvas").GetComponent<UIController>().AddScore();
			// �����G�t�F�N�g�𐶐�����	
			GameObject effect = Instantiate(explosionPrefab, transform.position, Quaternion.identity) as GameObject;
			Destroy(effect, 1.0f);
			Destroy(gameObject);
		}
    }
}
