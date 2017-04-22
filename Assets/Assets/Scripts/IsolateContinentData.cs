using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsolateContinentData : MonoBehaviour {

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

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			IsolateNorthAmerica ();
		} 
		else if(Input.GetKeyDown (KeyCode.Alpha2)){
			IsolateLatinAmerica ();
		}
		else if(Input.GetKeyDown (KeyCode.Alpha3)){
			IsolateAfrica ();
		}
		else if(Input.GetKeyDown (KeyCode.Alpha4)){
			IsolateEurope ();
		}
		else if(Input.GetKeyDown (KeyCode.Alpha5)){
			IsolateAsia ();
		}
		else if(Input.GetKeyDown (KeyCode.Alpha6)){
			IsolateOceania ();
		}
		else if(Input.GetKeyDown (KeyCode.Alpha7)){
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
