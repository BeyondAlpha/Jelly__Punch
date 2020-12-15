using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGame : MonoBehaviour
{
    static bool ableInput = false;
    static bool ableStart = true;
    bool ableCheck = false;
    public bool success = false;
    List<int> judgelist = new List<int>();
    List<string> hitSign = new List<string>();
    Vector3 hitSignTunacan;
    Rigidbody2D rigid;
    List<string> checklist = new List<string>();
    int GameNum;
    static public int Success = 0;
    // Start is called before the first frame update

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(checklist.Count);

        int _Sign = 1<<LayerMask.NameToLayer("Sign");

        RaycastHit2D hit = Physics2D.Raycast(rigid.position, new Vector3(1.0f,0,0), 1 , _Sign); // sign 감지 
        if (hit.collider != null && ableStart == true) 
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                hitSign = GameObject.Find(hit.collider.name).GetComponent<Sign>().notes;
                hitSignTunacan = GameObject.Find(hit.collider.name).GetComponent<Sign>().tunacan;
                Debug.Log(hitSign.Count);
                StartCoroutine(PrintSound(hitSign));
                if (hit.collider.name == "TutorialSign")
                {
                    GameNum = 0;
                }
                if ( hit.collider.name == "Sign1")
                {
                    GameNum = 1;
                }
                if ( hit.collider.name == "Sign2")
                {
                    GameNum = 2;
                }
                if ( hit.collider.name == "Sign3")
                {
                    GameNum = 3;
                }
                if ( hit.collider.name == "Sign4")
                {
                    GameNum = 4;
                }
                if ( hit.collider.name == "Sign5")
                {
                    GameNum = 5;
                }
                if ( hit.collider.name == "Sign6")
                {
                    GameNum = 6;
                }
            }

        }

        if (ableInput == true)
        {
            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                checklist.Add("Left");
                GameObject.Find("LeftSound").GetComponent<AudioSource>().Play();
            }
            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                checklist.Add("Right");
                GameObject.Find("RightSound").GetComponent<AudioSource>().Play();
            }
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                checklist.Add("Up");
                GameObject.Find("UpSound").GetComponent<AudioSource>().Play();
            }
            if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                checklist.Add("Down");
                GameObject.Find("DownSound").GetComponent<AudioSource>().Play();
            }
        }


        
        if (checklist.Count == hitSign.Count)
        {
            for (int i = 0; i < hitSign.Count; i++)
            {
                if (checklist[i].Equals(hitSign[i]))
                {
                    //1개라도 같지 않은 요소가 있으면 false
                    judgelist.Add(1);
                }
                else
                {
                    judgelist.Add(0);
                }
            }
        }
        
        if ( ableInput == true && judgelist.Count == hitSign.Count)
        {
            if (!judgelist.Contains(0))
            {
                ableCheck = true;
                judgelist = new List<int>();
                checklist = new List<string>();
                ableInput = false;
                
            }
            else
            {
                if (Success ==  1 )
                {
                    for ( int i = 0; i < BlockPosition.first_game.Count;i++)
                    {
                        KeyBoardGame.DestroyBlock(0);
                    }
                    Success = 0;
                }
                if (Success ==  2)
                {
                    for ( int i = 0; i < BlockPosition.first_game.Count;i++)
                    {
                        KeyBoardGame.DestroyBlock(0);
                    }
                    for (int i = 0; i < BlockPosition.second_game.Count;i++)
                    {
                        KeyBoardGame.DestroyBlock(1);
                    }
                    Success = 0;
                }
                if (Success ==  3)
                {
                    for ( int i = 0; i < BlockPosition.first_game.Count;i++)
                    {
                        KeyBoardGame.DestroyBlock(0);
                    }
                    for (int i = 0; i < BlockPosition.second_game.Count;i++)
                    {
                        KeyBoardGame.DestroyBlock(1);
                    }
                    for ( int i = 0; i < BlockPosition.third_game.Count;i++)
                    {
                        KeyBoardGame.DestroyBlock(2);
                    }
                    Success = 0;
                }
                GameManager.HealthDown();
                judgelist = new List<int>();
                checklist = new List<string>();
                ableInput = false;
                ableStart = true;
            }
            
        }

        if (ableCheck == true)
        {
            if (GameNum == 0)
            {
                KeyBoardGame.CreateWall(BlockPosition.tutorial_game, hitSignTunacan);
                ableCheck = false;
                GameNum = 0;
                ableStart = true;
            }
            if (GameNum == 1)
            {
                KeyBoardGame.CreateWall(BlockPosition.first_game, hitSignTunacan);
                ableCheck = false;
                GameNum = 0;
                Success ++;
                ableStart = true;
            }
            if (GameNum == 2)
            {
                KeyBoardGame.CreateWall(BlockPosition.second_game, hitSignTunacan);
                ableCheck = false;
                GameNum = 0;
                Success ++;
                ableStart = true;
            }
            if (GameNum == 3)
            {
                KeyBoardGame.CreateWall(BlockPosition.third_game, hitSignTunacan);
                ableCheck = false;
                GameNum = 0;
                Success = 0;
                ableStart = true;
            }
            if (GameNum == 4)
            {
                KeyBoardGame.CreateWall(BlockPosition.fourth_game, hitSignTunacan);
                ableCheck = false;
                GameNum = 0;
                Success ++;
                ableStart = true;
            }
            if (GameNum == 5)
            {
                KeyBoardGame.CreateWall(BlockPosition.fifth_game, hitSignTunacan);
                ableCheck = false;
                GameNum = 0;
                Success ++;
                ableStart = true;
            }
            if (GameNum == 6)
            {
                KeyBoardGame.CreateWall(BlockPosition.sixth_game, hitSignTunacan);
                ableCheck = false;
                GameNum = 0;
                Success = 0;
                ableStart = true;
            }
        }
        
    }

    static public IEnumerator PrintSound(List<string> notes)
    {
        Debug.Log("Play");
        for (int i = 0; i < notes.Count; i++)
        {
            KeyBoardGame.Playmusic(notes[i]);
            yield return new WaitForSeconds(1.0f);
        }
        ableInput = true;
        ableStart = false;
    }

}