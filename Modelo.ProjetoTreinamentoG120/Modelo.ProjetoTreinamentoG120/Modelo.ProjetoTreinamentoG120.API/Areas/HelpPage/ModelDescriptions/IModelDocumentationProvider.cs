using System;
using System.Reflection;

namespace Modelo.ProjetoTreinamentoG120.API.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}