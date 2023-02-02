using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI; // obs�uga interfejsu

public class GameManager : MonoBehaviour
{    
    public Text gameOverText;

    public Text scoreText;
    public int playerScore = 0;

    //public Text blasterTime;
    //public bool blasterPossibility = false;
    //public float timeToBlaster = 10;


    private void Update()
    {
        //wy��czenie kursora
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
        //if (playerScore >= 10)
        //    {
        //       Blaster();
        //    }
    }

    public void AddScore()
    {
        playerScore++;
        //konwersja wyniku na string
        scoreText.text = playerScore.ToString();
    }

    public void PlayerDied()
    {       
        gameOverText.gameObject.SetActive(true);
        //zatrzymanie gry
        Time.timeScale = 0;
    }



    //public void Blaster()
    //{
    //    blasterTime.text = ("Time To Blaster: " + (int)timeToBlaster);
    //    timeToBlaster -= Time.deltaTime;
    //    if (timeToBlaster <= 0)
    //    {
    //        timeToBlaster = 0;
    //        blasterPossibility = true;
    //    }
    //}
}
