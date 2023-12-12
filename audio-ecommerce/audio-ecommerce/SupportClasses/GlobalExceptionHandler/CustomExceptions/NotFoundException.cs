namespace audio_ecommerce.SupportClasses.GlobalExceptionHandler.CustomExceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        { }
    }
}
