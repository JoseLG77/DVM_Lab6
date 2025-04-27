using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 moveInput;
    private CharacterController cc;
    private PlayerControls controls;

    void Awake()
    {
        cc = GetComponent<CharacterController>();
        controls = new PlayerControls();
        controls.Gameplay.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => moveInput = Vector2.zero;
    }

    void OnEnable() => controls.Gameplay.Enable();
    void OnDisable() => controls.Gameplay.Disable();

    void Update()
    {
        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        cc.Move(move * speed * Time.deltaTime);
    }
}
