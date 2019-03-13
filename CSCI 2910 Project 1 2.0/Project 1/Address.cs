//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Project: Project 1
// Description: Object Orented Programing 
// Course: Server Side Web Programing
// Author: Smythe, Josiah, smythejg@etsu.edu, Department of Computing, East Tennessee State University
// Created: Wednesday, Femuary 16, 2019
// Copyright: Josiah Smythe, 2019
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;
using System;

namespace Project_1
{
    /// <summary>
    /// Creates an address in the United States Of America
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Random Number between 1 and 5000
        /// </summary>
        private int HouseNumber { get; set; }
        /// <summary>
        /// Name of the street in the address that is set from the StreetName Enum Class
        /// </summary>
        private string StreetName { get; set; }
        /// <summary>
        /// Prefx of street gathered from the StreetType Enum class
        /// </summary>
        private string StreetType { get; set; }
        /// <summary>
        /// is a city set from the CityNames Enum Class
        /// </summary>
        private string City { get; set; }
        /// <summary>
        /// state for the address and is gathered later from the dictionary
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// zipcode for the address class and is set later in the AssignZipCode method
        /// </summary>
        private string ZipCode { get; set; }
        /// <summary>
        /// Dictionary that will be filled with the 50 states of america
        /// </summary>
        private Dictionary <string, string>  StateDictionary { get; set; }
        /// <summary>
        /// String for storing the Country of the address, Defult is the United States, will be changed with an international address
        /// </summary>
        private string Country = "United States";
  
