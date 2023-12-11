using WebApiDeneme.Models;

namespace WebAPICrud.Data
{
    public class SeedData
    {
        public IEnumerable<PersonalInfo> GetPersonalInfoList()
        {
            List<PersonalInfo> listPersonalInfo = new List<PersonalInfo>();
            for (int i = 0; i < 1000; i++)
            {
                Random _Random = new Random();
                PersonalInfo _PersonalInfo = new()
                {
                    Name = "Tom-" + GenerateString(6),
                    City = GenerateString(4),
                    Country = GenerateString(4),
                    Email = "dev@" + GenerateString(6),

                    CreatedDate = DateTime.Now.AddDays(-_Random.Next(30)),
                    UpdatedDate = DateTime.Now.AddDays(-_Random.Next(30))
                };
                listPersonalInfo.Add(_PersonalInfo);
            }
            return listPersonalInfo;
        }

        Random _Random = new();
        public const string Alphabet = "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public string GenerateString(int size)
        {
            char[] chars = new char[size];
            for (int i = 0; i < size; i++)
            {
                chars[i] = Alphabet[_Random.Next(Alphabet.Length)];
            }
            return new string(chars);
        }
    }
}