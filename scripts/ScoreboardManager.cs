using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScoreboardManager : MonoBehaviour
{
    public List<ScoreboardEntry> entries;

    private string filePath;

    void Start() 
    {
        filePath = Path.Combine(Application.persistentDataPath, "scoreboard.json");
        LoadScoreboard();
    }

    public void LoadScoreboard() 
    {
        if (File.Exists(filePath)) 
        {
            string json = File.ReadAllText(filePath);
            entries = JsonUtility.FromJson<List<ScoreboardEntry>>(json);
        }
        else 
        {
            entries = new List<ScoreboardEntry>();
        }
    }

    public void SaveScoreboard() 
    {
        string json = JsonUtility.ToJson(entries, true);
        File.WriteAllText(filePath, json);
    }

    public void SortScoreboard() 
    {
        entries.Sort((entry1, entry2) => entry2.playerScore.CompareTo(entry1.playerScore));
    }

    public void UpdateScore(string playerName, int newScore) 
    {
        var entry = entries.Find(e => e.playerName == playerName);
        if (entry != null) 
        {
            entry.playerScore = newScore;
        }
        else 
        {
            entries.Add(new ScoreboardEntry { playerName = playerName, playerScore = newScore });
        }
        SortScoreboard();
        SaveScoreboard();
    }

    public void AddNewScoreEntry(string playerName, int score) 
    {
        entries.Add(new ScoreboardEntry { playerName = playerName, playerScore = score });
        SortScoreboard();
        SaveScoreboard();
    }
}
