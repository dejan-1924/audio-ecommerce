namespace audio_ecommerce.SupportClasses.GlobalExceptionHandler.CustomExceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base(message)
        { }

    }
}
