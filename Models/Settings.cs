using Google.Cloud.Firestore;

namespace OPSC_API.Models
{
    [FirestoreData]
    public class Settings
    {
        [FirestoreProperty]
        public string Theme { get; set; } = "Light";


    }
}
