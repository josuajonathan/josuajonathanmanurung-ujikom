using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float timer = 5;
    public float speed;

    public GameObject enemyBullet;
    private float bulletTime;
    public Transform spawnPoint;
    public float enemySpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalMove, 0, verticalMove);
        transform.Translate(moveDirection);
    }

    void ShootEnemy()
    {
        bulletTime -= Time.deltaTime;
        if(bulletTime > 0)
        {
            return;
        }

        bulletTime = timer;
        GameObject bulletObject = Instantiate(enemyBullet, spawnPoint, transform.position, spawnPoint.transform.rotation) as GameObject;
        Rigidbody bulletRig = bulletObject.GetComponent<Rigidbody>();
        bulletRig.AddForce(bulletRig.transform.forward * enemySpeed);
        Destroy(bulletObject, 0.1f);
    }
}
