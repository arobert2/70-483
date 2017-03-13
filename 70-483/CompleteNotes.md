# 70-483 Complete Notes

<ol>
	<li>Task Parallel Library</li>
	<li>
		<ol>
			<li>ParallelFor</li>
			<li>PLINQ</li>
			<li>Tasks</li>
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

To create and run a task in one command use the Task.Run(() => DoSomething()); method.

## Parallel.For

System.Threading.Tasks
Parallel.For executes a for loop that runs each loop on a different thread.

How to use.
```C#
var r = Parallel.For(int start, int stop, (i, state) => {});
var r = Parallel.For(int start, int stop, (i) => {});
```

# PLINQ

## What is a Parallel Query










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