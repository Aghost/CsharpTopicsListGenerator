# C-sharp Topics
## Program flow
conditional logic
- if, else if, else
- switch
- for next
- for each
- while loop
- do loop
- break, continue
- recursion

## Strings
- StringBuilder, StringWriter, StringReader
- Search Strings
- Enumerate String methods
- String Formatting
- String Interpolation
- IsNullOrWhiteSpace()
- Regular Expressions
- IFormattable, IFormatProvider
- Char Encoding (UTF, ASCI, Unicode)

## Implementing Types
- Struct
- Class
- Fields
- Properties
- Methods
- Events
- Namespace, Namespace Alias
- Assembly
- EventHandler, EventHandler<T>, CancelEventHandler
- EventArgs, CancelEventArgs
- Constructors
- Access Modifiers (public, private, internal, abstract virtual)
- Enforce Encapsulation
- Constants and ReadOnly
- Method Overloading, Constructor Overloading
- yield, return
- Optional Parameters
- Positional Arguments, Named Arguments
- ref and out Parameters
- Constructor Chaining
- Enum, Enum Flags
- Static Classes and Members
- Nullable<T>
- Delegates, Func<T>, Action, Predicate<T>
- 'Using' Attributes
- Anonymous Types
- Anonymous Methods
- Extension Methods
- Dynamic Type
- Tuple
- Record
- Partial Class
- Partial Member

## Creating Class Hierarchies
- Class Inheritance, base and derived class
- Protected, Protected Internal
- Overriding Members
- Member Hiding
- Interfaces
- Implicit Interface Implementation, Explicit Interface Implementation
- Abstract Classes, Abstract Members
- Sealed Classes, Sealed Members
- Operator Overloading
- IEquatable, IComparable, IComparer

## Collections
- Array, Multi-dimensional Array, Jagged Array
- Iterating Across Collections
- ArrayList
- Not Strongly Typed Collections, Strongly Typed Collections, Generic Collections
- List<T>
- Indexer
- Dictonaries
- Stack<T>
- Queue<T>
- Implement Custom Collections
- Implement Collection Interfaces
- IEnumerable
- ICollection
- IList
- HybridDictionary
- HashSet (unique Items, hash for fast search)

## Type Conversions
- Parse, TryParse
- Convert Class
- Implicit conversion, Explicit conversion
- Operator is, as
- GetType(), typeof()
- Cast
- Cast Types
- Boxing and Unboxing
- Covariance and contravariance, coalescence
- Conversion operators, Cast

## Generics
- Create Generic Types
- Generic Constraints

## Sugar Syntax
- var
- Auto Implemented Properties
- Object initializers
- Collection Initializers
- Lambda Expressions
- Expression Bodied Members
- Pattern Matching

## Language-integrated Query (LINQ)
- Linq to Objects
- Linq to Xml
- Method syntax
- Where(), Select(), Any(), First(), FirstOrDefault(), Single(), OrderBy(), ThenBy(), Join(), Group()
- Query Syntax
- from, where, select, group by, orderby, join

## Visual Studio
- Visual Studio Installer
- Visual Studio Workloads and Components
- Solutions, projects, code files
- Project Template
- Item Template
- Code Region
- Code Snippet
- Refactor
- Output Window
- Task Pane
- Object Browser
- Class View Window
- Package Manager Console
- Property Window
- Solution Explorer
- Server Explorer
- SqlServer Object Explorer
- Project settings
- Code File Build Action
- C# versions
- Live Share
- Comments
- Documenting Code with Comments

## Exception Handling
- Exception Types
- Try, Catch, Finally
- Throwing and Rethrowing Exceptions
- Custom Exceptions
- Handling inner Exceptions
- InvalidOperationException
- ArgumentException
- NullReferenceException

## Debugging, Logging and Tracing
- TraceListeners, TraceSwitch, TraceLevels
- Profiling applications
- Create and monitor performance counters
- Create and use event logs
- Start Without Debugging, Start Debugging, Step into, Step Over
- Debug Symbols and Symbol Server
- Remote Debugging
- Breakpoint Conditions, Breakpoint Actions
- Locals -, Autos -, Watch-, Call Stack- and Immediate Window
- Debug Build, Release Build

## File System IO
- System.IO
- File, FileInfo, Directory, DirectoryInfo, Path
- Read and Write files using streamreaders and streamwriters
- Flush
- File Storage
- Implementing asynchronous Input/Output operations

## Serialization
- Serialization
- Using Json
- Validate Json
- Using XML
- Binary Serialization
- XML Serializer
- Json Serializer
- Data Contract Serializer
- Custom Serialization

