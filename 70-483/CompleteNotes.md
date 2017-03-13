# 70-483 Complete Notes

<ol>
	<li><a href="#70-483-complete-notes">Task Parallel Library</a> <br>
		<ol>
			<li><a href="#creating-and-running-tasks-implicitly">Creating and Running Tasks Implicitly</a></li>
			<li><a href="#creating-and-running-tasks-explicitly">Creating and Running Tasks Explicitly</a></li>
			<li><a href="#parallelfor">ParallelFor</a></li>
			<li><a href="#plinq">PLINQ</a>
				<ol>
					<li><a href="#what-is-a-parallel-query">What is a Parallel Query</a></li>
				</ol>
			</li>
			<li><a href="#tasks">Tasks</a></li>
		</ol>
	</li>
	<li><a href="#control-statements">Control Statements</a>
		<ol>
			<li><a href="#ifelse">if/else</a></li>
			<li><a href="#while">while</a></li>
			<li><a href="#dowhile">do/while</a></li>
			<li><a href="#switch">switch</a></li>
			<li><a href="#for">for</a></li>
			<li><a href="#foreach">foreach</a></li>
			<li><a href="#break">break</a></li>
			<li><a href="#continue">continue</a></li>
			<li><a href="#goto">goto</a></li>
			<li><a href="#yield">yield</a></li>
			<li><a href="#yield-break-and-continue">yield break and continue</a></li>
			<li><a href="#enumerablerangeintint">Enumerable.Range(int,int)</a></li>
		</ol>
	</li>
	<li><A href="#events-and-delegates">Events and Delegates</a>
		<ol>
			<li><a href="#delegates">Delegates</a>
				<ol>
					<li><a href="#func">Func</a></li>
					<li><a href="#action">Action</a></li>
				</ol>
			</li>
			<li><a href="#lambda-expressionsanonymous-methods">Lambda Expressions/Anonymous Methods</a></li>
			<li><a href="#subscribingunsubscribing-from-events">Subscribing\Unsubscribing from events</a></li>
		</ol>
	</li>
	<li><a href="#methods">Methods</a>
		<ol>
			<li><a href="#optional-parameters">Optional Parameters</a></li>
			<li><a href="#named-parameters">Named Parameters</a></li>
		</ol>
	</li>
	<li><a href="#static-extension-methods">Static Extension Methods</a></li>
	<li><a href="#indexers">Indexers</a></li>
	<li><a href="#static-variables">Static Variables</a></li>
	<li><a href="#interfaces">Interfaces</a>
		<ol>
			<li><a href="#member-signatures">Member Signatures</a></li>
			<li><a href="#overloaded-members">Overloaded Members</a></li>
		</ol>
	</li>
	<li><a href="#base-classes">Base Classes</a>
		<ol>
			<li><a href="#abstract-base-classes">Abstract base Classes</a>
				<ol>
					<li><a href="#overridden members">Overridden Members</a></li>
				</ol>
			</li>
		</ol>
	</li>
</ol>

# Task Parallel Library

**Task Parallelilsm** - One or more independent tasks running concurrently.

Benefits of using Tasks: More efficient and more scalable use of system resources
						 More programmatic control than is possible with a thread or work item.

## Creating and Running Tasks Implicitly

Parallel.Invoke method is quick way to run a statement concurently. Pass an Action Delegate or anonymous method to start.
```C#
Parallel.Invoke(() => DoWork(), () => DoMoreWork());
```

## Creating and Running Tasks Explicitly

System.Threading.Tasks.Task are Tasks that do not return anything.
System.Threading.Tasks.Task<TResult> are Tasks that return a value.
Task.Status will return whether the Task has run or not.
Task.Status is returned as a TaskStatus enumeration.

Tasks are passed delegates to ecapsulate code.
Task.Wait() tells the program to wait for the task's complete before exiting.

```C#
using System;
using System.Threading;
using System.Threading.Tasks;

public class Examples
{
	public static void Main()
	{
		Thread.CurrentThread.Name = "Main";

		Task taskA = new Task(() => Console.WriteLine("hello from taskA"));
		taskA.Start();
	}
}
```
To create and run a task in one command use the Task.Run(() => DoSomething()); method.

## Parallel.For

