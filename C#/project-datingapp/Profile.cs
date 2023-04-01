using System;

namespace DatingProfile
{ 
  class Profile 
  {
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    public Profile(string name, int age, string city, string country, string pronouns = "they/them") {
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.hobbies = Array.Empty<string>();
    }

    public string ViewProfile() {
      if (hobbies.Length > 0) {
      string hobbs = "Hobbies: ";
      foreach (string hobby in hobbies) {
        string hobstr = $" {hobby}\n";
        hobbs = String.Concat(hobbs, hobstr);
      }
      string profileInfo = $"Name : {name} \nAge : {age} \nLocalisation : {city}, {country} \n";
      string prof = String.Concat(profileInfo, hobbs);
      return prof;
      }
      else {
        string profileInfo = $"Name : {name} \nAge : {age} \nLocalisation : {city}, {country} \n";
      return profileInfo;
      }
    }

    public void SetHobbies (string[] hobbies) {
      this.hobbies = hobbies;
    }
  }
}
