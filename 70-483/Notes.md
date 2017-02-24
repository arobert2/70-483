###70-483 Notes

**Parallelism** - The use of multiple threads in an application
**Synchronization** - the mechanism of ensuring that two threads don't execute a specific portion of your program at the same time.

The Thread Class

System.Threading

Used to create new threads, manage their priority, and get their status.
The thread class isn't commonly used.
It gives you full access to the thread.

**Thread.Sleep(0)** - Used to signal that the thread is complete so it can continue instead of using the entire time-slice.
**Priority** - priority can be set for a thread. Low priorty is for minor stuff. Example from book screen saver. High priort stuff should be used sparingly. Default is Normal.
**background and forground** - *background* - Threads that will close when the application closes.
                               *foreground* - Threads that will only close once they are finished. Application will continue to run until thread is complete.
**ParamaterizedThreadStart delegate** - *Thread constructor* - Can be used if you want to pass some data to your worker method.
		```C#
		Thread t = new Thread(new ThreadStart(ThreadMethod));
		t.Start();
		```
		```C#
		Thread t = new Thread(ParameterizedThreadStart(new ThreadMethod));
		t.Start(object);
		```

**Thread.Abort** - Aborts a thread. Will throw **ThreadAbort-Exception** which must be handled.

Best way to stop thread is with cancelation token. The task should monitor for the token and if found stop the thread.
For threads this is just an variable you can check for, probably a bool.

**ThreadStatic** - Attribute that allows threads to have their own non local data. Below the var is declared externally but each gets their own variable to modify.
		```C#
		[ThreadStatic]
		var staticvar;
		Thread t = new Thread(new ThreadStart(() => staticvar = "thread one"));
		Thread t1 = new Thread(ThreadStart(() => staticvar = "thread two"));
		```

**ThreadLocal<T>** - Lets you declare an higher scope variable local to a thread.
		```C#
		public ThreadLocal<int> localint;
		```