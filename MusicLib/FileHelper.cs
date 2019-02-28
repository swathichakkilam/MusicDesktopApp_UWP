using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;

namespace MusicLib
{
    static class FileHelper
    {
        public static async void WriteTextFileAsyc(string fileName, string content)
        {
            var localFolder = ApplicationData.Current.LocalFolder;
            var textFile = await localFolder.CreateFileAsync(fileName, CreationCollisionOption.OpenIfExists);

            var textStream = await textFile.OpenAsync(FileAccessMode.ReadWrite);
            var textWriter = new DataWriter(textStream);
            textWriter.WriteString(content);
            await textWriter.StoreAsync();
        }
    }
}
