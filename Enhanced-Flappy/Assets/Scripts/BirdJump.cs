using UnityEngine;
using UnityEngine.InputSystem;

public class BirdJump : MonoBehaviour
{
    [SerializeField] float jumpForce = 1.5f;

    Rigidbody rb;

    public InputActionReference jump;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        jump.action.Enable();
        jump.action.started += Jump;
    }

    private void OnDisable()
    {
        jump.action.started -= Jump;
        jump.action.Disable();
    }

    private void Jump(InputAction.CallbackContext obj)
    {
        rb.linearVelocity = Vector3.up * jumpForce;
    }
}
