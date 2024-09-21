using Google.Cloud.Firestore;

namespace OPSC_API.Models
{
    [FirestoreData]
    public class Score
    {
        [FirestoreProperty]
        public string UserID {  get; set; }
        [FirestoreProperty]
        public string QuizID { get; set; }

        [FirestoreProperty]
        public int QuizScore {  get; set; }
    }
}
