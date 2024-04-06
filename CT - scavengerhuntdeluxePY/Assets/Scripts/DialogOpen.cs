using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogOpen : MonoBehaviour
{

    public string dialog;
    public GameObject interfaceManager;
    public PlayerHolding pHolding;
    public bool begin = true;
    public bool end = false;
    private string[] collectibles;
    private int clue;

    private AudioSource greeting;

    // Start is called before the first frame update
    void Start()
    {
        greeting = GetComponent<AudioSource>();
        collectibles = new string[] { "film", "balloons", "life saver", "bull's eye", "pipe", "key", "fish", "birdhouse", "red airhorn", "magic hat" };
        createClue();
    }

    public void createClue()
    {
        clue = Random.Range(0, 9);
        searchDialog();
    }

    public void searchDialog()
    {
        if (collectibles[clue] == "film")
        {
            dialog = "I want to watch a movie with my friends, could you find my film?";
        }
        if (collectibles[clue] == "balloons")
        {
            dialog = "I want to make water balloons, could you find the balloons?";
        }
        if (collectibles[clue] == "life saver")
        {
            dialog = "I want to go to the beach, I need a life saver";
        }
        if (collectibles[clue] == "bull's eye")
        {
            dialog = "I need a target to practice my archery";
        }
        if (collectibles[clue] == "pipe")
        {
            dialog = "Im bored, I want my pipe";
        }
        if (collectibles[clue] == "key")
        {
            dialog = "I lOst mY kEy,  I nEeD iT";
        }
        if (collectibles[clue] == "fish")
        {
            dialog = "Im to lazy to fish, you go get it for me :)";
        }
        if (collectibles[clue] == "bird house")
        {
            dialog = "Find me a bird house so I can submit it to my teacher.";
        }
        if (collectibles[clue] == "red airhorn")
        {
            dialog = "GET ME A AIRHORN, IT IS GOING TO BE NOISY";
        }
        if (collectibles[clue] == "magic hat")
        {
            dialog = "MAKE SURE THE HAT YOU BUY ME IT NOT A SCAM";
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!begin && pHolding.Verify())
        {
            checkClue();
        }
        greeting.Play(0);
        interfaceManager.GetComponent<InterfaceManager>().ShowBox(dialog, clue);
    }

    private void checkClue()
    {
        if (pHolding.holdValue == clue)
        {
            dialog = "You found my " + collectibles[clue] + "! Hooray!";
            end = true;
        }
        else
        {
            dialog = "No, that's not my " + collectibles[clue] + ".";
        }
    }

    public void coinsScattered()
    {
        begin = false;
    }

}
