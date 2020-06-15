using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace YoutubeDownloaderv2
{
    public partial class main : Form
    {
        string destination;
        int version, revision;
        YoutubeClient youtube = new YoutubeClient();
        public main()
        {
            version = 2;
            revision = 1;
            InitializeComponent();
            destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\"; //set default path to users' desktop
            // flip the right youtube icon; this isn't really important
            Image flip = pictureBox2.Image;
            flip.RotateFlip(RotateFlipType.Rotate180FlipY);
            pictureBox2.Image = flip;
            vDisplay.Text = "Version: " + version + "." + revision;
        }

        private async void loadData_Click(object sender, EventArgs e)
        {
            try
            {
                var video = await youtube.Videos.GetAsync(urlInput.Text);
                var title = video.Title;
                var author = video.Author;
                var duration = video.Duration;
                log.Text += "Video: " + title + "\r\nYoutuber: " + author + "\r\nDuration: " + duration + "\r\n\r\n";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: Enter a valid Youtube URL!", "Error");
                log.Text += "Error: Enter a valid Youtube URL!\r\n\r\n";
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Error: Something went wrong! Either YouTube is offline, being blocked by your firewall or you don't have an Internet connection! Please try again.", "Error");
                log.Text += "Error: Something went wrong! Either YouTube is offline, being blocked by your firewall or you don't have an Internet connection! Please try again.\r\n\r\n";
            }
        }

        private async void downloadMP4_Click(object sender, EventArgs e)
        {
            try
            {
                log.Text += "Download Video started. Please wait for a completion message. Some videos may take some time to download.\r\n";
                downloadMP4.Enabled = false;
                downloadMP3.Enabled = false;
                changeDirectory.Enabled = false;
                var video = await youtube.Videos.GetAsync(urlInput.Text);
                var title = video.Title;

                var converter = new YoutubeConverter(youtube); // re-using the same client instance for efficiency, not required

                // Get stream manifest
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(urlInput.Text);

                // Select audio stream
                var audioStreamInfo = streamManifest.GetAudio().WithHighestBitrate();

                // Select video stream
                var videoStreamInfo = streamManifest.GetVideo().WithHighestVideoQuality();

                // Combine them into a collection
                var streamInfos = new IStreamInfo[] { audioStreamInfo, videoStreamInfo };

                // remove illegal path characters
                title = RemoveInvalidChars(title);

                // Download and process them into one file
                await converter.DownloadAndProcessMediaStreamsAsync(streamInfos, destination + title + ".mp4", "mp4");
                log.Text += "Download Video Complete.\r\n\r\n";
                downloadMP4.Enabled = true;
                downloadMP3.Enabled = true;
                changeDirectory.Enabled = true;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: Enter a valid Youtube URL!", "Error");
                log.Text += "Error: Enter a valid Youtube URL!\r\n\r\n";
                downloadMP4.Enabled = true;
                downloadMP3.Enabled = true;
                changeDirectory.Enabled = true;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Error: Something went wrong! Either YouTube is offline, being blocked by your firewall or you don't have an Internet connection! Please try again.", "Error");
                log.Text += "Error: Something went wrong! Either YouTube is offline, being blocked by your firewall or you don't have an Internet connection! Please try again.\r\n\r\n";
                downloadMP4.Enabled = true;
                downloadMP3.Enabled = true;
                changeDirectory.Enabled = true;
            }

        }

        public string RemoveInvalidChars(string filename)
        {
            return string.Concat(filename.Split(Path.GetInvalidFileNameChars()));
        }

        // does not allow the user to edit the log
        private void log_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void log_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void changeDirectory_Click(object sender, EventArgs e)
        {
            // allows the user to change the download path
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                destination = folderBrowserDialog.SelectedPath + "\\";
                log.Text += "Download Directory Changed To: " + destination + "\r\n\r\n";
            }
        }

        private async void downloadMP3_Click(object sender, EventArgs e)
        {
            try
            {
                log.Text += "Download Audio started. Please wait for a completion message. Some videos may take some time to download.\r\n";
                downloadMP4.Enabled = false;
                downloadMP3.Enabled = false;
                changeDirectory.Enabled = false;
                var video = await youtube.Videos.GetAsync(urlInput.Text);
                var title = video.Title;

                // Get stream manifest
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(urlInput.Text);

                var streamInfo = streamManifest.GetAudioOnly().WithHighestBitrate();

                // remove illegal path characters
                title = RemoveInvalidChars(title);

                await youtube.Videos.Streams.DownloadAsync(streamInfo, destination + title + ".mp3");
                log.Text += "Download Audio Complete.\r\n\r\n";
                downloadMP4.Enabled = true;
                downloadMP3.Enabled = true;
                changeDirectory.Enabled = true;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: Enter a valid Youtube URL!", "Error");
                log.Text += "Error: Enter a valid Youtube URL!\r\n\r\n";
                downloadMP4.Enabled = true;
                downloadMP3.Enabled = true;
                changeDirectory.Enabled = true;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Error: Something went wrong! Either YouTube is offline, being blocked by your firewall or you don't have an Internet connection! Please try again.", "Error");
                log.Text += "Error: Something went wrong! Either YouTube is offline, being blocked by your firewall or you don't have an Internet connection! Please try again.\r\n\r\n";
                downloadMP4.Enabled = true;
                downloadMP3.Enabled = true;
                changeDirectory.Enabled = true;
            }

        }

        private void creditsB_Click(object sender, EventArgs e)
        {
            // show respective credits
            credits open = new credits();
            open.Show();
        }
    }
}
