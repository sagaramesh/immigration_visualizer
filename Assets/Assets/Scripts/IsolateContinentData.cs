using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;

public class IsolateContinentData : MonoBehaviour {

    public NVRButton Button;
    public int continentNumber;

    public GameObject africaLabel;
    public GameObject europeLabel;
    public GameObject asiaLabel;
    public GameObject latinAmericaLabel;
    public GameObject oceaniaLabel;
    public GameObject northAmericaLabel;

    public GameObject africaBottom;
    public GameObject europeBottom;
    public GameObject asiaBottom;
    public GameObject latinAmericaBottom;
    public GameObject oceaniaBottom;
    public GameObject northAmericaBottom;



    // Use this for initialization
    void Start () {
		GameObject scriptContainer = GameObject.Find("ScriptContainer"); 



		/*a_NorthAmerica a = scriptContainer.GetComponent<a_NorthAmerica>();
		b_LatinAmerica b = scriptContainer.GetComponent<b_LatinAmerica>();
		c_Africa c = scriptContainer.GetComponent<c_Africa>();
		d_Europe d = scriptContainer.GetComponent<d_Europe>();
		e_Asia e = scriptContainer.GetComponent<e_Asia>();
		f_Oceania f = scriptContainer.GetComponent<f_Oceania>();*/
	}
	void Update () {

		if (Button.ButtonDown && continentNumber == 1) {
			//IsolateAfrica ();
			EventSequencer.Instance.regionSelected = 1;

            northAmericaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            latinAmericaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            africaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 218, 139, 255); // Modify
            europeLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            asiaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            oceaniaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);

            northAmericaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            latinAmericaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            africaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 218, 139, 255); // Modify
            europeBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            asiaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            oceaniaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
        } 
		else if(Button.ButtonDown && continentNumber == 2)
        {
			//IsolateEurope ();
			EventSequencer.Instance.regionSelected = 2;

            northAmericaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            latinAmericaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            africaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            europeLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 169, 235, 255); // Modify
            asiaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            oceaniaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);

            northAmericaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            latinAmericaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            africaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            europeBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 169, 235, 255); // Modify
            asiaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            oceaniaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
        }
		else if(Button.ButtonDown && continentNumber == 3)
        {
			//IsolateAsia ();
			EventSequencer.Instance.regionSelected = 3;

            northAmericaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            latinAmericaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            africaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            europeLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255); 
            asiaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(124, 255, 82, 255); // Modify
            oceaniaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);

            northAmericaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            latinAmericaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            africaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            europeBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255); 
            asiaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(124, 255, 82, 255); // Modify
            oceaniaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
        }
		else if(Button.ButtonDown && continentNumber == 4)
        {
			//IsolateLatinAmerica ();
			EventSequencer.Instance.regionSelected = 4;

            northAmericaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            latinAmericaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(77, 211, 255, 255); // Modify
            africaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            europeLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            asiaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            oceaniaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);

            northAmericaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            latinAmericaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(77, 211, 255, 255); // Modify
            africaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            europeBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            asiaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            oceaniaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
        }
		else if(Button.ButtonDown && continentNumber == 5)
        {
			//IsolateOceania ();
			EventSequencer.Instance.regionSelected = 5;

            northAmericaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            latinAmericaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            africaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            europeLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            asiaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            oceaniaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(81, 0, 199, 255); // Modify

            northAmericaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            latinAmericaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            africaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            europeBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            asiaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            oceaniaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(81, 0, 199, 255); // Modify
        }
		else if(Button.ButtonDown && continentNumber == 6)
        {
			//IsolateNorthAmerica ();
			EventSequencer.Instance.regionSelected = 6;

            northAmericaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(241, 255, 0, 255); // Modify
            latinAmericaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            africaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            europeLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            asiaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            oceaniaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);

            northAmericaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(241, 255, 0, 255); // Modify
            latinAmericaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            africaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            europeBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            asiaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            oceaniaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
        }
		else if(Button.ButtonDown && continentNumber == 7)
        {
			//IsolateNothing ();
			EventSequencer.Instance.regionSelected = 7;

            northAmericaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            latinAmericaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            africaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            europeLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            asiaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            oceaniaLabel.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);

            northAmericaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            latinAmericaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            africaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            europeBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            asiaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            oceaniaBottom.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
        }
		else {
            print("Nothing isolated");
        }
	}

	/*

	public void IsolateNorthAmerica(){

		a_NorthAmerica.northAmericaParent.SetActive (true);
		b_LatinAmerica.latinAmericaParent.SetActive (false);
		c_Africa.africaParent.SetActive (false);
		d_Europe.europeParent.SetActive (false);
		e_Asia.asiaParent.SetActive (false);
		f_Oceania.oceaniaParent.SetActive (false);
	}
	public void IsolateLatinAmerica(){

		a_NorthAmerica.northAmericaParent.SetActive (false);
		b_LatinAmerica.latinAmericaParent.SetActive (true);
		c_Africa.africaParent.SetActive (false);
		d_Europe.europeParent.SetActive (false);
		e_Asia.asiaParent.SetActive (false);
		f_Oceania.oceaniaParent.SetActive (false);

	}
	public void IsolateAfrica(){

		a_NorthAmerica.northAmericaParent.SetActive (false);
		b_LatinAmerica.latinAmericaParent.SetActive (false);
		c_Africa.africaParent.SetActive (true);
		d_Europe.europeParent.SetActive (false);
		e_Asia.asiaParent.SetActive (false);
        f_Oceania.oceaniaParent.SetActive(false);

    }
	public void IsolateEurope(){

		a_NorthAmerica.northAmericaParent.SetActive (false);
		b_LatinAmerica.latinAmericaParent.SetActive (false);
		c_Africa.africaParent.SetActive (false);
		d_Europe.europeParent.SetActive (true);
		e_Asia.asiaParent.SetActive (false);
		f_Oceania.oceaniaParent.SetActive (false);

	}
	public void IsolateAsia(){

		a_NorthAmerica.northAmericaParent.SetActive (false);
		b_LatinAmerica.latinAmericaParent.SetActive (false);
		c_Africa.africaParent.SetActive (false);
		d_Europe.europeParent.SetActive (false);
		e_Asia.asiaParent.SetActive (true);
		f_Oceania.oceaniaParent.SetActive (false);

	}
	public void IsolateOceania(){

		a_NorthAmerica.northAmericaParent.SetActive (false);
		b_LatinAmerica.latinAmericaParent.SetActive (false);
		c_Africa.africaParent.SetActive (false);
		d_Europe.europeParent.SetActive (false);
		e_Asia.asiaParent.SetActive (false);
		f_Oceania.oceaniaParent.SetActive (true);

	}
	public void IsolateNothing(){

		a_NorthAmerica.northAmericaParent.SetActive (true);
		b_LatinAmerica.latinAmericaParent.SetActive (true);
		c_Africa.africaParent.SetActive (true);
		d_Europe.europeParent.SetActive (true);
		e_Asia.asiaParent.SetActive (true);
        f_Oceania.oceaniaParent.SetActive(true);
    } */
}
