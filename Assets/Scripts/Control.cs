using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;
using System.Drawing;

public class Control : MonoBehaviour
{
    public float speed = 10;
    Animator anim;
    public float stamina = 100;
    public Text scoreTi;
    public static float way = 0;
    public GameObject start_UI;
    public Text tryagain;
    public Button tryagain_button;
    public GameObject ip;
    void Start()
    {
        anim = GetComponent<Animator>();
        start_UI = GameObject.Find("start_UI");
        tryagain.enabled = false;
        tryagain_button.gameObject.SetActive(false);
        ip = GetComponent<GameObject>();


    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Stationary && stamina > 50)
                {
                    transform.Translate(0, 0, speed * Time.deltaTime);
                    anim.SetBool("walk", true);
                    stamina = stamina -= 1 * Time.deltaTime * 3;
                    way = way += 1 * Time.deltaTime * 2;
                    scoreTi.text = way.ToString();
                    Debug.Log(stamina);

                }
                else if (touch.phase == TouchPhase.Stationary && stamina < 50 && stamina > 10)
                {
                    speed = 4;
                    Debug.Log("Speed: " + speed);
                    transform.Translate(0, 0, speed * Time.deltaTime);
                    anim.SetBool("slow", true);
                    stamina = stamina -= 1 * Time.deltaTime * 8;
                    way = way += 1 * Time.deltaTime * 1;
                    scoreTi.text = way.ToString();
                    Debug.Log(stamina);
                }
                else if (touch.phase == TouchPhase.Ended)
                {
                    transform.Translate(0, 0, 0);
                    anim.SetBool("slow", false);
                }
                if (touch.phase == TouchPhase.Stationary && stamina < 10)
                {
                    Destroy(ip);
                    anim.SetBool("dead", true);
                    speed = 0;
                    transform.Translate(0, 0, 0);
                    stamina = stamina -= 1 * Time.deltaTime * 0;
                    way = way += 1 * Time.deltaTime * 0;
                    tryagain.enabled = true;
                    tryagain_button.gameObject.SetActive(true);


            }
        }
            else
            {
                if (stamina > 10 && stamina <= 100)
                {
                    stamina = stamina += 1 * Time.deltaTime * 1;

                    Debug.Log(stamina);
                }
                transform.Translate(0, 0, 0);
                anim.SetBool("walk", false);

            }
        }
}
     

