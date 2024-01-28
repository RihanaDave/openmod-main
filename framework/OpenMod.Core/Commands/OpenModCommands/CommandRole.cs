﻿using System;
using System.Threading.Tasks;

namespace OpenMod.Core.Commands.OpenModCommands
{
    [Command("role")]
    [CommandParent(typeof(CommandOpenMod))]
    [CommandAlias("r")]
    [CommandAlias("permissionrole")]
    [CommandAlias("pr")]
    [CommandDescription("Manage permission roles")]
    [CommandSyntax("<add/remove> <[p]layer | [r]ole> <name> <role>")]

    public class CommandRole : Command
    {
        public CommandRole(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        protected override Task OnExecuteAsync()
        {
            return Task.FromException(new CommandWrongUsageException(Context));
        }
    }
}