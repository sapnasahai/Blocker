using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Reference variables
    private Camera mainCamera;

    

    public float moveSpeed = 5f;

    // 🔹 Awake is called FIRST
    void Awake()
    {
        // Reference assignment (setup work)
         mainCamera = Camera.main;

        Debug.Log("Awake: Camera reference assigned");
    }

    // 🔹 Start is called AFTER all Awake methods
    void Start()
    {
        // Gameplay logic
        Debug.Log("Start: Player is ready to move");
    }

    void Update()
    {
        
            float horizontal = Input.GetAxis("Horizontal"); // A / D

            transform.Translate(Vector3.right * horizontal * moveSpeed * Time.deltaTime);
       
    }
}
