using Google.Cloud.Firestore;

namespace OPSC_API.Models
{
    public class Question
    {
        [FirestoreProperty]
        public string QuestionID {  get; set; }
        [FirestoreProperty]
        public string QuestionContent {  get; set; }
        [FirestoreProperty]
        public string OptionA {  get; set; }
        [FirestoreProperty]
        public string OptionB { get; set; }
        [FirestoreProperty]
        public string OptionC {  get; set; }
        [FirestoreProperty]
        public string OptionD { get; set; }
        [FirestoreProperty]
        public string CorrectAnswer { get; set; }
    }
}
