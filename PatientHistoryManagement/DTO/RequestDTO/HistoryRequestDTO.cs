namespace PatientHistoryManagement.DTO.RequestDTO
{
    public class HistoryRequestDTO
    {
        public int PatientId { get; set; }
        public string Issue { get; set; }
        public DateTime VisitsToDoctor { get; set; }
    }
}
