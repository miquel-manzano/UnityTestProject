using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour, InputSystem_Actions.IPlayerActions
{
    private InputSystem_Actions inputActions;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform _shootPoint;

    public void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        inputActions = new InputSystem_Actions();
        inputActions.Player.SetCallbacks(this);
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if(context.performed)
            Instantiate(bullet, _shootPoint.position, Quaternion.identity);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _rb.linearVelocity = context.ReadValue<Vector2>() * 10;
    }

    public void OnEnable()
    {
           inputActions.Enable();
    }

    public void OnDisable()
    {
        inputActions.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
