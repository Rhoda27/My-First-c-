// See https://aka.ms/new-console-template for more information

//object methods
class keke
{
  string color;
  int maxSpeed;
  public void fullthrottle()
  {
    Console.WriteLine("the car");
  }  
  static void kekes(string[] args) 
  {
    keke myObj = new keke();
    myObj.fullthrottle();
  }
}

//field


class bus
{
    string color;
    int maxSpeed;
    static void buss(string[]args)
    {
        bus myObj = new bus();
        myObj.color = "red";
        myObj.maxSpeed = 200;
        Console.WriteLine(myObj.color);
        Console.WriteLine(myObj.maxSpeed);
    }
}

//class menbers
class myClass
{
    string color = "red";
    int maxSpeed = 200;
    public void fullthrottle()
    {
        Console.WriteLine("the car ");
    }
}

//  class and objects
class car
{
    string color = "red";
    static void cass(string[]args)
    {
       car myObj= new car();
       Console.WriteLine(myObj.color);
    }
}

//method overloading

Console.WriteLine("method overloading");

static int plusMethodint(int x, int y){
    return x+ y;
}
static double plusMethoddouble(double x, double y){
    return x + y;
}
static void plus(string[]args){
    int myNum1 = plusMethodint(8,5);
    double myNum2 = plusMethoddouble(3.5,6.7);
    Console.WriteLine("int:" + myNum1);
    Console.WriteLine("double:" + myNum2);
}

//named arguments

Console.WriteLine("named argument");
static void root(string child1){
    Console.WriteLine(child1);
}
static void roots(string[]args){
    root(child1:"john");
}

//return

Console.WriteLine("return");
static int methods(int x){
    return 5 + x;
}
static void Main(string[]args){
    Console.WriteLine(methods(3));
}

//method  two parameters

Console.WriteLine("method two parameters");
static int method(int x , int y){
    return x + y;
}
static void Mains(string[]args){
    Console.WriteLine(method(5,3));
}

//defualt parameter value

Console.WriteLine("default parameter value");
static void myMethods(string country = "norway"){
    Console.WriteLine(country);
}
static void mainss(string[]args){
    myMethods("sweden");
    myMethods("india");
    myMethods();
    myMethods("USA");
}

//parameter and agruments, mutiple agrument

Console.WriteLine("parameter and agruments,");
static void myMethod(string Fname){
    Console.WriteLine(Fname + "is");
}
static void main(string[]args){
    myMethod("liam");
    myMethod("jenny");
    myMethod("anja");
}

//call a method

Console.WriteLine("call a method");
static void MyMethod(){
    Console.WriteLine("i just got");
}
static void mains(String[]args){
    MyMethod();
}

//Loop through a 2D array

Console.WriteLine("loop through a 2D array");
int[,]numberss = {{1,4,3},{3,6,5}};
foreach (int l in numberss)
{
    Console.WriteLine(l);
}

//access element of 2D array

Console.WriteLine("access element of 2D array");
int [,]nums = {{1,4,2},{3,5,6}};
Console.WriteLine(nums[0,2]);

//Two dimensional

Console.WriteLine("two dimensional");
int[,]num ={{1,4,2},{3,5,6}};

//array $ sort

Console.WriteLine("array $ sort");
string[] cars = {"BMW","ford","mazda"};
Array.Sort(cars);

//break and continue

Console.WriteLine("break and contiune");
for(int e = 3; e < 7; e++){
    if(e==6){
        break;
    }
    Console.WriteLine(e);
}

//foreach loop

Console.WriteLine("foreach loop");
string[] car ={"BMW, TOTAL,FORD,MAZDA"};
foreach(string c in car){
    Console.WriteLine(c);
}

//nested for loop

Console.WriteLine("nested for loop");
for(int t = 1; t < 3; t++){
    Console.WriteLine(t);
    for(int j = 1; j < 2; j++){
        Console.WriteLine(j);
    }
}

//for loop

Console.WriteLine("for loop");
for(int m = 2; m < 5; m++){
    Console.WriteLine(m);
}

//do loop

Console.WriteLine("do loop");
int k = 0;
do{
    Console.WriteLine(k);
    k++;
}
while (k < 5);

//while loop

Console.WriteLine("wlile loop");
int  i = 1;
while (i < 9)
{
 Console.WriteLine(i);
 i++;
}

// my while loop

Console.WriteLine("wlile loop");
int  q = 0;
while (q < 5)
{
 Console.WriteLine(i);
 q++;
}

//switch
Console.WriteLine("switch");
int Day = 4;
switch (Day)
{
    case 1:
    Console.WriteLine("monday");
    break;
    
    case 2:
    Console.WriteLine("wednesday");
    break;

    case 3:
    Console.WriteLine("thursday");
    break;

    case 4:
    Console.WriteLine("friday");
    break;
}
 
 //my switch
 Console.WriteLine("switch");
