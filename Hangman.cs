using System;
using System.Collections.Generic;
class Program {

  static void Play(string roll, int tries, string progress, List<char> used){
    try{
      while(roll != progress && tries > 0){
        char guess = char.Parse(Console.ReadLine().ToLower());
        if(used.Contains(guess)){
          Console.WriteLine("Already used that letter\n{0}", progress);
          continue;
        }
        used.Add(guess);
        if(roll.Contains(guess.ToString())){
          for(int i = 0; i < roll.Length; i++){
            if(roll[i] == guess){
              progress = progress.Remove(i, 1).Insert(i, guess.ToString());
            }
          }
          Console.WriteLine("Correct! You still have {0} tries left \n{1}", tries, progress);
        }
        else{
          tries--;
          if(tries == 0){
          Console.WriteLine("Wrong, you have no more tries left");
          }
          else{
          Console.WriteLine("Wrong, you have {0} tries left \n{1}", tries, progress);
          }
        }
      }
      Console.WriteLine(roll == progress ? "You win!" : "You lose, the world was \"{0}\"", roll);
      Console.Write("Press any key to exit...");
      Console.ReadLine();
    }
    catch (System.Exception)
    {
      Console.WriteLine("Use single letters please\n{0}", progress);
      Play(roll, tries, progress, used);
    }
  }
  static void Main() {
    List<char> used = new List<char>();
    string[] words = {"abruptly", "absurd", "abyss", "affix", "askew", "avenue", "awkward", "axiom", "azure", "bagpipes", "bandwagon", "banjo", "bayou", "beekeeper", "bikini", "blitz", "blizzard", "boggle", "bookworm", "boxcar", "boxful", "buckaroo", "buffalo", "buffoon", "buxom", "buzzard", "buzzing", "buzzwords", "caliph", "cobweb", "cockiness", "croquet", "crypt", "curacao", "cycle", "daiquiri", "dirndl", "disavow", "dizzying", "duplex", "dwarves", "embezzle", "equip", "espionage", "euouae", "exodus", "faking", "fishhook", "fixable", "fjord", "flapjack", "flopping", "fluffiness", "flyby", "foxglove", "frazzled", "frizzled", "fuchsia", "funny", "gabby", "galaxy", "galvanize", "gazebo", "giaour", "gizmo", "glowworm", "glyph", "gnarly", "gnostic", "gossip", "grogginess", "haiku", "haphazard", "hyphen", "iatrogenic", "icebox", "injury", "ivory", "ivy", "jackpot", "jaundice", "jawbreaker", "jaywalk", "jazziest", "jazzy", "jelly", "jigsaw", "jinx", "jiujitsu", "jockey", "jogging", "joking", "jovial", "joyful", "juicy", "jukebox", "jumbo", "kayak", "kazoo", "keyhole", "khaki", "kilobyte", "kiosk", "kitsch", "kiwifruit", "klutz", "knapsack", "larynx", "lengths", "lucky", "luxury", "lymph", "marquis", "matrix", "megahertz", "microwave", "mnemonic", "mystify", "naphtha", "nightclub", "nowadays", "numbskull", "nymph", "onyx", "ovary", "oxidize", "oxygen", "pajama", "peekaboo", "phlegm", "pixel", "pizazz", "pneumonia", "polka", "pshaw", "psyche", "puppy", "puzzling", "quartz", "queue", "quips", "quixotic", "quiz", "quizzes", "quorum", "razzmatazz", "rhubarb", "rhythm", "rickshaw", "schnapps", "scratch", "shiv", "snazzy", "sphinx", "spritz", "squawk", "staff", "strength", "strengths", "stretch", "stronghold", "stymied", "subway", "swivel", "syndrome", "thriftless", "thumbscrew", "topaz", "transcript", "transgress", "transplant", "triphthong", "twelfth", "twelfths", "unknown", "unworthy", "unzip", "uptown", "vaporize", "vixen", "vodka", "voodoo", "vortex", "voyeurism", "walkway", "waltz", "wave", "wavy", "waxy", "wellspring", "wheezy", "whiskey", "whizzing", "whomever", "wimpy", "witchcraft", "wizard", "woozy", "wristwatch", "wyvern", "xylophone", "yachtsman", "yippee", "yoked", "youthful", "yummy", "zephyr", "zigzag", "zigzagging", "zilch", "zipper", "zodiac", "zombie"};
    Random rnd = new Random();
    string roll = words[rnd.Next(words.Length)];

    Console.WriteLine("Guess a letter:");
    int tries = 10;

    string progress = "";
    for (int i = 0; i < roll.Length; i++)
    {
      progress += '*';
    }
    Console.WriteLine(progress);
    Play(roll, tries, progress, used);
  }
}