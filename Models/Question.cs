using Google.Cloud.Firestore;

namespace OPSC_API.Models
{
    [FirestoreData]
    public class Question
    {
        [FirestoreProperty]
        public string QuestionText { get; set; } 

        [FirestoreProperty]
        public string Answer_1 { get; set; }

        [FirestoreProperty]
        public string Answer_2 { get; set; }

        [FirestoreProperty]
        public string Answer_3 { get; set; } 

        [FirestoreProperty]
        public string Answer_4 { get; set; } 

        [FirestoreProperty]
        public string CorrectAnswer { get; set; } 
    }
}
