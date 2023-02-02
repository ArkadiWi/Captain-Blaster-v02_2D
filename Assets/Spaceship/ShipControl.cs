using UnityEditor;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;    
    [SerializeField] private InputController inputController;
    [SerializeField] private float speed = 50f;
    [SerializeField] private float xLimit = 7f;
    Vector3 position;

    void Update()
    {
        transform.Translate(inputController.XInput * speed * Time.deltaTime, inputController.YInput * speed * Time.deltaTime, 0f);

        // ograniczenie po³o¿enia statku na osi X i Y
        position = transform.position;
        position.x = Mathf.Clamp(position.x, -xLimit, xLimit);
        position.y = Mathf.Clamp(position.y, -6f, -1f);
        transform.position = position;
    }
    

    //je¿eli meteor uderzy³ w gracza
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        gameManager.PlayerDied();
        Destroy(this.gameObject);
    }

}
