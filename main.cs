using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
   

   var random = new Random();
 
  List<string> topics = new List<string>();
  topics = File.ReadAllLines("choices.txt").ToList();
  
   /* Old version below with hard wired list

   List<string> topics = new List<string>(){
            "Internet",
            "WWW",
            "CPUs",
            "Input Devices",
            "Output Devices",
            "Social Media",
            "Storage",
            "Search",
            "Browsers",
            "Operating Systems",
            "Programming Languages",
            "The Cloud",
            "Databases",
            "Wireless Communications",
            "Big Tech Companies",
            "Mobile Computing (not phones)",
            "Video Games",
            "Open Source",
            "Graphics",
            "Global Positioning Systems",
            "Mobile Phones"};
*/


   double loopCount = topics.Count;      

    for (int a = 1; a <= loopCount; a++) 
    {
        int index = random.Next(topics.Count);
        Console.WriteLine("Group " + a + ": " + topics[index]);
        topics.RemoveAt(index);
        string noString = Console.ReadLine();
        Console.WriteLine(noString);
    }

  }
}

