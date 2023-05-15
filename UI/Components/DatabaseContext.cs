using System;

namespace UI.Components
{
    internal class DatabaseContext : IDisposable
    {
        public object Users { get; internal set; }
    }
}