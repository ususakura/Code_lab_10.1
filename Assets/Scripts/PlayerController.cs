using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 4f;
    public GameObject goal;
    Vector3 startPosition;
    InputAction upButton;
    InputAction downButton;
    InputAction leftButton;
    InputAction rightButton;
    AudioSource hitSound;

    public GameObject powerUp;
    public float boostedSpeed = 8f;
    float normalSpeed;

    public ChaserController chaser;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        normalSpeed = speed;

        hitSound = GetComponent<AudioSource>();

        startPosition = transform.position;
        upButton = InputSystem.actions.FindAction("Up");
        downButton = InputSystem.actions.FindAction("Down");
        leftButton = InputSystem.actions.FindAction("Left");
        rightButton = InputSystem.actions.FindAction("Right");

        
    }

    // Update is called once per frame
    void Update()
    {
        if (upButton.IsPressed())
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (downButton.IsPressed())
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if (leftButton.IsPressed())
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (rightButton.IsPressed())
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        // Clamp the player's position to the screen bounds
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -8f, 8f);
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, -4.5f, 4.5f);
        transform.position = clampedPosition;   


    }

    void ResetPosition()
    {
        transform.position = startPosition;
        speed = normalSpeed;
        powerUp.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("hazard") || other.gameObject == goal)
        {
            hitSound.Play();
            chaser.PlayerReachedGoal();
            ResetPosition();
        }
        else if (other.CompareTag("powerup"))
        {
            hitSound.Play();
            speed = boostedSpeed;
        }

    }
}
