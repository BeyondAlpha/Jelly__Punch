using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour

{
    static public int stage_Num;

    public void SceneChange0()
    {
        SceneManager.LoadScene("Stage_scene");
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void SceneChange2()
    {

        SceneManager.LoadScene("Tutorial");
        GameManager.totalPoint += GameManager.stagePoint;
        GameManager.stagePoint = 0;
        GameManager.health = 3;
    }

    public void SceneChange3()
    {

        SceneManager.LoadScene("Stage2");
        GameManager.totalPoint += GameManager.stagePoint;
        GameManager.stagePoint = 0;
        GameManager.health = 3;
    }

    public void SceneChange4()
    {
        SceneManager.LoadScene("Stage3");
        GameManager.totalPoint += GameManager.stagePoint;
        GameManager.stagePoint = 0;
        GameManager.health = 3;
    }

    public void SceneChange5()
    {
        stage_Num = 4;
        SceneManager.LoadScene("Last_JumpMap");
    }

    public void SceneChange6()
    {
        SceneManager.LoadScene("clear");
    }

    public void SceneChang7()
    {
        SceneManager.LoadScene("fail");
    }

    public void SceneChange8()
    {
        SceneManager.LoadScene("About");
    }
}