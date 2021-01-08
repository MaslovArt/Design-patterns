using System;

namespace TemplateMethod
{
    public class LotsSynchronizer : Synchronizer
    {
        public override void Connect()
        {
            Console.WriteLine("Lots: connecting...");
        }

        public override void GetData()
        {
            Console.WriteLine("Lots: getting data...");
        }

        public override void Map()
        {
            Console.WriteLine("Lots: mapping...");
        }

        public override void UploadData()
        {
            Console.WriteLine("Lots: uploading");
        }
    }
}
