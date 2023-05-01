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




## Documentation

- [gTTS](https://pypi.org/project/gTTS/)
- [SpeechRecognition](https://pypi.org/project/SpeechRecognition/)
- [mpg321](https://mpg321.sourceforge.net/)
- [os](https://docs.python.org/3/library/os.html)
- [pyaudio](https://people.csail.mit.edu/hubert/pyaudio/)
- [pydub](https://pypi.org/project/pydub/)
- [wave](https://docs.python.org/3/library/wave.html)
- [Deepgram](https://developers.deepgram.com/sdks-tools/sdks/python-sdk/)
