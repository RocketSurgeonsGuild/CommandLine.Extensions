﻿using System.Threading.Tasks;
using McMaster.Extensions.CommandLineUtils;

namespace Rocket.Surgery.Extensions.CommandLine
{
    [Command(Description = "Run the application", ExtendedHelpText = "Default action if no command is given", ShowInHelpText = true)]
    class RunApplication
    {
        private readonly IApplicationStateInner _applicationState;

        public RunApplication(IApplicationStateInner applicationState)
        {
            _applicationState = applicationState;
        }

        public Task<int> OnExecuteAsync() => _applicationState.OnExecuteAsync();
    }
}
