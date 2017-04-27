using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;

public class ScaleInfo : MonoBehaviour {
	
	public NVRButton Button;

	public GameObject info_message;

	public GameObject info_label;
	public GameObject exit_label;

    private Vector3 infoMaximized = new Vector3(0.1f, 0.1f, 0.1f);
    private Vector3 infoMinimized = new Vector3(0f, 0f, 0f);

    float labelActive;

    private float smoothFactor = 2f;

	// 1 is active, 2 is inactive 

	//private float sphereDuration = 1f;

	void Start(){

        info_message.transform.localScale = infoMinimized;

        info_label.SetActive(true);
        exit_label.SetActive(false);

        labelActive = 1;
	}

	void Update() {

        // BUTTON CONDITIONS

        if (Button.ButtonDown && labelActive == 1 || Input.GetKeyDown(KeyCode.I))
        {
            StartCoroutine(InfoScaleUp(infoMaximized, 1.0f));
            StartCoroutine("ActivateExitLabel");
            
            //info_message.transform.localScale = Vector3.Lerp(infoMinimized, infoMaximized, Time.time * smoothFactor + 0.2f);
            //StartCoroutine("ActivateExitLabel");
        }
        else if (Button.ButtonDown && labelActive == 2 || Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(InfoScaleDown(infoMinimized, 1.0f));
            StartCoroutine("ActivateInfoLabel");
        }
        else {
        }
	}

    IEnumerator ActivateInfoLabel()
    {
        yield return new WaitForSeconds(2);
        info_label.SetActive(true);
        exit_label.SetActive(false);

        labelActive = 1;
    }

    IEnumerator ActivateExitLabel()
    {
        yield return new WaitForSeconds(2);
        info_label.SetActive(false);
        exit_label.SetActive(true);

        labelActive = 2;
    }

    IEnumerator InfoScaleUp(Vector3 info_scaleValue, float info_Time)
    {
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / info_Time)
        {
            Vector3 newScale = info_message.transform.localScale = Vector3.Lerp(infoMinimized, info_scaleValue, t * smoothFactor + 0.4f);
            info_message.transform.localScale = newScale;

            yield return new WaitForEndOfFrame();
        }
    }

    IEnumerator InfoScaleDown(Vector3 info_scaleValue, float info_Time)
    {
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / info_Time)
        {
            Vector3 newScale = info_message.transform.localScale = Vector3.Lerp(infoMaximized, info_scaleValue, t * smoothFactor + 0.4f);
            info_message.transform.localScale = newScale;

            yield return new WaitForEndOfFrame();
        }
    }

}
