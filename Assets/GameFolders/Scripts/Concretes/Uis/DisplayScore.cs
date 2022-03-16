using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace UdemyprojectTutorialBerk1.Uis
{
    public class DisplayScore : MonoBehaviour
    {
        TextMeshProUGUI _scoreText;
        private void Awake()
        {
            _scoreText = GetComponent<TextMeshProUGUI>();
        }

        private void Start()
        {
            GameManager.Instance.OnScoreChanged += HandleOnScoreChange;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnScoreChanged -= HandleOnScoreChange;
        }
        private void HandleOnScoreChange(int score = 0)
        {
            _scoreText.text = $"Score:{score}";
        }
    }
}

