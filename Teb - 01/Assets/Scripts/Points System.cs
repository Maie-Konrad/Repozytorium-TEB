using System.Collections;
using System.Collections.Generic;
using System.Net;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class PointsSystem : MonoBehaviour
{
    public int Points;
        public int EndInt;
    public int wymagany;

    public TextMeshProUGUI textPoints;
    public TextMeshProUGUI doWin;
    public TextMeshProUGUI Win;

    public GameObject WON;
    public GameObject prefabToCount;


    private void Start()
    {
        Points = 0;
        WON.SetActive(false);
    }
    private void Update()
    {
        int wynik = (EndInt - Points);
        int wymagany = 4;
        textPoints.text = ("Points :" + Points.ToString());
        doWin.text = ("Wymagane :" + wymagany);
        Win.text = ("W grze monet :" + wynik);


    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("test");
        if (other.CompareTag("Consumable"))
        {
            Debug.Log("test");
          

            Points++;
            Destroy(other.gameObject);
        }

        if (other.CompareTag("End"))
        {
            Debug.Log("Styk z Win");
            if ( Points == wymagany || Input.GetKeyDown(KeyCode.P))
            {
                doWin.text = "WYGRA£EŒ";
                WON.SetActive(true);

            }

        }
    }





    //void CountPrefabs()
    //{

    //    GameObject[] prefabs = GameObject.FindGameObjectsWithTag(prefabToCount.tag);




    //}
}





