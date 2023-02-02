using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] private InputController inputController;
    [SerializeField] private GameObject spaceShip;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] GameObject bulletPrefab1;
    [SerializeField] GameObject bulletPrefab2;
    [SerializeField] GameObject bulletPrefab3;
    [SerializeField] GameObject bulletPrefab4;

    Vector3 spawnPos;
    readonly float reloadTime = 0.6f;
    float _elapsedTime = 0f;
    
    
    void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (inputController.Fire1 && _elapsedTime > reloadTime && spaceShip != null)
        {            
            spawnPos = spaceShip.transform.position;
            spawnPos += new Vector3(0, 1.2f, 0);
            
            Instantiate(bulletPrefab, spawnPos, Quaternion.identity);

            _elapsedTime = 0f;
        }

        if (inputController.Fire2 && gameManager.blasterPossibility == true && spaceShip != null)
        {
            Vector3 spawnPos1 = spaceShip.transform.position;
            Vector3 spawnPos2 = spaceShip.transform.position;
            Vector3 spawnPos3 = spaceShip.transform.position;
            Vector3 spawnPos4 = spaceShip.transform.position;
            spawnPos1 += new Vector3(0.6f, 1.2f, 0);
            spawnPos2 += new Vector3(0.3f, 1.2f, 0);
            spawnPos3 += new Vector3(-0.3f, 1.2f, 0);
            spawnPos4 += new Vector3(-0.6f, 1.2f, 0);

            Instantiate(bulletPrefab1, spawnPos1, Quaternion.identity);
            Instantiate(bulletPrefab2, spawnPos2, Quaternion.identity);
            Instantiate(bulletPrefab3, spawnPos3, Quaternion.identity);
            Instantiate(bulletPrefab4, spawnPos4, Quaternion.identity);

            gameManager.blasterPossibility = false;
        }
    }
}
