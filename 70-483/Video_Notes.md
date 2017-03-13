
Notes from:
https://www.youtube.com/watch?v=Ii6ucNLdtC4

Look up new item types at Microsoft Learning site.

40-60 questions

1-4 hours to complete exam

Can review questions

Cannot move between case studies

700 is passing

### Interpret questions

Business problem
Goal Statement
One or Multiple Correct Answers
Multiple Distracters

## Study Resources
Microsoft 70-483 exam site.
### Skills Measured
Broken down by percentage
### Preparation Options
Instructor-led training
Exam prep video  
Community Links

Microsoft Virtual Academy
## Manage Program Flow
### Task Paralell Library
~~ParallelFor~~
PLINQ
Tasks
### Async/Await keywords
--anything run in await is run in a Task.Continuef()
Task.Run(delegate) == Task.Factory.StartNew<T>(delegate)
Task.Wait() == wait on multiple tasks at the same time. If you put in awaits in tasks you're still waiting on one task to finish before starting the other.
Task.Factory.StartNew().Unwrap(); does the same as Task.Run();
### Concurrent Collections
ConcurrentBag
ConcurrentDictionary
ConccurrentQueue
BlockingCollection
### Cancelation Tokens
CancellationTokenSource, CancellationToken
Passing into Task
Cancelling a Task
### Locks
### Thread-safe methods
~~### Control Statements~~
~~if/else~~
~~while~~
~~do/while~~
~~switch~~
~~for~~
~~foreach~~
~~break~~
~~continue~~
~~Goto~~
~~yield~~

~~yield break~~
~~yield continue~~

~~Enumerable.Range(int,int);~~
### Delegates
~~Func<T,U>~~
~~Action<T>~~
Comparison<T>
COmparison<T,U>
Predicate<T>
EventHandler<T>
~~### Lambda expression~~
~~### Anonymous Methods~~
~~### Subscribing/Unsubscribing from event~~
~~### Example Questions~~
~~Try statement, want new of the same error thrown. Which statement?~~
~~A. catch(Exception e) {throw new Exception(e); }  --- Will change the call stack~~
~~B. catch(Execption) {throw;}  ~~
~~C. catch(Exception e) {throw e;}  --- Clear the call stack~~
~~D. catch(Exception) {throw new Exception;} ---Waste of time.~~
~~Answer B~~
## Create and Use Types
### Value Types
Structs
Enum
change backing field for enum | enum newenum : long
### Reference Types
### Generics
### Methods
~~Optional Parameters~~
~~o is optional because it's already definied.~~

~~public void method(int i, int j, int o = 3)~~

~~Named Parameters~~
~~Can use paramters out of order.~~
~~public void method (parametername1: 1, paramatername2: 5)~~
Parameter Attributes
Pass by Refernce vs. Value
~~### Static Extension Methods~~
~~By using this as a parameter it turns the object into the object passed as left. In this case an int. So you can now call any int with .Add(int) to add that int.~~

~~void Main()~~
~~{~~
	~~3.Add(4)~~
~~}~~
~~public static class extmethod {~~
	~~public static int Add(this int left, int right){~~
		~~return left + right~~
	~~}~~
~~}~~

~~### Indexers~~
~~### Static Variables~~
~~### Overloaded/Overriden Members~~
### IDisposable
Use best practice. Look it up on MSDN library.
### Finalization
### Unmanaged Resources
### Garbage Collection
~~### Interfaces~~
~~Member signatures~~
### Base classes
Abstract base classes
virtual memebers
abstract memebers
### Existing Interfaces
IComparable
IEnumerable
IDisposable
IUnknown
### Example Question
Combine a bunch of text. Best way?
A. String append operator +=
B. String concatenation
C. StringBuilder class
D. StringWriter class
Answer C
## Debug Applications and Implement Security
### Asemmetric
RSACryptoServerProvider (RSA alcorithm)
Public and Private Keys
### Symmetric
CryptoStream
RijandaelManaged (Rijndael algorithm)
### Hashing Data
MD5CryptoServerProvider (MD5 Hash)
Hash + Salt Data
### System.Diagnostic.Trace
TraceListerners
Information, Warning, Error
### Profiling
### Performance Counters
### Systrem.Diagnostic.EventLog
### Debugging
### Compiler Directives
### Build Types
Debug, Release
### Versioning Assemblies
### Signing Assemblies using Strong Names
create a new windows app look at SNK file.
### Example Question
Guy gives you password, must hash and salt can't expose provided password. What classes can be used to encrypt provided password at login?
A. SHA1CryptoServiceProvider   --- Technically yes, but not actual.
B. RSACryptoServiceProvider 
C. TripleDESCryptoServiceProvider
D. MD5CryptoServiceProvider  --- Official answer
Answer D
## Implement Data Access
### Working with Files
File.ReadAllLines, File.ReadLine
File.WriteAllLines
### Streams
CryptoStream
FileStream
MemoryStream
### System.Net
WebRequest, WebResponse
HttpWebRequest, HttpWebResponse
### LINQ to XML
XDocument.Load
XElement
XAttribute
### Classic
XmlReader, XmlTextReader
XmlWriter
XmlNavigator
### Binary Serialization
### Custom Serialization
### XML Serialization
### Data Contract Serializer
### Data Contract JSON Serializer
## LINQ
### Operators
Projection
Join
Group
Take
Skip
Aggregate
### Writing LINQ extension method
### Query Syntax vs Lambda Syntax
### Deferred Query Execution
Number 1 trip up
IQuerableProvideable
LINQToEntity
### Generic COllection
Dictionary <T,U>
List<T>
Queue<T>
SortedList<T,U>
Stack<T>
### ArrayList
### Hashtable
### Queue
### Stack
### Example Question
Deserialize JSON strings to pre-defined type. Which class?
A. XmlObjectSerializer
B. DataContractSerializer
C. DataContractJsonSerializer
D. SoapFormatter
Answer C

```C#
int[] values = {1,3,5,7,9}; int threshold = 6;
var highValues = from v in values where v >= threshold select v;
threshold = 3;
var results = highValues.ToList();
```
Result?
A. {3,5,7,9}
B. {7,9}
C. {1,3,5,7,9}
D. {5,7,9}
Answer A

ToList() calls the enumeration creating the execution. Threshold was changed to 3 before execution of LINQ query.