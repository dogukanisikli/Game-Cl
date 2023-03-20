using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class finish : MonoBehaviour
{
    public Text finish_Text;
    public Button tryagain_button;
    GameObject speed;
    void Start()

    {
        Time.timeScale = 1;
        finish_Text.enabled = false;
        tryagain_button.gameObject.SetActive(false);
    }

    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        {
            finish_Text.enabled = true;
            tryagain_button.gameObject.SetActive(true);
            Time.timeScale = 0;

        }

    }
}
