# Stock-Data-Analyzer

## About
This is a project I developed in order to build my skills working with C# and the .NET framework. 

Within this repository you will find the code and executable for a Windows Form Applications that analyzes and detects stock market patterns by running algorithms against .csv files from https://finance.yahoo.com

## For Developers
Before you get started playing with the code that makes up my project make sure you have the following:

- A computer running Windows 7 or later.

- The .NET Framework 4.6 or later. https://dotnet.microsoft.com/download

- Visual Studio 2019 or later. https://visualstudio.microsoft.com/downloads

After you make sure you have these dependecies simply clone the repository 

`git clone https://github.com/jackysiegs/Stock-Data-Analyzer.git`

Then open the file "Stock Data Analyzer.sln" from the main folder.

## For Users

To set up the project, follow these steps:

1. Clone the repository: `git clone https://github.com/jackysiegs/Stock-Data-Analyzer.git`

2. Navigate to Stock Data.exe within the project which can be found here:

`/Stock-Data-Analyzer/Stock Data Analyzer/bin/Debug/Stock Data.exe`

3. Open Stock Data.exe and start analyzing candlestick data!



## How to Use

1. The first form will provide the user with the options to select the following:

- DATE
- PERIOD (daily, weekly, monthly)
- TICKER

Select each of these to your liking, then hit the "Load" button to spawn a graph form with the respective information.

You can load as many graphs as you please.

2. Following step 1 a chart form will appear with the following capabilities:

- A candlestick graph displaying market information for the TICKER selected.
- Pattern Selection: Select a pattern from the drop-down list and then press the "Load" button to annotate the identified candlesticks.
- Clear: Click the "Clear" button to remove annotated candlesticks from the current chart.
- Zoom: Drag over any portion of the graph to zoom in and then hit the "Zoom-out" button to zoom out.


## Loading Additional Stock Data

The program comes with daily, weekly, and monthly stock data for:

- AAPL
- GOOGL
- IBM
- META
- MSFT
- TSLA

To load aditional stock information do the following:

1. Go to https://finance.yahoo.com

2. In the search bar type the specific stock you are looking for then click it.

3. Once at the page of your selected stock navigate to the "Historical Data" section.

4. Select the time period and dates you want to analyze and then click "Download" to recieve your .csv

5. Navigate to the "Stock Data" folder in the project found here:

`/Stock-Data-Analyzer/Stock Data Analyzer/bin/Debug/Stock Data`

6. Name the file you downloaded `<TICKER>-<PERIOD>.csv` for example:
  
  `TSLA-Day.csv` `AAPL-Week.csv` `MSFT-Month.csv`
  
7. Note that the project will only load the PERIOD and DATEs pertaining to information related to the .csv that you downloaed.
  
   Becase of this it would be good practice to download Daily, Weekly, and Monthly data for each TICKER you would like to observe.
  
   It is also recommended to download 1 year of Daily data, 2 years of Weekly data, and 5 years or Month data.
  
8. Add the downloaded .csv files to the "Stock Data" folder then run "Stock Data.exe" like normal!




## Documentation

- [.NET Framework](https://docs.microsoft.com/en-us/dotnet/framework/)
- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
