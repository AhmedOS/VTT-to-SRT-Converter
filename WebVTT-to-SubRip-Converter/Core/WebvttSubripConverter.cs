using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;

namespace VttSrtConverter.Core
{
    class WebvttSubripConverter
    {

        static string subripFileExtension = ".srt";

        public void ConvertToSubrip(string inputFilePath, string outputFolderPath)
        {
            String webvttSubtitle;
            using (StreamReader stream = new StreamReader(inputFilePath))
                webvttSubtitle = stream.ReadToEnd();

            String subripSubtitle = ConvertToSubrip(webvttSubtitle);

            string fileName = Path.GetFileNameWithoutExtension(inputFilePath) + subripFileExtension;
            string outputFilePath = outputFolderPath + '\\' + fileName;
            using (StreamWriter outputFile = new StreamWriter(outputFilePath))
                outputFile.Write(subripSubtitle);
        }

        public String ConvertToSubrip(String webvttSubtitle)
        {
            StringReader reader = new StringReader(webvttSubtitle);
            StringBuilder output = new StringBuilder();
            int lineNumber = 1;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (IsTimecode(line))
                {

                    output.AppendLine(lineNumber.ToString());
                    lineNumber++;

                    line = line.Replace('.', ',');

                    line = DeleteCueSettings(line);

                    string timeSrt1 = line.Substring(0, line.IndexOf('-'));
                    string timeSrt2 = line.Substring(line.IndexOf('>') + 1);
                    DateTime timeAux1 = DateTime.ParseExact(timeSrt1.Trim(), "mm:ss,fff", CultureInfo.InvariantCulture);
                    DateTime timeAux2 = DateTime.ParseExact(timeSrt2.Trim(), "mm:ss,fff", CultureInfo.InvariantCulture);
                    line = timeAux1.ToString("HH:mm:ss,fff") + " --> " + timeAux2.ToString("HH:mm:ss,fff");

                    output.AppendLine(line);

                    bool foundCaption = false;
                    while (true)
                    {
                        if ((line = reader.ReadLine()) == null)
                        {
                            if (foundCaption)
                                break;
                            else
                                throw new Exception(Strings.invalidFile);
                        }
                        if (String.IsNullOrEmpty(line) || String.IsNullOrWhiteSpace(line))
                        {
                            output.AppendLine();
                            break;
                        }
                        foundCaption = true;
                        output.AppendLine(line);
                    }
                }
            }
            return output.ToString();
        }

        bool IsTimecode(string line)
        {
            return line.Contains("-->");
        }

        string DeleteCueSettings(string line)
        {
            StringBuilder output = new StringBuilder();
            foreach (char ch in line)
            {
                char chLower = Char.ToLower(ch);
                if (chLower >= 'a' && chLower <= 'z')
                {
                    break;
                }
                output.Append(ch);
            }
            return output.ToString();
        }

    }
}
