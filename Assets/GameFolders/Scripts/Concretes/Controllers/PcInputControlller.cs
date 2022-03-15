using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyprojectTutorialBerk1.Controllers
{
    public class PcInputControlller
    {
        public bool LeftMouseClikDown => Input.GetMouseButtonDown(0);
        public bool RightMouseClickDown => Input.GetMouseButtonDown(1);
    }
}


