using UnityEngine;

public class Bullet3 : MonoBehaviour
{
    float speedY = 10f;

    GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        //odszukanie obiektu kontrolnego game manager
        gameManager = GameObject.FindObjectOfType<GameManager>();

        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(-0.8f, speedY);
        Destroy(this.gameObject,0.7f);
    }

    private void OnCollisionEnter2D(Collision2D other)        
    {
        if (other.gameObject.tag == "Meteor")
        {
            Destroy(other.gameObject); //usuni�cie meteoru
            gameManager.AddScore(); //Inkrementacja liczby punkt�w
            Destroy(this.gameObject); // usuni�cie pocisku
        }
    }    
}