int day = 3;
switch (day)
{
    case 1:
    Console.WriteLine("monday");
    break;
    
    case 2:
    Console.WriteLine("wednesday");
    break;

    case 3:
    Console.WriteLine("thursday");
    break;

    case 4:
    Console.WriteLine("friday");
    break;
}

//short hand if...else
Console.WriteLine("short hand if...else");
int Time = 20;
string result = (Time < 18) ? "Good day." : "Good Evening.";
Console.WriteLine(result);

//my short hand if...else
Console.WriteLine("my short hand if...else");
int Times = 20;
string results = (Times < 18) ? "Good day." : "Good Evening.";
Console.WriteLine(results);

//the if else statement
Console.WriteLine("the if else statement");
int tims = 22;
if (tims < 10 )
{
    Console.WriteLine("Good Morning.");
}
else if (tims < 20)
{
    Console.WriteLine("Good Day.");
}
else
{
    Console.WriteLine("Good Evening.");
}

//my if else statement
Console.WriteLine("my if else statement");
int tim = 22;
if (tim < 10 )
{
    Console.WriteLine("Good Morning.");
}
else if (tims < 20)
{
    Console.WriteLine("Good Day.");
}
else
{
    Console.WriteLine("Good Evening.");
}

//else
Console.WriteLine("else");
int time = 20;
if (time < 18)
{
    Console.WriteLine("Good Day.");
}
else
{
    Console.WriteLine("Good Evening.");
}

// my else
Console.WriteLine("my else");
int times = 20;
if (times < 18)
{
    Console.WriteLine("Good Day.");
}
else
{
    Console.WriteLine("Good Evening.");
}

//if 
Console.WriteLine("if");
if (20 > 18)
{
    Console.WriteLine("20 is greater than 18");
}

int X = 20;
int Y = 18;
if (X > Y)
{
    Console.WriteLine("x is greater than y");
}

// my if 
Console.WriteLine("my if");
if (20 > 18)
{
    Console.WriteLine("20 is greater than 18");
}

int B = 20;
int A = 18;
if (A > B)
{
    Console.WriteLine("x is greater than y");
}

//boolean values
Console.WriteLine("boolean values");
bool isCsharpfun = true;
bool isFishTasty = false;
Console.WriteLine(isCsharpfun);
Console.WriteLine(isFishTasty);

//boolean values
Console.WriteLine("my boolean values");
bool isCsharp = true;
bool isFish = false;
Console.WriteLine(isCsharp);
Console.WriteLine(isFish);

//special characters
Console.WriteLine("special characters");
string special = "we are the so-called \"vikings\" from the north";
string specials = " it\'s alright.";
Console.WriteLine(special);
Console.WriteLine(specials);
//my special characters
Console.WriteLine("my special characters");
string speci = "we are the so-called \"vikings\" from the north";
string specis = " it\'s alright.";
Console.WriteLine(speci);
Console.WriteLine(specis);

//index
Console.WriteLine("index");
string full = "john Doe";
int charPos = full.IndexOf("D");
string last = full.Substring(charPos);
Console.WriteLine(last);

//my index 
Console.WriteLine("my index");
string fulls ="ken sam";
int charPo = fulls.IndexOf("e");
string lasts = fulls.Substring(charPo);
Console.WriteLine(lasts);

//access string
Console.WriteLine("access string");
string myString = "hello";
Console.WriteLine(myString[0]);

//my accsse string
Console.WriteLine("my access string");
string myStrings = "hello";
Console.WriteLine(myStrings[2]);

//string interpolation
Console.WriteLine("string interplation");
string nName = "john";
string nNames = "Doe";
string nem = $"my full name is : {nName} {nNames}";
Console.WriteLine(nem);

// my string interpolation
Console.WriteLine("my string interplation");
string nNam = "ken";
string nNams = "sam";
string news = $"my full name is : {nNam} {nNams}";
Console.WriteLine(news);

//Concatenation
Console.WriteLine("concatenation");
string Pname = "ruth";
string lname ="likita";
string fname = string.Concat(Pname, lname);
Console.WriteLine(fname);

//my concatenation
Console.WriteLine("my concatenation");
string pName = "moses";
string lName = "gimba";
string fName = string.Concat(pName,lName);
Console.WriteLine(fName);

//other methods
Console.WriteLine("other method");
string txts = "hello world";
Console.WriteLine(txts.ToUpper());
Console.WriteLine(txts.ToLower());
//My other merthod
Console.WriteLine("my other method");
string texts = "hello world";
Console.WriteLine(texts.ToUpper());
Console.WriteLine(texts.ToLower());
//STRING LENGTH
Console.WriteLine("string length");
string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("The length of the txt string is:" + txt.Length);

