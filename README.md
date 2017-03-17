# Index
1. [ 70-483 Complete Notes](#70-483-complete-notes)
1. [ Manage Program FLow](#manage-program-flow)
	1. [ Task Parallel Library](#task-parallel-library)
		1. [ Data Parallelism](#data-parallelism)
		1. [ Task Parallelism](#task-parallelism)
			1. [ Creating and Running Tasks Implicitly](#creating-and-running-tasks-implicitly)
			1. [ Creating and Running Tasks Explicitly](#creating-and-running-tasks-explicitly)
			1. [ Parallel.For](#parallelfor)
			1. [ Parallel.ForEach](#parallelforeach)
		1. [ Dataflow](#dataflow)
		1. [ PLINQ](#plinq)
			1. [ What is a Parallel Query](#what-is-a-parallel-query)
		1. [ Tasks and TaskFactories](#tasks-and-taskfactories)
			1. [ Task](#task)
			1. [ TaskFactory](#taskfactory)
	1. [ Locks, Deadlocks, and Race Conditions](#locks-deadlocks-and-race-conditions)
		1. [ Race Condition](#race-condition)
		1. [ Deadlocks](#deadlocks)
		1. [ lock](#lock)
	1. [ Async/Await Keywords](#asyncawait-keywords)
		1. [ Async Improves responsiveness](#async-improves-responsiveness)
		1. [ Async Methods are Easiere to Write](#async-methods-are-easiere-to-write)
			1. [ What makes an async method](#what-makes-an-async-method)
		1. [ Examples of API Async Methods](#examples-of-api-async-methods)
		1. [ Threads](#threads)
		1. [ async and await](#async-and-await)
		1. [ Return types](#return-types)
		1. [ Naming Convention](#naming-convention)
	1. [ Concurrent Collections](#concurrent-collections)
		1. [ IProducerConsumerCollection< T>](#iproducerconsumercollection-t)
		1. [ BlockingCollection< T>](#blockingcollection-t)
				1. [ Constructors  ](#constructors--)
			1. [ Properties  ](#properties--)
			1. [ Methods ](#methods-)
			1. [ Explicit Interface Implementations   ](#explicit-interface-implementations---)
		1. [ ConcurrentBag< T>](#concurrentbag-t)
		1. [ ConcurrentDictionary< T,U>](#concurrentdictionary-tu)
		1. [ ConcurrentQueue< T>](#concurrentqueue-t)
		1. [ ConcurrentStack< T>](#concurrentstack-t)
		1. [ OrderablePartitioner< TSource>](#orderablepartitioner-tsource)
			1. [ Constructors  ](#constructors--)
			1. [ Properties  ](#properties--)
			1. [ Methods  ](#methods--)
		1. [ Partitioner](#partitioner)
			1. [ Methods  ](#methods--)
		1. [ Partitioner< TSource>](#partitioner-tsource)
			1. [ Methods  ](#methods--)
	1. [ Cancellation Tokens](#cancellation-tokens)
		1. [ CancellationTokenSource](#cancellationtokensource)
			1. [ Constructors](#constructors)
			1. [ Properties](#properties)
			1. [ Methods](#methods)
		1. [ Example](#example)
	1. [ Control Statements](#control-statements)
		1. [ if/else](#ifelse)
		1. [ while](#while)
		1. [ do/while](#dowhile)
		1. [ switch](#switch)
		1. [ for](#for)
		1. [ foreach](#foreach)
		1. [ break](#break)
		1. [ continue](#continue)
		1. [ goto](#goto)
		1. [ yield](#yield)
		1. [ yield break and continue](#yield-break-and-continue)
		1. [ Enumerable.Range(int,int)](#enumerablerangeintint)
	1. [ Events and Delegates](#events-and-delegates)
		1. [ Delegates](#delegates)
			1. [ Func< T,U>](#func-tu)
			1. [ Action< t>](#action-t)
			1. [ Comparison< T>](#comparison-t)
			1. [ Predicate< T>](#predicate-t)
			1. [ EventHandler< TEventArgs>](#eventhandler-teventargs)
		1. [ lambda Expressions/Anonymous Methods](#lambda-expressionsanonymous-methods)
		1. [ Subscribing/Unsubscriping from events](#subscribingunsubscriping-from-events)
1. [ Create and Use Types](#create-and-use-types)
	1. [ Reference Types](#reference-types)
		1. [ class](#class)
		1. [ interface](#interface)
		1. [ delegate](#delegate)
		1. [ object](#object)
		1. [ string](#string)
		1. [ dynamic](#dynamic)
	1. [ Value Types](#value-types)
		1. [ struct](#struct)
		1. [ enum](#enum)
		1. [ Other Value Types](#other-value-types)
	1. [ Generics](#generics)
		1. [ Generic type parameters](#generic-type-parameters)
			1. [ Type Parameter Naming Guidlines](#type-parameter-naming-guidlines)
	1. [ Methods](#methods)
		1. [ Optional Parameters](#optional-parameters)
		1. [ Named Parameters](#named-parameters)
		1. [ Passing by Reference vs. Passing by Value](#passing-by-reference-vs-passing-by-value)
			1. [ Ref vs. Out](#ref-vs-out)
	1. [ Static Extension Methods](#static-extension-methods)
	1. [ Indexers](#indexers)
	1. [ Static Variables](#static-variables)
	1. [ Interfaces](#interfaces)
		1. [ Member Signatures](#member-signatures)
		1. [ Overloaded Members](#overloaded-members)
	1. [ Base Classes](#base-classes)
		1. [ Abstract base classes](#abstract-base-classes)
		1. [ Overridden Members](#overridden-members)
1. [ Debug Applications and Implementing Security](#debug-applications-and-implementing-security)
1. [ Implement Data Access](#implement-data-access)
	1. [ Working with files](#working-with-files)
		1. [ System.IO.File](#systemiofile)
			1. [ File.AppendAllLines](#fileappendalllines)
			1. [ File.AppendAllText](#fileappendalltext)
			1. [ File.AppendTest](#fileappendtest)
			1. [ File.Copy](#filecopy)
				1. [ overload methods  ](#overload-methods--)
				1. [ example](#example)
			1. [ File.Create](#filecreate)
			1. [ File.ReadAllLines()](#filereadalllines)
				1. [ example](#example)
			1. [ File.Decrypt(string)](#filedecryptstring)
				1. [ overload methods](#overload-methods)
				1. [ example](#example)
			1. [ File.Encrypt](#fileencrypt)
				1. [ overload methods](#overload-methods)
				1. [ example](#example)
			1. [ File.Delete](#filedelete)
				1. [ overload methods](#overload-methods)
				1. [ example](#example)
			1. [ File.Exists](#fileexists)
			1. [ File.GetAccessControl](#filegetaccesscontrol)
				1. [ overload methods](#overload-methods)
				1. [ example](#example)
			1. [ File.GetAttribute](#filegetattribute)
				1. [ overload methods](#overload-methods)
				1. [ example](#example)
			1. [ File.GetCreationTime](#filegetcreationtime)
			1. [ File.GetCreationTimeUtc](#filegetcreationtimeutc)
			1. [ File.GetLastAccessTime](#filegetlastaccesstime)
			1. [ File.GetLastAccessTimeUtc](#filegetlastaccesstimeutc)
			1. [ File.GetLastWriteTime](#filegetlastwritetime)
			1. [ File.GetLastWriteTimeUtc](#filegetlastwritetimeutc)
			1. [ File.Move](#filemove)
			1. [ File.Open](#fileopen)
				1. [ overload methods](#overload-methods)
				1. [ example](#example)
			1. [ File.ReadLine](#filereadline)
				1. [ overload methods](#overload-methods)
				1. [ examples](#examples)
			1. [ File.WriteAllLines](#filewritealllines)
				1. [ overload methods](#overload-methods)
				1. [example](#example)
		1. [ System.IO.FileMode](#systemiofilemode)
			1. [ Append](#append)
			1. [ Create ](#create-)
			1. [ CreateNew](#createnew)
			1. [ Open](#open)
			1. [ OpenOrCreate](#openorcreate)
			1. [ Truncate ](#truncate-)
		1. [ System.IO.FileAccess](#systemiofileaccess)
			1. [ Read](#read)
			1. [ Write](#write)
			1. [ ReadWrite](#readwrite)
		1. [ System.IO.FileShare](#systemiofileshare)
			1. [ Delete](#delete)
			1. [ Inheritable](#inheritable)
			1. [ None](#none)
			1. [ Read](#read)
			1. [ ReadWrite](#readwrite)
			1. [ Write](#write)
		1. [ System.IO.FileOptions](#systemiofileoptions)
			1. [ Asynchronous](#asynchronous)
			1. [ DeleteOnClose](#deleteonclose)
			1. [ Encrypted](#encrypted)
			1. [ None](#none)
			1. [ RandomAccess](#randomaccess)
			1. [ SequentialScan](#sequentialscan)
			1. [ WriteThrough](#writethrough)
	1. [ Streams](#streams)
		1. [ CryptoStream](#cryptostream)
		1. [ FileStream](#filestream)
			1. [ Constructors](#constructors)
		1. [ MemoryStream](#memorystream)
1. [ LINQ](#linq)
	1. [ Basic LINQ Queries](#basic-linq-queries)
		1. [ Query Example](#query-example)
		1. [ Data Source](#data-source)
		1. [ The Query](#the-query)
	1. [ Deferred Execution](#deferred-execution)
	1. [ LINQ and Generic Types](#linq-and-generic-types)
	1. [ Basic LINQ Query Operations](#basic-linq-query-operations)
		1. [ Documentation](#documentation)
		1. [ Obtaining a Data Source](#obtaining-a-data-source)
		1. [ Filtering](#filtering)
		1. [ Ordering](#ordering)
		1. [ Grouping](#grouping)
		1. [ Joining](#joining)
		1. [ Group Join](#group-join)
		1. [ Left Outer Join](#left-outer-join)
		1. [ The Equals Operator](#the-equals-operator)
		1. [ Non-Equijoins](#non-equijoins)
		1. [ Joins on object collections vs relation tables](#joins-on-object-collections-vs-relation-tables)
		1. [ Composite Keys](#composite-keys)
	1. [ Data Transformation with LINQ](#data-transformation-with-linq)
		1. [ Joining Multiple Inputs into One Output Sequence Example](#joining-multiple-inputs-into-one-output-sequence-example)
		1. [ Selecting a Subset of each Source Element](#selecting-a-subset-of-each-source-element)
		1. [ Transforming in-Memory Objects into XML](#transforming-in-memory-objects-into-xml)
	1. [ Connect LINQ to a databse](#connect-linq-to-a-databse)
	1. [ Generic Collections](#generic-collections)
		1. [ Dictionary< T,U>](#dictionary-tu)
		1. [ List< T>](#list-t)
		1. [ Queue< T>](#queue-t)
		1. [ SortedList< T,U>](#sortedlist-tu)
		1. [ Stack< T>](#stack-t)
1. [ Example Questions](#example-questions)

# 70-483 Complete Notes
[top](#index)  

# Manage Program FLow
[top](#index)  

## Task Parallel Library
[top](#index)  
```C#
System.Threading
```
```C#
System.Threading.Tasks
```

The purpose of the TPL is to make developers more productive by simplifying the process of adding parallelism and concurrency to applications.  
Scales processes to use the processor most efficiently.  

Benefits of using Tasks: More efficient and more scalable use of system resources  
						 More programmatic control than is possible with a thread or work item.  

### Data Parallelism
[top](#index)  
Data parallelism - The Scenario in which the same operation is performed concurrently on elements in a source collection or array.  
Portions of the collections are segregated off so each thread can access it without disturbing the others.

Part of ```System.Threading.Tasks.Parallel```
```Parallel.For``` and ```Parallel.ForEach``` handle data parallelism.

### Task Parallelism
[top](#index)  
The TPL is based on the concept of a task, which represents an asynchonous operation.  
A task resembles a thread or ThreadPool but at a higher level of abstraction.
Task Parallelism refers to one or more independent tasks running concurrently. 

#### Creating and Running Tasks Implicitly
[top](#index)  
Parallel.Invoke method is quick way to run a statement concurently. Pass an Action Delegate or anonymous method to start.
```C#
Parallel.Invoke(() => DoWork(), () => DoMoreWork());
```

#### Creating and Running Tasks Explicitly
[top](#index)  
System.Threading.Tasks.Task are Tasks that do not return anything.
System.Threading.Tasks.Task< TResult> are Tasks that return a value.
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

#### Parallel.For
[top](#index)  
System.Threading.Tasks
Parallel.For executes a for loop that runs each loop on a different thread.

How to use.
```C#
var r = Parallel.For(int start, int stop, (i, state) => {});
var r = Parallel.For(int start, int stop, (i) => {});
```

#### Parallel.ForEach
[top](#index)  
Foreach loop that runs parallel.
```C#
Parallel.ForEach(enumerablecollection, delegate);
Parallel.ForEach(enumerablecollection, () => {
	DoSomething();
});
```
### Dataflow
[top](#index)  


### PLINQ
[top](#index)  

#### What is a Parallel Query
[top](#index)  

### Tasks and TaskFactories
[top](#index)  
```Task``` and ```TaskFactory``` are used to create and manage tasks. Task is robust but still doesn't provide as many options as TaskFacotry. TaskFactory is clunky because of the options.

#### Task
[top](#index)  
Examples of running tasks
```C#
//creates a task and starts it.
Task newtask = Task(() => {
	DoSomething();
});
newtask.Start();
```
```C#
//runs right away.
Task.Run(() => {
	Do Something
});
```

using Task.Wait() will cause your application to wait until all tasks are finished.

#### TaskFactory
[top](#index)  
```C#
//Task factory examples of Task.Run();
TaskFactory.StartNew< string>(() => {
	DoSomething();
});
```

TaskFactory.StartNew.Unwrap will automatically return the result. Task.Run does this without prompting.

## Locks, Deadlocks, and Race Conditions
[top](#index)  
Common multithreading error and how to deal with them.
### Race Condition
[top](#index)  
Race conditions occure when more than one thread is trying to access a shared variable at the same time.

Two or more threads take in the same variable and output to the same variable. It's a race to who's last. Each thread will overwrite the last.

### Deadlocks
[top](#index)  
Deadlocks occur when two or more threads try to lock a resource the other has already locked. Neither thread can make any furhter progress.

Many methods of the managed threading classes provide time-outs to help you detect deadlocks.
```C#
if(Monitor.TryEnter(lockObject, 300)) {
	try {
		//code that will run if the monitor locks
	}
	finally {
		Monitor.Exit(this);
	}
else{
		//code that will run if the monitor doesn't lock
	}
}
```

### lock
[top](#index)  
The ```lock``` keyword marks a statement block as a critical section.
By locking a block of code it will make sure it cannot execute while another locked thread is accessing a shared resource.
```C#
class lock_example
{
	object locthis;

	public void Go()
	{
		Task.Run(()=>{
			loc(new Object())
			{
				locthis = new Object {Tag = "this"};
			}
		});

		Task.Tun(()=>{
			loc(new Object())
			{
				locthis = new Object {Tag = "that"};
			}
		});
	}
}
```
The bottom thread will wait for the top thread to finish before turning locthis into a new object with the Tag Property of "that".

## Async/Await Keywords
[top](#index)  
Aynchronous programmer is complicated but increases the performance of your application.

Introduced in VS2012 async and await takes away a lot of the complicated code required for multithreading.

### Async Improves responsiveness
[top](#index)  
Syncrhony is essential for activites that are potentially blocking, like when you are running a large query and it blocks updates to your UI making the program unresponsive.

The following areas are common for async programming

Web access - ```HttpClient``` ```SyndicationClient```  
Working with files - ```StorageFile``` ```StreamWriter``` ```StreamReader``` ```XmlReader```  
Working with images - ```MediaCapture``` ```BitmapEncoder``` ```BitmapDecoder```  
WCF programming - Synchronous and Asynchronous Operations  

Especially vailable for applications that access the UI thread because all UI-related activity usually shares one thread.
Without, your UI will be blocked, locking the program until the task is finished.

### Async Methods are Easiere to Write
[top](#index)  
The async and await keyword are the heart of async programming. They use resources in the .NET Framework or the Windowws Runtime to create asynchronous method almost as easily as you create a synchronous method. Asycnhronous methods that you define by suing async and await are referred to as async methods.

```C#
//This is an async method
public async Task< int> AccessTheWebAsync()
{
	HttpClient client = new HttpClient();
	//Runs asynchrounously because of the call to Task. Code will not wait.
	Task< String> getStringTask = client.GetStringAsync("http://www.google.com")
	//This cannot rely on getStringTask because it may still be waiting for client.GetStringAsync to return information.
	ExecuteSomeCode()
	//The await keyword lets the program know that if getStringTask isn't populated yet it will wait until it is.
	string urlContents = await getStringTask
	//returns urlContent length.
	return urlContents.Length;
}
```

If you don't need to do work in between ```client.GetStringAsync``` and string ```url.Contents = await getStringTask``` the code can be simplifed.
```C#
string urlContents = await client.GetStringAsync();
```

#### What makes an async method
[top](#index)  
* ```async``` keyword used
* Method name ends with Async to help the user know this is an async method.
* The return type is of the following
	* Task< TResult>
	* Task
	* void
* usually have atleast one await statement.

### Examples of API Async Methods
[top](#index)  
```CopyToAsync``` Asynchonously copies bytes from the current stream to another stream.    
```ReadAsync``` Asychronously reads a sequence of bytes from the current stream then advances position by that sequence of bytes.  
```WriteAsync```Asynchronously write a sequence of bytes to the current stream thena advances it's position by that sequence of bytes.  

The Synchronous counterparts of each of thsee methods are ```CopyTo```, ```Read```, and ```Write``` and are available in most streams.

### Threads
[top](#index)  
Async methods are intended to be non-blocking operations. An await expression in an async method doesn't block the current thread while the awaited task is running. Instaead, the expression signs up the rest of the method as a continuation and returns control to the caller of the async method.

The async and await keywords don't cause additional threads to be created. Async methods dont' require multithreading beacuse an async method doens't run on it's own thread. The method runs on the current synchronization context and uses tim on the thread only when the method is active.
You can use Task.Run or TaskFactory.StartNew to move CPU-bound work to a background thread, but a background thread doesn't help with a process that's just waiting for results to become available.

The async-based approach to asynchronous programming is preferable to existing approaches in almost every case. In aprticular, this approach is better than BackgroundWorker  for IO-bound operations beacuse the code is ismpler and you don't have to gaurd against race coniditions.
In combination with Task.Run, async programming is better than a BackgroundWorker for CPU-bound operations because async programmign separates the coordination defailts of running your code from the work that Task.Run transfers to the threadpool.

### async and await
[top](#index)  
If you specify a method as an async method you enable the following

* The marked async method can use await to designate suspension points. The await operator tells the compiler that the async method can't continue past that point until awaited async process is complete. In the meantime control is returned to the caller of the async method. The suspension of an async method at an await expression doesn't constitute an exit from the method, and ```finally``` blocks don't run.

* The marked async method can istelf be awaited by methods that call it.

Without an await key used in an async method the method will run synchornously.

### Return types
[top](#index)  
You can't await void async methods because they have nothing to return.

You can't use ```ref``` or ```out``` on async methods.

Asynchronous APIs in Windows Runtime programmign have on eo fhte following return types, which are similar to tasks:

* IAsyncOperations, which corresponds to Task< TResult>
* IAsyncAction, which corresponds to Task
* IAsyncActionWithProgress
* IAsyncOperationWithProgress

### Naming Convention
[top](#index)  
You should put Async as the last part of your method names.

## Concurrent Collections
[top](#index)  
```System.Collections.Concurrent```

Provides several thraed-safe collection classes taht should be used in place of the corresponding types in System.Collections and System.Collections.Generic namespaces whenever multiple threas are accesing the collection concurrent.

Members accessed through one of the interfaces implemented by the current collection are not garaunteed to be thread-safe, including extension methods, and may need to be synchronized by the caller.

### IProducerConsumerCollection< T>
[top](#index)  

Interface defines methods to manipulate thread-safe collections intended for producer/consumer usage. This interface provides a unified representation for producer/consumer collections fo that higher level abstractions such as System.Collections.Concurrent.BlockingCollection< T> can use the collection as a data-store.

### BlockingCollection< T>
[top](#index)  
Provides blocking and bounding capabilities for thread-safe collections that implement ```IProducerConsumerCollections< T>```

Implements IDisposable interface. When you have finished using the type, you should dispose of it either directly or inderectly. To dispose of it directly call Dispose in a try/catch block. To dispose of it directly call it in a using block
```C#
//Direct disposal
BlockingCollection< object> bc = new BlockingCollection< object>();
try{
	bc.Dispose()
}

//indirect disposal
using(BlockingCollection< object> bc = new BlockingCollection< string>())
{
	...
}
```
BlockingCollection will automatically dispose at the end of the using block.

##### Constructors  
[top](#index)  
()		Initializing BlockingCollection without upperbounds.  
(int upperbound)	Initialize BlockingCollection with upperbounds.  
(IProducerConsumerCollection< T> datastore)	Initializes a new instance using the IProducerConsumerCollection as an underlying data store.  
(IproducerConsumerCollection< T> datastore, int upperbounds)		Uses IProducerConsumerCollection as a data store and defines an upperbounds.  

#### Properties  
[top](#index)  
BoundedCapacity - Gets the bounded capacity of this BlockingCollection< T> instance.  
Count - Gets the number of items  
IsAddingCompleted - Gets whether this BlockingCollection< T> has been makred as completed for adding.  
IsCompleted - Gets whether this BlockingCollection< T> has been marked as complete for addign and is empty.  

#### Methods 
[top](#index)  
Add(T) - Adds an item  
Add(T, CancellationToken) - Adds an item but the process can be cancelled by using a CancellationToken.  
AddToAny(BlockingCollection[], T) - Adds the specified item to any one of the specified BlockCollection< T> instances.  
AddToAny(BlockingCollection< t>[], T, CancellationToken)	- Adds the specified item to any one of the specified BlockColletion< T> Instances.  
CompleteAdding() - Marks theBlockingCollection< T> instance as not accepting any more additions.  
CopyTo(T[], int) - Copies all of the items to a compatible one-dimensional array, starting at the specified index.  
Dispose - Release all resources used by the current instance of the class.  
Dispose(bool) - release resources used by hte instance.  
Equals - Determine if this object is equal to another.  
Finalize() - Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.  
GetConsumingEnumerable - Provides a consuming IEnumerator< T> for items in the collection.  
GetConsumingEnumerable(CancellationToken) - same but can be cancelled.  
GetHashCode() - Serves as the default hash function.  
GetType() - returns the objects Type.  
MemberwiseClone() - Creates a shwllow copy of the current object.  
Take() - Removes an item from the collection  
Take(CancellationToken) - Cancellable remove command.  
TakeFromAny(BlockingCollection< T>[], T) - Takes an item from any one of the specified instances.  
TakeFromAny(BlockingCollection< T>[], T, CancellationToken) - Same but can be cancelled.  
ToArray() - Returns an array of items in collection.  
ToString() - Returns a string that resprents the current object.  
TryAdd(T) - Tries to add the specified item to the BlockingCollection< T>.  
TryAdd(T, int) - Tries to add the specified item to the BlockingCollection< T> within the specified time period.  
TryAdd(T, int, CancellationToken) - Same but can be cancelled.  
TryAddToAny(BlockingCollection< T>[], T) - Tries to add an object to any of the provided collections.  
TryAddToAny(BlockingCollection, T, int32, CancellationToken) - same but within a time span with a cancellation token.  
TryAddToAny(BlockingCollection< T>[], T, Timespan) - Same but no cancellation and uses a TimeSpan object for the timeout.  
TryTake(T) - Tries to remove an object  
TryTake(T, int) - Tries to remove object within a specific time.  
TryTake(T, int, CancellationToken) - Same but cancellable.  
TryTake(T, TimeSpan) - Uses TimeSpan object instead of int to set time out.  
TryTakeFromAny(BlockingCollection< T>[], T) - Try to remove an object from any of the provided BlockingCollections  
TryTakeFromAny(BlockingCollection< T>[], T, int) - same but wtihin a time frame.  
TryTakeFromAny(BlockingCollection< T>[], T, int, CancellationToken) - Same but can be cancelled  
TryTakeFromAny(BlockingCollection< T>[], T, TimeSpan) - same but not cancellation and uses TimeSpan for timeout instead of int.  

#### Explicit Interface Implementations   
[top](#index)  
IEnumerable< T>.GetEnumerator() - Gets an IEnumerator< T> which can be used for things like foreach loops.  
ICollection.CopyTo(Array, int) - Copies all of the items in the BlockingCollection< T> instance to a compatible on-dimensional arra, startin at the specified index of the target array.  
IEnumerable.GetEnumerator() - Provides an IEnumerator for items in the collection, used for things like foreach loops.  
ICollection.IsSyncrhonized - Gets a value indicating whether access to the ICollection is synchronized.  
ICollection.SyncRoot - Gets an object that can be used to synchronize access to the ICollection. This property is not supported.  

### ConcurrentBag< T>
[top](#index)  
Represents thread-safe unorder collection objects.

Otherwise functions like any standard List.

Accepts ```null``` as a valid value for reference types.

### ConcurrentDictionary< T,U>
[top](#index)  
A thread-safe dictionary.

It work like a ```Dictionary< T,U>``` except it's thraed safe.

### ConcurrentQueue< T>
[top](#index)  
A thread-safe Queue

It works like a ```Queue< T>``` except it's thread safe.

### ConcurrentStack< T>
[top](#index)  
A thread-safe Stack

It works like a ```Stack< T>``` except it's thread safe.

### OrderablePartitioner< TSource>
[top](#index)  
Splits an orderable data source into multiple partitions

#### Constructors  
[top](#index)  
(bool KeysOrderedInEachPartition, bool KeysOrderedAcrossPartitions, bool KeysNormalized)  

**KeysOrderedIneachPartition** - Inidcates whether the elemnts in each partition are yielded in the order of increasing keys.  
**KeysOrderedAcrossPartition** - Indicates whether elements in an earlier partition always come before elements in a later partition. If true, each element in aprtition 0 has a smaller order key than any element in partition 1, each element in partition 1 has a smaller order key than any element in partition 2, and so on.  
**KeysNormalized** - Indicates whether keys are normalized. If true, all order keys are distinct integers in the range [0 .. numberOfElements - 1] if false, order keys must still be distinct, but only their relative order is considered, not their absolute values.  

#### Properties  
[top](#index)  
KeysNormalized - Gets whether order keys are normalized.  
KeysOrderedAcrossPartition - Gets whether elements in any earlier partition always come before elements in a later partition.  
KeysOrderedInEachPartition - Gets whether elements in each partition are yielded in the order of increasing keys.  
SupportsDynamicPartitions - Gets whether additional partitions can be created dynamically.  

#### Methods  
[top](#index)  
GetDynamicPartitions() - Creates an object that can partition the underlying collection into a variable number of partitions.  
GetOrderablDynamicPartitions - Creates an object that can partition the underlying collection into a variable number of partitions.  
GetOrderableParittions(int numberofpartitions) - Partitions the underlying collection into the specified number of orderable partitions.  
GetPartitions(int numberofpartitions) - Partitions the underlying collction into the given number of ordered partitions.  

### Partitioner
[top](#index)  
Static class provides common parittioning startegies for arrays, lists, and enumerables.

#### Methods  
[top](#index)  
Create(int32, int32) -  Creats a partition that chunks the user-specified range.  
Create(int32, int32, int32 - ) - same  
Create(int64, int64) - same  
Create(int64, int64, int64) - same  
Create< TSource>(TSource[], bool) - Creats an orderable partition from an Array instance. Bool sets the object to dynamically load balance or statically load balance.  
Craete< TSource>(IEnumerable< TSource>, EnumerablePartitionerOptions) - Same but with an IEnumerable, EnumerablePartitionOptions allows you to set the buffering behavior of the partition.  
Create< TSource>(IList< TSource>, Boolean) - Creates an orderable partitioner from an IList< T> object. Bool sets the object to dynamically load balance or statically load balance.  

### Partitioner< TSource>
[top](#index)  
Represents a particular manner of splitting a data source into multiple partitions

Constructor:  
Partitioner< TSource>() - Creates a new partitioner instance.

Properties:  
SupportsDynamicPartitions - Gets whether additional parittions can be created dynamically.  

#### Methods  
[top](#index)  
GetDynamicPartition() - Creates an object that can partition the underlying collection into a variable number of partitions.  
GetPartitions(int32) - Partitions the underlying collection into the given number of partitions.  

## Cancellation Tokens
[top](#index)  
```CancellationToken``` enables cooperative cancellation between threads, thread pool work items, or Task objects. AN object creates a cencellation token by using a CancellationTokenSource, and then apsses the cancellation token to any number of threads or objects that should recieve notice of a cancellation.
The token cannot be used to initiate a cancellation. When the owning object calls Cancel on the ```CancellationTokenSource```, ```the IsCanncellationRequested``` property on every copy of the cancellation token is set to tru. The objects that receive the notification can respond in whatever manner is appropriate.

### CancellationTokenSource
[top](#index)  
Used to create and coordinate ```CancellationToken```  

#### Constructors
[top](#index)  
()  
(int cancelafterthismanymiliseconds)  
(TimeSpan cancelafterthistimepasses)  

#### Properties
[top](#index)  
IsCancellationRequested - Can be checked to see if a cancel has been requested  
Token - CancellationToken that is associated with this CancellationTokenSource  

#### Methods
[top](#index)  
Cancel() - Sends a cancel request setting IsCancellationRequested to true.  
Cancel(bool) - Same, but also sets whether this cancel will throw an exception blocking all threads from running. True = so important everything needs to stop.  
CancelAfter(int) - Cancel after this many miliseconds  
CancelAfter(TimeSpan) - Cancel after this time interval.  
CreateLinkedTokenSource(CancellationToken, CancellationToken) - Links these tokens together. If either of their sources are canceled the other is too.  
CreateLinkedTokenSource(CancellationToken[]) - Same but links an array of tokens.  
Dispose() - Release all resources  
Dispose(bool) - release all unmanaged resources, set bool true to release all Managed resources also.

### Example
[top](#index)  
```C#
int Main()
{
	CancellationTokenSource cts = new CancellationTokenSource();
	public void runTask()
	{
		Task.Factory.Startnew(() => DoSomething(), cts.Token)
	}
	//This cancels the task.
	cts.Cancel();
}
```

## Control Statements
[top](#index)  

### if/else
[top](#index)  
**if/else** statements help with decision making in program flow. If something is satisified do this else, do this.
```C#
if(variable == 0)
	DoSomething();
else
	DoSomethingElse();
```

### while
[top](#index)  
**while** loop until an outcome is satisfied. Will not run if already satisfied.
```C#
while (checkvar != "STOP!")
{
	checkvar = DoSomething();
};
```

### do/while
[top](#index)  
**Do/While** Loop until an outcome is satisfied. Will run atleast once no matter the outcome.
```C#
do
{
	checkvar = DoSomething();
}while(checkvar != "STOP!");
```

### switch
[top](#index)  
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

### for
[top](#index)  
**for** loops are simple loops that will loop a set amount of times. loop.
```C#
for(int i = 0;i <  10;i++)
	DoSomething();

for(int i = 0; i <  variable;i++)
	DoSomething();
```

### foreach
[top](#index)  
**foreach** loops through any object that inherites from the IEnumerable interface. These are collections of the same object type.
```C#
foreach(object o in objectcollection)
	DoSomething(o);
```
passes each object in objectcollection to the DoSomething(object o) method.

### break
[top](#index)  
**break** forces your program out of a loop. The following is common.
```C#
while(true)
{
	if(something == outcome)
		break;
}
```
this will continue to run until something and outcome equal the same.

### continue
[top](#index)  
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

### goto
[top](#index)  
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

### yield
[top](#index)  
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

### yield break and continue
[top](#index)  
**yield break** allows you to break a loop within your enumerator.
**yield continue** allows you to break a loop within an enumerator.

### Enumerable.Range(int,int)
[top](#index)  
Generates a quick enumerated set of integers between a set of numbers.

## Events and Delegates
[top](#index)  

### Delegates
[top](#index)  
Delegates hold methods as objects and allow you to invoke them at will.
```C#
public delegate void MyDelegate(string info);
public MyDelegate delegatehandler;

delegatehandler += MyNewMethod;

public void MyNewMethod(string info)
{
	Console.WriteLine(info);
}
```
Whenever the delegatehandler is called it will execute the method passed to the delegate.

#### Func< T,U>
[top](#index)  
```Func``` is a generic delegate that takes and input and returns an output.
```C#
public class functest
{
	public Func< string, string> concatfunc;

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
The last variable in Func is an out variable which means it updataes the variable a scope above that was passed to it.
It also returns a what ever type you have set.
The first call prints the return, but at the same time it updates inputoutput.
This allows the second console.writeline code to print SecondFirst instead of just Second.

#### Action< t>
[top](#index)  
Action is like func except it doesn't return anything, not even with ```out``` parameters.
It can have a lot of input parameters though. Invoke the same way, don't expect any returns.

#### Comparison< T>
[top](#index)  
Delegate that returns a custom comparison by int form.
```
public void Main()
{
	List< object> objectlist = new List< object>();
	objectlist.Sort(compare);
}

public int compare(object find, object compare)
{
	if(find > compare)
		return 1;
	if(find <  compare)
		return -1;
	if(find == compare)
		return 0;
}
```
Sort uses a Compare< T> delegate. You can pass a method to it that must return a 1, 0, or -1 in order to function.

You can create multiple methods for different cases.
```C#
Array.Sort(Collection, Collection.PropertyToSortBy);
```
Array.Sort's first parameter is an out param. Collection is updated on execution without return.

#### Predicate< T>
[top](#index)  
Predicate< T> set a particular constraint and filter items that do not conform to the constraint.
```
//Find the first number in a string.
public bool search(char c)
{
	string[] str = {1234567890}
	return str.Contains(c);
}

public void Main()
{
	Console.WriteLine(Array.Find("This is a 21 Test.", search));
}
```
THe above code will return the first number in a string.

#### EventHandler< TEventArgs>
[top](#index)  
You can create custom EventArgs by inheriting from EventArgs. Then you can use it an a generic inside of an EventHandler to pass event arguments.

Events conform to the following
```C#
//The event
EventHandler< CustomerEventArgs> eventhandler = CustomMethod;
//The event method.
public void EventMethod(sender o, CustomEventArgs cea)
```
EventHandler< T> will pass the event args input during invoke so you can pass information into the trigger method. It also passes the object that trigger the event.

### lambda Expressions/Anonymous Methods
[top](#index)  
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

### Subscribing/Unsubscriping from events
[top](#index)  
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
# Create and Use Types
[top](#index)  

## Reference Types
[top](#index)  
Reference types return a memory reference.

### class
[top](#index)  
```class``` is the blueprint of an object. It contains fields, properties, methods, and constructors to create and manipulated objects.

### interface
[top](#index)  
```interface``` is an inheritable class like object that can only be inherited. It outlines how a class must function and is used for polymorphism and Liskov Substitution Principal.

### delegate
[top](#index)  
```delegate``` is an object that holds a method. When a delegate is called is executes that method. A delegate can change which methods are executed.

### object
[top](#index)  
```object``` is the most basic class in C#. All classes eventually inherit from object. An object is a broad term to describe any field holding an instantiated class.

### string
[top](#index)  
```string``` holds an array of characters and is used convey text.

### dynamic
[top](#index)  
```dynamic``` is a reference type that bypasses compile time checking. It is commonly used by COM APIs such as Office Automation API, IronPython Libraries, and HTML Document Object Model(DOM)

## Value Types
[top](#index)  
Derived from System.ValueType.
Value types are types that return a value instead of a memory reference. When given a value you cannot modify the value like reference objects.
Can not inherit from value types.
Values can be assigned null if declared nullable.

All integrals inherit from System.Int32.

### struct
[top](#index)  
The ```struct``` declaration is similar to a class in that it stores data and can execute methods. Structs though only return values instead of references.
structs must have all their public properties and fields initialized during the struct initialization. This is because you cannot modify information in a struct.
In order to declare new information in a struct you have to make a new one. 
```C#
public struct struct_example
{
	public int X;
	public int Y => 25
	public int Z;
	//x is required as an argument because X is not initialized by the constructor or during instantiation.
	public struct_example(int x)
	{
		Z = 10;
		X = x;
	}
}
```
### enum
[top](#index)  
```enum``` is a value that declares a keyword assigned to a number (or other types).
```C#
public enum NewEnum {val1, val2, val3}
public enum NewEnum2 {val1 = 10, val2 = 5, val3 = 0}
```
You can declare an enum with default values like in the first example. In this example val1 = 0, val2 = 1, val3 = 2.  
You can also declare enums with custom values like in second example.

You can also declare your enum as a different data type to store different information.
```C#
public enum NewEnum3 : float {val1 = .5, val2 = .25 val3 = 0;}
```

Enums can also be cast between their value class and their enum class.
```C#
int ex1 = NewEnum.val2;  //1
int ex2 = NewEnum2.val1;  //10
float ex3 = NewEnum3.val3; //0

NewEnum ne = NewEnum.val1;
NewEnum2 ne2 = NewEnum.val3;
NewEnum3 ne3 = NewEnum.val2;

ne = (NewEnum)2; //NewEnum.val3
ne2 = (NewENum2)10 //NewEnum2.val1
ne3 = (NewEnum3).25 //NewEnum.val2
```

### Other Value Types
[top](#index)  
**bool** - Boolean value - True or False - False  
**byte** - 8-bit unsigned integer - 0 to 255 - 0  
**char** - 16 bit unicode character - U +0000 to U +ffff - '\0'  
**decimal** - 128-bit precise decimal values with 28-28 significant digits - (-7.9x10^28 to 7.9x10^28) / 10^0 to 10^28 - 0.0M  
**double** - 64-bit double precision floating point type - (+/-)5.0x10^-324 to (+/-)1.7x10^308 - 0.0D   
**float** - 32-bit single-precision floating type - -3.4x10^38 +3.4x10^28 - 0.0F  
**int** - 32-bit signed integer - -2,147,483,648 to 2,147,483,647 - 0  
**long** - 64-bit signed integer type - -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807  - 0L  
**sbyte** - 8-bit signed integer type - -128 to 127 - 0  
**short** - 16-bit signed integer type - -32,768 to 32,767 - 0  
**uint** - 32-bit unsigned integer - 0 to 4,294,967,295 - 0  
**ulong** - 64-bit unsigned integer type - 0 to 18,446,744,073,709,551,615 - 0  
**ushort** - 16-bit unsigned integer type - 0 to 65,535 - 0  

## Generics
[top](#index)  

Generics are the implementation of the concept of a Type parameter.
you can provide a type to this object on creation. Previously you would need to make a custom class for each object you wanted to interact with.

You can implement existing Generic types, or create custom Generic types.

### Generic type parameters
[top](#index)  
```C#
//This defines an object called GenericList which takes in a type parameter. The generic list now expects floats to interact with in some way.
//This is common with collections. List< T> when declared can dynamically add new object equivalent to the type provided at T.
GenericList< float> list1 = new GenericList< float>()
```

#### Type Parameter Naming Guidlines
[top](#index)  

Name generic type parameters with descripting names, unless a single letter name is completely self explanatory and a descriptive name would not add value.
```C#
public interface ISeesionChannel< TSession>{//...}
public delegate TOutput Converter< TInput, TOutPut(TInput from);
public class List< T>{//...}
```

Consider using T as the type parameter name for types with ong single letter type parameter.
```C#
public int ICompare< t>() {return 0; }
public delegate bool Predicate< t>(T item);
public struct Nullable< t> where T | struct {//...}
```

Prefix descriptive type parameter names with "T"
```C#
public interface ISessionChannel< TSession>
{
	TSession Session {get;}
}
```

## Methods
[top](#index)  
Methods are blocks of codes within a class or struct that execute on variables that are passed into them or local variables within the class.
```C#
public class method_example
{
	public void method()
	{
		...
	}
}
```
### Optional Parameters
[top](#index)  
Optional Parameters are predefined parameters in a method. They must come at the end of all requires variables.
If they are not referenced in the call they will use the default value provided.
```C#
public void optionalexample(int i, int j, string optional = "optional"){ ... }

public void Main()
{
	//Don't have to declare
	ExampleClass.optionalexample(1,2);
	//But can
	ExampleClass.optoinalexample(1,2,"not optional");
}
```
### Named Parameters
[top](#index)  
You can name parameters during instantiation. You can apply parameters in any order when doing so.
```C#
void method(int i, int j, int x) { ... }

void Main()
{
	method(j : 1, x :  5, i: 2);
}
```
### Passing by Reference vs. Passing by Value
[top](#index)  
By default, when a value type is passed to a amtheod, a copy is passed instead of the object itself. 
Therefore, changes to the argument have no effect on the original copy in the calling method. You can pass 
a value0type by reference by using the ```ref``` or ```out``` keyword.

bottom line, passing by value(default) will not effect the variable that was passesd. Passing by reference will.

#### Ref vs. Out
[top](#index)  
They are basically the same except for key points.
|ref													|out										|
|------------------------------------------------------:|------------------------------------------:|
|must be initialized before passing						|can be uninitialized when passed.			|
|Not required to return anything						|Must return something						|
|Good for modifying parameter							|Good for returning multiple values			|
|Doesn't need to be initialized in the calling method	|Must be initialized in the calling method.	|
|Ref passes data bi-drecitonaly							|out passas data uni-directionaly			|

Both ref and out ar etreatd differently at runtime and they are treated the same at compile time.
Properties are not variables, therfore it cannot be passed as an out or ref parameter.

## Static Extension Methods
[top](#index)  
You can extend objects by creating a static method that references it's first parameter with this
```C#
public static int Sigma(this int x)
{
	int newx = 0;
	for(int i = 0; i < = x; i++ )
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
static extention methods must be created in a static class.

## Indexers
[top](#index)  
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

## Static Variables
[top](#index)  
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
	public static Dictionary< string, Queue< string>> taskqueue = new Dictionary< string, Queue< string>>();

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
## Interfaces
[top](#index)  
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

### Member Signatures
[top](#index)  
The signature of a member is the name and any argumnents that can be provided.
```C#
public void method() { ... }
public void method(int i) { ... }
```
These are entirely differenty methods because their signature is different. Parameters are part of the signature. Their paremters are different. Therefore different method.
This can apply to constructors by name and parameters
Indexers by assigning different variables to index.
Opterators but that's not really important.

### Overloaded Members
[top](#index)  
An overloaded members is a member of an object that is named the same but have a different signature.
```C#
public void overload_method(int i) { ... }
public void overload_method(int i, int j) { ... }
```
Both methods above have the same name but are legal. overload_method is overloaded because when you accept different parameters the method has a different signature so it can exist on it's own.

## Base Classes
[top](#index)  
Classes that can be inherited from. Some cannot be instantiated.

### Abstract base classes
[top](#index)  
Abstract classes are similar to interfaces in that they cannot be instantiated, they outline required methods and properties in classes that inherit it,
and they can be used for polymorphism. But ```abstract``` classes can contain complete inheritable methods and properties that can be used by derived classes.
```C#
public abstract class abstractexample
{
	//must be overriden
	public abstract int Property {get;set;}
	//can be overriden
	public virtual int Property2 {get;set;}
	//cannot be overriden but can be accessed
	public int Property3 {get;set;}

	//the same works for methods
	//Must be overridden, no code can be written for abstract.
	public abstract int GetNumber();
	//Can be overridden, code must be provided.
	public virtual int GetNumber2() { return 1; }
	//Cannot be overridden but can be accessed.
	public int GetNumber3() { return 2; }
}

public class inheritabstract : abstractexample
{
	//override property.
	public override int Property {get {return 2} set {value} };

	//override class is required.
	public override int GetNumber()
	{
		return 5;
	}
	//override, but didn't have to.
	public override GetNumber2()
	{
		return 7;
	}
}
```
The above code uses the ```virtual``` and ```abstract``` method modifiers to determine how they will be handled with derived classes.
**virtual** - is a method modifier that allows a derived class to ```override``` it and use it's own code.
**abstract** - defines a signature for a property or method but does not supply any code. Derived classes must ```override``` this class.

Any method or property not merked with a modifier are inherited and can be executed by the derived class, but the derived class cannot ```override``` them.

### Overridden Members
[top](#index)  
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
# Debug Applications and Implementing Security
[top](#index)  

# Implement Data Access
[top](#index)  

## Working with files
[top](#index)  

### System.IO.File
[top](#index)  
A class that's able to interact and manipulate files.

#### File.AppendAllLines
[top](#index)  
Appends lines to a file. Creates a file if one doesn't exist. Closes file when finished.

overload methods:  
(string path, IEnumerable< string> contents)  
(string path, IEnumerable< string> contents, Encoding encoding)		When the file is created or written to it uses the specified text encoding.  

example:
```C#
List< string> listofstrings = new List< string>(new string[] { 
		"This is a test", 
		"yes it is", 
		"this is a test", 
		"yes it is", 
		"it's a test", 
		"it's a test"
	});
string path = "path\\to\\file"
File.AppendAllLines(path, listofstrings);
File.AppendAllLines(path, listofstrings, Encoding.UTF8);
```

#### File.AppendAllText
[top](#index)  
Appends a specified string to a file. If a file doesn't exist, it creates one, writes to it, then closes the file.

overload methods:  
(string path, string content)  
(string path, string content, Encoding encoding)		When the file is created or written to it uses the specified text encoding.  

example:
```C#
string path = "path\\to\\file";
File.AppendAllText(path, "just a string");
File.AppendAllText(path, "just a string", Encoding.UTF8);
```

#### File.AppendTest
[top](#index)  
Creates a StreamWriter that appends UTF-8 encoded text to an existing file or creates a new one.

overload methods:  
(string path)  

example:
```C#
string path = "path\\to\\file";
using(StreamWriter sw = File.AppendText(path))
{
	sw.WriteLine("append this.")
	sw.WriteLine("append this too.")
}
```

#### File.Copy
[top](#index)  
Copies an existing file to a new file

##### overload methods  
[top](#index)  
(string source, string dest)					overwriting existing files is not allowed  
(string source, string dest, bool overwrite)	overwriting is allowed.  

##### example
[top](#index)  
```C#
string filetocopy = "path\\to\\file";
string wheretocopy = "path\\to\\destination"
File.Copy(filetocopy, wheretocopy);
File.Copy(filetocopy, wheretocopy, true)	//will overwrite
File.Copy(filetocopy, wheretocopy, false)	//won't overwrite
```

#### File.Create
[top](#index)  
Creates or overwrites a file.

overload methods
(string path)
(string path, int buffersize)	Number of bytes buffered for read and write
(string path, int buffersize, FileOptions.Encrypted)	has a buffer, and allows for FileOptions to be declared.
(string path, int buffersize, FileOptions.None, FileSecurity accesscontrol)		Allows file security to determine access control.

#### File.ReadAllLines()
[top](#index)  
Creates or opens a file writing UTF-8 encoded text

overload methods:
(string path)

##### example
[top](#index)  
```C#
string path "path\\to\\file";
using(StreamWriter sw = File.CreateText(path))
{
	sw.WriteLine("Hello");
}
```

#### File.Decrypt(string)
[top](#index)  
Decrypt a file that was encrypted by the current account using the Encrypt method.

##### overload methods
[top](#index)  
(string path)

##### example
[top](#index)  
```C#
string path = "path\\to\\file";
File.Decrypt(path);
```

#### File.Encrypt
[top](#index)  
Encrypt a file

##### overload methods
[top](#index)  
(string path)

##### example
[top](#index)  
```C#
string path = "path\\to\\file"
File.Encrypt(path);
```

#### File.Delete
[top](#index)  
Delete a file

##### overload methods
[top](#index)  
(string path)

##### example
[top](#index)  
```C#
string path = "path\\to\\file"
File.Delete(path);
```

#### File.Exists
[top](#index)  
Checks to see if a file exists

overload methods:
(string path)

example:
```C#
string path = "path\\to\\file";
File.Exists(path);
```

#### File.GetAccessControl
[top](#index)  
Gets the FileSecurity object that encapsulates the access control list.

##### overload methods
[top](#index)  
(string path)
(string path, AccessControlSections.Owner)	specifies the type of access control list information to receive.

##### example
[top](#index)  
```C#
string path = "path\\to\\file";
FileSecurity filesecurity = File.GetAccessControl(path);
FileSecurity morefilesecurity = File.GetAccessControl(path, AccessControlSection.All);
```

#### File.GetAttribute
[top](#index)  
Gets the attribuets of a file

##### overload methods
[top](#index)  
(string path)

##### example
[top](#index)  
```C#
File.GetAttributes(path)
```

#### File.GetCreationTime
[top](#index)  
returns the creation time
File.GetCreationTime(path)

#### File.GetCreationTimeUtc
[top](#index)  
Returns the creation time in UTC.
File.GetCreationTimeUtc(path)

#### File.GetLastAccessTime
[top](#index)  
Returns the last time the file was accessed
File.GetLastAccessTime(path)

#### File.GetLastAccessTimeUtc
[top](#index)  
Returns the last tim the file was accessed in UTC
File.GetLastAccessTimeUtc(path)

#### File.GetLastWriteTime
[top](#index)  
Last time file was written to.
File.GetLastWriteTime(path)

#### File.GetLastWriteTimeUtc
[top](#index)  
What do you think?

#### File.Move
[top](#index)  
Moves the file
File.Move(dest,target)

#### File.Open
[top](#index)  
Opens a file and sets the file mode.

##### overload methods
[top](#index)  
(string path, FileMode.Create)
(string path, FileMode.Append, FileAccess.ReadWrite)	Sets file access as well
(string path, FileMode.Open, FileAccess.Read, FileShare.Write) sets file access and stream access with FileShare.

##### example
[top](#index)  
```C#
using(FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None))
{
	Console.WriteLine(fs.ReadByte())
}
```
#### File.ReadLine
[top](#index)  
Reads the lines of a file

##### overload methods
[top](#index)  
(stirng path)
(string path, Encode.Unicode)	What encoding is needed to read.

##### examples
[top](#index)  
```C#
foreach(string line in File.ReadLine(path))
	Console.WriteLine(line);
```

#### File.WriteAllLines
[top](#index)  
Creates a file if needed, writes a collection of strings to a file, closes the file.

##### overload methods
[top](#index)  
(string path, IEnumerable< string> stringlist)
(string path, IEnumerable< string> stringlist, Encoding.UTF8)	Specifies text encoding.
(string path, string[] content)		Uses an array instead of a list
(string path, string[] content, Encoding.UTF8)	Uses an array and specifies text encoding.

#####example
[top](#index)  
```C#
List< string> stringlist = new List< string>(new string[] {
	"we are testing",
	"yes we are"
});

File.WriteAllLines(path, stringlist, Encode.UTF8)
```
### System.IO.FileMode
[top](#index)  
FileMode enum - not to be confused with FileAccess enum - specifies how the operating system should open a file.

#### Append
[top](#index)  
```FileMode.Append``` Opens the file if it exists and seeks to the end of the file, or creates a new file. Can only be used with ```FileAccess.Write```

```C#
using(FileStream fs = FileStream(path, FileMode.Append, FileAccess.Write))
{
	fs.WriteByte(10);
}
```

#### Create 
[top](#index)  
```FileMode.Create``` Creates a new file, if the file already exists it will be overwritten. Throws ```UnauthorizedAccessException``` if the file is hidden.

```C#
using(FileStream fs = FileStream(path, FileMode.Create))
{
	fs.WriteByte(10);
	fs.ReadByte();
}
```

#### CreateNew
[top](#index)  
```FileMode.CreateNew``` Creates a new file, if it exists it throws a ```System.IO.FileNoteFoundException```

```C#
using(FileStream fs = FileStream(path, FileMode.CreateNew))
{
	fs.WriteByte(10);
	fs.ReadByte();
}
```

#### Open
[top](#index)  
```FileMode.Open``` Tells the operating system to open an existing file. ```FileNotFoundException``` thrown if file doesn't exist.

```C#
using(FileStream fs = FileStream(path, FileMode.Open, FileAccess.ReadWrite))
{
	fs.WriteByte(10);
	fs.ReadBute(10);
}
```

#### OpenOrCreate
[top](#index)  
```OpenOrCreate``` Tries to open a file, if it can't be found it creates a new one.

#### Truncate 
[top](#index)  
```Truncate``` Opens an existing file and then deletes all contents. Reading from it throw sArgumentException.

### System.IO.FileAccess
[top](#index)  
```FileAccess``` enumeration, not to be confused with System.IO.FileMode, Defines the constants for read, write or read/write access to a file.

#### Read
[top](#index)  
You can read the file.

#### Write
[top](#index)  
You can write to a file.

#### ReadWrite
[top](#index)  
You can both read and write to a file.

### System.IO.FileShare
[top](#index)  
Contains constants for controlling the kind of access other FileStream objects can have to the same file.
By settings these, you can allow other streams to read and write to object.

#### Delete
[top](#index)  
Allows subsequent deleting of a file.

#### Inheritable
[top](#index)  
Makes the file handle inheritable by child processes. This is not directly supported by Win32.

#### None
[top](#index)  
Declines sharing of the current file. Any request to open the file will fail until the file is closed.

#### Read
[top](#index)  
Allows subsequent opening of the file for reading.

#### ReadWrite
[top](#index)  
Allows subsequent openings of the file for read or write.

#### Write
[top](#index)  
Allows subsequent openings of the file for writing.

### System.IO.FileOptions
[top](#index)  
Represents advanced optoins for creating a FileStream object

This enumration has a FlagsAttribute attribute that allows a bitwise combination of it's values.

#### Asynchronous
[top](#index)  
Indicates that a file can be used for asynchronous reading and writing.

#### DeleteOnClose
[top](#index)  
Indicates that a file is autmatically deleted when it is no longer in use.

#### Encrypted
[top](#index)  
Indicates that a file is encreypted and can be decrypted only by using the same user account used for encryption.

#### None
[top](#index)  
Inidcates taht no additional optoins should be used.

#### RandomAccess
[top](#index)  
Inidcates that the file is accessed randomly. THe system can use this as a hint to optimize file caching.

#### SequentialScan
[top](#index)  
Inidcates taht the file is to be accessed sequentially from beginning to end. The system can use this as a hint to optimize file caching. If an application moves the file pointer for ranomd access, optimum caching may not occur; however, correct operation is still garaunteed.

#### WriteThrough
[top](#index)  
Indicates that the system should write through any intermediate cache and go directly to disk.

## Streams
[top](#index)  

### CryptoStream
[top](#index)  

### FileStream
[top](#index)  
```C#
System.IO.Filestream
```
Provides a stream for a file, supporting both synchronous and asynchronous read and write operations.

#### Constructors
[top](#index)  
(SafeFileHandle FileHandle, FileAccess.ReadWrite)	Initializes a new instance of the FileStream class for the specified file handle, with the specified read/write permission.   
(SafeFileHandle FileHandle, FileAccess.Read, int buffersize)	Adds buffer size to the previous constructor  
(SafeFileHandle FileHandle, FileAccess.Write, int buffersize, Boolean runasync)		Adds a bool to determin async run or not to the previous constructor  
(string path, FileMode.Create)		Uses a string for the file path, and uses FileMode to tell the system how to access the file.  
(string path, FileMode.Open, FileAccess.ReadWrite)		Uses FileAccess to determine how much access the program has.  
(string path, FileMode.Create, FileAccess.Write, FileShare.Read)	Uses FileShare to share the file with other StreamObjects  
(string path, FileMode.Create, FileAccess.Write, FileShare.Read, int buffer)	Adds a buffer  
(string path, FileMode.Create, FileAccess.Write, FileShare.Read, bool aync)		Adds a bool to determin if you are writing asyncrounously or not.  
(string path, FileMode.Create, FileAccess.Write, FileShare.Read, int buffer, FileOptions.None)		Uses FileOption to implement advanced featuers.  
(String path, FileMode.Create, FileSystemRights.AppendData, FileShare.Read, Int buffer, FileOptions.RandomAccess)	Uses System.Security.AccessControl to set more optoins.  
(String jpath, FileMode.Create, FileSystemRights.ChangePermissions, FileShare.Read, Int buffer, FileOptions.Asynchronous, FileSecurity filesecuritysettings)	Adds the ability to pass a FileSecurity object to setup file security.  

### MemoryStream
[top](#index)  

# LINQ
[top](#index)  

Language-Integrated Query - LINQ - Introduced in .Net 3.5
Must be used against Strongly Typed collections
LINQ is a unified model for querying any IEnumerable or IEnumerable< T> in a safe manner.
LINQ to Objects is the name for LINQ queries in memory.

Can be used to query SQL Server, XML Documents, ADO.NET Datasets, IEnumerable or IEnumerable< T>.

## Basic LINQ Queries
[top](#index)  

Query is an expression that retieves data from a data source. LINQ simplifies queries between languages.

< ol>
	< il>Obtain the data source.< /il>
	< il>Create the query.< /il>
	< il>Execute the query.< /il>
< /ol>

### Query Example
[top](#index)  
Example calls an array which executes foreach to query the information.
Foreach can only be executed on objects that inherit from IEnumerable, Ienumerable< T>, IQueryable< T> or any derived interface.
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
[top](#index)  
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
IQueryable< Customer> custQuery = from cust in db.Customers
								 where cust.City == "London"
								 select cust;
```
A LINQ data source is any object that inherits the generic IEnumerable< T> interface or any interface that derives from it.

### The Query
[top](#index)  
Queries are stored in a query variable and initialized with a query expression
The query doesn't actually run until the data is accessed.

## Deferred Execution
[top](#index)  
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
List< int> query1 = //or int[] query1
	(from num in numbers
	 where (num % 2) == 0
	 select num).ToList(); // or ToArray()
```
## LINQ and Generic Types
[top](#index)  

```C#
IEnumerable< Customer> query = //LINQ query...
```
Query returns a list of objects called customer.

Compiler can handle it with var
```C#
var query = //LINQ query...
```

## Basic LINQ Query Operations
[top](#index)  

### Documentation
[top](#index)  
< a href="https://msdn.microsoft.com/en-us/library/bb397927(v=vs.110).aspx">Microsoft Basic LINQ Query Operations< /a>
< a href="https://msdn.microsoft.com/en-us/library/bb311040(v=vs.110).aspx">Microsoft Join clause documentation< /a>

### Obtaining a Data Source
[top](#index)  
from defines the range variable (range of data)
in defines the data source
```C#
from cust in customers
```
Additional range variables can be added with the ```let``` clause.

### Filtering
[top](#index)  
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
[top](#index)  
use the ```orderby``` clause to sort.
```
orderby cust.Name ascending
```

### Grouping
[top](#index)  
The ```group``` clause enables you to gorup your results based on a key that you specify.
example: group by city so all cities are in a group.
```C#
// queryCustomerByCity is an Ienumerable< IGrouping< string, Customer>>
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
[top](#index)  
Joining allows you to create associations between sequence that are not explicitly modeled in the data sources.
In LINQ ```join``` clause always works against object collections instead of database tables directly.
```C#
var innerJoinQuery =
	from cust in customers
	join dist in distributors on cust.City equals dist.City
	select new { CustomerName = cust.Name, DistributorName = dist.Name };
```

### Group Join
[top](#index)  
a ```join``` clause with an ```into``` clause

```C#
var innerGroupJoinQuery =
	from category in categories
	join prod in products on category.ID equals prod.CategoryID into prodGroup
	select new { CategoryName = category.Name, Products = prodGroup };
```

### Left Outer Join
[top](#index)  
Use the ```DefaultIfEmpty()``` method in combination with a group join
```C#
var leftOuterJoinQuery =
	from category in categories
	join prod in products on category.ID equals prod.CategoryID into prodGroup
	from item in prodGroup.DefaultIfEmpty(new Product { Name = String.Empty, CategoryID = 0 })
	select new { CatName = category.Name, ProdName = item.Name };
```

### The Equals Operator
[top](#index)  
A ```join``` clause performas an equijoin this means you can only base matches on the equality of two keys.
greater than and not equals are not supported
join uses ```equal``` to make sure there isn't confusion between other C# operators.

### Non-Equijoins
[top](#index)  
You can perform non-equijoins, cross joins,a nd other custom join operations by using the ```from``` clause

### Joins on object collections vs relation tables
[top](#index)  
join is only necessary when joining objects that are not modeled
LINQ to SQL stores the primary and seconadary key tables in the object

### Composite Keys
[top](#index)  
You can test for equality of multiple values by using a composite key.

## Data Transformation with LINQ
[top](#index)  
< a href="https://msdn.microsoft.com/en-us/library/bb397914(v=vs.110).aspx">Microsoft Data Transformations with LINQ Documentation< /a>

Can transform data
< ul>
	< li>Merge multiple input sequences into a single output sequence that has a new type.< /li>
	< li>Create output sequences whose elements consist of only one or several properties of each element in the source sequence.< /il>
	< li>Create output sequences who elements conssit of the results of operations perform on the source data.< /li>
	< li>Create output sequence in a different format. For example, you can transform data from SQL rows or test files into XML.< /li>
< /ul>

### Joining Multiple Inputs into One Output Sequence Example
[top](#index)  
```C#
//Data classes
class Student
{
	public string First { get; set; }
	public string Last { get; set; }
	public int ID { get; set; }
	public string Street { get; set; }
	public string City { get; set; }
	public List< int> Scores { get; set; }
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
        List< Student> students = new List< Student>()
        {
            new Student {First="Svetlana",
                Last="Omelchenko", 
                ID=111, 
                Street="123 Main Street",
                City="Seattle",
                Scores= new List< int> {97, 92, 81, 60}},
            new Student {First="Claire",
                Last="O’Donnell", 
                ID=112,
                Street="124 Main Street",
                City="Redmond",
                Scores= new List< int> {75, 84, 91, 39}},
            new Student {First="Sven",
                Last="Mortensen",
                ID=113,
                Street="125 Main Street",
                City="Lake City",
                Scores= new List< int> {88, 94, 65, 91}},
        };

		 // Create the second data source.
        List< Teacher> teachers = new List< Teacher>()
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
[top](#index)  
```C#
var query = from cust in customers
			select cust.City;

var query = from cust in Customers
			select new {Name = cust.Name, City = cust.City};
```

### Transforming in-Memory Objects into XML
[top](#index)  
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
[top](#index)  
create a connection in visual studio
reference it in code  
```C#
string connectString = System.Configuration.ConfigurationManager.ConnectionStrings["LinqToSQLDBConnectionString"].ToString();
LinqToSQLDataContext db = new LinqToSQLDataContext(connectString); 
```
Then use standard LINQ queries by referencing the ```LinqToSQLDataContext``` object.

## Generic Collections
[top](#index)  
Collections of like objects.

### Dictionary< T,U>
[top](#index)  
```C#
Dictionary< string, int> dict = new Dictionary< string,int>();
dict[key];
```
A Dictionary takes an object as a key and allows you to use those objects as indexers. it has a dynamic size.

### List< T>
[top](#index)  
```C#
List< int> newlist = new List< int>();
newlist[0];
```
A list holds a set of numbers that can be referenced like an array. It has a dynamic size.

### Queue< T>
[top](#index)  
```C#
Queue< object> aqueue = new Queue< object>();
//enqueue object
aqueue.Enqueue(new object());
//Look at next in line
aqueue.Peak();
//Remove the variable on the top
aqueue.Dequeue();
```
A queue uses the first in first out principal. You can add items to the back of the line with ```Dequeue()``` , see whats at the front with ```Peak()``` , and remove the first item from the Queue with ```Dequeue()```

### SortedList< T,U>
[top](#index)  
A collcetion of Key/Value pairs that are sorted by key based on the associeted IComparer< T> implementation.

Pretty much a Dictionary but doesn't follow input order. Sorts by key.

### Stack< T>
[top](#index)  
```C#
Stack< int> newstack = new Stack< int>();
//Push an object to the top of the stack.
newstack.Push(1);
//Look at the top of the stack
newstack.Peak();
//remove object from top of stack
newstack.Pop();
```
Stacks work on a first in last out principal. You can add varibles to the top of the stack with ```Push()``` , You can look at the top veriable with ```Peak()``` . You can remove the top variable with ```Pop()```

# Example Questions
[top](#index)  

Try statement, want new of the same error thrown but no stack change. Which statement?  
A. catch(Exception e) { throw new Exception(e); }  --- Will change the call stack  
B. catch(Execption) { throw; }  
C. catch(Exception e) { throw e; }  --- Clear the call stack  
D. catch(Exception) { throw new Exception; } ---Waste of time.  
Answer B  

Combine a bunch of text. Best way?  
A. String append operator +=  
B. String concatenation  
C. StringBuilder class  
D. StringWriter class  
Answer C  

Guy gives you password, must hash and salt can't expose provided password. What classes can be used to encrypt provided password at login?  
A. SHA1CryptoServiceProvider   --- Technically yes, but not actual.  
B. RSACryptoServiceProvider  
C. TripleDESCryptoServiceProvider  
D. MD5CryptoServiceProvider  --- Official answer  
Answer D  

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

