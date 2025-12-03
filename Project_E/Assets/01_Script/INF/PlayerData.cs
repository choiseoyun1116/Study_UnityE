using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LANGUAGE
{
    KOREAN = 0,
    ENGLISH,
}

[System.Serializable]
public class PlayerData
{
    public PlayerData()
    {
        Option = new PlayerOption();
        Renpy = new RenpyPlayerData();
        StarRail = new StarRailPlayerData();
    }

    public PlayerOption Option;

    public RenpyPlayerData Renpy;
    public StarRailPlayerData StarRail;

    public LANGUAGE Language;
}

[System.Serializable]
public class PlayerOption
{
    public PlayerOption()
    {
        BGMVol = 1;
        SFXVol = 1;
    }

    public float BGMVol;
    public float SFXVol;

}

[System.Serializable]
public class RenpyPlayerData
{
    public RenpyPlayerData()
    {
        NowStoryID = 1001;
    }

    public int NowStoryID;
}

[System.Serializable]
public class StarRailPlayerData
{
    public StarRailPlayerData()
    {

    }

    public int NowWorldID = 2001;
}