# Stock-Data-Analyzer

## Updates to fork

I have swapepd the Whisper Framework with a popular framework called Deepgram which offer many benefits, one being WAY faster transcription of audio files.
Deepgram also offers the uttility to trasncribe from live online sources using URL.

Deepgram offers 12,000 minutes or 200 hours of free transciption (which I've been using for this testing) after that pricing starts at $0.0145/min for the enhanced models and $0.0125/min for the base models. This framework also allows for the transcription of live web resources via URL. Further pricing information can be found here: https://deepgram.com/pricing/

run ```python3 find_microphones.py``` to find the PyAudio index value of a desried microphone on your machine.

requirements.txt is updated to install with Deepgram instead of Whisper.

## Orignal Mission Statement
The scope of this project is to create a system that can integrate onto a raspberry pi, and recognize the user's speech, store it as a python variable, and repeat the user's speech back to the user. The system will also be able to recognize the user's speech and perform a specific action based on the user's speech. 

## Setup

To set up the project, follow these steps:

1. Clone the repository: `git clone https://github.com/jackysiegs/GIO.git`

2. Create and activate a virtual environment in CLI (Unix)):

```
$ pip install virtualenv
$ python3.10 -m venv venv
$ source venv/bin/activate
```

3. Install the required packages: `pip install -r requirements.txt`

## Troubleshooting

If you encounter any issues with the project, try the following:

- Make sure you have the correct dependencies installed.

- Make sure you are running the project in the virtual environment.

- Check the project's documentation for any additional troubleshooting steps.

- Make sure to input a Deepgram API Key into transcriber.py

## Documentation

- [gTTS](https://pypi.org/project/gTTS/)
- [SpeechRecognition](https://pypi.org/project/SpeechRecognition/)
- [mpg321](https://mpg321.sourceforge.net/)
- [os](https://docs.python.org/3/library/os.html)
- [pyaudio](https://people.csail.mit.edu/hubert/pyaudio/)
- [pydub](https://pypi.org/project/pydub/)
- [wave](https://docs.python.org/3/library/wave.html)
- [Deepgram](https://developers.deepgram.com/sdks-tools/sdks/python-sdk/)
