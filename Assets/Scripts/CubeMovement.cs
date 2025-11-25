using UnityEngine;
using UnityEngine.InputSystem;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpforce = 5f;
    [SerializeField] private float Health = 5f;
    [SerializeField] private float Life = 5f;


    void Update()
    {

        //  auto forward movement
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // ---- Time Scale Controls (New Input System) ----

        if (Keyboard.current.digit1Key.wasPressedThisFrame)
        {
            Time.timeScale = 0.2f;   // Slow motion
            Debug.Log("Slow Motion");
        }

        if (Keyboard.current.digit2Key.wasPressedThisFrame)
        {
            Time.timeScale = 1f;     // Normal speed
            Debug.Log("Normal Speed");
        }

        if (Keyboard.current.digit3Key.wasPressedThisFrame)
        {
            Time.timeScale = 2f;     // Fast motion
            Debug.Log("Fast Motion");
        }
    }
}
