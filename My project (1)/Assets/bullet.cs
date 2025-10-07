using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb.linearVelocity = new Vector2(0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
