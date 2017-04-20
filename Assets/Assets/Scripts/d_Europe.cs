using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class d_Europe : MonoBehaviour {

	public GameObject continent_group;
	public TextAsset data_file;
	private int numberOfObjects;

	private GameObject europeParent;

	void Start () {

		Load (data_file); // Using CSV data dragged into the Inspector
	}

	void Update(){

		if (Input.GetKeyDown (KeyCode.A)) { // 2015
			Destroy (europeParent);
			numberOfObjects = Convert.ToInt32 (Find_Year ("2015").BornEurope) / 10000; // Change year + origin continent; dividing by 10,000 gives us clean numbers
			StartCoroutine ("generateSpheres"); // Generate spheres sequentially based on numberOfObjects value
			print ("2015 European Immigrants: " + (Convert.ToInt32 (Find_Year ("2015").BornEurope) / 10000) + " * 10,000"); // Check if these values match with CSV 
		} 
		else if (Input.GetKeyDown (KeyCode.B)){ // 2014
			Destroy (europeParent);
			numberOfObjects = Convert.ToInt32 (Find_Year ("2014").BornEurope) / 10000;
			StartCoroutine ("generateSpheres"); 
			print ("2014 European Immigrants: " + (Convert.ToInt32 (Find_Year ("2014").BornEurope) / 10000) + " * 10,000");
		}
		else if (Input.GetKeyDown (KeyCode.C)){ // 2013
			Destroy (europeParent);
			numberOfObjects = Convert.ToInt32 (Find_Year ("2013").BornEurope) / 10000;
			StartCoroutine ("generateSpheres"); 
			print ("2013 European Immigrants: " + (Convert.ToInt32 (Find_Year ("2013").BornEurope) / 10000) + " * 10,000");
		}
		else if (Input.GetKeyDown (KeyCode.D)){ // 2012
			Destroy (europeParent);
			numberOfObjects = Convert.ToInt32 (Find_Year ("2012").BornEurope) / 10000;
			StartCoroutine ("generateSpheres"); 
			print ("2012 European Immigrants: " + (Convert.ToInt32 (Find_Year ("2012").BornEurope) / 10000) + " * 10,000");
		}
		else if (Input.GetKeyDown (KeyCode.E)){ // 2011
			Destroy (europeParent);
			numberOfObjects = Convert.ToInt32 (Find_Year ("2011").BornEurope) / 10000;
			StartCoroutine ("generateSpheres"); 
			print ("2011 European Immigrants: " + (Convert.ToInt32 (Find_Year ("2011").BornEurope) / 10000) + " * 10,000");
		}
		else if (Input.GetKeyDown (KeyCode.F)){ // 2010
			Destroy (europeParent);
			numberOfObjects = Convert.ToInt32 (Find_Year ("2010").BornEurope) / 10000;
			StartCoroutine ("generateSpheres"); 
			print ("2010 European Immigrants: " + (Convert.ToInt32 (Find_Year ("2010").BornEurope) / 10000) + " * 10,000");
		}
		else if (Input.GetKeyDown (KeyCode.G)){ // 2009
			Destroy (europeParent);
			numberOfObjects = Convert.ToInt32 (Find_Year ("2009").BornEurope) / 10000;
			StartCoroutine ("generateSpheres"); 
			print ("2009 European Immigrants: " + (Convert.ToInt32 (Find_Year ("2009").BornEurope) / 10000) + " * 10,000");
		}
		else if (Input.GetKeyDown (KeyCode.H)){ // 2008
			Destroy (europeParent);
			numberOfObjects = Convert.ToInt32 (Find_Year ("2008").BornEurope) / 10000;
			StartCoroutine ("generateSpheres"); 
			print ("2008 European Immigrants: " + (Convert.ToInt32 (Find_Year ("2008").BornEurope) / 10000) + " * 10,000");
		}
		else if (Input.GetKeyDown (KeyCode.I)){ // 2007
			Destroy (europeParent);
			numberOfObjects = Convert.ToInt32 (Find_Year ("2007").BornEurope) / 10000;
			StartCoroutine ("generateSpheres"); 
			print ("2007 European Immigrants: " + (Convert.ToInt32 (Find_Year ("2007").BornEurope) / 10000) + " * 10,000");
		}
		else if (Input.GetKeyDown (KeyCode.J)){ // 2006
			Destroy (europeParent);
			numberOfObjects = Convert.ToInt32 (Find_Year ("2006").BornEurope) / 10000;
			StartCoroutine ("generateSpheres"); 
			print ("2006 European Immigrants: " + (Convert.ToInt32 (Find_Year ("2006").BornEurope) / 10000) + " * 10,000");
		}
		else if (Input.GetKeyDown (KeyCode.K)){ // 2005
			Destroy (europeParent);
			numberOfObjects = Convert.ToInt32 (Find_Year ("2005").BornEurope) / 10000;
			StartCoroutine ("generateSpheres"); 
			print ("2005 European Immigrants: " + (Convert.ToInt32 (Find_Year ("2005").BornEurope) / 10000) + " * 10,000");
		}
		else {
			// Nothing's happening
		}
	}

	public class Row
	{
		public string Year;
		public string TotalForeignPop;
		public string BornEurope;
		public string BornAsia;
		public string BornAfrica;
		public string BornOceania;
		public string BornLatinAm;
		public string BornNorthAm;
		public string YoungerThan25;
		public string Between25_55;
		public string Between55_85;
		public string OlderThan85;

	}

	List<Row> rowList = new List<Row>();
	bool isLoaded = false;

	public bool IsLoaded()
	{
		return isLoaded;
	}

	public List<Row> GetRowList()
	{
		return rowList;
	}

	public void Load(TextAsset csv)
	{
		rowList.Clear();
		string[][] grid = CsvParser2.Parse(csv.text);
		for(int i = 1 ; i < grid.Length ; i++)
		{
			Row row = new Row();
			row.Year = grid[i][0];
			row.TotalForeignPop = grid[i][1];
			row.BornEurope = grid[i][2];
			row.BornAsia = grid[i][3];
			row.BornAfrica = grid[i][4];
			row.BornOceania = grid[i][5];
			row.BornLatinAm = grid[i][6];
			row.BornNorthAm = grid[i][7];
			row.YoungerThan25 = grid[i][8];
			row.Between25_55 = grid[i][9];
			row.Between55_85 = grid[i][10];
			row.OlderThan85 = grid[i][11];

			rowList.Add(row);
		}
		isLoaded = true;
	}

	public int NumRows()
	{
		return rowList.Count;
	}

	public Row GetAt(int i)
	{
		if(rowList.Count <= i)
			return null;
		return rowList[i];
	}

	public Row Find_Year(string find)
	{
		return rowList.Find(x => x.Year == find);
	}
	public List<Row> FindAll_Year(string find)
	{
		return rowList.FindAll(x => x.Year == find);
	}
	public Row Find_TotalForeignPop(string find)
	{
		return rowList.Find(x => x.TotalForeignPop == find);
	}
	public List<Row> FindAll_TotalForeignPop(string find)
	{
		return rowList.FindAll(x => x.TotalForeignPop == find);
	}
	public Row Find_BornEurope(string find)
	{
		return rowList.Find(x => x.BornEurope == find);
	}
	public List<Row> FindAll_BornEurope(string find)
	{
		return rowList.FindAll(x => x.BornEurope == find);
	}
	public Row Find_BornAsia(string find)
	{
		return rowList.Find(x => x.BornAsia == find);
	}
	public List<Row> FindAll_BornAsia(string find)
	{
		return rowList.FindAll(x => x.BornAsia == find);
	}
	public Row Find_BornAfrica(string find)
	{
		return rowList.Find(x => x.BornAfrica == find);
	}
	public List<Row> FindAll_BornAfrica(string find)
	{
		return rowList.FindAll(x => x.BornAfrica == find);
	}
	public Row Find_BornOceania(string find)
	{
		return rowList.Find(x => x.BornOceania == find);
	}
	public List<Row> FindAll_BornOceania(string find)
	{
		return rowList.FindAll(x => x.BornOceania == find);
	}
	public Row Find_BornLatinAm(string find)
	{
		return rowList.Find(x => x.BornLatinAm == find);
	}
	public List<Row> FindAll_BornLatinAm(string find)
	{
		return rowList.FindAll(x => x.BornLatinAm == find);
	}
	public Row Find_BornNorthAm(string find)
	{
		return rowList.Find(x => x.BornNorthAm == find);
	}
	public List<Row> FindAll_BornNorthAm(string find)
	{
		return rowList.FindAll(x => x.BornNorthAm == find);
	}
	public Row Find_YoungerThan25(string find)
	{
		return rowList.Find(x => x.YoungerThan25 == find);
	}
	public List<Row> FindAll_YoungerThan25(string find)
	{
		return rowList.FindAll(x => x.YoungerThan25 == find);
	}
	public Row Find_Between25_55(string find)
	{
		return rowList.Find(x => x.Between25_55 == find);
	}
	public List<Row> FindAll_Between25_55(string find)
	{
		return rowList.FindAll(x => x.Between25_55 == find);
	}
	public Row Find_Between55_85(string find)
	{
		return rowList.Find(x => x.Between55_85 == find);
	}
	public List<Row> FindAll_Between55_85(string find)
	{
		return rowList.FindAll(x => x.Between55_85 == find);
	}
	public Row Find_OlderThan85(string find)
	{
		return rowList.Find(x => x.OlderThan85 == find);
	}
	public List<Row> FindAll_OlderThan85(string find)
	{
		return rowList.FindAll(x => x.OlderThan85 == find);
	}

	IEnumerator  generateSpheres () {

		europeParent = new GameObject();

		for (int i = 0; i < numberOfObjects; i++) {

			Vector3 position = UnityEngine.Random.onUnitSphere * 3.2f; // Change this value depending on how large the unit circle should be
			GameObject go = Instantiate (continent_group, position, Quaternion.identity) as GameObject;
			go.transform.SetParent(europeParent.transform);
			yield return new WaitForSeconds (0.02f);
		}
	}
}