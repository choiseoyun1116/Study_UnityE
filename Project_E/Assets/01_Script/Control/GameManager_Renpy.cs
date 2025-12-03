using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager_Renpy : SingletonBehabiour<GameManager_Renpy>
{
    public static PlayerData PData;

    protected override void Awake()
    {
        base.Awake();

        Initialize();
    }
    // 초기화 로직을 호출


    void Initialize()
    {
        LoadData();
        RenpyControl.Instance.Open(PData);
        RenpyControl.Instance.Initialize();
    }
    // 데이터를 로드하고 Renpy 컨트롤을 초기화

    void Open()
    {
    }
    // 현재는 비어있는 함수

    public void SaveData()
    {
        string jsonString = JsonUtility.ToJson(PData);
        PlayerPrefs.SetString("PData", jsonString);
    }
    // 현재 플레이어 데이터를 JSON으로 변환하여 저장

    public bool LoadData()
    {
        if (PlayerPrefs.HasKey("PData"))
        {
            string jsonString = PlayerPrefs.GetString("PData");
            PData = JsonUtility.FromJson<PlayerData>(jsonString);
            return true;
        }
        else
        {
            UnityEngine.Debug.Log("<color=red>Create New Data</color>");
            PData = new PlayerData();
            return false;
        }
    }
    // 저장된 데이터를 로드하거나, 데이터가 없으면 새로 생성
}