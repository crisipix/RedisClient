Redis Desktop Manager : http://docs.redisdesktop.com/en/latest/quick-start/


Youll need this : 
https://github.com/MSOpenTech/redis/releases
Redis on Windows

    This is a port for Windows based on Redis.
    We officially support the 64-bit version only. Although you can build the 32-bit version from source if desired.
    You can download the latest unsigned binaries and the unsigned MSI installer from the release page.
    For releases prior to 2.8.17.1, the binaries can found in a zip file inside the source archive, under the bin/release folder.
    Signed binaries are available through NuGet and Chocolatey.
    Redis can be installed as a Windows Service.

Windows-specific changes

    There is a replacement for the UNIX fork() API that simulates the copy-on-write behavior using a memory mapped file on 2.8. Version 3.0 is using a similar behavior but dropped the memory mapped file in favor of the system paging file.
    In 3.0 we switch the default memory allocator from dlmalloc to jemalloc that is supposed to do a better job at managing the heap fragmentation.
    Because Redis makes some assumptions about the values of file descriptors, we have built a virtual file descriptor mapping layer.
	
https://github.com/StackExchange/StackExchange.Redis

StackExchange.Redis is a high performance general purpose redis client for .NET languages (C# etc). It is the logical successor to BookSleeve, and is the client developed-by (and used-by) Stack Exchange for busy sites like Stack Overflow. For the full reasons why this library was created (i.e. "What about BookSleeve?") please see here.
Features

    High performance multiplexed design, allowing for efficient use of shared connections from multiple calling threads
    Abstraction over redis node configuration: the client can silently negotiate multiple redis servers for robustness and availability
    Convenient access to the full redis feature-set
    Full dual programming model both synchronous and asynchronous usage, without requiring "sync over async" usage of the TPL
    Support for redis "cluster"

Installation

StackExchange.Redis can be installed via the nuget UI (as StackExchange.Redis), or via the nuget package manager console:

PM> Install-Package StackExchange.Redis

If you require a strong-named package (because your project is strong-named), then you may wish to use instead:

PM> Install-Package StackExchange.Redis.StrongName

(for further reading, see here)
Documentation

    Basic Usage - getting started and basic usage
    Configuration - options available when connecting to redis
    Pipelines and Multiplexers - what is a multiplexer?
    Keys, Values and Channels - discusses the data-types used on the API
    Transactions - how atomic transactions work in redis
    Events - the events available for logging / information purposes
    Pub/Sub Message Order - advice on sequential and concurrent processing
    Where are KEYS / SCAN / FLUSH*? - how to use server-based commands
    Profiling - profiling interfaces, as well as how to profile in an async world
    Scripting - running Lua scripts with convenient named parameter replacement