## Application Settings and Resources
- app.config
- appsettings.json
- ConfigurationManager
- Resource Files
- Globalization, Localization
- ResGen

## Remoting
- Read Write files from network using System.Net
- TransactionScope
- HttpClient
- Use Data by using Windows Communication Foundation(WCF)

## ADO.NET
- SqlLite, SqlExpressLocalDb
- SqlConnection
- SqlCommand
- SqlParameter
- DataReader
- CRUD(Create, Read, Update, Delete) Data(SQLConnection from System.Data.SqlClient

## Entity Framework
- Entities and Navigation Properties
- DbContext
- DbSet<T>
- EntityState
- Change Tracking
- Query Data by using query comprehension syntax
- Select Data by using anonymous types
- IQueryable
- Lazy, Eager and Explicit Loading
- Find(), Include()
- Force execution of a query, deferred execution
- Code First Migrations
- Seed
- EF inheritance, TPH, TPC, TPT

## Threading
- Async and Await
- Tasks
- Continuation Tasks
- Threads and Threadpool
- Concurrent Collections
- Parallel LINQ
- Resource synchronization
- Implementing Locking
- Cancelling Long running Tasks with Cancelation Tokens
- Child and Nested Tasks
- Events and callbacks (TPM?, IAsyncResult, callback delegate)
- Handling AggregateExceptions
- TaskScheduler
- Task.Factory

## Security
- Manage Data Integrity
- Data Integrity by using Hashing data
- Cryptography and Cryptoanalysis
- Symmetric and Asymmetric Encryption
- Encryption using AES
- Encryption using Symmetric Standards
- Implementing public and private key management
- Digital signatures and certificates
- Implement Security Namespace
- Encrypting streams
- Authentication, Authorization
- WindowsPrincipal, WindowsIdentity, GenericPrincipal, GenericIdentity

## Reflection
- Creating Custom Attributes
- Use Reflection to process Attributes
- Use Reflection to load and run Assemblies and Types

## Managed Code Execution Environment
- .NET Framework, .Net Core, .NET5
- Project references, Project dependancies
- CLR, JIT, UTS
- checked, unchecked
- Assemblies and the ApplicationDomain
- Inspect IL and MetaData with ILdasm.exe
- Garbage Collection
- using(){}
- IDisposable
- WeakReference
- Manage Unmanaged Resources
- Dispose Pattern
- AddMemoryPressure
- Versioning Assemblies
- BindingRedirect
- SupportedRuntime, RequiredRuntime
- Sign assemblies by using strong names
- Adding to the Global Assembly Cache (GAC)
- Implementing side-by-side Hosting
- Create a WinMD, WinRT assembly
- RuntimeServices
- Unsafe

## Unmanaged Code
- Primary Interop Assembly
- RCW, Type Library Imported (Tlbimp.exe)
- CCW, Type Library Exporter (Tlbexp.exe)
- RegAsm.exe, RegSvr...exe, RegEdit.exe
- IUnknown
- SafeHandle

## Generate Code by using CodeDOM
- CodeCompileUnit
- CodeDomProvider

## Console Aplication
- Title
- Write, Read, WriteLine, ReadLine
- Clear
- ForegoundColor, BackgroundColor, ConsoleColors, ResetColors

## Testing
- Types of Errors
- Syntax or Compile Error
- Runtime Error (Exception)
- Logical Error
- Test Pyramid
- Unit Test
- Arrange, Act Assert
- Test Frameworks, MsTest, xUnit

## Windows Presentation Foundation
- Input Controls
- Container Controls
- Window, Page, Style
- Data / Command Binding
- MVVM / MVP

## HTML
- Markup elements, tags, and attributes
- Structure of a document (html, head, body)
- Headers (h1-h6)
- p, div, ul, ol, li, span, hr
- Input Elements
- Linking scripts and css files
- Header, footer, section, article, nav, figure
- Autofocus, readonly, disabled
- Images,
- Video, Audio

## CSS
- Inline, Internal, External css
- Css selectors
- Colors
- Fonts and Font-styles
- Transparency
- Visibility
- Background
- Units
- Box model
- Media queries
- Display
- Positioning
- Floating
- Transitions
- Animations

## Javascript
- Variables and Datatypes
- Conditional and loop statements
- Functions
- Scoping Hoisting
- DOM
- Objects
- Object Literal Notation
- JSON
- Prototypes
- ES2015(class, module)
- WebStorage
- WebWorkers
- GeoLocation
- WebSockets
- Offline Support

## SPA
## Progressive Web App
## ASP.NET
## ASP.NET MVC
## ASP.NET Web Api
## Blazor
## Github
## Azure Fundamentals
## Azure Developer
## Azure DevOps
