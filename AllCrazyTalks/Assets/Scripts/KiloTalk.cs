



































































































































































































































































































































































































































using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using KModkit;
public class KiloTalk : MonoBehaviour {
    public KMBombInfo Bomb;
    public KMAudio Audio;
    public KMSelectable[] Displays;
    public KMSelectable Submit; //Newtons Grams Kilograms Tonnes "Metric Ton" Slug Pound Ounce
    private List<string> Units = new List<string>{" Newtons"," Grams"," Kilograms"," Tonnes"," Metric Tons"," Slugs"," Pounds"," Ounces", " Tons"};
    public TextMesh Fatass;
    public TextMesh[] Fatasses;
    float Idontfuckingknow = 420;
    int gofuckyourselftwo = 69;
    int gofuckyourself = 0;
    string space = "";
    int anotherfuckingvariable = 0;
    int fuck = 0;
    int shit = 0;
    int cunt = 0;
    static int moduleIdCounter = 1;
    int moduleId;
    private bool moduleSolved;
    void Awake () {
        moduleId = moduleIdCounter++;
        foreach (KMSelectable Display in Displays) {
            Display.OnInteract += delegate () { DisplaysPress(Display); return false; };
        }
        Submit.OnInteract += delegate () { PressSubmit(); return false; };
    }
    void Start () {
      Idontfuckingknow = UnityEngine.Random.Range(2,1000);
      Idontfuckingknow = Idontfuckingknow - (Idontfuckingknow % 1);
      gofuckyourself = UnityEngine.Random.Range(0,Units.Count());
      gofuckyourselftwo = UnityEngine.Random.Range(0,Units.Count());
      while (gofuckyourselftwo == gofuckyourself) {
        gofuckyourselftwo = UnityEngine.Random.Range(0,Units.Count());
      }
      Debug.LogFormat("[Kilo Talk #{0}] The starting value is {1}{2}. The target unit is {3}.", moduleId, Idontfuckingknow, Units[gofuckyourself],Units[gofuckyourselftwo]);
      Fatass.text = Idontfuckingknow.ToString() + Units[gofuckyourself] + "\n"+ space + "to" + Units[gofuckyourselftwo];
      for (int i = 0; i < 3; i++) {
          Fatasses[i].text = "0";
      }
      switch (gofuckyourself) {
        case 0:
        switch (gofuckyourselftwo) { //0Newtons 1Grams 2Kilograms 3Tonnes 4"Metric Ton" 5Slug 6Pound 7Ounce 8Ton
          case 1:
          Idontfuckingknow *= 102f;
          break;
          case 2:
          Idontfuckingknow *= .102f;
          break;
          case 3:
          Idontfuckingknow *= 0.000102f;
          break;
          case 4:
          Idontfuckingknow *= 0.000102f;
          break;
          case 5:
          Idontfuckingknow *= 0.006987f;
          break;
          case 6:
          Idontfuckingknow *= 0.2248f;
          break;
          case 7:
          Idontfuckingknow *= 3.597f;
          break;
          case 8:
          Idontfuckingknow *= 0.0001f;
          break;
          default: break;
        }
        break;
        case 1:
        switch (gofuckyourselftwo) {
          case 0:
          Idontfuckingknow *= 0.009807f;
          break;
          case 2:
          Idontfuckingknow *= 0.001f;
          break;
          case 3:case 4:
          Idontfuckingknow *= 0.000001f;
          break;
          case 5:
          Idontfuckingknow *= 0.00006852f;
          break;
          case 6:
          Idontfuckingknow *= 0.002205f;
          break;
          case 7:
          Idontfuckingknow *= 0.03527f;
          break;
          case 8:
          Idontfuckingknow *= 0.000001102f;
          break;
          default: break;
        }
        break;
        case 2:
        switch (gofuckyourselftwo) {
		  case 0:
          Idontfuckingknow *= 9.807f;
          break;
          case 1:
          Idontfuckingknow *= 1000f;
          break;
          case 3:case 4:
          Idontfuckingknow *= 0.001f;
          break;
          case 5:
          Idontfuckingknow *= 0.06852f;
          break;
          case 6:
          Idontfuckingknow *= 2.205f;
          break;
          case 7:
          Idontfuckingknow *= 35.27f;
          break;
          case 8:
          Idontfuckingknow *= 0.001102f;
          break;
          default: break;
        }
        break;
        case 3: case 4:
        switch (gofuckyourselftwo) {
          case 0:
          Idontfuckingknow *= 9807f;
          break;
          case 1:
          Idontfuckingknow *= 1000000f;
          break;
          case 2:
          Idontfuckingknow *= 1000f;
          break;
          case 5:
          Idontfuckingknow *= 68.52f;
          break;
          case 6:
          Idontfuckingknow *= 2205f;
          break;
          case 7:
          Idontfuckingknow *= 35274f;
          break;
          case 8:
          Idontfuckingknow *= 1.102f;
          break;
		  default: break; //you can still get 3 or 4 from here
        }
        break;
        case 5:
        switch (gofuckyourselftwo) { //0Newtons 1Grams 2Kilograms 3Tonnes 4"Metric Ton" 5Slug 6Pound 7Ounce 8Ton
          case 0:
          Idontfuckingknow *= 143.1f;
          break;
          case 1:
          Idontfuckingknow *= 14594f;
          break;
          case 2:
          Idontfuckingknow *= 14.594f;
          break;
          case 3: case 4:
          Idontfuckingknow *= 0.01459f;
          break;
          case 6:
          Idontfuckingknow *= 32.17f;
          break;
          case 7:
          Idontfuckingknow *= 514.8f;
          break;
          case 8:
          Idontfuckingknow *= 0.01609f;
          break;
        }
        break;
        case 6:
        switch (gofuckyourselftwo) { //0Newtons 1Grams 2Kilograms 3Tonnes 4"Metric Ton" 5Slug 6Pound 7Ounce 8Ton
          case 0:
          Idontfuckingknow *= 4.448f;
          break;
          case 1:
          Idontfuckingknow *= 453.6f;
          break;
          case 2:
          Idontfuckingknow *= 0.4536f;
          break;
          case 3: case 4:
          Idontfuckingknow *= 0.0004536f;
          break;
          case 5:
          Idontfuckingknow *= 0.03108f;
          break;
          case 7:
          Idontfuckingknow *= 16f;
          break;
          case 8:
          Idontfuckingknow *= 0.0005f;
          break;
        }
        break;
        case 7:
        switch (gofuckyourselftwo) { //0Newtons 1Grams 2Kilograms 3Tonnes 4"Metric Ton" 5Slug 6Pound 7Ounce 8Ton
          case 0:
          Idontfuckingknow *= 0.278f;
          break;
          case 1:
          Idontfuckingknow *= 28.3495f;
          break;
          case 2:
          Idontfuckingknow *= 0.0283495f;
          break;
          case 3: case 4:
          Idontfuckingknow *= 0.00002835f;
          break;
          case 5:
          Idontfuckingknow *= 0.001943f;
          break;
          case 6:
          Idontfuckingknow *= 0.0625f;
          break;
          case 8:
          Idontfuckingknow *= 0.00003125f;
          break;
        }
        break;
        case 8:
        switch (gofuckyourselftwo) { //0Newtons 1Grams 2Kilograms 3Tonnes 4"Metric Ton" 5Slug 6Pound 7Ounce 8Ton
          case 0:
          Idontfuckingknow *= 8896f;
          break;
          case 1:
          Idontfuckingknow *= 907185f;
          break;
          case 2:
          Idontfuckingknow *= 907.185f;
          break;
          case 3: case 4:
          Idontfuckingknow *= 0.9072f;
          break;
          case 5:
          Idontfuckingknow *= 62.16f;
          break;
          case 6:
          Idontfuckingknow *= 2000f;
          break;
          case 7:
          Idontfuckingknow *= 32000f;
          break;
        }
        break;
      }
      anotherfuckingvariable = (int)Idontfuckingknow;
      Debug.LogFormat("[Kilo Talk #{0}] Adjusting by the value gives you {1}.", moduleId, Idontfuckingknow);
	}
	void DisplaysPress (KMSelectable Display) {
    for (int i = 0; i < 3; i++) {
      if (Display == Displays[i]) {
        Fatasses[i].text = ((int.Parse(Fatasses[i].text) + 1) % 10).ToString();
        if (i == 0) {
          fuck = (fuck + 1) % 10;
        }
        else if (i == 1) {
          shit = (shit + 1) % 10;
        }
        else {
          cunt = (cunt + 1) % 10;
        }
      }
    }
	}
    void PressSubmit()
    {
        if ((fuck * 100) + (shit * 10) + cunt == anotherfuckingvariable % 1000)
        {
            Debug.LogFormat("[Kilo Talk #{0}] You submitted {1}. Module disarmed.", moduleId, Idontfuckingknow);
            GetComponent<KMBombModule>().HandlePass();
            Audio.PlaySoundAtTransform("Kachow", transform);
            Fatasses[0].text = "4";
            Fatasses[1].text = "2";
            Fatasses[2].text = "0";
            Fatass.text = "Kilo Talk";
            //return null;
        }
        else
        {
            Debug.LogFormat("[Kilo Talk #{0}] You submitted {1}. Strike, weed eater.", moduleId, (fuck * 100) + (shit * 10) + cunt);
            GetComponent<KMBombModule>().HandleStrike();
        }
    }































































































































































































































































































