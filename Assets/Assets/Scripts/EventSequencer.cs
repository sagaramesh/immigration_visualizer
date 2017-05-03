using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSequencer : MonoBehaviour {

	// regionSelected key:

	// Africa - 1
	// Europe - 2
	// Asia - 3
	// Latin America - 4
	// Oceania - 5
	// North America - 6
	// Show All - 7

	public static EventSequencer Instance;

    private int startYear = 0;
    private int startRegion = 7;

	public int yearSelected;
	public int regionSelected;

    public GameObject label2015;
    public GameObject label2014;
    public GameObject label2013;
    public GameObject label2012;
    public GameObject label2011;
    public GameObject label2010;
    public GameObject label2009;
    public GameObject label2008;
    public GameObject label2007;
    public GameObject label2006;
    public GameObject label2005;

    public GameObject bottom2015;
    public GameObject bottom2014;
    public GameObject bottom2013;
    public GameObject bottom2012;
    public GameObject bottom2011;
    public GameObject bottom2010;
    public GameObject bottom2009;
    public GameObject bottom2008;
    public GameObject bottom2007;
    public GameObject bottom2006;
    public GameObject bottom2005;

	public GameObject worldmap_all;
	public GameObject worldmap_africa;
	public GameObject worldmap_europe;
	public GameObject worldmap_asia;
	public GameObject worldmap_northamerica;
	public GameObject worldmap_latinamerica;
	public GameObject worldmap_oceania;

    public AudioSource year2015;
    public AudioClip year2015Clip;
    public AudioSource year2014;
    public AudioClip year2014Clip;
    public AudioSource year2013;
    public AudioClip year2013Clip;
    public AudioSource year2012;
    public AudioClip year2012Clip;
    public AudioSource year2011;
    public AudioClip year2011Clip;
    public AudioSource year2010;
    public AudioClip year2010Clip;
    public AudioSource year2009;
    public AudioClip year2009Clip;
    public AudioSource year2008;
    public AudioClip year2008Clip;
    public AudioSource year2007;
    public AudioClip year2007Clip;
    public AudioSource year2006;
    public AudioClip year2006Clip;
    public AudioSource year2005;
    public AudioClip year2005Clip;

    //public AudioSource showAll;
    //public AudioClip showAllClip;

    // Use this for initialization
    void Awake(){
		Instance = this;
	}

	void Start () {

		yearSelected = startYear;
		regionSelected = startRegion;

		GameObject scriptContainer = GameObject.Find("ScriptContainer"); 

		a_NorthAmerica a = scriptContainer.GetComponent<a_NorthAmerica>();
		b_LatinAmerica b = scriptContainer.GetComponent<b_LatinAmerica>();
		c_Africa c = scriptContainer.GetComponent<c_Africa>();
		d_Europe d = scriptContainer.GetComponent<d_Europe>();
		e_Asia e = scriptContainer.GetComponent<e_Asia>();
		f_Oceania f = scriptContainer.GetComponent<f_Oceania>();

	}
	
	// Update is called once per frame
	void Update () {

		print ("Year selected " + yearSelected);
		print ("Region selected " + regionSelected);

        ColorYears();
		ActivateMaps ();
        //BloomSound();

		Year2005 ();
		Year2006 ();
		Year2007 ();
		Year2008 ();
		Year2009 ();
		Year2010 ();
		Year2011 ();
		Year2012 ();
		Year2013 ();
		Year2014 ();
		Year2015 ();

	}

    // ACTIVATE AND SWITCH BETWEEN WORLD MAPS

    /*
    
    void BloomSound() {
        if (yearSelected == 2015 && regionSelected == 7)
        {
            showAll.clip = showAllClip;
            showAll.Play();
        }
        else if (yearSelected == 2014 && regionSelected == 7)
        {
            showAll.clip = showAllClip;
            showAll.Play();
        }
        else if (yearSelected == 2013 && regionSelected == 7)
        {
            showAll.clip = showAllClip;
            showAll.Play();
        }
        else if (yearSelected == 2012 && regionSelected == 7)
        {
            showAll.clip = showAllClip;
            showAll.Play();
        }
        else if (yearSelected == 2011 && regionSelected == 7)
        {
            showAll.clip = showAllClip;
            showAll.Play();
        }
        else if (yearSelected == 2010 && regionSelected == 7)
        {
            showAll.clip = showAllClip;
            showAll.Play();
        }
        else if (yearSelected == 2009 && regionSelected == 7)
        {
            showAll.clip = showAllClip;
            showAll.Play();
        }
        else if (yearSelected == 2008 && regionSelected == 7)
        {
            showAll.clip = showAllClip;
            showAll.Play();
        }
        else if (yearSelected == 2007 && regionSelected == 7)
        {
            showAll.clip = showAllClip;
            showAll.Play();
        }
        else if (yearSelected == 2006 && regionSelected == 7)
        {
            showAll.clip = showAllClip;
            showAll.Play();
        }
        else if (yearSelected == 2005 && regionSelected == 7)
        {
            showAll.clip = showAllClip;
            showAll.Play();
        }
        else {

            // Do nothing
        }
    } 

    */

    void ActivateMaps() {

		if (regionSelected == 1) { // AFRICA
			
			worldmap_africa.SetActive (true);
			worldmap_europe.SetActive (false);
			worldmap_asia.SetActive (false);
			worldmap_latinamerica.SetActive (false);
			worldmap_oceania.SetActive (false);
			worldmap_northamerica.SetActive (false);
			worldmap_all.SetActive (false);

		} else if (regionSelected == 2) { // EUROPE
			
			worldmap_africa.SetActive (false);
			worldmap_europe.SetActive (true);
			worldmap_asia.SetActive (false);
			worldmap_latinamerica.SetActive (false);
			worldmap_oceania.SetActive (false);
			worldmap_northamerica.SetActive (false);
			worldmap_all.SetActive (false);

		} else if (regionSelected == 3) { // ASIA

			worldmap_africa.SetActive (false);
			worldmap_europe.SetActive (false);
			worldmap_asia.SetActive (true);
			worldmap_latinamerica.SetActive (false);
			worldmap_oceania.SetActive (false);
			worldmap_northamerica.SetActive (false);
			worldmap_all.SetActive (false);

		} else if (regionSelected == 4) { // LATIN AMERICA

			worldmap_africa.SetActive (false);
			worldmap_europe.SetActive (false);
			worldmap_asia.SetActive (false);
			worldmap_latinamerica.SetActive (true);
			worldmap_oceania.SetActive (false);
			worldmap_northamerica.SetActive (false);
			worldmap_all.SetActive (false);

		} else if (regionSelected == 5) { // OCEANIA

			worldmap_africa.SetActive (false);
			worldmap_europe.SetActive (false);
			worldmap_asia.SetActive (false);
			worldmap_latinamerica.SetActive (false);
			worldmap_oceania.SetActive (true);
			worldmap_northamerica.SetActive (false);
			worldmap_all.SetActive (false);

		} else if (regionSelected == 6) { // NORTH AMERICA

			worldmap_africa.SetActive (false);
			worldmap_europe.SetActive (false);
			worldmap_asia.SetActive (false);
			worldmap_latinamerica.SetActive (false);
			worldmap_oceania.SetActive (false);
			worldmap_northamerica.SetActive (true);
			worldmap_all.SetActive (false);

		} else if (regionSelected == 7) { // ALL ACTIVE

			worldmap_africa.SetActive (false);
			worldmap_europe.SetActive (false);
			worldmap_asia.SetActive (false);
			worldmap_latinamerica.SetActive (false);
			worldmap_oceania.SetActive (false);
			worldmap_northamerica.SetActive (false);
			worldmap_all.SetActive (true);

		} else {

			worldmap_africa.SetActive (false);
			worldmap_europe.SetActive (false);
			worldmap_asia.SetActive (false);
			worldmap_latinamerica.SetActive (false);
			worldmap_oceania.SetActive (false);
			worldmap_northamerica.SetActive (false);
			worldmap_all.SetActive (true);
		}
	}

	// HIGHLIGHT SELECTED YEAR BUTTONS, STOP HIGHLIGHTING THOSE THAT ARE NOT SELECTED

	void ColorYears() {
        
        // 2015

        if (yearSelected == 2015) {
            label2015.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);
            bottom2015.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);

            year2015.clip = year2015Clip;
            year2015.Play();
        }
        else {
            label2015.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            bottom2015.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);

        }

        // 2014

        if (yearSelected == 2014)
        {
            label2014.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);
            bottom2014.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);

            year2014.clip = year2014Clip;
            year2014.Play();
        }
        else
        {
            label2014.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            bottom2014.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);

        }

        // 2013

        if (yearSelected == 2013)
        {
            label2013.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);
            bottom2013.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);

            year2013.clip = year2013Clip;
            year2013.Play();
        }
        else
        {
            label2013.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            bottom2013.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);

        }

        // 2012

        if (yearSelected == 2012)
        {
            label2012.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);
            bottom2012.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);

            year2012.clip = year2012Clip;
            year2012.Play();
        }
        else
        {
            label2012.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            bottom2012.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);

        }

        // 2011

        if (yearSelected == 2011)
        {
            label2011.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);
            bottom2011.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);

            year2011.clip = year2011Clip;
            year2011.Play();
        }
        else
        {
            label2011.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            bottom2011.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);


        }

        // 2010

        if (yearSelected == 2010)
        {
            label2010.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);
            bottom2010.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);

            year2010.clip = year2010Clip;
            year2010.Play();
        }
        else
        {
            label2010.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            bottom2010.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);

        }

        // 2009

        if (yearSelected == 2009)
        {
            label2009.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);
            bottom2009.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);

            year2009.clip = year2009Clip;
            year2009.Play();
        }
        else
        {
            label2009.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            bottom2009.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);

        }

        // 2008

        if (yearSelected == 2008)
        {
            label2008.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);
            bottom2008.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);

            year2008.clip = year2008Clip;
            year2008.Play();
        }
        else
        {
            label2008.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            bottom2008.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);

        }

        // 2007

        if (yearSelected == 2007)
        {
            label2007.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);
            bottom2007.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);

            year2007.clip = year2007Clip;
            year2007.Play();
        }
        else
        {
            label2007.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            bottom2007.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);

        }

        // 2006

        if (yearSelected == 2006)
        {
            label2006.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);
            bottom2006.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);

            year2006.clip = year2006Clip;
            year2006.Play();
        }
        else
        {
            label2006.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            bottom2006.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);

        }

        // 2005

        if (yearSelected == 2005)
        {
            label2005.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);
            bottom2005.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);

            year2005.clip = year2005Clip;
            year2005.Play();
        }
        else
        {
            label2005.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            bottom2005.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
        } 
    }

	// For each year's data, two main cases for each region. Either the year has been hit with show all selected, 
	// or the year has been hit with one of the regions selected. Cover all bases for every year with this in mind.

	void Year2015 () {

		// NORTH AMERICA

		if (yearSelected == 2015 && regionSelected == 7) {
			a_NorthAmerica.northAmericaParent.SetActive (true); // Change region that's set active here
        } 
		else if (yearSelected == 2015 && regionSelected == 6){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (true); // Set active, disable others
			b_LatinAmerica.latinAmericaParent.SetActive (false);
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);

			//a_NorthAmerica.northAmericaParent.transform.eulerAngles = Vector3.Lerp (startRotation, endRotation, Time.deltaTime * smoothFactor + 0.2f);
		}
		else {	
			// No selected year
		}

		// LATIN AMERICA

		if (yearSelected == 2015 && regionSelected == 7) {
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2015 && regionSelected == 4){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Set active, disable others
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// AFRICA

		if (yearSelected == 2015 && regionSelected == 7) {
			c_Africa.africaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2015 && regionSelected == 1){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (true); // Set active, disable others
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// EUROPE

		if (yearSelected == 2015 && regionSelected == 7) {
			d_Europe.europeParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2015 && regionSelected == 2){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (true); // Set active, disable others
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// ASIA

		if (yearSelected == 2015 && regionSelected == 7) {
			e_Asia.asiaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2015 && regionSelected == 3){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (true); // Set active, disable others
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// OCEANIA

		if (yearSelected == 2015 && regionSelected == 7) {
			f_Oceania.oceaniaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2015 && regionSelected == 5){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (false); 
			f_Oceania.oceaniaParent.SetActive (true); // Set active, disable others
		}
		else {	
			// No selected year
		}
	}

	void Year2014 () {

		// NORTH AMERICA

		if (yearSelected == 2014 && regionSelected == 7) {
			a_NorthAmerica.northAmericaParent.SetActive (true); // Change region that's set active here

        } 
		else if (yearSelected == 2014 && regionSelected == 6){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (true); // Set active, disable others
			b_LatinAmerica.latinAmericaParent.SetActive (false);
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// LATIN AMERICA

		if (yearSelected == 2014 && regionSelected == 7) {
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2014 && regionSelected == 4){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Set active, disable others
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// AFRICA

		if (yearSelected == 2014 && regionSelected == 7) {
			c_Africa.africaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2014 && regionSelected == 1){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (true); // Set active, disable others
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// EUROPE

		if (yearSelected == 2014 && regionSelected == 7) {
			d_Europe.europeParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2014 && regionSelected == 2){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (true); // Set active, disable others
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// ASIA

		if (yearSelected == 2014 && regionSelected == 7) {
			e_Asia.asiaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2014 && regionSelected == 3){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (true); // Set active, disable others
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// OCEANIA

		if (yearSelected == 2014 && regionSelected == 7) {
			f_Oceania.oceaniaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2014 && regionSelected == 5){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (false); 
			f_Oceania.oceaniaParent.SetActive (true); // Set active, disable others
		}
		else {	
			// No selected year
		}
	}

	void Year2013 () {

		// NORTH AMERICA

		if (yearSelected == 2013 && regionSelected == 7) {
			a_NorthAmerica.northAmericaParent.SetActive (true); // Change region that's set active here

        } 
		else if (yearSelected == 2013 && regionSelected == 6){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (true); // Set active, disable others
			b_LatinAmerica.latinAmericaParent.SetActive (false);
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// LATIN AMERICA

		if (yearSelected == 2013 && regionSelected == 7) {
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2013 && regionSelected == 4){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Set active, disable others
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// AFRICA

		if (yearSelected == 2013 && regionSelected == 7) {
			c_Africa.africaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2013 && regionSelected == 1){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (true); // Set active, disable others
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// EUROPE

		if (yearSelected == 2013 && regionSelected == 7) {
			d_Europe.europeParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2013 && regionSelected == 2){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (true); // Set active, disable others
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// ASIA

		if (yearSelected == 2013 && regionSelected == 7) {
			e_Asia.asiaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2013 && regionSelected == 3){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (true); // Set active, disable others
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// OCEANIA

		if (yearSelected == 2013 && regionSelected == 7) {
			f_Oceania.oceaniaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2013 && regionSelected == 5){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (false); 
			f_Oceania.oceaniaParent.SetActive (true); // Set active, disable others
		}
		else {	
			// No selected year
		}
	}

	void Year2012 () {

		// NORTH AMERICA

		if (yearSelected == 2012 && regionSelected == 7) {
			a_NorthAmerica.northAmericaParent.SetActive (true); // Change region that's set active here
        } 
		else if (yearSelected == 2012 && regionSelected == 6){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (true); // Set active, disable others
			b_LatinAmerica.latinAmericaParent.SetActive (false);
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// LATIN AMERICA

		if (yearSelected == 2012 && regionSelected == 7) {
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2012 && regionSelected == 4){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Set active, disable others
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// AFRICA

		if (yearSelected == 2012 && regionSelected == 7) {
			c_Africa.africaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2012 && regionSelected == 1){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (true); // Set active, disable others
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// EUROPE

		if (yearSelected == 2012 && regionSelected == 7) {
			d_Europe.europeParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2012 && regionSelected == 2){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (true); // Set active, disable others
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// ASIA

		if (yearSelected == 2012 && regionSelected == 7) {
			e_Asia.asiaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2012 && regionSelected == 3){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (true); // Set active, disable others
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// OCEANIA

		if (yearSelected == 2012 && regionSelected == 7) {
			f_Oceania.oceaniaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2012 && regionSelected == 5){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (false); 
			f_Oceania.oceaniaParent.SetActive (true); // Set active, disable others
		}
		else {	
			// No selected year
		}
	}

	void Year2011 () {

		// NORTH AMERICA

		if (yearSelected == 2011 && regionSelected == 7) {
			a_NorthAmerica.northAmericaParent.SetActive (true); // Change region that's set active here

        } 
		else if (yearSelected == 2011 && regionSelected == 6){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (true); // Set active, disable others
			b_LatinAmerica.latinAmericaParent.SetActive (false);
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// LATIN AMERICA

		if (yearSelected == 2011 && regionSelected == 7) {
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2011 && regionSelected == 4){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Set active, disable others
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// AFRICA

		if (yearSelected == 2011 && regionSelected == 7) {
			c_Africa.africaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2011 && regionSelected == 1){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (true); // Set active, disable others
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// EUROPE

		if (yearSelected == 2011 && regionSelected == 7) {
			d_Europe.europeParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2011 && regionSelected == 2){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (true); // Set active, disable others
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// ASIA

		if (yearSelected == 2011 && regionSelected == 7) {
			e_Asia.asiaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2011 && regionSelected == 3){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (true); // Set active, disable others
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// OCEANIA

		if (yearSelected == 2011 && regionSelected == 7) {
			f_Oceania.oceaniaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2011 && regionSelected == 5){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (false); 
			f_Oceania.oceaniaParent.SetActive (true); // Set active, disable others
		}
		else {	
			// No selected year
		}
	}

	void Year2010 () {

		// NORTH AMERICA

		if (yearSelected == 2010 && regionSelected == 7) {
			a_NorthAmerica.northAmericaParent.SetActive (true); // Change region that's set active here

        } 
		else if (yearSelected == 2010 && regionSelected == 6){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (true); // Set active, disable others
			b_LatinAmerica.latinAmericaParent.SetActive (false);
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// LATIN AMERICA

		if (yearSelected == 2010 && regionSelected == 7) {
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2010 && regionSelected == 4){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Set active, disable others
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// AFRICA

		if (yearSelected == 2010 && regionSelected == 7) {
			c_Africa.africaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2010 && regionSelected == 1){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (true); // Set active, disable others
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// EUROPE

		if (yearSelected == 2010 && regionSelected == 7) {
			d_Europe.europeParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2010 && regionSelected == 2){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (true); // Set active, disable others
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// ASIA

		if (yearSelected == 2010 && regionSelected == 7) {
			e_Asia.asiaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2010 && regionSelected == 3){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (true); // Set active, disable others
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// OCEANIA

		if (yearSelected == 2010 && regionSelected == 7) {
			f_Oceania.oceaniaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2010 && regionSelected == 5){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (false); 
			f_Oceania.oceaniaParent.SetActive (true); // Set active, disable others
		}
		else {	
			// No selected year
		}
	}

	void Year2009 () {

		// NORTH AMERICA

		if (yearSelected == 2009 && regionSelected == 7) {
			a_NorthAmerica.northAmericaParent.SetActive (true); // Change region that's set active here

        } 
		else if (yearSelected == 2009 && regionSelected == 6){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (true); // Set active, disable others
			b_LatinAmerica.latinAmericaParent.SetActive (false);
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// LATIN AMERICA

		if (yearSelected == 2009 && regionSelected == 7) {
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2009 && regionSelected == 4){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Set active, disable others
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// AFRICA

		if (yearSelected == 2009 && regionSelected == 7) {
			c_Africa.africaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2009 && regionSelected == 1){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (true); // Set active, disable others
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// EUROPE

		if (yearSelected == 2009 && regionSelected == 7) {
			d_Europe.europeParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2009 && regionSelected == 2){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (true); // Set active, disable others
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// ASIA

		if (yearSelected == 2009 && regionSelected == 7) {
			e_Asia.asiaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2009 && regionSelected == 3){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (true); // Set active, disable others
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// OCEANIA

		if (yearSelected == 2009 && regionSelected == 7) {
			f_Oceania.oceaniaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2009 && regionSelected == 5){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (false); 
			f_Oceania.oceaniaParent.SetActive (true); // Set active, disable others
		}
		else {	
			// No selected year
		}
	}

	void Year2008 () {

		// NORTH AMERICA

		if (yearSelected == 2008 && regionSelected == 7) {
			a_NorthAmerica.northAmericaParent.SetActive (true); // Change region that's set active here

        } 
		else if (yearSelected == 2008 && regionSelected == 6){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (true); // Set active, disable others
			b_LatinAmerica.latinAmericaParent.SetActive (false);
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// LATIN AMERICA

		if (yearSelected == 2008 && regionSelected == 7) {
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2008 && regionSelected == 4){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Set active, disable others
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// AFRICA

		if (yearSelected == 2008 && regionSelected == 7) {
			c_Africa.africaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2008 && regionSelected == 1){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (true); // Set active, disable others
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// EUROPE

		if (yearSelected == 2008 && regionSelected == 7) {
			d_Europe.europeParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2008 && regionSelected == 2){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (true); // Set active, disable others
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// ASIA

		if (yearSelected == 2008 && regionSelected == 7) {
			e_Asia.asiaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2008 && regionSelected == 3){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (true); // Set active, disable others
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// OCEANIA

		if (yearSelected == 2008 && regionSelected == 7) {
			f_Oceania.oceaniaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2008 && regionSelected == 5){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (false); 
			f_Oceania.oceaniaParent.SetActive (true); // Set active, disable others
		}
		else {	
			// No selected year
		}
	}

	void Year2007 () {

		// NORTH AMERICA

		if (yearSelected == 2007 && regionSelected == 7) {
			a_NorthAmerica.northAmericaParent.SetActive (true); // Change region that's set active here

        } 
		else if (yearSelected == 2007 && regionSelected == 6){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (true); // Set active, disable others
			b_LatinAmerica.latinAmericaParent.SetActive (false);
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// LATIN AMERICA

		if (yearSelected == 2007 && regionSelected == 7) {
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2007 && regionSelected == 4){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Set active, disable others
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// AFRICA

		if (yearSelected == 2007 && regionSelected == 7) {
			c_Africa.africaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2007 && regionSelected == 1){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (true); // Set active, disable others
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// EUROPE

		if (yearSelected == 2007 && regionSelected == 7) {
			d_Europe.europeParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2007 && regionSelected == 2){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (true); // Set active, disable others
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// ASIA

		if (yearSelected == 2007 && regionSelected == 7) {
			e_Asia.asiaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2007 && regionSelected == 3){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (true); // Set active, disable others
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// OCEANIA

		if (yearSelected == 2007 && regionSelected == 7) {
			f_Oceania.oceaniaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2007 && regionSelected == 5){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (false); 
			f_Oceania.oceaniaParent.SetActive (true); // Set active, disable others
		}
		else {	
			// No selected year
		}
	}

	void Year2006 () {

		// NORTH AMERICA

		if (yearSelected == 2006 && regionSelected == 7) {
			a_NorthAmerica.northAmericaParent.SetActive (true); // Change region that's set active here

        } 
		else if (yearSelected == 2006 && regionSelected == 6){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (true); // Set active, disable others
			b_LatinAmerica.latinAmericaParent.SetActive (false);
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// LATIN AMERICA

		if (yearSelected == 2006 && regionSelected == 7) {
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2006 && regionSelected == 4){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Set active, disable others
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// AFRICA

		if (yearSelected == 2006 && regionSelected == 7) {
			c_Africa.africaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2006 && regionSelected == 1){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (true); // Set active, disable others
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// EUROPE

		if (yearSelected == 2006 && regionSelected == 7) {
			d_Europe.europeParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2006 && regionSelected == 2){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (true); // Set active, disable others
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// ASIA

		if (yearSelected == 2006 && regionSelected == 7) {
			e_Asia.asiaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2006 && regionSelected == 3){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (true); // Set active, disable others
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// OCEANIA

		if (yearSelected == 2006 && regionSelected == 7) {
			f_Oceania.oceaniaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2006 && regionSelected == 5){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (false); 
			f_Oceania.oceaniaParent.SetActive (true); // Set active, disable others
		}
		else {	
			// No selected year
		}
	}

	void Year2005 () {

		// NORTH AMERICA

		if (yearSelected == 2005 && regionSelected == 7) {
			a_NorthAmerica.northAmericaParent.SetActive (true); // Change region that's set active here

        } 
		else if (yearSelected == 2005 && regionSelected == 6){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (true); // Set active, disable others
			b_LatinAmerica.latinAmericaParent.SetActive (false);
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// LATIN AMERICA

		if (yearSelected == 2005 && regionSelected == 7) {
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2005 && regionSelected == 4){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (true); // Set active, disable others
			c_Africa.africaParent.SetActive (false);
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// AFRICA

		if (yearSelected == 2005 && regionSelected == 7) {
			c_Africa.africaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2005 && regionSelected == 1){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (true); // Set active, disable others
			d_Europe.europeParent.SetActive (false);
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// EUROPE

		if (yearSelected == 2005 && regionSelected == 7) {
			d_Europe.europeParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2005 && regionSelected == 2){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (true); // Set active, disable others
			e_Asia.asiaParent.SetActive (false);
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// ASIA

		if (yearSelected == 2005 && regionSelected == 7) {
			e_Asia.asiaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2005 && regionSelected == 3){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (true); // Set active, disable others
			f_Oceania.oceaniaParent.SetActive (false);
		}
		else {	
			// No selected year
		}

		// OCEANIA

		if (yearSelected == 2005 && regionSelected == 7) {
			f_Oceania.oceaniaParent.SetActive (true); // Change region that's set active here
		} 
		else if (yearSelected == 2005 && regionSelected == 5){ // Change value of region selected
			a_NorthAmerica.northAmericaParent.SetActive (false); 
			b_LatinAmerica.latinAmericaParent.SetActive (false); 
			c_Africa.africaParent.SetActive (false); 
			d_Europe.europeParent.SetActive (false); 
			e_Asia.asiaParent.SetActive (false); 
			f_Oceania.oceaniaParent.SetActive (true); // Set active, disable others
		}
		else {	
			// No selected year
		}
	}
}