System.Threading.Tasks
Parallel.For executes a for loop that runs each loop on a different thread.

How to use.
```C#
var r = Parallel.For(int start, int stop, (i, state) => {});
var r = Parallel.For(int start, int stop, (i) => {});
```

## PLINQ

#### What is a Parallel Query

## Tasks




# Control Statements

## if/else
**if/else** statements help with decision making in program flow. If something is satisified do this else, do this.
```C#
if(variable == 0)
	DoSomething();
else
	DoSomethingElse();
```

## while
**while** loop until an outcome is satisfied. Will not run if already satisfied.
```C#
while (checkvar != "STOP!")
{
	checkvar = DoSomething();
};
```

## do/while
**Do/While** Loop until an outcome is satisfied. Will run atleast once no matter the outcome.
```C#
do
{
	checkvar = DoSomething();
}while(checkvar != "STOP!");
```

## switch
**switch** Similar to if used to satisfy multiple outcomes cleanly. Has ability for default for unexpected value.
```C#
switch(varcheck)
{
	case "GO!":
		DoSomething();
		break;
	case "STOP!"
		DoSomethingElse();
		break;
	default:
		Console.WriteLine("UNEXPECTED RESULT");
		break;
}
```

## for
**for** loops are simple loops that will loop a set amount of times. loop.
```C#
for(int i = 0;i < 10;i++)
	DoSomething();

for(int i = 0; i < variable;i++)
	DoSomething();
```

## foreach
**foreach** loops through any object that inherites from the IEnumerable interface. These are collections of the same object type.
```C#
foreach(object o in objectcollection)
	DoSomething(o);
```
passes each object in objectcollection to the DoSomething(object o) method.

## break
**break** forces your program out of a loop. The following is common.
```C#
while(true)
{
	if(something == outcome)
		break;
}
```
this will continue to run until something and outcome equal the same.

## continue
**continue** allows the loop to continue.
```C#
while(true)
{
	if(something == outcome)
		continue;
	else
		break;
}
```
this will continue until something and outcome do not equal the same.

## goto
**goto** can be used to move the code between tagged areas. This is similar to basic and batch. Tagged areas are written as ```Label:``` 
```C#
Goto10:
	Console.WriteLine(""/Do you have an extra goto 10 line?"/ -Calculon");
goto Goto10;
```
You can also use them in switch statements
```C#
switch (integer)
{
	case 0:
		goto case 10:
		break;
	case 1:
		goto case 10:
		break;
	case 10:
		Console.WriteLine("An actual 10 line to goto.");
		break;
}
```

## yield
Returns enumerated objects. Everytime the method with the yield return is called it will return the next yield.
```C#
public int ReturnNum()
{
	yield return 1;
	yield return 2;
	yield return 3;
}
```
They can also be used for custom IEnumerable objects
```C#
class enumerableTest : IEnumerable
{
	public Enumerator GetEnumerator()
	{
		yield return 1;
		yield return 2;
		yield return 3;
		yield return 4;
	}
}
```
This can now be used in a foreach loop because of the IEnumerable interface and the implementation of the ```GetEnumerator()``` method.

## yield break and continue
**yield break** allows you to break a loop within your enumerator.
**yield continue** allows you to break a loop within an enumerator.

## Enumerable.Range(int,int)
Generates a quick enumerated set of integers between a set of numbers.

# Events and Delegates

## Delegates
Delegates hold methods as objects and allow you to invoke them at will.
```
public delegate void MyDelegate(string info);
public MyDelegate delegatehandler;

delegatehandler += MyNewMethod;

public void MyNewMethod(string info)
{
	Console.WriteLine(info);
}
```
Whenever the delegatehandler is called it will execute the method passed to the delegate.

### Func<T,U>
```Func``` is a generic delegate that takes and input and returns an output.
```C#
public class functest
{
	public Func<string, string> concatfunc;

	public functest()
	{
		concatfunc += concatmethod;
	}

	public void trigger()
	{
		string input = "First";
		string inputoutput = "Second"
		Console.WriteLine(concatfunc.Invoke(input, inputoutput));
		Console.WriteLine(inputoutput);
	}

	public string concatmethod (string s, out string s2)
	{
		s2 += s;
		return s + s2;
	}
}
```
This will output:
FirstSecond
SecondFirst
The last variable in Func is na out variable which means it updataes the variable a scope above that was passed to it.
It also returns a what ever type you have set.
The first call prints the return, but at the same time it updates inputoutput.
This allows the second console.writeline code to print SecondFirst instead of just Second.

