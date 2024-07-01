using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class ScoreboardManager : MonoBehaviour
{
    //public List<ScoreboardEntry> entries;
    public ScoreboardEntryList entries;
    public ScoreboardEntryList x;

    private string filePath;

    void Start() 
    {
        filePath = Path.Combine(Application.persistentDataPath, "scoreboard.json");
        LoadScoreboard();
        /*x = new ScoreboardEntryList();
        x.entryList = new List<ScoreboardEntry>();
        x.entryList.Add(new ScoreboardEntry { playerName = "sdsdggds", playerScore = 322 });
        x.entryList.Add(new ScoreboardEntry { playerName = "123123", playerScore = 1231232 });
        x.entryList.Add(new ScoreboardEntry { playerName = "ûגפאûגאןûןגא", playerScore = 228 });
        Debug.Log(JsonUtility.ToJson(x));*/
    }

    public void LoadScoreboard() 
    {
        if (File.Exists(filePath)) 
        {
            string json = File.ReadAllText(filePath);
            entries = JsonUtility.FromJson<ScoreboardEntryList>(json);
        }
        else 
        {
            entries = new ScoreboardEntryList();
            entries.entryList = new List<ScoreboardEntry>();
        }
    }

    public void SaveScoreboard() 
    {
        string json = JsonUtility.ToJson(entries);
        File.WriteAllText(filePath, json);
        Debug.Log(json);

    }

    public void SortScoreboard() 
    {
        entries.entryList.Sort((entry1, entry2) => entry2.playerScore.CompareTo(entry1.playerScore));
    }

    public void UpdateScore(string playerName, int newScore) 
    {
        var entry = entries.entryList.Find(e => e.playerName == playerName);
        if (entry != null) 
        {
            entry.playerScore = newScore;
        }
        else 
        {
            entries.entryList.Add(new ScoreboardEntry { playerName = playerName, playerScore = newScore });
        }
        SortScoreboard();
        SaveScoreboard();
    }

    public void AddNewScoreEntry(string playerName, int score) 
    {
        entries.entryList.Add(new ScoreboardEntry { playerName = playerName, playerScore = score });
        SortScoreboard();
        SaveScoreboard();
    }
}
