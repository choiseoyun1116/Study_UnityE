using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager_StarRail : SingletonBehabiour<GameManager_Renpy>
{
    public static PlayerData PData;

    protected override void Awake()
    {
        base.Awake();

        Initialize();
    }
    // 게임 매니저 인스턴스 생성 시 초기화 함수 호출

    
    void Initialize()
    {
        LoadData();
        // Open();

        StarrailControl.Instance.Open(PData);
        StarrailControl.Instance.Initialize();
    }
    // 시작되었을 때 PData 데이터를 참조하도록 연결하고 컨트롤러 초기화

    void Open()
    {
    }
    // 현재 사용되지 않는 빈 함수

    public void SaveData()
    {
        string jsonString = JsonUtility.ToJson(PData);
        PlayerPrefs.SetString("PData", jsonString);
    } 
    // 현재 플레이어 데이터를 디스크에 저장

    public bool LoadData()
    {
        if(PlayerPrefs.HasKey("PData"))
        {
            string jsonString = PlayerPrefs.GetString("PData");
            PData = JsonUtility.FromJson<PlayerData>(jsonString);
            return true;
        }
        else
        {
            UnityEngine.Debug.Log("<color=red>Create New Data</color>");
            PData = new PlayerData();
            // SaveData();
            return false;
        }
    }
    // 저장된 데이터가 있는지 확인하고 로드, 없으면 새 데이터 생성 요구
}