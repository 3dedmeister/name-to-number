//int[] digits = [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 ];
//string[] letters = [ "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" ];
//My first idea was to use arrays, but I'll need more experience if I want to do it like this :(

Console.WriteLine("Enter the name you want to convert to a number:");

while (1 != 2)
//Allows you to convert multiple names in a row without rebooting the application each time
{
    string? name = Console.ReadLine();

    if (name == "EXIT") 
    {
        Environment.Exit(0);
    }

    string name2 = name!.ToLower();
    //Convert user input to lowercase, which halves the size of the else-if-monstrosity later since you don't have to check each letter twice anymore

    int value = 0;

    foreach (char c in name2)
    {
        if (c == 'a') { value += 1; }
        else if (c == 'b') { value += 2; }
        else if (c == 'c') { value += 3; }
        else if (c == 'd') { value += 4; }
        else if (c == 'e') { value += 5; }
        else if (c == 'f') { value += 6; }
        else if (c == 'g') { value += 7; }
        else if (c == 'h') { value += 8; }
        else if (c == 'i') { value += 9; }
        else if (c == 'j') { value += 10; }
        else if (c == 'k') { value += 11; }
        else if (c == 'l') { value += 12; }
        else if (c == 'm') { value += 13; }
        else if (c == 'n') { value += 14; }
        else if (c == 'o') { value += 15; }
        else if (c == 'p') { value += 16; }
        else if (c == 'q') { value += 17; }
        else if (c == 'r') { value += 18; }
        else if (c == 's') { value += 19; }
        else if (c == 't') { value += 20; }
        else if (c == 'u') { value += 21; }
        else if (c == 'v') { value += 22; }
        else if (c == 'w') { value += 23; }
        else if (c == 'x') { value += 24; }
        else if (c == 'y') { value += 25; }
        else if (c == 'z') { value += 26; }
    }
    //Since this code block only checks the English alphabet, all other "invalid" letters and symbols are automatically ignored

    Console.WriteLine($"The letters of the name you entered sum to {value}.\nTo convert another name, enter the name. To exit the application, enter \"EXIT\".\n");
}