using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FetchQuest : MonoBehaviour
{
    public bool isInTrigger = false;
    public bool questStarted = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isInTrigger && Input.GetKeyDown(KeyCode.Z ) && !questStarted)
        {
            Debug.Log("Quest started!");
            questStarted = true;
            
        }
        
        else
        {
            return;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isInTrigger = true;
        Debug.Log("In trigger");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isInTrigger = false;
        Debug.Log("Out of trigger");
    }
}
