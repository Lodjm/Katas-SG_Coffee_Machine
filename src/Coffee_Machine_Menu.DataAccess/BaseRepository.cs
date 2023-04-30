using Newtonsoft.Json;

namespace Coffee_Machine_Menu.DataAccess
{
    public class BaseRepository
    {
        private readonly string _fileName = string.Empty;
        private readonly string _dataPath = string.Empty;

        public BaseRepository(string fileName, string dataPath)
        {
            _fileName = fileName;
            _dataPath = dataPath;
        }

        public IEnumerable<T> GetData<T>()
        {
            if (!string.IsNullOrEmpty(_dataPath))
            {
                if (Directory.Exists(_dataPath))
                {
                    if (!string.IsNullOrEmpty(_fileName))
                    {
                        var filePath = Path.Combine(_dataPath, _fileName);
                        if (File.Exists(filePath)) 
                        {
                            try
                            {
                                using StreamReader reader = new StreamReader(filePath);
                                var json = reader.ReadToEnd();
                                if (json != null)
                                {
                                    return JsonConvert.DeserializeObject<IEnumerable<T>>(json);
                                }
                            }
                            catch
                            {
                                return Enumerable.Empty<T>();
                            }
                        }
                    }
                }
            }
            return Enumerable.Empty<T>();
        }
    }
}