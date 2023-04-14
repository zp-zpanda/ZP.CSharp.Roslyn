using System.Threading.Tasks;
using Microsoft.DocAsCode;
namespace ZP.CSharp.Enigma.Docs
{
    public class Program
    {
        public static async Task Main() => await Docset.Build("ZP.CSharp.Roslyn.Docs.json");
    }
}
