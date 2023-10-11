using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;



public class DataManager : MonoBehaviour
{
    
    //싱글톤
    public static DataManager instance;

    public userData nowPlayer = new userData();

    public String path;//경로
    public int nowSlot;//현재 슬롯번호
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);

        path = Application.persistentDataPath + "/save";
        Debug.Log(path);
    }
    

    public void SaveData()//저장기능
    {
        string data = JsonUtility.ToJson(nowPlayer);//저장할데이터를 json형식으로 변환
        File.WriteAllText(path + nowSlot.ToString(), data);//변환한 파일 저장
    }

    public void LoadData()//불러오기 기능
    {
        string data = File.ReadAllText(path + nowSlot.ToString());//저장된데이터 불러오기
        nowPlayer = JsonUtility.FromJson<userData>(data);//json형식에서 원래 데이터 형식으로 변환
    }

    public void DataClear()
    {
        nowSlot = -1;
        nowPlayer = new userData();
    }
}
