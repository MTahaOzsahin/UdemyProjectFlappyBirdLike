using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UdemyprojectTutorialBerk1.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        Rigidbody2D _rigidbody2D;
        bool _isLeftMouseClicked;

       [SerializeField] float jumpForce;

        //public float JumpForce            Encapsulation ornegi
        //{
        //    get
        //    {
        //        return jumpForce;
        //    }
        //    set
        //    {
        //        if (value <1f || value > 1000f)
        //        {
        //            jumpForce = 500f;
        //        }
        //        else
        //        {
        //            jumpForce = value;
        //        }
        //    }
                
        //}

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            if (Input.GetMouseButton(0))
            {
                _isLeftMouseClicked = true;
            }
        }
        private void FixedUpdate()
        {
            if (_isLeftMouseClicked)
            {
                _rigidbody2D.velocity = Vector2.zero;
                _rigidbody2D.AddForce(Vector2.up * jumpForce);
                _isLeftMouseClicked = false;
            }
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            GameManager.Instance.RestartGame();
        }
    }
}