        /// <summary>
        /// Defult constructor for the Address class and sets the HouseNumber, StreetName, StreetType, City, StateDictionary, AssignStateName(); AssignZipCode();
        /// </summary>
        public Address()
        {
            Random RandomNumber = new Random();
            HouseNumber = RandomNumber.Next(1,5001);

            Array StreetNamesArray = Enum.GetValues(typeof(StreetName));
            StreetName = StreetNamesArray.GetValue(RandomNumber.Next(0, StreetNamesArray.Length)).ToString();
            
            Array StreetTypeArray = Enum.GetValues(typeof(StreetType));
            StreetType = StreetTypeArray.GetValue(RandomNumber.Next(0, StreetTypeArray.Length)).ToString();
           
            CreateStateDictionary();
            AssignStateName();
            
            
            AssignZipCode();
            
            SetStateCity(GetStateAbbr(State));  
        }
        /// <summary>
        /// Creates a new address acording to all the values passed in
        /// </summary>
        /// <param name="houseNumber"></param>
        /// <param name="streetName"></param>
        /// <param name="streetType"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zipCode"></param>
        /// <param name="country"></param>
        public void CreateInternationalAddress(int houseNumber, string streetName, string streetType, string city,
            string state, string zipCode, string country)
        {
            HouseNumber = houseNumber;
            StreetName = streetName;
            StreetType = streetType;
            City = city;
            State = state;
            GetStateAbbr(state);
            ZipCode = zipCode;
            Country = country;
        }
        /// <summary>
        /// Creates a dictionary of all the states in the US, keys are the state abreveations and the values are the state names.
        /// </summary>
        public void CreateStateDictionary()
        {
            StateDictionary = new Dictionary <string, string>
            {
                {"AL", "Alabama"}, 
                {"AK", "Alaska"}, 
                {"AZ", "Arizona"}, 
                {"AR", "Arkansas"},
                {"CA", "Californa"},
                {"CO","Colorado"}, 
                {"CT", "Connecticut"}, 
                {"DE", "Delaware"}, 
                {"FL", "Florida"},
                {"GA", "Georgia"},
                {"HI", "Hawaii"},
                {"ID", "Idaho"},
                {"IL", "Illinois"},
                {"IN", "Indiana"},
                {"IA", "Iowa"},
                {"KS", "Kansas"},
                {"KY", "Kentucky"},
                {"LA", "Louisiana"},
                {"ME", "Maine"},
                {"MD", "Maryland"},
                {"MA", "Massachusetts"},
                {"MI", "Michigan"},
                {"MN", "Minnesota"},
                {"MS", "Mississippi"},
                {"MO", "Missouri"},
                {"MT", "Montana"},
                {"NE", "Nebraska"},
                {"NV", "Nevada"},
                {"NH", "New Hampshire"},
                {"NJ", "New Jersey"},
                {"NM", "New Mexico"},
                {"NY", "New York"},
                {"NC", "North Carolina"},
                {"ND", "North Dakota"},
                {"OH", "Ohio"},
                {"OK", "Oklahoma"},
                {"OR", "Oregon"},
                {"PA", "Pennsylvania"},
                {"RI", "Road Island"},
                {"SC", "South Carolina"},
                {"SD", "South Dakota"},
                {"TN", "Tennessee"},
                {"TX", "Texas"},
                {"UT", "Utah"},
                {"VT", "Vermont"},
                {"VA", "Virginia"},
                {"WA", "Washington"},
                {"WV", "West Virginia"},
                {"WI", "Wisconsin"},
                {"WY", "Wyoming"}
            };
        }
        /// <summary>
        /// this method sets the state city from the enum file citynames with enum for each of the 50 states
        /// </summary>
        /// <param name="StateAbreveation"></param>
        public void SetStateCity(string StateAbreveation)
        {
            Random RanNumber = new Random();

            
            
            if (StateAbreveation.Equals("AL"))
            {
                Array alaCityArray = Enum.GetValues(typeof(AlabamaCities));
                City = alaCityArray.GetValue(RanNumber.Next(0, alaCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("AK"))
            {
                Array alkCityArray = Enum.GetValues(typeof(AlaskaCities));
                City = alkCityArray.GetValue(RanNumber.Next(0, alkCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("AZ"))
            {
                Array azrCityArray = Enum.GetValues(typeof(ArizonaCities));
                City = azrCityArray.GetValue(RanNumber.Next(0, azrCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("AR"))
            {
                Array arkCityArray = Enum.GetValues(typeof(ArkansasCities));
                City = arkCityArray.GetValue(RanNumber.Next(0, arkCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("CA"))
            {
                Array calCityArray = Enum.GetValues(typeof(CalifornaCities));
                City = calCityArray.GetValue(RanNumber.Next(0, calCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("CO"))
            {
                Array colCityArray = Enum.GetValues(typeof(ColoradoCities));
                City = colCityArray.GetValue(RanNumber.Next(0, colCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("CT"))
            {
                Array conCityArray = Enum.GetValues(typeof(ConnecticutCities));
                City = conCityArray.GetValue(RanNumber.Next(0, conCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("DE"))
            {
                Array delCityArray = Enum.GetValues(typeof(DelawareCities));
                City = delCityArray.GetValue(RanNumber.Next(0, delCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("FL"))
            {
                Array floCityArray = Enum.GetValues(typeof(FloridaCities));
                City = floCityArray.GetValue(RanNumber.Next(0, floCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("GA"))
            {
                Array geoCityArray = Enum.GetValues(typeof(GeorgiaCities));
                City = geoCityArray.GetValue(RanNumber.Next(0, geoCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("HI"))
            {
                Array hawCityArray = Enum.GetValues(typeof(HawaiiCities));
                City = hawCityArray.GetValue(RanNumber.Next(0, hawCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("ID"))
            {
                Array idaCityArray = Enum.GetValues(typeof(IdahoCities));
                City = idaCityArray.GetValue(RanNumber.Next(0, idaCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("IL"))
            {
                Array illCityArray = Enum.GetValues(typeof(IllinoisCities));
                City = illCityArray.GetValue(RanNumber.Next(0, illCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("IN"))
            {
                Array indCityArray = Enum.GetValues(typeof(IndianaCities));
                City = indCityArray.GetValue(RanNumber.Next(0, indCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("IA"))
            {
                Array iowCityArray = Enum.GetValues(typeof(IowaCities));
                City = iowCityArray.GetValue(RanNumber.Next(0, iowCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("KS"))
            {
                Array kanCityArray = Enum.GetValues(typeof(KansasCites));
                City = kanCityArray.GetValue(RanNumber.Next(0, kanCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("KY"))
            {
                Array kenCityArray = Enum.GetValues(typeof(KentuckyCities));
                City = kenCityArray.GetValue(RanNumber.Next(0, kenCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("LA"))
            {
                Array louCityArray = Enum.GetValues(typeof(LouisianaCities));
                City = louCityArray.GetValue(RanNumber.Next(0, louCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("ME"))
            {
                Array maiCityArray = Enum.GetValues(typeof(MaineCities));
                City = maiCityArray.GetValue(RanNumber.Next(0, maiCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("MD"))
            {
                Array marCityArray = Enum.GetValues(typeof(MarylandCities));
                City = marCityArray.GetValue(RanNumber.Next(0, marCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("MA"))
            {
                Array masCityArray = Enum.GetValues(typeof(MassachusettsCities));
                City = masCityArray.GetValue(RanNumber.Next(0, masCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("MI"))
            {
                Array micCityArray = Enum.GetValues(typeof(MichiganCities));
                City = micCityArray.GetValue(RanNumber.Next(0, micCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("MN"))
            {
                Array minCityArray = Enum.GetValues(typeof(MinnesotaCities));
                City = minCityArray.GetValue(RanNumber.Next(0, minCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("MS"))
            {
                Array misCityArray = Enum.GetValues(typeof(MississippiCities));
                City = misCityArray.GetValue(RanNumber.Next(0, misCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("MO"))
            {
                Array misCityArray = Enum.GetValues(typeof(MissouriCities));
                City = misCityArray.GetValue(RanNumber.Next(0, misCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("MT"))
            {
                Array monCityArray = Enum.GetValues(typeof(MontanaCities));
                City = monCityArray.GetValue(RanNumber.Next(0, monCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("NE"))
            {
                Array nebCityArray = Enum.GetValues(typeof(NebraskaCities));
                City = nebCityArray.GetValue(RanNumber.Next(0, nebCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("NV"))
            {
                Array nevCityArray = Enum.GetValues(typeof(NevadaCities));
                City = nevCityArray.GetValue(RanNumber.Next(0, nevCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("NH"))
            {
                Array nehCityArray = Enum.GetValues(typeof(New_HampshireCities));
                City = nehCityArray.GetValue(RanNumber.Next(0, nehCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("NJ"))
            {
                Array nejCityArray = Enum.GetValues(typeof(New_JerseyCities));
                City = nejCityArray.GetValue(RanNumber.Next(0, nejCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("NM"))
            {
                Array nemCityArray = Enum.GetValues(typeof(New_MexicoCities));
                City = nemCityArray.GetValue(RanNumber.Next(0, nemCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("NY"))
            {
                Array neyCityArray = Enum.GetValues(typeof(New_YorkCities));
                City = neyCityArray.GetValue(RanNumber.Next(0, neyCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("NC"))
            {
                Array nocCityArray = Enum.GetValues(typeof(North_CarolinaCities));
                City = nocCityArray.GetValue(RanNumber.Next(0, nocCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("ND"))
            {
                Array nodCityArray = Enum.GetValues(typeof(North_DakotaCities));
                City = nodCityArray.GetValue(RanNumber.Next(0, nodCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("OH"))
            {
                Array ohiCityArray = Enum.GetValues(typeof(OhioCities));
                City = ohiCityArray.GetValue(RanNumber.Next(0, ohiCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("OK"))
            {
                Array oklCityArray = Enum.GetValues(typeof(OklahomaCities));
                City = oklCityArray.GetValue(RanNumber.Next(0, oklCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("OR"))
            {
                Array oreCityArray = Enum.GetValues(typeof(OregonCities));
                City = oreCityArray.GetValue(RanNumber.Next(0, oreCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("PA"))
            {
                Array penCityArray = Enum.GetValues(typeof(PennsylvaniaCities));
                City = penCityArray.GetValue(RanNumber.Next(0, penCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("RI"))
            {
                Array roaCityArray = Enum.GetValues(typeof(Road_IslandCities));
                City = roaCityArray.GetValue(RanNumber.Next(0, roaCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("SC"))
            {
                Array socCityArray = Enum.GetValues(typeof(South_CarolinaCities));
                City = socCityArray.GetValue(RanNumber.Next(0, socCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("SD"))
            {
                Array sodCityArray = Enum.GetValues(typeof(South_DakotaCities));
                City = sodCityArray.GetValue(RanNumber.Next(0, sodCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("TX"))
            {
                Array texCityArray = Enum.GetValues(typeof(TexasCities));
                City = texCityArray.GetValue(RanNumber.Next(0, texCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("TN"))
            {
                Array tenCityArray = Enum.GetValues(typeof(TennesseeCities));
                City = tenCityArray.GetValue(RanNumber.Next(0, tenCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("UT"))
            {
                Array utaCityArray = Enum.GetValues(typeof(UtahCities));
                City = utaCityArray.GetValue(RanNumber.Next(0, utaCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("VT"))
            {
                Array verCityArray = Enum.GetValues(typeof(VermontCities));
                City = verCityArray.GetValue(RanNumber.Next(0, verCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("VA"))
            {
                Array virCityArray = Enum.GetValues(typeof(VirginiaCities));
                City = virCityArray.GetValue(RanNumber.Next(0, virCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("WA"))
            {
                Array wasCityArray = Enum.GetValues(typeof(WashingtonCities));
                City = wasCityArray.GetValue(RanNumber.Next(0, wasCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("WV"))
            {
                Array wevCityArray = Enum.GetValues(typeof(West_VirginiaCities));
                City = wevCityArray.GetValue(RanNumber.Next(0, wevCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("WI"))
            {
                Array wisCityArray = Enum.GetValues(typeof(WisconsinCities));
                City = wisCityArray.GetValue(RanNumber.Next(0, wisCityArray.Length)).ToString();
            }
            else if (StateAbreveation.Equals("WY"))
            {
                Array wyoCityArray = Enum.GetValues(typeof(WyomingCities));
                City = wyoCityArray.GetValue(RanNumber.Next(0, wyoCityArray.Length)).ToString();
            }
            else
            {
                Console.Out.WriteLine("False State");
            }

        }
        /// <summary>
        /// Set the State abreveation based on the Dicitonary Keys
        /// </summary>
        /// <returns>The State Abreveation</returns>
        public string GetStateAbbr(string state)
        {
            List<string> StateKeyList = new List<string>(StateDictionary.Keys);
            List<string> StateNameList = new List<string>(StateDictionary.Values);

            string Abbrev = "";

            for (int i = 0; i < StateDictionary.Count; i++)
            {
                if (state.Equals(StateNameList[i]))
                {
                    Abbrev = StateKeyList[i];
                    break;
                }
                
            }

            return Abbrev;
        }
        /// <summary>
        /// Sets the State Name by accessing the StateDictionary
        /// </summary>
        /// <returns>The State Name</returns>
        public  string AssignStateName()
        {
            List<string> StateNameList = new List<string>(StateDictionary.Values);
            Random RandomNum = new Random();
            int RandomInt = RandomNum.Next(0, StateDictionary.Count);
            State = StateNameList[RandomInt];
          
            return State;
        }
        /// <summary>
        /// Sets the ZipCode based on the State Abreveation and acording to the zip code areas
        /// </summary>
        /// <returns>A String Zip Code</returns>
        public string AssignZipCode()
        {
            
            string StateAbreveation = GetStateAbbr(State);
            //string ZipCode = "";
            Random RanNumber = new Random();
            
            if (StateAbreveation.Equals("AL"))
            {
                ZipCode = RanNumber.Next(35000, 36999).ToString();
            }
            else if (StateAbreveation.Equals("AK"))
            {
                ZipCode = RanNumber.Next(99500, 99999).ToString();
            }
            else if (StateAbreveation.Equals("AZ"))
            {
                ZipCode = RanNumber.Next(85000, 86999).ToString();
            }
            else if (StateAbreveation.Equals("AR"))
            {
                ZipCode = RanNumber.Next(71600, 72999).ToString();
            }
            else if (StateAbreveation.Equals("CA"))
            {
                ZipCode = RanNumber.Next(90000, 96199).ToString();
            }
            else if (StateAbreveation.Equals("CO"))
            {
                ZipCode = RanNumber.Next(80000, 81999).ToString();
            }
            else if (StateAbreveation.Equals("CT"))
            {
                ZipCode = RanNumber.Next(02800, 02999).ToString();
            }
            else if (StateAbreveation.Equals("DE"))
            {
                ZipCode = RanNumber.Next(19700, 19999).ToString();
            }
            else if (StateAbreveation.Equals("FL"))
            {
                ZipCode = RanNumber.Next(32000, 34999).ToString();
            }
            else if (StateAbreveation.Equals("GA"))
            {
                ZipCode = RanNumber.Next(30000, 31999).ToString();
            }
            else if (StateAbreveation.Equals("HI"))
            {
                ZipCode = RanNumber.Next(96700, 96899).ToString();
            }
            else if (StateAbreveation.Equals("ID"))
            {
                ZipCode = RanNumber.Next(83200, 83999).ToString();
            }
            else if (StateAbreveation.Equals("IL"))
            {
                ZipCode = RanNumber.Next(60000, 62999).ToString();
            }
            else if (StateAbreveation.Equals("IN"))
            {
                ZipCode = RanNumber.Next(46000, 47999).ToString();
            }
            else if (StateAbreveation.Equals("IA"))
            {
                ZipCode = RanNumber.Next(50000, 52999).ToString();
            }
            else if (StateAbreveation.Equals("KS"))
            {
                ZipCode = RanNumber.Next(66000, 67999).ToString();
            }
            else if (StateAbreveation.Equals("KY"))
            {
                ZipCode = RanNumber.Next(40000, 42999).ToString();
            }
            else if (StateAbreveation.Equals("LA"))
            {
                ZipCode = RanNumber.Next(70000, 71599).ToString();
            }
            else if (StateAbreveation.Equals("ME"))
            {
                ZipCode = RanNumber.Next(03900, 04999).ToString();
            }
            else if (StateAbreveation.Equals("MD"))
            {
                ZipCode = RanNumber.Next(20600, 21999).ToString();
            }
            else if (StateAbreveation.Equals("MA"))
            {
                ZipCode = RanNumber.Next(01000, 02799).ToString();
            }
            else if (StateAbreveation.Equals("MI"))
            {
                ZipCode = RanNumber.Next(48000, 49999).ToString();
            }
            else if (StateAbreveation.Equals("MN"))
            {
                ZipCode = RanNumber.Next(55000, 56799).ToString();
            }
            else if (StateAbreveation.Equals("MS"))
            {
                ZipCode = RanNumber.Next(38600, 39999).ToString();
            }
            else if (StateAbreveation.Equals("MO"))
            {
                ZipCode = RanNumber.Next(63000, 65999).ToString();
            }
            else if (StateAbreveation.Equals("MT"))
            {
                ZipCode = RanNumber.Next(59000, 59999).ToString();
            }
            else if (StateAbreveation.Equals("NE"))
            {
                ZipCode = RanNumber.Next(68000, 699999).ToString();
            }
            else if (StateAbreveation.Equals("NV"))
            {
                ZipCode = RanNumber.Next(88900, 89999).ToString();
            }
            else if (StateAbreveation.Equals("NH"))
            {
                ZipCode = RanNumber.Next(03000, 03899).ToString();
            }
            else if (StateAbreveation.Equals("NJ"))
            {
                ZipCode = RanNumber.Next(07000, 08999).ToString();
            }
            else if (StateAbreveation.Equals("NM"))
            {
                ZipCode = RanNumber.Next(87000, 88499).ToString();
            }
            else if (StateAbreveation.Equals("NY"))
            {
                ZipCode = RanNumber.Next(10000, 14999).ToString();
            }
            else if (StateAbreveation.Equals("NC"))
            {
                ZipCode = RanNumber.Next(27000, 28999).ToString();
            }
            else if (StateAbreveation.Equals("ND"))
            {
                ZipCode = RanNumber.Next(58000, 58999).ToString();
            }
            else if (StateAbreveation.Equals("OH"))
            {
                ZipCode = RanNumber.Next(4300, 45999).ToString();
            }
            else if (StateAbreveation.Equals("OK"))
            {
                ZipCode = RanNumber.Next(73000, 74999).ToString();
            }
            else if (StateAbreveation.Equals("OR"))
            {
                ZipCode = RanNumber.Next(97000, 97999).ToString();
            }
            else if (StateAbreveation.Equals("PA"))
            {
                ZipCode = RanNumber.Next(15000, 19699).ToString();
            }
            else if (StateAbreveation.Equals("RI"))
            {
                ZipCode = RanNumber.Next(02800, 03000).ToString();
            }
            else if (StateAbreveation.Equals("SC"))
            {
                ZipCode = RanNumber.Next(27000, 29000).ToString();
            }
            else if (StateAbreveation.Equals("SD"))
            {
                ZipCode = RanNumber.Next(57000, 58000).ToString();
            }
            else if (StateAbreveation.Equals("TX"))
            {
                ZipCode = RanNumber.Next(75000, 80000).ToString();
            }
            else if (StateAbreveation.Equals("TN"))
            {
                ZipCode = RanNumber.Next(37000, 38600).ToString();
            }
            else if (StateAbreveation.Equals("UT"))
            {
                ZipCode = RanNumber.Next(84000, 84999).ToString();
            }
            else if (StateAbreveation.Equals("VT"))
            {
                ZipCode = RanNumber.Next(05000, 05999).ToString();
            }
            else if (StateAbreveation.Equals("VA"))
            {
                ZipCode = RanNumber.Next(22000, 24699).ToString();
            }
            else if (StateAbreveation.Equals("WA"))
            {
                ZipCode = RanNumber.Next(98000, 99499).ToString();
            }
            else if (StateAbreveation.Equals("WV"))
            {
                ZipCode = RanNumber.Next(24700, 26999).ToString();
            }
            else if (StateAbreveation.Equals("WI"))
            {
                ZipCode = RanNumber.Next(53000, 54999).ToString();
            }
            else if (StateAbreveation.Equals("WY"))
            {
                ZipCode = RanNumber.Next(82000, 83199).ToString();
            }
            else
            {
                Console.Out.WriteLine("[ False State Abreveation ]");
            }
            return ZipCode;
        }
        
        /// <summary>
        /// Returns the values as strings of State, State Abbreveation, House Number, StreetName, City, ZipCode, Street Name
        /// </summary>
        /// <returns>The values State, State Abbreveation, House Number, StreetName, City, ZipCode, Street Name</returns>
        public string ToString()
        {
            return "\n     ===== Address =====" + "\n Country      : " + Country +"\n State:       : " + State + "\n State Abrv   : " + GetStateAbbr(State) + "\n House Number : " + HouseNumber + "\n Street Name  : " + StreetName +"\n City Name    : "+ City + "\n Zipcode      : " + ZipCode + "\n Street Type  : " + StreetType;
        }
        /// <summary>
        /// Returns the values of the International Address
        /// </summary>
        /// <returns></returns>
        public string ToStringInternational()
        {
            return "Country: " + Country +"\nState: " + State + "\nHouse Number: " + HouseNumber + "\nStreet Name: " + StreetName +"\nCity: "+ City + "\nZipcode: " + ZipCode + "\nStreet Type: " + StreetType;

        }
    }
}