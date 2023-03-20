using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tryagain : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
    }
    public void OnButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
