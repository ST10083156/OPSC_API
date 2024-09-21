using Google.Cloud.Firestore;

namespace OPSC_API.Models
{

    [FirestoreData]
    public class User
    {
        [FirestoreProperty]
        public string UserID { get; set; }

        [FirestoreProperty]
        public string Name { get; set; }

        [FirestoreProperty]
        public string Email { get; set; }

        [FirestoreProperty]
        public string Password {  get; set; }

        [FirestoreProperty]
        public string Username {  get; set; }

        [FirestoreProperty]
        public Settings Settings { get; set; }

        [FirestoreProperty]
        public List<User> Friends { get; set; }

        [FirestoreProperty]
        public List<User> Requests { get; set; }
    }
}
