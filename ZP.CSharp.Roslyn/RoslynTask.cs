using System;
using Microsoft.Build.Utilities;
using Microsoft.Build.Framework;
using ZP.CSharp.Roslyn;
namespace ZP.CSharp.Roslyn
{
    public class RoslynTask : Task
    {
        public override bool Execute()
        {
            Log.LogMessage(MessageImportance.High, "\x1b[93m");
            Log.LogMessage(MessageImportance.High, "ZP.CSharp.Roslyn Task");
            Log.LogMessage(MessageImportance.High, "\x1b[0m");
            return !Log.HasLoggedErrors;
        }
    }
}
