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
		this.fallSpeed = 0.01f + 0.01f * Random.value * Time.fixedDeltaTime;
		this.rotSpeed = 2.5f + 1.5f * Random.value * Time.fixedDeltaTime;
	}

	void Update()
	{
		transform.Translate(0, -fallSpeed, 0, Space.World);
		transform.Rotate(0, 0, rotSpeed);

		if (transform.position.y < -5.5f)
		{
			GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
			Destroy(gameObject);
		}
	}
}
