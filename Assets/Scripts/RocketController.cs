using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    public GameObject bulletPrefab;
    uint power;
    float[] BulletPerPower = new float[] { 0, 0.2f, 0.4f };
    // Start is called before the first frame update
    void Start()
    {
        power = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-1.5f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(1.5f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (uint i = 1; i <= power; i++)
            {
                switch (i)
                {
                    case 1:
                        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                        break;
                    case 2:
                        Vector3 bullet1 = transform.position;
                        Vector3 bullet2 = transform.position;
                        bullet1.x = bullet1.x - BulletPerPower[i - 1];
                        bullet1.y = bullet1.y - BulletPerPower[i - 1];
                        bullet2.x = bullet2.x + BulletPerPower[i - 1];
                        bullet2.y = bullet2.y - BulletPerPower[i - 1];
                        Instantiate(bulletPrefab, bullet1, Quaternion.identity);
                        Instantiate(bulletPrefab, bullet2, Quaternion.identity);
                        break;
                    case 3:
                        Vector3 bullet3 = transform.position;
                        Vector3 bullet4 = transform.position;
                        bullet3.x = bullet3.x - BulletPerPower[i - 1];
                        bullet3.y = bullet3.y - BulletPerPower[i - 1];
                        bullet4.x = bullet4.x + BulletPerPower[i - 1];
                        bullet4.y = bullet4.y - BulletPerPower[i - 1];
                        Instantiate(bulletPrefab, bullet3, Quaternion.identity);
                        Instantiate(bulletPrefab, bullet4, Quaternion.identity);
                        break;
                    default:
                        break;
                }
            }
        }
    }

    public void PowerUp()
    {
        if (power < 3) 
        {
            power += 1;
        }
    }
}
