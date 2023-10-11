using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class SelectData : MonoBehaviour
{
    public GameObject create;
    public Text[] slotText; 
    public Text newPlayerName;

    private bool[] savefile = new bool[3];
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            if (File.Exists(DataManager.instance.path + $"{i}"))
            {
                savefile[i] = true;
                DataManager.instance.nowSlot = i;
                DataManager.instance.LoadData();
                slotText[i].text = DataManager.instance.nowPlayer.name;
            }
            else
            {
                slotText[i].text = "새 게임";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
