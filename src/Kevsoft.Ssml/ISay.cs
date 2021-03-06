﻿using System.Threading.Tasks;
using System.Xml;

namespace Kevsoft.Ssml
{
    public interface ISay : ISsml
    {
        ISsml AsAlias(string alias);

        ISsml Emphasised();

        ISsml Emphasised(EmphasiseLevel level);
    }
}