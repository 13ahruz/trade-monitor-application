TradeMonitorApp
TradeMonitorApp is a WPF application designed to monitor a directory for trade data files in CSV, XML, or TXT formats. It automatically loads new files, parses the trade data, and displays it in a user-friendly interface. The application utilizes a plugin-based architecture for data loaders and implements the MVVM design pattern with dependency injection to ensure maintainability and testability.

Features:
	Real-time Directory Monitoring: Automatically detects and processes new trade data files added to a specified directory.
	Support for Multiple File Formats: Parses trade data from CSV, XML, and TXT files.
	Extensible Loader Architecture: Easily add support for new file formats via the plugin-based loader system.
	Data Visualization: Displays trade data in a DataGrid with columns for Date, Open, High, Low, Close, and Volume.
	Logging: Implements Serilog for logging application events and errors.
	Unit Testing: Comprehensive test suite using xUnit and Moq to ensure application reliability.

Requirements:
	Operating System: Windows 7 or later
	Framework: .NET 8.0 or later

Dependencies:
	WPF
	Microsoft.Extensions.DependencyInjection
	Serilog
	Serilog.Sinks.File
	Serilog.Sinks.Console
	CsvHelper
	xUnit (for testing)
	Moq (for testing)
	FluentAssertions (optional, for testing)