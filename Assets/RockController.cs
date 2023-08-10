using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
	// Start is called before the first frame update
	float fallSpeed;
	float rotSpeed;

	void Start()
	{
		this.fallSpeed = 0.01f + 0.2f * Random.value;
		this.rotSpeed = 2.5f + 3.0f * Random.value ;
	}

	void Update()
	{
		transform.Translate(0, -fallSpeed * Time.fixedDeltaTime, 0, Space.World);
		transform.Rotate(0, 0, rotSpeed * Time.fixedDeltaTime );

		if (transform.position.y < -5.5f)
		{
			GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
			Destroy(gameObject);
		}
	}
}