//my string length
Console.WriteLine("my string length");
string text ="abcdefghijkmnopqrstuvwxyz";
Console.WriteLine("the length of the text string is:" + text.Length);


//user input
Console.WriteLine("user input");
Console.WriteLine("Enter username");
string username = Console.ReadLine();
Console.WriteLine("username is" + username);

Console.WriteLine("Enter age");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("AGE is" + age);

//my user input
Console.WriteLine("MY user input");
Console.WriteLine("Enter username");
string userName = Console.ReadLine();
Console.WriteLine("username is " + userName);

Console.WriteLine("Enter age");
int Age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("AGE is" + Age);


// conversion method

Console.WriteLine("conversion method");
int myINT = 10;
double myDuble = 5.25;
bool myBol = true;

Console.WriteLine(Convert.ToString(myINT));
Console.WriteLine(Convert.ToString(myDuble));
Console.WriteLine(Convert.ToString(myINT));
Console.WriteLine(Convert.ToString(myBol));

// conversion method

Console.WriteLine("my conversion method");
int myINTs = 10;
double myDubles = 5.25;
bool myBols = true;

Console.WriteLine(Convert.ToString(myINTs));
Console.WriteLine(Convert.ToString(myDubles));
Console.WriteLine(Convert.ToString(myINTs));
Console.WriteLine(Convert.ToString(myBols));

//implicit casting
Console.WriteLine("Implicit casting");
int myInt = 9;
double myDoubl = myInt;
Console.WriteLine(myInt);
Console.WriteLine(myDoubl);

//explicit casting
Console.WriteLine("explicit casting");
double myDoub = 9.78;
int myIn = (int) myDoub;
Console.WriteLine(myDoub);
Console.WriteLine(myIn); 

//my implicit casting
Console.WriteLine("my Implicit casting");
int myInts = 7;
double myDoubles = myInts;
Console.WriteLine(myInts);
Console.WriteLine(myDoubles);

//my  explicit casting
Console.WriteLine("my explicit casting");
double myDoubls =4.69;
int myIns = (int) myDoubls;
Console.WriteLine(myIns);
Console.WriteLine(myDoubls);

//multiple Variables
Console.WriteLine("multiple variables");
int h = 5, v = 6, n = 50;
Console.WriteLine(h + v + n);

//My multiple Variables
Console.WriteLine("my multiple variable");
int d = 5, f = 3, r = 20;
Console.WriteLine(d + f + r);


//display variables
Console.WriteLine("Display variables");
string firstNames = "john";
string lastNames = "Doe";
string fullNames = firstNames + lastNames;
Console.WriteLine("Hello" + fullNames);

int x = 5;
int y = 6;
Console.WriteLine(x + y);

//my display variables
Console.WriteLine("My display variables");
string Names = "james";
string lastName = "john";
string FULL= Names + lastName; 
Console.WriteLine("Hello" + FULL); 

int a = 6;
int b = 8;
Console.WriteLine(a + b);


// variables
Console.WriteLine("variable");

string name = "john";
Console.WriteLine(name);

int myNum = 15;
Console.WriteLine(myNum);

double myDoubleNum = 5.99;
Console.WriteLine(myDoubleNum);

char myLetter = 'D';
Console.WriteLine(myLetter);

bool myBool = true;
Console.WriteLine(myBool);
// My variables
Console.WriteLine("My variable");
string Name = "james";
Console.WriteLine(Name);

int myNumb = 20;
Console.WriteLine(myNumb);

double myDouble = 4.66;
Console.WriteLine(myDouble);

char myLetters = 'R';
Console.WriteLine(myLetters);

bool myBools = false;
Console.WriteLine(myBools);
 
//output
Console.WriteLine("output");
Console.WriteLine("Hello World");
Console.WriteLine("I am Learning C#");
Console.WriteLine("It is awsome!");
// My output
Console.WriteLine("my output");
Console.WriteLine("My first c# code");
Console.WriteLine("output");

//Console.WriteLine("addition");
Console.WriteLine(2+3);

Console.WriteLine("division");
Console.WriteLine(2/9);

Console.WriteLine("multiplication");
Console.WriteLine(20*9);

Console.WriteLine("modulus");
Console.WriteLine(2%60);

Console.WriteLine("subtraction");
Console.WriteLine(40-3);

Console.WriteLine("it returns the square root numbers");
Console.WriteLine(Math.Sqrt(10));
Console.WriteLine("it returns the positive numbers");
Console.WriteLine(Math.Abs(10));
Console.WriteLine("it returns the smaller numbers");
Console.WriteLine(Math.Min(2, 10));
Console.WriteLine( "it returns the larger numbers");
Console.WriteLine(Math.Max(2, 10));