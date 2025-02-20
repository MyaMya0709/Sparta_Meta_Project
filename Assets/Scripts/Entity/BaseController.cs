using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BaseController : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;

    [SerializeField] private SpriteRenderer CharacterRenderer;

    protected Vector2 movementDirection = Vector2.zero;
    public Vector2 MovementDirection { get { return movementDirection; } }

    protected Vector2 lookDirection = Vector2.zero;
    public Vector2 Lookdirection { get { return lookDirection; } }

    protected virtual void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        HandleAction();
        Rotate(lookDirection);

    }

    protected virtual void FixedUpdate()
    {
        Movment(movementDirection);

    }

    protected virtual void HandleAction()
    {

    }

    protected virtual void Movment(Vector2 direction)
    {
        direction = direction * 5;
        _rigidbody.velocity = direction;

    }

    protected void Rotate(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;
        bool isLeft = Mathf.Abs(rotZ) > 90f;

    }
}
