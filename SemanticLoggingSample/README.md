# Semantic Logging
This sample ASP.NET MVC project helps to understand Enterprise Library Semantic Logging.

1. Start by creating an empty ASP.NET MVC project - Project1
2. Add Home controller
3. Add another class library project for Tracing/Logging - Project2
4. Create custom EventSource class in Project2
5. Add reference of Project2 in Project1
6. Consume the tracing/logging library in Project1 to start tracing
7. Raise from events from the web application - Project1
8. Start PerfView to collect event traces from the application
[OPTIONAL] Install a nuget pacakge for event source analysis - Install-Package EnterpriseLibrary.SemanticLogging.EventSourceAnalyzer
9. Install and run Out-of-Process Windows Service/Console Host
10. Install the nuget package "Semantic Logging Application Block - Out-of-process Service""
11. Run PowerShell from the installed nuget package to resolve additional dependencies
12. Update the SemanticLogging-svc.xml file with the required event source and sinks
13. Run the Out-of-Process console to collect the traces from the application
