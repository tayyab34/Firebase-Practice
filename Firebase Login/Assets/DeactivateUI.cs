using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateUI : MonoBehaviour
{
    public List<GameObject> UImessages;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject messages in UImessages)
        {
            if (messages.activeInHierarchy)
            {
                StartCoroutine(Delay());
            }
            IEnumerator Delay()
            {
                yield return new WaitForSeconds(5f);
                messages.SetActive(false);
            }
        }
    }

}
