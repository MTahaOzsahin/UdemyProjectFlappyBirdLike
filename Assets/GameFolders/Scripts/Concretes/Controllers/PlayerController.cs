using System.Collections;
using System.Collections.Generic;
using UdemyprojectTutorialBerk1.Combat;
using UdemyprojectTutorialBerk1.Movements;
using UnityEngine;


namespace UdemyprojectTutorialBerk1.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        Rigidbody2D _rigidbody2D;
        Jump _jump;
        PcInputControlller _input;
        LaunchProjectile _launchProjectile;
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
            _launchProjectile = GetComponent<LaunchProjectile>();
            _input = new PcInputControlller();
        }
        private void Update()
        {
            if (_input.LeftMouseClikDown)
            {
                _isLeftMouseClicked = true;
            }
            if (_input.RightMouseClickDown)
            {
                _launchProjectile.LaunchAction();
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
        
    }
}

