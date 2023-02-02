using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    [SerializeField] private InputController inputController;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject spaceShip;
    //[SerializeField] GameObject bulletPrefab1;
    //[SerializeField] GameObject bulletPrefab2;
    //[SerializeField] GameObject bulletPrefab3;
    //[SerializeField] GameObject bulletPrefab4;

    Vector3 spawnPos;
    float reloadTime = 0.6f;
    float _elapsedTime = 0f;
        

    // Update is called once per frame
    void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (inputController.Fire1 && _elapsedTime > reloadTime)
        {
            //utworzenie egzemplarza pocisku w odleg³ 1.2 od gracza
            spawnPos = spaceShip.transform.position;
            spawnPos += new Vector3(0, 1.2f, 0);
            
            Instantiate(bulletPrefab, spawnPos, Quaternion.identity);

            _elapsedTime = 0f;
        }

        //if (Input.GetButtonDown("Fire2") && gameManager.blasterPossibility == true)
        //{
        //    Vector3 spawnPos1 = transform.position;
        //    Vector3 spawnPos2 = transform.position;
        //    Vector3 spawnPos3 = transform.position;
        //    Vector3 spawnPos4 = transform.position;
        //    spawnPos1 += new Vector3(0.6f, 1.2f, 0);
        //    spawnPos2 += new Vector3(0.3f, 1.2f, 0);
        //    spawnPos3 += new Vector3(-0.3f, 1.2f, 0);
        //    spawnPos4 += new Vector3(-0.6f, 1.2f, 0);

        //    Instantiate(bulletPrefab1, spawnPos1, Quaternion.identity);
        //    Instantiate(bulletPrefab2, spawnPos2, Quaternion.identity);
        //    Instantiate(bulletPrefab3, spawnPos3, Quaternion.identity);
        //    Instantiate(bulletPrefab4, spawnPos4, Quaternion.identity);



        //    if (gameManager.playerScore > 30)
        //        gameManager.timeToBlaster = 3;
        //    else if (gameManager.playerScore > 20)
        //        gameManager.timeToBlaster = 5;
        //    else
        //        gameManager.timeToBlaster = 10;

        //    gameManager.blasterPossibility = false;
        //}
    }
}
