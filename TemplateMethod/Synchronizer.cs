namespace TemplateMethod
{
    public abstract class Synchronizer
    {
        public void Sync()
        {
            Connect();
            GetData();
            Map();
            UploadData();
        }

        public abstract void Connect();
        public abstract void GetData();
        public abstract void Map();
        public abstract void UploadData();
    }
}
