using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunController : MonoBehaviour
{
        //public bool isFiring;

        public EnemyBulletController bullet;
    
       

        public float bulletSpeed;
        public float timeBetweenShots;
        public float shotCounter;

        public Transform firePoint;
        //public GunController uzi;
        //public GameObject handgun;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
                shotCounter -= Time.deltaTime;
                if (shotCounter <= 0)
                {
                    shotCounter = timeBetweenShots;
                    EnemyBulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as EnemyBulletController;
                    newBullet.speed = bulletSpeed;
                }
            
            else
            {
                shotCounter = 0;
            }
        }
    }
