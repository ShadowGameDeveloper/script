using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Manager : MonoBehaviour
{
    Text masText;
    // Start is called before the first frame update
    void Start()
    {
        masText = GameObject.Find("Text").GetComponent<Text>();
        StartCoroutine("Sample");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Sample()
    {
        yield return new WaitForSeconds(1.0f);
        masText.text = "1sec";

        yield return new WaitForSeconds(4.0f);
        masText.text = "5sec";

        yield return new WaitForSeconds(2.0f);
        masText.text = "7sec";
    }
}
