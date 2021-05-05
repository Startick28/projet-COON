using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyManager : MonoBehaviour
{

    public static KeyManager instance;
    public Text keyText;

    public Indicator indicatorPrefab;
    public Material[] materials = new Material[12];

    public ArrayList lineTypes = new ArrayList();
    public Collider lineCollider;
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
        for (int i = 21 ; i <= 108; i++) {
            if (MidiJack.MidiMaster.GetKeyDown(i)) {
                lastKey = (Key) i-21;
                keyText.text = "Current Key Pressed : " + i.ToString();
            }
        }
        Indicator tmp;
        lineTypes.Clear();
        for (int i = 48 ; i <= 83; i++) {
            if (MidiJack.MidiMaster.GetKeyDown(i)) {
                tmp = Instantiate(indicatorPrefab,noteToPos(i),Quaternion.identity);
                tmp.gameObject.GetComponent<MeshRenderer>().material = materials[(i-36)%12];
                changeLineColor = true;
                lineRenderer.material = materials[(i-36)%12];
                lineTypes.Add(i);
            }
        }

        if (changeLineColor) {
            colorTimer += Time.deltaTime;
        }
        if (colorTimer>=0.2f) {
            colorTimer = 0f;
            changeLineColor = false;
            lineRenderer.material = baseLineMaterial;
        }
        
    }

    Vector3 noteToPos(int note) {

        Vector3 res;
        switch (note) {

            case 48:
                res = new Vector3(-8.6f,-1.69f,0);
                break;
            case 49:
                res = new Vector3(-8.26f,-0.2f,0);
                break;
            case 50:
                res = new Vector3(-7.74f,-1.69f,0);
                break;
            case 51:
                res = new Vector3(-7.26f,-0.2f,0);
                break;
            case 52:
                res = new Vector3(-6.83f,-1.69f,0);
                break;
            case 53:
                res = new Vector3(-6f,-1.69f,0);
                break;
            case 54:
                res = new Vector3(-5.76f,-0.2f,0);
                break;
            case 55:
                res = new Vector3(-5.15f,-1.69f,0);
                break;
            case 56:
                res = new Vector3(-4.78f,-0.2f,0);
                break;
            case 57:
                res = new Vector3(-4.28f,-1.69f,0);
                break;
            case 58:
                res = new Vector3(-3.8f,-0.2f,0);
                break;
            case 59:
                res = new Vector3(-3.47f,-1.69f,0);
                break;
            case 60:
                res = new Vector3(-2.55f,-1.69f,0);
                break;
            case 61:
                res = new Vector3(-2.27f,-0.2f,0);
                break;
            case 62:
                res = new Vector3(-1.75f,-1.69f,0);
                break;
            case 63:
                res = new Vector3(-1.19f,-0.2f,0);
                break;
            case 64:
                res = new Vector3(-0.84f,-1.69f,0);
                break;
            case 65:
                res = new Vector3(0f,-1.69f,0);
                break;
            case 66:
                res = new Vector3(0.3f,-0.2f,0);
                break;
            case 67:
                res = new Vector3(0.8f,-1.69f,0);
                break;
            case 68:
                res = new Vector3(1.3f,-0.2f,0);
                break;
            case 69:
                res = new Vector3(1.7f,-1.69f,0);
                break;
            case 70:
                res = new Vector3(2.2f,-0.2f,0);
                break;
            case 71:
                res = new Vector3(2.6f,-1.69f,0);
                break;
            case 72:
                res = new Vector3(3.4f,-1.69f,0);
                break;
            case 73:
                res = new Vector3(3.8f,-0.2f,0);
                break;
            case 74:
                res = new Vector3(4.3f,-1.69f,0);
                break;
            case 75:
                res = new Vector3(4.8f,-0.2f,0);
                break;
            case 76:
                res = new Vector3(5.2f,-1.69f,0);
                break;
            case 77:
                res = new Vector3(6f,-1.69f,0);
                break;
            case 78:
                res = new Vector3(6.3f,-0.2f,0);
                break;
            case 79:
                res = new Vector3(6.9f,-1.69f,0);
                break;
            case 80:
                res = new Vector3(7.3f,-0.2f,0);
                break;
            case 81:
                res = new Vector3(7.7f,-1.69f,0);
                break;
            case 82:
                res = new Vector3(8.3f,-0.2f,0);
                break;
            case 83:
                res = new Vector3(8.6f,-1.69f,0);
                break;
            default:
                res = new Vector3(0,0,0);
                break;
        }
        return res;
    }

}
