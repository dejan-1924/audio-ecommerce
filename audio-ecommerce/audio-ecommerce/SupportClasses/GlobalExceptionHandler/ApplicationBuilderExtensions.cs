using audio_ecommerce.SupportClasses.GlobalExceptionHandler.CustomExceptions;

namespace audio_ecommerce.SupportClasses.GlobalExceptionHandler
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder AddGlobalExceptionHandler(this IApplicationBuilder applicationBuilder)
            => applicationBuilder.UseMiddleware<GEHMiddleware>();
    }
}
