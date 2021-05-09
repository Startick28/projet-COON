using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyManager : MonoBehaviour
{
    private PlayerHealth vie;
    public static KeyManager instance;
    public Text keyText;

    public Indicator indicatorPrefab;
    public Material[] materials = new Material[12];
    public BasicLine[] lines = new BasicLine[12];

    //public ArrayList lineTypes = new ArrayList();
    public Renderer lineRenderer;
    public Material baseLineMaterial;
    private float colorTimer = 0f;
    private bool changeLineColor = false;

    public enum Key {
        A0, A0s, B0, 
        C1, C1s, D1, D1s, E1, F1, F1s, G1, G1s, A1, A1s, B1, 
        C2, C2s, D2, D2s, E2, F2, F2s, G2, G2s, A2, A2s, B2, 
        C3, C3s, D3, D3s, E3, F3, F3s, G3, G3s, A3, A3s, B3, 
        C4, C4s, D4, D4s, E4, F4, F4s, G4, G4s, A4, A4s, B4, 
        C5, C5s, D5, D5s, E5, F5, F5s, G5, G5s, A5, A5s, B5, 
        C6, C6s, D6, D6s, E6, F6, F6s, G6, G6s, A6, A6s, B6, 
        C7, C7s, D7, D7s, E7, F7, F7s, G7, G7s, A7, A7s, B7, 
        C8,
        Null
    }

    public Key lastKey = Key.Null;
    
    public void Awake()
    {
        if(instance)
        {
            Debug.Log("Il y a déjà une instance de KeyManager " + name);
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    void Start()
    {
        keyText.text = "Current Key Pressed : " + "None";
    }

    void Update()
    {
        //Affichage info dernière note
        for (int i = 21 ; i <= 108; i++) {
            if (MidiJack.MidiMaster.GetKeyDown(i)) {
                lastKey = (Key) i-21;
                keyText.text = "Current Key Pressed : " + i.ToString();
            }
        }

        RaycastHit hit;
        Indicator tmp;
        Monster tmpMonster;
        //lineTypes.Clear();
        for (int i = 48 ; i <= 83; i++) {
            // QUAND ON APPUIE SUR UNE TOUCHE
            if (MidiJack.MidiMaster.GetKeyDown(i)) {
                // Décrémenter la vie
                //vie.TakeDamage(5);


                // Affichage de l'indicateur
                tmp = Instantiate(indicatorPrefab,noteToPos(i),Quaternion.identity);
                tmp.gameObject.GetComponent<MeshRenderer>().material = materials[(i-36)%12];
                // Affichage ligne
                    //changeLineColor = true;
                    //lineRenderer.material = materials[(i-36)%12];
                StartCoroutine(lines[(i-36)%12].Pulse());
                // Tests collisions.
                if (Physics.Raycast(noteToPos(i),Vector3.up, out hit, 5))
                {
                    if (hit.collider.CompareTag("Monster"))
                    {
                        tmpMonster = hit.transform.GetComponent<Monster>();
                        if (tmpMonster.type == i) tmpMonster.Hit();
                    }
                }
                

                //lineTypes.Add(i);
            }
        }

        if (Input.GetKeyDown(KeyCode.A)) {
            PressedKey(48);
        }
        if (Input.GetKeyDown(KeyCode.Z)) {
            PressedKey(49);
        }
        if (Input.GetKeyDown(KeyCode.E)) {
            PressedKey(50);
        }
        if (Input.GetKeyDown(KeyCode.R)) {
            PressedKey(51);
        }
        if (Input.GetKeyDown(KeyCode.T)) {
            PressedKey(52);
        }
        if (Input.GetKeyDown(KeyCode.Y)) {
            PressedKey(53);
        }
        if (Input.GetKeyDown(KeyCode.U)) {
            PressedKey(54);
        }
        if (Input.GetKeyDown(KeyCode.I)) {
            PressedKey(55);
        }
        if (Input.GetKeyDown(KeyCode.O)) {
            PressedKey(56);
        }
        if (Input.GetKeyDown(KeyCode.P)) {
            PressedKey(57);
        }
        if (Input.GetKeyDown(KeyCode.RightBracket)) {
            PressedKey(58);
        }
        if (Input.GetKeyDown(KeyCode.Semicolon)) {
            PressedKey(59);
        }
        if (Input.GetKeyDown(KeyCode.Q)) {
            PressedKey(60);
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            PressedKey(61);
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            PressedKey(62);
        }
        if (Input.GetKeyDown(KeyCode.F)) {
            PressedKey(63);
        }
        if (Input.GetKeyDown(KeyCode.G)) {
            PressedKey(64);
        }
        if (Input.GetKeyDown(KeyCode.H)) {
            PressedKey(65);
        }
        if (Input.GetKeyDown(KeyCode.J)) {
            PressedKey(66);
        }
        if (Input.GetKeyDown(KeyCode.K)) {
            PressedKey(67);
        }
        if (Input.GetKeyDown(KeyCode.L)) {
            PressedKey(68);
        }
        if (Input.GetKeyDown(KeyCode.M)) {
            PressedKey(69);
        }
        if (Input.GetKeyDown(KeyCode.BackQuote)) {
            PressedKey(70);
        }
        if (Input.GetKeyDown(KeyCode.Backslash)) {
            PressedKey(71);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            PressedKey(72);
        }
        if (Input.GetKeyDown(KeyCode.W)) {
            PressedKey(73);
        }
        if (Input.GetKeyDown(KeyCode.X)) {
            PressedKey(74);
        }
        if (Input.GetKeyDown(KeyCode.C)) {
            PressedKey(75);
        }
        if (Input.GetKeyDown(KeyCode.V)) {
            PressedKey(76);
        }
        if (Input.GetKeyDown(KeyCode.B)) {
            PressedKey(77);
        }
        if (Input.GetKeyDown(KeyCode.N)) {
            PressedKey(78);
        }
        if (Input.GetKeyDown(KeyCode.Comma)) {
            PressedKey(79);
        }
        if (Input.GetKeyDown(KeyCode.Period)) {
            PressedKey(80);
        }
        if (Input.GetKeyDown(KeyCode.Slash)) {
            PressedKey(81);
        }
        if (Input.GetKeyDown(KeyCode.BackQuote)) {
            PressedKey(82);
        }
        if (Input.GetKeyDown(KeyCode.RightShift)) {
            PressedKey(83);
        }


        if (changeLineColor) {
            colorTimer += Time.deltaTime;
        }
        if (colorTimer>=0.1f) {
            colorTimer = 0f;
            changeLineColor = false;
            lineRenderer.material = baseLineMaterial;
        }
    }

    void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey)
        {
            Debug.Log("Detected key code: " + e.keyCode);
        }
    }

    void PressedKey(int i)
    {
        RaycastHit hit;
        Indicator tmp;
        Monster tmpMonster;
        // Décrémenter la vie
        //vie.TakeDamage(5);
        // Affichage de l'indicateur
        tmp = Instantiate(indicatorPrefab,noteToPos(i),Quaternion.identity);
        tmp.gameObject.GetComponent<MeshRenderer>().material = materials[(i-36)%12];
        StartCoroutine(lines[(i-36)%12].Pulse());
        // Tests collisions
        if (Physics.Raycast(noteToPos(i),Vector3.up, out hit, 5))
        {
            if (hit.collider.CompareTag("Monster"))
            {
                tmpMonster = hit.transform.GetComponent<Monster>();
                if (tmpMonster.type == i) tmpMonster.Hit();
            }
        }
    }

    public static Vector3 noteToPos(int note) {

        Vector3 res;
        switch (note) {

            case 48:
                res = new Vector3(-8.723f,-1.69f,-0.5f); 
                break;
            case 49:
                res = new Vector3(-8.277f,-0.2f,-0.5f);//#
                break;
            case 50:
                res = new Vector3(-7.852f,-1.69f,-0.5f);
                break;
            case 51:
                res = new Vector3(-7.391f,-0.2f,-0.5f); //#
                break;
            case 52:
                res = new Vector3(-6.96f,-1.69f,-0.5f);
                break;
            case 53:
                res = new Vector3(-6.082f,-1.69f,-0.5f);
                break;
            case 54:
                res = new Vector3(-5.633f,-0.2f,-0.5f); //#
                break;
            case 55:
                res = new Vector3(-5.2f,-1.69f,-0.5f);
                break;
            case 56:
                res = new Vector3(-4.75f,-0.2f,-0.5f); //#
                break;
            case 57:
                res = new Vector3(-4.32f,-1.69f,-0.5f);
                break;
            case 58:
                res = new Vector3(-3.875f,-0.2f,-0.5f); //#
                break;
            case 59:
                res = new Vector3(-3.513f,-1.69f,-0.5f);
                break;
            case 60:
                res = new Vector3(-2.716f,-1.69f,-0.5f);
                break;
            case 61:
                res = new Vector3(-2.281f,-0.2f,-0.5f); //#
                break;
            case 62:
                res = new Vector3(-1.844f,-1.69f,-0.5f);
                break;
            case 63:
                res = new Vector3(-1.394f,-0.2f,-0.5f); //#
                break;
            case 64:
                res = new Vector3(-0.962f,-1.69f,-0.5f);
                break;
            case 65:
                res = new Vector3(-0.075f,-1.69f,-0.5f);
                break;
            case 66:
                res = new Vector3(0.364f,-0.2f,-0.5f); //#
                break;
            case 67:
                res = new Vector3(0.809f,-1.69f,-0.5f);
                break;
            case 68:
                res = new Vector3(1.245f,-0.2f,-0.5f); //#
                break;
            case 69:
                res = new Vector3(1.68f,-1.69f,-0.5f);
                break;
            case 70:
                res = new Vector3(2.124f,-0.2f,-0.5f); //#
                break;
            case 71:
                res = new Vector3(2.58f,-1.69f,-0.5f);
                break;
            case 72:
                res = new Vector3(3.44f,-1.69f,-0.5f);
                break;
            case 73:
                res = new Vector3(3.882f,-0.2f,-0.5f); //#
                break;
            case 74:
                res = new Vector3(4.32f,-1.69f,-0.5f);
                break;
            case 75:
                res = new Vector3(4.759f,-0.2f,-0.5f); //#
                break;
            case 76:
                res = new Vector3(5.2f,-1.69f,-0.5f);
                break;
            case 77:
                res = new Vector3(6.08f,-1.69f,-0.5f);
                break;
            case 78:
                res = new Vector3(6.525f,-0.2f,-0.5f); //#
                break;
            case 79:
                res = new Vector3(6.94f,-1.69f,-0.5f);
                break;
            case 80:
                res = new Vector3(7.408f,-0.2f,-0.5f); //#
                break;
            case 81:
                res = new Vector3(7.84f,-1.69f,-0.5f);
                break;
            case 82:
                res = new Vector3(8.285f,-0.2f,-0.5f); //#
                break;
            case 83:
                res = new Vector3(8.72f,-1.69f,-0.5f);
                break;
            default:
                res = new Vector3(0,0,0);
                break;
        }
        return res;
    }

}