### Action<t>
Action is like func except it doesn't return anything, not even with ```out``` parameters.
It can have a lot of input parameters though. Invoke the same way, don't expect any returns.

## lambda Expressions/Anonymous Methods
Lambda Expressions and Anonymous Methods are the same thing.
You can create a lambda expression with the operator ``=>``
You can use a lambda expression to define delegates, actions, funcs, events.
```C#
public class lambdatest
{
	//event that will hold our Lambda Expression
	public Action event lambdatestevent;

	//uses the lambda operator to create a get property.
	public int ANumber => 5;

	public lambdatest
	{
		lambdatestevent = () => {
			Console.WriteLine("This is from the lambda expression");
		};
	}
}
```
Whenever lambdatestevent is triggered it will run the lambda expression that is created on object instantiation.

## Subscribing\Unsubscriping from events
You can subscribe with += and unsubscribe with -=
```C#
public event action thisevent;

public void subscribe(Action act)
{
	thisevent += act;
}

public void unsubscribe(Action act)
{
	thisevent -= act;
}
```
The above code allows you to subscribe and unsubscribe Action delegates from events using the += and -= operators.
+= and -= actually access custom accessors available only to events ```add``` and ```remove```

You can subscribe more than one method to a event/delegate/generic delegate and they will execute in order.

# Methods
Methods are blocks of codes within a class or struct that execute on variables that are passed into them or local variables within the class.

## Optional Parameters
Optional Parameters are predefined parameters in a method. They must come at the end of all requires variables.
If they are not referenced in the call they will use the default value provided.
```C#
public void optionalexample(int i, int j, string optional = "optional"){ ... }

public void Main()
{
	//Don't have to declare'
	ExampleClass.optionalexample(1,2);
	//But can
	ExampleClass.optoinalexample(1,2,"not optional");
}
```
## Named Parameters
You can name parameters during instantiation. You can apply parameters in any order when doing so.
```C#
void method(int i, int j, int x) { ... }

void Main()
{
	method(j : 1, x :  5, i: 2);
}
```

# Static Extension Methods
You can extend objects by creating a static method that references it's first parameter with this
```C#
public static int Sigma(this int x)
{
	int newx = 0;
	for(int i = 0; i <= x; i++ )
		newx += x * i;
	return newx;
}

void Main()
{
	Console.WriteLine(5.Sigma());
	int sigmatest = 20;
	Console.WriteLine(sigmatest.Sigma());
}
```
Sigma is now a method available to all Integer type classes because the first parameter is this, refering to it's self as an int.

# Indexers
Anytime you reference information like this ```[]``` you are using an indexer.
You can add indexers to any objects.
```C#
public object this [int]
{
	get { return indexedobject[i]; }
    set { indexedobject[i] = value; }
}
```
The this command references the object this Property belongs to. This defines the [] part to this and defines how it functions.

# Static Variables
Static variables (and classes and methods) are instantiated on runtime. They are globally accessible. This is a great way for shared assets.
```C#
public class newobject
{
	private static _id = 0;
	public string ID {get;set;}

	public newobject()
	{
		ID = "REF" + _id;
		_id++;
	}
}
```
Above uses a ```static``` variable to assign an ID numbers. The ```_id``` variable will be the same across all ```newobject``` objects because it is declared static.
the ```_id++``` updates the variable so the next created ```newobject``` ID will be incremented by 1.

