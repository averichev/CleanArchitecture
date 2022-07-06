using System;
using APP.Contracts.Data;

namespace DMN.Logic.Application
{
    public class ApplicationInformation : IApplicationInformation
    {
        public DateTime CurrentTime => DateTime.Now;
    }
}