// Collections
//Arrays!
//Fixed signs and of a particular type
//indexed at 0, meaning numbered starting with 0

var students = new string[13]; // this creates an empty array with five slots to fill.
//variable = new type[length]; -> generic template
var instructors = new string[] { "Davis", "Gavin", "El", "Rickie", "Cliff" };
//because there are five things listed. the arrays are 5
//variable = new type[]{comma seperated values};
//an arrays length and type cannot change. period..

//change the value ar a slow in an array
//name = value;
//array[index] = value;
students[7] = "Ashley";
// student at index seven is updated to say "Ashley"
//student at index seven is not the seventh student -> 8th student
// 0 1 2 3 4 5 6 7
//first thing in list -> array[0]
//last thing in list -> array[array.Length -1]
Console.WriteLine(students.Length); // print the number of slots that the array has.
Console.WriteLine(students[7]); //-> prints the name

//Lists
// Dynamic size, still must be of one type
//indexed at 0, similar to arrays
var groceries = new List<string>();  //setting up the list, starting with no values within, its count is 0
groceries.Add("Pizza"); //our list contains one item, (pizza index = 0)
groceries.Add("Bananas"); // our list contains 2 items (banana has an index of 1)
groceries.Add("Grapes"); // index 2
groceries.Add("Potatoes"); // index 3
Console.WriteLine(groceries[0]);

//Remove items from an array
//list.Remove(item to remove);
groceries.Remove("Bananas");
Console.WriteLine(groceries.Count);
Console.WriteLine(groceries[1]);
//RemoveAt -> give index to remove

//groceries.RemoveAt(1); // removes second item in list

groceries.Insert(1, "Bananas"); //shift items after this index up ny 1, adds bananas to list
Console.WriteLine(groceries.Count);
Console.WriteLine(groceries[1]);

// How Do We Print Out Lists??

//Foreach Loops
//Loops that run once time for each item in a collection
// rather than specifically having an index (i) like previous loops, we have an object that we can look at and engage with
// foreach(type item in collection){
// code to run on this item
//}

foreach(var grocery in instructors)
{
    Console.WriteLine(grocery);
}

// sometimes its nice to have access to the index of a particular item as well as the item itself. So we can replicate loop
// same example as above, but with a for loop"
// collections.Length if array, collection.Count if list
for ( var i = 0; i < instructors.Length; i++)
{
    Console.WriteLine(instructors[i]);
}
// instructors[i] in a forloop is the same as a var instructir in a foreach loop

//Dictionaires
//collectiond of key value pairs
//keys - how we access elements
//values - the value we get in return

var weather = new Dictionary<string, float>();
weather["Atlanta"] = 82.3f; //key is atlanta, and the value is 82.3f
weather["Cleveland"] = 71f;
Console.WriteLine(weather["Atlanta"]); // accessing the value at "atlanta"

Console.WriteLine(weather.Count);

//report is a keyvaluepair object, meaning we have acces to both the keys and values as we go through each item in our weather dictionary.
foreach( var report in weather)
{
    Console.WriteLine(report);
}
