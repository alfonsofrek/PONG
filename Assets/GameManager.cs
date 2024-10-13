using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    [SerializeField] private TMP_Text ScoreI;
    [SerializeField] private TMP_Text ScoreD;
    [SerializeField] private Transform PalaDtransform;
    [SerializeField] private Transform PalaItransform;
    [SerializeField] private Transform Balltransform;
    private int ScoreIp;
    private int ScoreDp;
    private static GameManger instance;
    public static GameManger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindAnyObjectByType<GameManger>();
            }
            return instance;
        }
    }

    public void palaIscored()
    {
        ScoreIp++;
        ScoreI.text = ScoreIp.ToString();

        if (ScoreIp >= 10)
        {
            RestartGame();
            EndGameI();
        }
    }

    public void palaDscored()
    {
        ScoreDp++;
        ScoreD.text = ScoreDp.ToString();

        if (ScoreDp >= 10)
        {
            RestartGame();
            EndGameD();
        }
        
    }

    public void RestartGame()
    {
        ScoreIp = 0;
        ScoreDp = 0;
        ScoreI.text = ScoreIp.ToString();
        ScoreD.text = ScoreDp.ToString();

     


    }
    public void EndGameD()
    {
        
    
        SceneManager.LoadScene("GanadorPD");
    }
    public void EndGameI()
    {


        SceneManager.LoadScene("GanadorPI");
    }
}
