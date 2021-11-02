using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LaunchProjectile : MonoBehaviour
{
    public float projectileForce = 20.0f;
    GameObject projectile;
    public static event Action shootProjectile;

    // Update is called once per frame
    void Update()
    {
        //Firing Projectiles From Object Pool
        if(Input.GetMouseButtonDown(1))
        {
            #region observer
            shootProjectile?.Invoke();
            #endregion

            projectile = ProjectilePool.SharedInstance.GetPooledObject();

            if (projectile != null)
            {
                projectile.transform.position = this.transform.position;
                projectile.transform.rotation = Quaternion.Euler(this.transform.forward);
                projectile.SetActive(true);

                projectile.GetComponent<Rigidbody2D>().velocity = transform.right * projectileForce;
            }
        }
    }
}
