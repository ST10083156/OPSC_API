using Google.Cloud.Firestore;

namespace OPSC_API.Models
{
    [FirestoreData]
    public class Quiz
    {
        [FirestoreProperty]
        public string QuizID { get; set; }

        [FirestoreProperty]
        public string Category {  get; set; }

        [FirestoreProperty]
        public Question[] Questions { get; set; }
    }
}
