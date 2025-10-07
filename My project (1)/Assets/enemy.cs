using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private Vector2 initialPosition = new Vector2(-10, 3);
    [SerializeField] private float speed = 5f;

    public spawner _spawner;

    public void Update()
    {
        if (_rb.position.x >= 10)
        {
            _rb.linearVelocityX = -speed;
        }
        if (_rb.position.x <= -10)
        {
            _rb.linearVelocityX = speed;
            _rb.position = _rb.position - new Vector2(0, 0.1f);
        }
        _rb.rotation = _rb.rotation + 5;
    }

    public void Start()
    {
        _rb.position = initialPosition;
        _rb.linearVelocityX = speed;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            Destroy(collision.gameObject);
            //Destroy(gameObject);
            _spawner.EnemiesStack.Push(gameObject);
            gameObject.SetActive(false);
        }
    }

    public void OnMove()
    {
        
    }

}
