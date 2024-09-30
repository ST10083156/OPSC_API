using Google.Cloud.Firestore;

namespace OPSC_API.Models
{
    [FirestoreData]
    public class User
    {
        [FirestoreProperty]
        public string ID { get; set; }

        [FirestoreProperty]
        public string Name { get; set; }

        [FirestoreProperty]
        public string Username { get; set; }

        [FirestoreProperty]
        public string? Image { get; set; }

        [FirestoreProperty]
        public int Score { get; set; }
    }
}
