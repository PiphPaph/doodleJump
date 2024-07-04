using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;



public class ScoreboardManager : MonoBehaviour
{
    
    public ScoreboardEntryList entries;
    private string filePath;
    
    public Text scoreTextPrefab; // Префаб текста для отображения счета
    public GameObject scoreboardPanel; // Панель для размещения текстовых элементов

    void Start() 
    {
        filePath = Path.Combine(Application.persistentDataPath, "scoreboard.json");
        LoadScoreboard();
    }

    public void LoadScoreboard() 
    {

        if (File.Exists(filePath)) 
        {
            var json = File.ReadAllText(filePath);
            entries = JsonUtility.FromJson<ScoreboardEntryList>(json);
            
            while (entries.entryList.Count > 10)
            {
                entries.entryList.RemoveAt(entries.entryList.Count - 1);
            }
            
            for (int i = 0; i < entries.entryList.Count; i++)
            {

                var scoreText = Instantiate(scoreTextPrefab, scoreboardPanel.transform);
                scoreText.text = $"{entries.entryList[i].playerName}: {entries.entryList[i].playerScore}";
            }
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
        
    }
}
