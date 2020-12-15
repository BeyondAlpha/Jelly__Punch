using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static public int totalPoint;
    static public int stagePoint;
    static public int stageIndex;
    static public int health;

    public GameObject[] Stages;

    static public Image[] UIHealth;
    static public Image[] UICan;
    static public Text UIStage;
    public Text UIPoint;
    static public GameObject UIRestartBtn;

    private float GameTime = 50;
    public string transferMap;
    public Text GameTimeText;

    void Update()
    {

        UIPoint.text = (totalPoint + stagePoint).ToString();
        UIStage.text = Change.stage_Num.ToString();

        
            
        
            if((int)GameTime == 0)
            {
                Debug.Log("Game Over");
                SceneManager.LoadScene("fail");

            } 
            else
            {
                GameTime -= Time.deltaTime;
                Debug.Log((int)GameTime);
                GameTimeText.text = "Time: " + (int)GameTime;
            }
    }



    void Awake()
    {
        health = 3;
        stagePoint = 0;
        totalPoint = 0;
    }
    
    static public void HealthDown()
    {
        if (health > 1)
        {
            health--;
            UIHealth[health].color = new Color(1,1,1,0.2f);
        }
        else {
            UIHealth[0].color = new Color(1,1,1,0.2f);
            //Player Die Effect
            PlayerMove.OnDie();

            //Result UI       
            UIRestartBtn.SetActive(true);
        }
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Stage_scene");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            // Next Stage
            HealthDown();

            collision.transform.Translate(0f,0f,0f);
        }
    }
    
}
