using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

namespace Nannaphat.GameDev3.Chapter2
{
    public class BasicMouseInformation : MonoBehaviour
    {
        public Text m_TextMousePosition;

        // Update is called once per frame
        void Update()
        {
            m_TextMousePosition.text = Input.mousePosition.ToString();
        }
    }
}