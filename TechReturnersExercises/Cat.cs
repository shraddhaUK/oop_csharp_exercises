
using System;
namespace TechReturners.Exercises
{

	public abstract class Cat : ICat
	{

	  public bool IsAsleep{get;set;}

	  public int AverageHeight{get;set;}
	
	  public String Setting{get;set;}
	 
	  public void GoToSleep(){
  
		 IsAsleep = true;
	  }
	 
	  public void WakeUp(){

		IsAsleep = false;
	  }

  
   //abstract behaviour for all cats
  //has eaten its food their reaction tends to differ between species 
  public abstract String Eat();

  //abstract behaviour for all cats
  //has eaten its food their actions they will do after eating
  public abstract String PostMealAction();
  
  }

  public class DomesticCat : Cat
	{
	
		public DomesticCat()
		{
			AverageHeight = 23;
			Setting = "domestic";
		}

		public override String Eat(){
			return "Purrrrrrr";
		}

		public override String PostMealAction()
		{
		
			return "Lick their Paw";
		
		}
	}

public class LionCat : Cat
	{

		public LionCat()
		{
			AverageHeight = 1100;
			Setting = "wild";
		}
 
	  public override String Eat(){
			return "Roar!!!!";
		}

		public  override String PostMealAction()
		{
		
			return "Will go to sleep";
		
		}
	}

 public class CheetahCat : Cat
	{

	
		public CheetahCat()
		{
			AverageHeight = 94;
			Setting = "wild";
		}
		public override String Eat(){
			return "Zzzzzzz";
		}

		public override String PostMealAction()
		{
		
			return "Go for Hunting Again";
		
		}
	}

}