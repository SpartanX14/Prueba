using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int gemsCounter = 0;
    public TextMeshProUGUI gemsCounterText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddGems()
    {
        gemsCounter++;
        gemsCounterText.text = gemsCounter.ToString();
    }
}
