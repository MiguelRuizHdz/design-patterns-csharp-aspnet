using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Generator
{
    public enum TypeFormat
    {
        Json,
        Pipes
    }

    public enum TypeCharacter
    {
        Normal,
        Uppercase,
        Lowercase
    }

    public interface IBuilderGenerator
    {
        void Reset();
        void SetContent(List<string> content);
        void SetPath(string path);
        void SetFormat(TypeFormat format);
        void SetCharacter(TypeCharacter character = TypeCharacter.Normal);

    }
}
