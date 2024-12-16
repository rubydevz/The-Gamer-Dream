using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigoController : MonoBehaviour
{
    public float _moveSpeedinimigo = 3.5f;
    private Vector2 _inimigoDirection;
    private Rigidbody2D _inimigoRB2D;
    public DetectionController _detectionArea;
    private SpriteRenderer _spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _inimigoRB2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _inimigoDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        if(_detectionArea.detectedObjs.Count > 0)
        {
            _inimigoDirection = (_detectionArea.detectedObjs[0].transform.position - transform.position).normalized;

            _inimigoRB2D.MovePosition(_inimigoRB2D.position + _inimigoDirection * _moveSpeedinimigo * Time.fixedDeltaTime);

            if(_inimigoDirection.x > 0)
            {
                _spriteRenderer.flipX = true;
            }
            else if (_inimigoDirection.x < 0)
            {
                _spriteRenderer.flipX = false;
            }

        }
    }
}