Static Variables can also be used to access information between objects and threads
```C#
public class StaticVariableAndMethod
{
	public static Dictionary<string, Queue<string>> taskqueue = new Dictionary<string, Queue<string>>();

	public static string CheckForUpdate(string idnum)
	{
		string nextcomm = taskqueue[idnum].Peak();
		taskqueue[idnum].dequeue();
		return nextcomm;
	}
}
```
The following block of code can be used to share messages for objects with particular idnumbers. 
Both the variable and the method can be access as:
```C#
//To access the static variable taskqueue;
StaticVariableAndMethod.taskqueue;
//To access the static method CheckForUpdate
StaticVariableAndMethod.CheckForUpdate(objectwithid.ID);
```
# Interfaces
Interfaces are a type of inheritable object. Public members are defined within an Interface but no code to execute.
Classes that inherit from an interface must implement each members of the interface publicly.
Interfaces are basically a contract in which you agree that a particular class will conform to.
The major use is polymorphism and satisfying the Liskov Substitution Principle from SOLID.
```C#
public interface IInterfeceTest
{
	int AnInteger { get; set; }
	int GetInteger();
}

public class newclass : IInterfaceTest
{
	int _aint = 0;
	public int AnInteger { get { return _aint; } set { _aint = value; } }

	public int GetInteger()
	{
		return _aint;
	}
}
```
You can inherit from as many interfaces as you need and it is recommended to split up interfaces into a small and few as possible. This is the Interface Segregation Principle of SOLID.
The above code confirms to the IInterfaceTest members. You can hold any child class in the object of it's interface
```C#
public class anotherclass : IInterfaceTest
{
	...
}

int Main()
{
	IInterfaceTest iit = new newclass();
	iit = new anotherclass();
}
```

## Member Signatures
The signature of a member is the name and any argumnents that can be provided.
```C#
public void method() { ... }
public void method(int i) { ... }
```
These are entirely differenty methods because their signature is different. Parameters are part of the signature. Their paremters are different. Therefore different method.
This can apply to constructors by name and parameters
Indexers by assigning different variables to index.
Opterators but that's not really important.

## Overloaded Members
An overloaded members is a member of an object that is named the same but have a different signature.
```C#
public void overload_method(int i) { ... }
public void overload_method(int i, int j) { ... }
```
Both methods above have the same name but are legal. overload_method is overloaded because when you accept different parameters the method has a different signature so it can exist on it's own.

# Base Classes

## Abstract base classes

### Overridden Members
Overriden Members are members of a class that are inherited and marked as ```abstract``` or ```virtual```
**virtual** - virtual denotes that a class can be overridden but is not required to be. This class can be fully defined.
**abstract** - abstract denotes that a class must be overridden. Abstract methods and properties are never defined and abstract classes cannot be instantiated.
```C#
public abstract class abstractexamples
{
	public void abstract runthis();

	public void virtual runthistoo()
	{
		Console.WriteLine("this is running")
	}
}

public class abstractinherit : abstractexamples
{
	public void override runthis()
	{
		Console.WriteLine("This is now a declared method.")
	}
}

int Main()
{
	abstractinherit ah = new abstractinherit();
	ah.runthis();
	ah.runthistoo();
}
```


# No Section Yet

# LINQ

Language-Integrated Query - LINQ - Introduced in .Net 3.5
Must be used against Strongly Typed collections
LINQ is a unified model for querying any IEnumerable or IEnumerable<T> in a safe manner.
LINQ to Objects is the name for LINQ queries in memory.

Can be used to query SQL Server, XML Documents, ADO.NET Datasets, IEnumerable or IEnumerable<T>.

## Basic LINQ Queries

Query is an expression that retieves data from a data source. LINQ simplifies queries between languages.

<ol>
	<il>Obtain the data source.</il>
	<il>Create the query.</il>
	<il>Execute the query.</il>
</ol>

### Query Example
Example calls an array which executes foreach to query the information.
Foreach can only be executed on objects that inherit from IEnumerable, Ienumerable<T>, IQueryable<T> or any derived interface.
Classes that inherit from those interfaces are called Queryable Types.
LINQ natively supports Queriable Types.

```C#
class foo
{
	static void main()
	{
		//1. The data source.
		int[] numbers = new int[7] {0,1,2,3,4,5,6}

		//2. Query creation
		var numQuery = from num in numbers
					   where (num & 2) == 0
					   select num;

		//3. Query Execution
		foreach(int num in numQuery)
			Console.Write("{0,1}", num);
	}
}
```
### Data Source
The above example is LINQ To Object against an array.

You can also use Linq to XML
```C#
//Data source
XElement xmldata = XElement.Load(@"C:\Path\To\File.xml");
```

