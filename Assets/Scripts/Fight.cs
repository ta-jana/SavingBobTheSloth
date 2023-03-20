using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fight : MonoBehaviour
{
    public GameObject Rock;
    public GameObject Paper;
    public GameObject Scissors;

    public TextMeshProUGUI LivesRemaining;
    public TextMeshProUGUI EnemyChoiceText;
    public TextMeshProUGUI MyChoiceText;



    public List<string> Choices = new List<string> { "Rock", "Paper", "Scissors" };

    public void RockOpt()
    {
        MyChoiceText.text = "Rock";
        EnemyChoice();
    }
    public void PaperOpt()
    {
        MyChoiceText.text = "Paper";
        EnemyChoice();
    }
    public void ScissorsOpt()
    {
        MyChoiceText.text = "Scissors";
        EnemyChoice();
    }

    void Start()
    {
        
    }


  
    string EnemyChoice()
    {
        int index = Random.Range(0, Choices.Count);

        EnemyChoiceText.text = Choices[index];
        return EnemyChoiceText.text;
    }

    void fight()
    {
        string EChoice = EnemyChoice();
        string MChoice = MyChoiceText.text;

        if(EChoice == MChoice)
        {
            // go again
        }else if(EChoice == "Rock")
        {
            if (MChoice == "Scissors")
            {
                // enemy won
                // player losing heart
                // check if player is not dead
                // another round

            }
            else
            {
                // player - paper won
            }
        }else if(EChoice == "Paper")
        {
            if(MChoice == "Rock")
            {
                // enemy won
            }
            else
            {
                //pl scissors - won
            }
        }else if(EChoice == "Scissors")
        {
            if(MChoice == "Paper")
            {
                // en won
            }
            else
            {
                // pl - rock - won
            }
        }
    }
   
}
