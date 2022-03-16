using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyprojectTutorialBerk1.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
       public void YesButtonClick()
        {
            GameManager.Instance.RestartGame();
        }
        public void NoButtonClick()
        {
            Debug.Log("No button clicked");
        }
    }
}