    //Twitch Plays
    #pragma warning disable 414
    private readonly string TwitchHelpMessage = @"Use !{0} submit 420 to submit 420 as the answer.";
    #pragma warning restore 414
    IEnumerator ProcessTwitchCommand(string fuckme) {
        fuckme = fuckme.ToLowerInvariant().Trim();
        Match m = Regex.Match(fuckme, @"submit (\d{3})");
        if (m.Success)
        {
            char[] crap = m.Groups[1].Value.ToCharArray();
            //((fuck * 100) + (shit * 10) + cunt == anotherfuckingvariable % 1000)
            yield return null;
            while (fuck != (crap[0] - '0')){
                yield return "trycancel";
                Displays[0].OnInteract();
                yield return new WaitForSeconds(.1f);
            }
            while (shit != (crap[1] - '0')){
                yield return "trycancel";
                Displays[1].OnInteract();
                yield return new WaitForSeconds(.1f);
            }
            while (cunt != (crap[2] - '0')){
                yield return "trycancel";
                Displays[2].OnInteract();
                yield return new WaitForSeconds(.1f);
            }
            Submit.OnInteract();
            yield return new WaitForSeconds(.1f);
        }
        else
            yield return "sendtochaterror Valid command is submit. Use !{1} help to see full command.";
        yield break;
    }
    IEnumerator TwitchHandleForcedSolve(){
        var crab = (anotherfuckingvariable % 1000).ToString();
        while (crab.Length < 3)
            crab = "0" + crab;
        yield return ProcessTwitchCommand("submit " + crab);
    }
}
