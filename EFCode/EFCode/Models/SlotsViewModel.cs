namespace EFCode.Models
{
    [Serializable]
    public class SlotsViewModel
    {
        public string Name { get; set; }
        public string UserEmail { get; set; }
        public string UserType { get; set; }
        public double rating { get; set; }
        public string UserMessage { get; set; }
        public string StudentUserName { get; set; }
        public List<string> TutorUserName { get; set; }
        public DateTime Date { get; set; }
        public List<string> Value { get; set; }
        public List<string> Requests { get; set; }
        public List<string> RequestStatus { get; set; }
        public List<string> studentUsernameList { get; set; }
        public List<string> studentrequestsDates { get; set; }
        public List<string> studentrequestsSlots { get; set; }
        public List<string> studentsUnameList { get; set; }

        public List<string> StudentList { get; set; }
		public List<string> StudentInfo { get; set; }

        public List<string> MessageStatus { get; set; }
        
    }
}
