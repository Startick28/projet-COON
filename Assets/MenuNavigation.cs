using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour
{


    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;

    private int menu;
    private int numberOfOptions = 3;
    private int numberOfOptions2 = 2;

    private int selectedButton;

    private void OnLevelWasLoaded(int level)
    {
        menu = 1;
        selectedButton = 1;
        button1.OnDeselect(null);
        button2.OnDeselect(null);
        button3.OnDeselect(null);
        button4.OnDeselect(null);
        button5.OnDeselect(null);
    }
    void Start()
    {
        menu = 1;
        selectedButton = 1;
        button1.Select();
        button1.OnSelect(null);
    }

    // Update is called once per frame
    void Update()
    {
        if (menu == 1)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow) || MidiJack.MidiMaster.GetKeyDown(84))
            { //Input telling it to go up or down.
                selectedButton += 1;
                if (selectedButton > numberOfOptions) //If at end of list go back to top
                {
                    selectedButton = 1;
                }
                button1.OnDeselect(null);
                button2.OnDeselect(null);
                button3.OnDeselect(null);
                button4.OnDeselect(null);
                button5.OnDeselect(null);


                switch (selectedButton) //Set the visual indicator for which option you are on.
                {
                    case 1:
                        button1.Select();
                        button1.OnSelect(null);
                        break;
                    case 2:
                        button2.Select();
                        button2.OnSelect(null);
                        break;
                    case 3:
                        button3.Select();
                        button3.OnSelect(null);
                        break;
                }
            }

            if (Input.GetKeyDown(KeyCode.UpArrow) || MidiJack.MidiMaster.GetKeyDown(86))
            { //Input telling it to go up or down.
                selectedButton -= 1;
                if (selectedButton < 1) //If at end of list go back to top
                {
                    selectedButton = numberOfOptions;
                }
                button1.OnDeselect(null);
                button2.OnDeselect(null);
                button3.OnDeselect(null);
                button4.OnDeselect(null);
                button5.OnDeselect(null);

                switch (selectedButton) //Set the visual indicator for which option you are on.
                {
                    case 1:
                        button1.Select();
                        button1.OnSelect(null);
                        break;
                    case 2:
                        button2.Select();
                        button2.OnSelect(null);
                        break;
                    case 3:
                        button3.Select();
                        button3.OnSelect(null);
                        break;
                }
            }

            if (Input.GetKeyDown(KeyCode.Return) || MidiJack.MidiMaster.GetKeyDown(88))
            {
                Debug.Log("Picked: " + selectedButton); //For testing as the switch statment does nothing right now.

                switch (selectedButton) //Set the visual indicator for which option you are on.
                {
                    case 1:
                        button1.onClick.Invoke();
                        break;
                    case 2:
                        button2.onClick.Invoke();
                        button2.OnDeselect(null);
                        button4.Select();
                        button4.OnSelect(null);
                        menu = 2;
                        selectedButton = 1;
                        break;
                    case 3:
                        button3.onClick.Invoke();
                        break;
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.DownArrow) || MidiJack.MidiMaster.GetKeyDown(84))
            { //Input telling it to go up or down.
                selectedButton += 1;
                if (selectedButton > numberOfOptions2) //If at end of list go back to top
                {
                    selectedButton = 1;
                }
                button1.OnDeselect(null);
                button2.OnDeselect(null);
                button3.OnDeselect(null);
                button4.OnDeselect(null);
                button5.OnDeselect(null);


                switch (selectedButton) //Set the visual indicator for which option you are on.
                {
                    case 1:
                        button4.Select();
                        button4.OnSelect(null);
                        break;
                    case 2:
                        button5.Select();
                        button5.OnSelect(null);
                        break;
                }
            }

            if (Input.GetKeyDown(KeyCode.UpArrow) || MidiJack.MidiMaster.GetKeyDown(86))
            { //Input telling it to go up or down.
                selectedButton -= 1;
                if (selectedButton < 1) //If at end of list go back to top
                {
                    selectedButton = numberOfOptions2;
                }
                button1.OnDeselect(null);
                button2.OnDeselect(null);
                button3.OnDeselect(null);
                button4.OnDeselect(null);
                button5.OnDeselect(null);

                switch (selectedButton) //Set the visual indicator for which option you are on.
                {
                    case 1:
                        button4.Select();
                        button4.OnSelect(null);
                        break;
                    case 2:
                        button5.Select();
                        button5.OnSelect(null);
                        break;
                }
            }

            if (Input.GetKeyDown(KeyCode.Return) || MidiJack.MidiMaster.GetKeyDown(88))
            {
                Debug.Log("Picked: " + selectedButton); //For testing as the switch statment does nothing right now.

                switch (selectedButton) //Set the visual indicator for which option you are on.
                {
                    case 1:
                        button4.onClick.Invoke();
                        break;
                    case 2:
                        button5.onClick.Invoke();
                        button5.OnDeselect(null);
                        button1.Select();
                        button1.OnSelect(null);
                        menu = 1;
                        selectedButton = 1;
                        break;
                }
            }
        }
    }
}