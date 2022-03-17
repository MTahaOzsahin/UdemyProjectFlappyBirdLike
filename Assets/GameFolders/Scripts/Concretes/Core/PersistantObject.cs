using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyprojectTutorialBerk1.Core
{
    public class PersistantObject : MonoBehaviour
    {
        [SerializeField] GameObject persistantPrefab;

        static bool _isFirstTime = true;

        private void Start()
        {
            if (_isFirstTime)
            {
                SpawnPersistantObjects();
                _isFirstTime = false;
            }
        }

        void SpawnPersistantObjects()
        {
           GameObject newObject = Instantiate(persistantPrefab);
            DontDestroyOnLoad(newObject);
        }
    }
}

