# D365FO-ManagedExceptions

It's a proof of concept showing how managed (.NET, CLR) exceptions can be thrown from X++ code in Microsoft Dynamics 365 for Finance and Operations.

Refer to the blog post [Throwing managed exceptions from X++ in D365FO](http://dev.goshoom.net/en/2018/10/throwing-managed-exceptions/) for more details.

To run the code, you must put the content of the *Metadata* folder to the modelstore of D365FO (e.g. *C:\AOSService\PackagesLocalDirectory* or *K:\AOSService\PackagesLocalDirectory*).Then you can build the Visual Studio solution and run the code. Sample code is in the project called *Example*.

Code was built on platform update 20.
