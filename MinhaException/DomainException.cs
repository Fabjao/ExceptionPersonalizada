using System;

namespace Exception.MinhaException
{
  public class DomainException : ApplicationException
  {
    public DomainException(string mensagem) : base(mensagem)
    {
    }
  }
}