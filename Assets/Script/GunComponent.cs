using UnityEngine;

public class GunComponent : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float chargeSpeed = 10f;
    private float chargeTime = 0f;
    public float baseBulletSpeed = 10.0f;


    void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            // Spawn bullet when Fire1 is released
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

            BulletComponent bulletComp = bulletPrefab.GetComponent<BulletComponent>();
            bulletComp.bulletSpeed = chargeTime * baseBulletSpeed;
            chargeTime = 0f;
        }

        if (Input.GetButton("Fire1")) {
            chargeTime += Time.deltaTime * chargeSpeed;
            chargeTime = Mathf.Clamp(chargeTime, 0, 3);

            

        }
    }
}

