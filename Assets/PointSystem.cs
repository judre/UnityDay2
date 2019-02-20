using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class PointSystem : MonoBehaviour
{

    public Text timerText;
    public int points = 0;
    GameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        timerText.text = points.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        timerText.DOColor((0,0,1,1), 1);
        points += 1;
        GetComponent<AudioSource>().Play();
    }
}
