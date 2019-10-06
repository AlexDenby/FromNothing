using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressionHandler : MonoBehaviour
{
    public GameObject[] Players = new GameObject[10];
    public GameObject[] PettingZoo = new GameObject[10];
    public GameObject[] Construction = new GameObject[10];
    public GameObject[] Lab = new GameObject[10];
    public GameObject[] OtherNPCs = new GameObject[10];
    public GameObject FaceDeath;
    public int i = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Kill()
    {
        GameObject Player = Players[i];
        //Player.transform.GetChild(0).enabled = true;
        //transform.parent.GetChild(0).gameObject.SetActive(true);
        //Player.transform.lookAt(FaceDeath);
        Player.SetActive(false);





        i++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
