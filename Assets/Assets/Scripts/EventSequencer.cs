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

    // For each year's data, two main cases for each region. Either the year has been hit with show all selected, 
    // or the year has been hit with one of the regions selected. Cover all bases for every year with this in mind.


    void ColorYears() {

        // 2015

        if (yearSelected == 2015) {
            label2015.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);
            bottom2015.GetComponent<SpriteRenderer>().material.color = new Color32(90, 228, 255, 255);
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
        }
        else
        {
            label2005.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
            bottom2005.GetComponent<SpriteRenderer>().material.color = new Color32(255, 255, 255, 255);
        } 
    }

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