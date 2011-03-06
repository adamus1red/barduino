/************************************************
* Method enumerator
************************************************/
enum MethodList
{
  PUMP
  // TODO: include more methods
};

/************************************************
* Digital I/O pins that correspond to the pumps
************************************************/
const int pump1 = 1;
const int pump2 = 2;
const int pump3 = 3;
const int pump4 = 4;
const int pump5 = 5;
const int pump6 = 6;
const int pump7 = 7;
const int pump8 = 8;

/************************************************
* Setup function
************************************************/
void setup()
{
  pinMode(pump1, OUTPUT); 
  pinMode(pump2, OUTPUT);
  pinMode(pump3, OUTPUT);
  pinMode(pump4, OUTPUT);
  pinMode(pump5, OUTPUT);
  pinMode(pump6, OUTPUT);
  pinMode(pump7, OUTPUT);
  pinMode(pump8, OUTPUT);
}

/************************************************
* Main loop
************************************************/
void loop()
{
 // TODO
 // 1. read data from ethernet
 // 2. parse command (that means we build an API)
 // 3. execute the command
}
