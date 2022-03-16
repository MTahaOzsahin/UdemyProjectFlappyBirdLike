using System;
using System.Collections;
using System.Collections.Generic;
using UdemyprojectTutorialBerk1.Combat;
using UnityEngine;

namespace UdemyprojectTutorialBerk1.Uis
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPanel;
        private void Awake()
        {
            gameOverPanel = transform.GetChild(1).gameObject;
        }

        private void Start()
        {
            Death death = FindObjectOfType<Death>();
            death.onDead += HandleOnDeath;
        }

        private void HandleOnDeath()
        {
            gameOverPanel.SetActive(true);
        }
    }
}
