using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GRIDCITY
{
    public enum blockType { Block, Arches, Columns, Dishpivot, DomeWithBase, HalfDome, SlitDome, Slope, Tile};

    public class CityManager : MonoBehaviour

    {

        #region Fields
        private static CityManager _instance;
        public Mesh[] meshArray;
        public Material[] materialArray;
        public Transform buildingPrefab;
        public BuildingProfile[] profileArray;

        public static CityManager Instance
        {
            get
            {
                return _instance;
            }
        }
        #endregion

        #region Properties	
        #endregion

        #region Methods
        #region Unity Methods

        public GameObject key;
        public bool keyActive = false;

        // Use this for internal initialization
        void Awake() {
            if (_instance == null)
            {
                _instance = this;
            }

            else
            {
                Destroy(gameObject);
                Debug.LogError("Multiple CityManager instances in Scene. Destroying clone!");
            };
        }

        // Use this for external initialization
        void Start() {
            //City
            for (float i = -60; i < 20; i += 2.5f)
            {

                for (int j = -60; j < 20; j += 11)
                {
                    int random = Random.Range(0, profileArray.Length);
                    int ran = Random.Range(0, 8);
                    Instantiate(buildingPrefab, new Vector3(i, 0.0f, j += ran), Quaternion.identity).GetComponent<DeluxeTowerBlock>().SetProfile(profileArray[0]);
                }
            }

            //Special Buildings
            for (float i = -40; i < 20; i += 40)
            {

                for (int j = -40; j < 20; j += 50)
                {
                    int random = Random.Range(0, profileArray.Length);
                    int ran = Random.Range(0, 8);
                    Instantiate(buildingPrefab, new Vector3(i, 0.0f, j), Quaternion.identity).GetComponent<DeluxeTowerBlock>().SetProfile(profileArray[1]);

                }
            }

        }



        // Update is called once per frame
        void Update() {



        }
    }
		#endregion
	#endregion
		
	}