LINQ to SQL requires an object-relational mappting at design time.
This can be done manually or by using hte Object Relational Designer.
You write your queries against objects and LINQ to SQL builds the objects from the database at runtime.

LINQ to SQL
The following assumes there is a table called customers imported to an object that holds the data called Northwnd db.
```C#
Northwnd db = new Northwnd(@"C:\northwnd.mdf");

// submit query
IQueryable<Customer> custQuery = from cust in db.Customers
								 where cust.City == "London"
								 select cust;
```
A LINQ data source is any object that inherits the generic IEnumerable<T> interface or any interface that derives from it.

### The Query
Queries are stored in a query variable and initialized with a query expression
The query doesn't actually run until the data is accessed.

## Deferred Execution
Query is not run until data is acessed
```C#
//The query
var result = from foo in bar
			 where (foo.foobar == true)
			 select foo;
//When the query is executed.
foreach(foo in result)
	DoSomething(foo);
```
Using IEnumerable properties like Count, Max, and Average run the query, but only return the value requested.
```C#
//returns the count, not the query, still runs query.
int count = Query.Count();
```
To force immediate execution you can always you can call ToList() or ToArray()
```C#
List<int> query1 = //or int[] query1
	(from num in numbers
	 where (num % 2) == 0
	 select num).ToList(); // or ToArray()
```
## LINQ and Generic Types

```C#
IEnumerable<Customer> query = //LINQ query...
```
Query returns a list of objects called customer.

Compiler can handle it with var
```C#
var query = //LINQ query...
```

## Basic LINQ Query Operations

### Documentation
<a href="https://msdn.microsoft.com/en-us/library/bb397927(v=vs.110).aspx">Microsoft Basic LINQ Query Operations</a>
<a href="https://msdn.microsoft.com/en-us/library/bb311040(v=vs.110).aspx">Microsoft Join clause documentation</a>

### Obtaining a Data Source
from defines the range variable (range of data)
in defines the data source
```C#
from cust in customers
```
Additional range variables can be added with the ```let``` clause.

### Filtering
Using the ```where``` clause allows you to specify content.
```C#
where cust.City == "London"
```
Using the and and or operators work just like c#
```C#
where cust.City == "London" && cust.Name == "Bob"
where cust.City == "London" || cust.Name == "Bob"
```

### Ordering
use the ```orderby``` clause to sort.
```
orderby cust.Name ascending
```

### Grouping
The ```group``` clause enables you to gorup your results based on a key that you specify.
example: group by city so all cities are in a group.
```C#
// queryCustomerByCity is an Ienumerable<IGrouping<string, Customer>>
var queryCustomerByCity =
	from cust in customers
	group cust by cust.City;

	foreach(var customerGroup in queryCustomerByCity)
	{
		Console.WriteLine(CustomerGroup.Key)
		foreach(Customer customer in customerGroup)
			Console.WriteLine("     {0}", customer.Name);
	}
```
When you use the ```group``` clause your reults take the form of a list of lists.
You must use a nested foreach to iterate these. Above

If you must refer to the result of a group operation you can use the into keyword to create an identify that can be queried further.

```C#
group cust by cust.City into custGroup
```

### Joining
Joining allows you to create associations between sequence that are not explicitly modeled in the data sources.
In LINQ ```join``` clause always works against object collections instead of database tables directly.
```C#
var innerJoinQuery =
	from cust in customers
	join dist in distributors on cust.City equals dist.City
	select new { CustomerName = cust.Name, DistributorName = dist.Name };
```

### Group Join
a ```join``` clause with an ```into``` clause

```C#
var innerGroupJoinQuery =
	from category in categories
	join prod in products on category.ID equals prod.CategoryID into prodGroup
	select new { CategoryName = category.Name, Products = prodGroup };
```

### Left Outer Join
Use the ```DefaultIfEmpty()``` method in combination with a group join
```C#
var leftOuterJoinQuery =
	from category in categories
	join prod in products on category.ID equals prod.CategoryID into prodGroup
	from item in prodGroup.DefaultIfEmpty(new Product { Name = String.Empty, CategoryID = 0 })
	select new { CatName = category.Name, ProdName = item.Name };
```

