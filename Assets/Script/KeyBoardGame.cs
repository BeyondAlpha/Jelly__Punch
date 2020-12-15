using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardGame : MonoBehaviour
{
    static List<int> typelst = new List<int>(); 

    static public void Playmusic(string note)
    {
        GameObject.Find(note+"Sound").GetComponent<AudioSource>().Play();
    }

    static public void CreateWall(List<Vector3> blockPosition, Vector3 tunacan)
    {
        List<Vector3> position = blockPosition;
        string[] blockType = {"LeftBlock","RightBlock","DownBlock","UpBlock"};
        int Type = Random.Range(0,4);
        typelst.Add(Type);
        GameObject block = GameObject.Find(blockType[Type]);
        Debug.Log("hit" + position.Count);
        for( int i = 0; i < position.Count;i++)
        {
            Instantiate(block,position[i], Quaternion.identity);
        }

        GameObject Tunacan = GameObject.Find("Tunacan_item");
        Instantiate(Tunacan, tunacan, Quaternion.identity);
    }

    static public void DestroyBlock(int Num)
    {
        
        string[] blockType = {"LeftBlock","RightBlock","DownBlock","UpBlock"};
        GameObject block = GameObject.Find(blockType[typelst[Num]]+"(Clone)");
        Destroy(block);
    }
    // Update is called once per frame
}
