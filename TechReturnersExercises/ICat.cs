using System;

namespace TechReturners.Exercises
{
    public interface ICat
    {
	// A piece of data that says whether they are asleep or not 
	  bool IsAsleep{get;}
	 //An average height represented in centimetres
	  int AverageHeight{get;}
	 //A piece of data that indicates their setting such as "domestic" or "wild"
	  String Setting{get;}
	  void GoToSleep();
	  void WakeUp();
	  String Eat();
	  String PostMealAction();
    }
}