### The Equals Operator
A ```join``` clause performas an equijoin this means you can only base matches on the equality of two keys.
greater than and not equals are not supported
join uses ```equal``` to make sure there isn't confusion between other C# operators.

### Non-Equijoins
You can perform non-equijoins, cross joins,a nd other custom join operations by using the ```from``` clause

### Joins on object collections vs relation tables
join is only necessary when joining objects that are not modeled
LINQ to SQL stores the primary and seconadary key tables in the object

### Composite Keys
You can test for equality of multiple values by using a composite key.

## Data Transformation with LINQ
<a href="https://msdn.microsoft.com/en-us/library/bb397914(v=vs.110).aspx">Microsoft Data Transformations with LINQ Documentation</a>

Can transform data
<ul>
	<li>Merge multiple input sequences into a single output sequence that has a new type.</li>
	<li>Create output sequences whose elements consist of only one or several properties of each element in the source sequence.</il>
	<li>Create output sequences who elements conssit of the results of operations perform on the source data.</li>
	<li>Create output sequence in a different format. For example, you can transform data from SQL rows or test files into XML.</li>
</ul>

###Joining Multiple Inputs into One Output Sequence Example
```C#
//Data classes
class Student
{
	public string First { get; set; }
	public string Last { get; set; }
	public int ID { get; set; }
	public string Street { get; set; }
	public string City { get; set; }
	public List<int> Scores { get; set; }
}

class Teacher
{
    public string First { get; set; }
    public string Last { get; set; }
    public int ID { get; set; } 
    public string City { get; set; }
}

class DataTransformation
{
	static void Main()
	{
        // Create the first data source.
        List<Student> students = new List<Student>()
        {
            new Student {First="Svetlana",
                Last="Omelchenko", 
                ID=111, 
                Street="123 Main Street",
                City="Seattle",
                Scores= new List<int> {97, 92, 81, 60}},
            new Student {First="Claire",
                Last="O’Donnell", 
                ID=112,
                Street="124 Main Street",
                City="Redmond",
                Scores= new List<int> {75, 84, 91, 39}},
            new Student {First="Sven",
                Last="Mortensen",
                ID=113,
                Street="125 Main Street",
                City="Lake City",
                Scores= new List<int> {88, 94, 65, 91}},
        };

		 // Create the second data source.
        List<Teacher> teachers = new List<Teacher>()
        {                
            new Teacher {First="Ann", Last="Beebe", ID=945, City = "Seattle"},
            new Teacher {First="Alex", Last="Robinson", ID=956, City = "Redmond"},
            new Teacher {First="Michiyo", Last="Sato", ID=972, City = "Tacoma"}
        };

		var peopleInSeattle = (from student in students
								where student.City == "Seattle"
								select student.Last)
								.Concat(from teacher in teachers
										where teacher.City == "Seattle"
										select teacher.Last);

		//People in Seatle
		foreach(var person in peopleInSeatle)
			Console.WriteLine(person)
	}
}
```

### Selecting a Subset of each Source Element
```C#
var query = from cust in customers
			select cust.City;

var query = from cust in Customers
			select new {Name = cust.Name, City = cust.City};
```

### Transforming in-Memory Objects into XML
```C#
var studentsToXml = new XElement("Root",
	from student in students
	let x = String.Format("{0}, {1}, {2}, {3}", student.Scores[0],
			student.Scores[1], student.Scores[2], student.Scores[3])
	else new XElement("student",
			new XElement("first", student.First),
			new XElement("Last:, student.Last),
			new XElement("Scores", x)
	)
);
```

## Connect LINQ to a databse
create a connection in visual studio
reference it in code  
```
string connectString = System.Configuration.ConfigurationManager.ConnectionStrings["LinqToSQLDBConnectionString"].ToString();
LinqToSQLDataContext db = new LinqToSQLDataContext(connectString); 
```
Then use standard LINQ queries by referencing the ```LinqToSQLDataContext``` object.

# Example Questions

Try statement, want new of the same error thrown but no stack change. Which statement?  
A. catch(Exception e) { throw new Exception(e); }  --- Will change the call stack  
B. catch(Execption) { throw; }  
C. catch(Exception e) { throw e; }  --- Clear the call stack  
D. catch(Exception) { throw new Exception; } ---Waste of time.  
Answer B  