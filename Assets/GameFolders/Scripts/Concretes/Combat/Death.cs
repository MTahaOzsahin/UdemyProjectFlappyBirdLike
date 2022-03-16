using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyprojectTutorialBerk1.Combat
{
    public class Death : MonoBehaviour
    {
        [SerializeField] bool _isDead;
        public bool IsDead => _isDead;

        public event System.Action onDead;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            _isDead = true;
            onDead?.Invoke();
            Time.timeScale = 0f;
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            _isDead = true;
            onDead?.Invoke();
            Time.timeScale = 0f;
        }


        //private void OnCollisionEnter2D(Collision2D collision)
        //{
        //    GameManager.Instance.RestartGame();
        //}
        //private void OnTriggerEnter2D(Collider2D collision)
        //{
        //    GameManager.Instance.RestartGame();
        //}
    }
    
}

