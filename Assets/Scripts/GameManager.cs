using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI; // obs³uga interfejsu
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class GameManager : MonoBehaviour
{    
    public Text gameOverText;
    public Text scoreText;
    public Text blasterTimeText;

    public bool blasterPossibility = false;
    public int playerScore;
    public float timeToBlaster;

    int conditionSwitch;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
        playerScore = 0;
        conditionSwitch = 0;
        timeToBlaster = 6.0f;
    }


    private void Update()
    {        
        if (playerScore >= 2)
            BlasterTimer();
            

        if (playerScore >= 30 && conditionSwitch == 2 && !blasterPossibility)
        {
            timeToBlaster = 3f;
            conditionSwitch++;
        }


        else if (playerScore >= 20 && conditionSwitch == 1 && !blasterPossibility)
        {
            timeToBlaster = 5f;
            conditionSwitch++;
        }
            

        else if (playerScore >= 10 && conditionSwitch == 0 && !blasterPossibility)
        {
            timeToBlaster = 10f;
            conditionSwitch++;
        }
                
    }

    public void AddScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    public void PlayerDied()
    {       
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void BlasterTimer()
    {
        timeToBlaster -= Time.deltaTime;

        if (timeToBlaster <= 0)
        {
            timeToBlaster = 0;
            blasterTimeText.color = Color.red;
            blasterTimeText.text = ("You may use your force");
            blasterPossibility = true;
        }

        else
            blasterTimeText.color = Color.magenta;
            blasterTimeText.text = ("Time To Blaster: " + (int)timeToBlaster);
    }
}
