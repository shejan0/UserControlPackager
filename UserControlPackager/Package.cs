using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace UserControlPackager
{
    public class Package
    {
        
        [JsonProperty("name")]
        String name;
        [JsonProperty("height")]
        float height;
        [JsonProperty("width")]
        float width;
        [JsonProperty("depth")]
        float depth;
        [JsonProperty("weight")]
        float weight;
        [JsonProperty("streetAddress")]
        String streetAddress;
        [JsonProperty("buildingNum")]
        String buildingNum;
        [JsonProperty("city")]
        String city;
        [JsonProperty("state")]
        String state;
        [JsonProperty("country")]
        String country;
        [JsonProperty("zipCode")]
        String zipCode;
        public Package(String nam, float h, float w, float d, float grams, String strAddr, String buildNum, String cit, String st, String count,String zip)
        {
            name = nam;
            height = h;
            width = w;
            depth = d;
            weight = grams;
            streetAddress = strAddr;
            buildingNum = buildNum;
            city = cit;
            state = st;
            country = count;
            zipCode = zip;
        }
        public override String ToString()
        {
            return name + ", " + streetAddress + ", " + city + ", " + state + " " + zipCode + ", " + country + ", Size: " + height + "mm x" + width + "mm x" + depth+"mm"+", Weight: "+weight+"g";

        }
        public String ToShippingLabelString()
        {
            return name + "\n" + streetAddress + "\n" + city + ", " + state + " " + zipCode + "\n" + country + "\nSize: " + height + "mm x " + width + "mm x " + depth+"mm,\nWeight: "+weight+"g";
        }
    }
}
