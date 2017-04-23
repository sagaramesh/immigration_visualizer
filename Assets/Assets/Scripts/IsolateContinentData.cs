using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;

public class IsolateContinentData : MonoBehaviour {

    public NVRButton Button;
    public int continentNumber;

    // Use this for initialization
    void Start () {
		GameObject scriptContainer = GameObject.Find("ScriptContainer"); 
		a_NorthAmerica a = scriptContainer.GetComponent<a_NorthAmerica>();
		b_LatinAmerica b = scriptContainer.GetComponent<b_LatinAmerica>();
		c_Africa c = scriptContainer.GetComponent<c_Africa>();
		d_Europe d = scriptContainer.GetComponent<d_Europe>();
		e_Asia e = scriptContainer.GetComponent<e_Asia>();
		f_Oceania f = scriptContainer.GetComponent<f_Oceania>();
	}
	void Update () {

		if (Button.ButtonDown && continentNumber == 1) {
			IsolateAfrica ();
		} 
		else if(Button.ButtonDown && continentNumber == 2)
        {
			IsolateEurope ();
		}
		else if(Button.ButtonDown && continentNumber == 3)
        {
			IsolateAsia ();
		}
		else if(Button.ButtonDown && continentNumber == 4)
        {
			IsolateLatinAmerica ();
		}
		else if(Button.ButtonDown && continentNumber == 5)
        {
			IsolateOceania ();
		}
		else if(Button.ButtonDown && continentNumber == 6)
        {
			IsolateNorthAmerica ();
		}
		else if(Button.ButtonDown && continentNumber == 7)
        {
			IsolateNothing ();
		}
		else {
			print ("Nothing isolated");
		}
	}

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
		f_Oceania.oceaniaParent.SetActive (false);

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
		f_Oceania.oceaniaParent.SetActive (true);

	}
}
