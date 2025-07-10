namespace HotelBookingAPI.DTOs.UserDTOs
{
    public class CreateUserResponseDTO
    {
        public int UserId { get; set; } // it was string i marked it to string
        public string Message { get; set; }
        public bool IsCreated { get; set; }

    }
}
