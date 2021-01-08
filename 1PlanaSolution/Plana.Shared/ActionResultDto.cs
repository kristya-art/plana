namespace Plana.Shared
{
    public class ActionResultDto<T> where T : new()
    {
        public ActionResultDto()
        {
        }

        public ActionResultDto(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public ActionResultDto(T data)
        {
            Data = data;
        }

        public string ErrorMessage { get; set; }
        
        public T Data { get; set; }

        public static implicit operator ActionResultDto<T>(T data) => new ActionResultDto<T>(data);
    }
}
