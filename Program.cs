using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};
RandomizeAnimals();

//three visiting schools
string[,] schools = 
{
{"School A", "6"},{"School B", "3"} , {"School C", "2"}
};

//Randomize the animals
string RandomizeAnimals()
{
    Random random = new Random();
    int randomIndex = random.Next(0, pettingZoo.Length);
    int i = 0;
   while (i <= 6)
   {

   }
}
//Assign the animals to the correct number of groups

//Print the school name

//pring the animal groups
