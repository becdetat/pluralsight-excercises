using System;
using System.IO;
using System.Linq;
using System.Windows;
using Microsoft.Phone.Controls;
using Windows.ApplicationModel;
using Windows.Phone.Speech.Synthesis;

namespace TextToSpeech
{
    public partial class MainPage : PhoneApplicationPage
    {
        private readonly SpeechSynthesizer _speechSynthesizer = new SpeechSynthesizer();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void TextToSpeech_OnClick(object sender, RoutedEventArgs e)
        {
            await _speechSynthesizer.SpeakTextAsync("Text to speech");
        }

        private async void TextToSpeechDifferentLanguage_OnClick(object sender, RoutedEventArgs e)
        {
            var frenchVoice = InstalledVoices.All
                                             .First(v => v.Language == "fr-FR" && v.Gender == VoiceGender.Female);
            _speechSynthesizer.SetVoice(frenchVoice);

            await _speechSynthesizer.SpeakTextAsync("Salut tout le monde!");
        }

        private async void TextToSpeechSsml_OnClick(object sender, RoutedEventArgs e)
        {
            var ssml = @"
<speak version='1.0' xmlns='http://www.w3.org/2001/10/synthesis' xml:lang='en-US'>
Text to speech from SSML
</speak>
                ";

            await _speechSynthesizer.SpeakSsmlAsync(ssml);
        }

        private async void TextToSpeechSsmlFromFile_OnClick(object sender, RoutedEventArgs e)
        {
            var path = Path.Combine(Package.Current.InstalledLocation.Path, "SSMLFromFile.xml");
            var changeVoice = new Uri(path, UriKind.Absolute);

            await _speechSynthesizer.SpeakSsmlFromUriAsync(changeVoice);
        }
    }
}