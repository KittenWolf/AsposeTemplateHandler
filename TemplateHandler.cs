using Aspose.Words;
using Aspose.Words.Replacing;
using System;
using System.Collections.Generic;

namespace AsposeTemplateHandler
{
    internal class TemplateHandler
    {
        public void FillTemplate(string template, Dictionary<string, string> data, string saveDir)
        {
            var savePath = $"{saveDir}\\{Guid.NewGuid()}.docx";
            var totalReplacements = 0;

            try
            {
                var doc = new Document(template);
                var option = new FindReplaceOptions
                {
                    FindWholeWordsOnly = true,
                    MatchCase = true
                };

                foreach (var item in data)
                {
                    totalReplacements += doc.Range.Replace(item.Key, item.Value, option);
                }

                if (totalReplacements > 0 )
                {
                    doc.Save(savePath);
                } 
                else
                {
                    Console.WriteLine("Data is not valid for this template.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
