using System.Collections;
using System.Collections.Generic;
using UdemyprojectTutorialBerk1.Movements;
using UnityEngine;


namespace UdemyprojectTutorialBerk1.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        Rigidbody2D _rigidbody2D;
        Jump _jump;
        PcInputControlller _input;
        bool _isLeftMouseClicked;

      

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
            _jump = GetComponent<Jump>();
            _input = new PcInputControlller();
        }
        private void Update()
        {
            if (_input.LeftMouseClikDown)
            {
                _isLeftMouseClicked = true;
            }
        }
        private void FixedUpdate()
        {
            if (_isLeftMouseClicked)
            {
                _jump.JumpAction(_rigidbody2D);
                _isLeftMouseClicked = false;
            }
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            GameManager.Instance.RestartGame();
        }
    }
}

