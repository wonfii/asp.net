namespace data_access.Entities
{
    public class FieldOfStudySubject
    {
        public int FieldOfStudyId { get; set; }
        public FieldOfStudy FieldOfStudy { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }

}
