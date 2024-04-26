using Microsoft.AspNetCore.Mvc;
using PatientHistoryManagement.DTO.RequestDTO;

namespace PatientHistoryManagement.Interface
{
    public interface IPatientHistory
    {
        public Task<ActionResult<List<object>>> AddPatientHistory(HistoryRequestDTO historyRequestDto, int userId);
        public Task<ActionResult<List<object>>> GetHistory(int PatientId, int userId);
    }
}
