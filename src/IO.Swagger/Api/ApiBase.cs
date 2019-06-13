using System;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
  public abstract class ApiBase
  {
    private ExceptionFactory _exceptionFactory = (name, response) => null;

    protected ApiBase()
    {
      // use the default one in Configuration
      Configuration = Configuration.Default;

      ExceptionFactory = Configuration.DefaultExceptionFactory;

      // ensure API client has configuration ready
      if (Configuration.ApiClient.Configuration == null)
      {
        Configuration.ApiClient.Configuration = Configuration;
      }
    }

    protected ApiBase(Configuration configuration)
    {
      if (configuration == null)
      {
        throw new ArgumentNullException(nameof(configuration));
      }

      Configuration = configuration;

      ExceptionFactory = Configuration.DefaultExceptionFactory;

      // ensure API client has configuration ready
      if (Configuration.ApiClient.Configuration == null)
      {
        Configuration.ApiClient.Configuration = Configuration;
      }
    }

    public Configuration Configuration { get; set; }

    /// <summary>
    /// Provides a factory method hook for the creation of exceptions.
    /// </summary>
    public ExceptionFactory ExceptionFactory
    {
      get
      {
        if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
        {
          throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
        }
        return _exceptionFactory;
      }
      set => _exceptionFactory = value;
    }
  }
}
